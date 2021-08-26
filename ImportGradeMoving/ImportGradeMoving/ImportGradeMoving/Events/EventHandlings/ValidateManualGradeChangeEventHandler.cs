using OmniWMS.Domain.AggregatesModels.Master;
using OmniWMS.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using UtilityByWaii;
using UtilityByWaii.Common;

namespace ImportGradeMoving.Events.EventHandlings
{
    public class ValidateManualGradeChangeEventHandler
    {
        private readonly WMSDB_PWBContext _context;
        private readonly ImportGradeMovingSetting _setting;
        private readonly int NotExistData = 0;
        public ValidateManualGradeChangeEventHandler(WMSDB_PWBContext context, ImportGradeMovingSetting setting)
        {
            _context = context;
            _setting = setting;
        }

        public List<ExwmsImportGradeMovingTemp> Handle(string batchId)
        {
            bool isError = false;
            try
            {

                isError = ValidateImportGradeMovingTemp(batchId);

                if (isError)
                {
                    //มี Error
                    List<ExwmsImportGradeMovingTemp> importGradeMovingTemps = _context.ExwmsImportGradeMovingTemp.Where(condition => condition.DocumentStatus == "-10" && condition.BatchId == batchId).ToList();
                    if (importGradeMovingTemps.Count != NotExistData)
                    {
                        _context.RemoveRange(importGradeMovingTemps);
                        _context.SaveChanges();
                        return importGradeMovingTemps;
                    }
                }
                else
                {
                    //ไม่มี Error
                    List<ExwmsImportGradeMovingTemp> importGradeMovingTemps = _context.ExwmsImportGradeMovingTemp.Where(condition => condition.DocumentStatus == "90" && condition.BatchId == batchId).ToList();
                    if (importGradeMovingTemps.Count != NotExistData)
                    {
                        InsertGradeMovingRequest(importGradeMovingTemps);
                        InsertImportGradeMovingLog(importGradeMovingTemps);
                        _context.RemoveRange(importGradeMovingTemps);
                        _context.SaveChanges();
                        var masterRepo = new MasterRepository<WMSDB_PWBContext>(_context);
                        var affectRow = masterRepo.CallNonQueryStoreProcedure<object>(_setting.ProcedureName, null);
                        var responseChangeGradeAPI = CallAPI<object, string>.PostAPI(null, _setting.UrlChangeGradeAPI);
                    }
                }
                return new List<ExwmsImportGradeMovingTemp>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void InsertImportGradeMovingLog(List<ExwmsImportGradeMovingTemp> importGradeMovingTemps)
        {
            try
            {
                List<ExwmsImportGradeMovingLog> importGradeMovingLogs = new List<ExwmsImportGradeMovingLog>();
                foreach (var importGradeMovingTemp in importGradeMovingTemps)
                {
                    ExwmsImportGradeMovingLog importGradeMovingLog = Utility.Map<ExwmsImportGradeMovingTemp, ExwmsImportGradeMovingLog>(importGradeMovingTemp);
                    importGradeMovingLog.CreateDate = DateTime.Now;
                    importGradeMovingLog.UpdateBy = null;
                    importGradeMovingLog.UpdateDate = null;
                    importGradeMovingLogs.Add(importGradeMovingLog);
                }
                _context.ExwmsImportGradeMovingLog.AddRange(importGradeMovingLogs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void InsertGradeMovingRequest(List<ExwmsImportGradeMovingTemp> importGradeMovingTemps)
        {
            try
            {
                List<ExwmsGradeMovingRequest> gradeMovingRequests = new List<ExwmsGradeMovingRequest>();
                foreach (var importGradeMovingTemp in importGradeMovingTemps)
                {
                    ExwmsGradeMovingRequest gradeMovingRequest = Utility.Map<ExwmsImportGradeMovingTemp, ExwmsGradeMovingRequest>(importGradeMovingTemp);
                    gradeMovingRequest.BatchIdIn = importGradeMovingTemp.BatchId;
                    gradeMovingRequest.CreateDate = DateTime.Now;
                    gradeMovingRequest.DocumentStatus = "0";
                    gradeMovingRequest.Zone = _setting.Zone;
                    gradeMovingRequest.OrderType = importGradeMovingTemp.GradeFrom == "A" ? _setting.OrderTypeA : _setting.OrderTypeSP ;
                    gradeMovingRequest.OrderTypeAgainst = importGradeMovingTemp.GradeTo == "A" ? _setting.OrderTypeA : _setting.OrderTypeSP;
                    gradeMovingRequest.DocumentStatus = "0";
                    gradeMovingRequest.CreateBy = "ManualFromUpload";
                    gradeMovingRequest.MoveType = "ManualFromUpload";
                    gradeMovingRequest.UpdateBy = null;
                    gradeMovingRequest.UpdateDate = null;
                    gradeMovingRequests.Add(gradeMovingRequest);
                }
                _context.ExwmsGradeMovingRequest.AddRange(gradeMovingRequests);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidateImportGradeMovingTemp(string batchId)
        {
            try
            {
                bool isError = false;
                var importGradeMovingTemps = _context.ExwmsImportGradeMovingTemp.Where(condition => condition.DocumentStatus == "0" && condition.BatchId == batchId).ToList();
                if (importGradeMovingTemps.Count != NotExistData)
                {
                    #region GradeFrom = GradeTo
                    var errorSameGrades = importGradeMovingTemps.Where(condition => condition.GradeFrom == condition.GradeTo).ToList();
                    foreach (var errorSameGrade in errorSameGrades)
                    {
                        isError = true;
                        errorSameGrade.DocumentStatus = "-10";
                        errorSameGrade.StatusCode = "411";
                        errorSameGrade.StatusDesc = "ไม่สามารถบันทึก GradeFrom, GradeTo เป็นชนิดเดียวกันได้";
                    }
                    if (isError) return isError;

                    #endregion

                    #region GradeFrom , GradeTo Invalid ItemStatus
                    var errorGradeFromGradeToInvalidItemStatuses = importGradeMovingTemps
                    .Join(_context.MsItemStatus, src => src.GradeFrom, des => des.ItemStatusId, (src, des) => new { Temp = src, GradeFrom = des })
                    .Join(_context.MsItemStatus, src => src.Temp.GradeTo, des => des.ItemStatusId, (src, des) => new { Temp = src.Temp, GradeFrom = src.GradeFrom, GradeTo = des })
                    .Select(selector => selector.Temp).ToList();
                    if (errorGradeFromGradeToInvalidItemStatuses.Count != importGradeMovingTemps.Count)
                    {
                        foreach (var errorGradeFromGradeToInvalidItemStatuse in errorGradeFromGradeToInvalidItemStatuses)
                        {
                            isError = true;
                            errorGradeFromGradeToInvalidItemStatuse.DocumentStatus = "-10";
                            errorGradeFromGradeToInvalidItemStatuse.StatusCode = "421";
                            errorGradeFromGradeToInvalidItemStatuse.StatusDesc = "GradeFrom, GradeTo ไม่ถูกต้อง";
                        }
                        if (isError) return isError;
                    }
                    #endregion

                    #region QtyMove > QtyAvailable
                    var errorQtyMoveGreaterThanQtyAvailables = importGradeMovingTemps.Where(condition => condition.MoveQty > condition.FromAvailQty).ToList();
                    foreach (var errorQtyMoveGreaterThanQtyAvailable in errorQtyMoveGreaterThanQtyAvailables)
                    {
                        isError = true;
                        errorQtyMoveGreaterThanQtyAvailable.DocumentStatus = "-10";
                        errorQtyMoveGreaterThanQtyAvailable.StatusCode = "431";
                        errorQtyMoveGreaterThanQtyAvailable.StatusDesc = "ไม่สามารถย้ายสินค้าเกินจำนวน Available ได้";
                    }
                    if (isError) return isError;
                    #endregion

                    #region QtyMove = 0 || QtyMove = null
                    var errorZeroQtyMoves = importGradeMovingTemps.Where(condition => condition.MoveQty == null || condition.MoveQty == 0).ToList();
                    foreach (var errorZeroQtyMove in errorZeroQtyMoves)
                    {
                        errorZeroQtyMove.DocumentStatus = "-10";
                        errorZeroQtyMove.StatusCode = "489";
                        errorZeroQtyMove.StatusDesc = "ไม่มีการระบุจำนวน, มีการระบุ 0";
                    }
                    #endregion
                    importGradeMovingTemps = importGradeMovingTemps.Where(condition => condition.DocumentStatus != "-10").ToList();
                    foreach (var importGradeMovingTemp in importGradeMovingTemps)
                    {
                        importGradeMovingTemp.DocumentStatus = "90";
                    }
                }
                return isError;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                try
                {
                    if (_context.ChangeTracker.HasChanges())
                    {
                        _context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }                
            }
        }
    }
}
