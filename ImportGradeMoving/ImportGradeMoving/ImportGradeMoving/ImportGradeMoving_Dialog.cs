using ExcelDataReader;
using ImportGradeMoving.Events.EventHandlings;
using ImportGradeMoving.ViewModel;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OmniWMS.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using UtilityByWaii.OfficeHelper;

namespace ImportGradeMoving
{
    public partial class ImportGradeMoving_Dialog : Form
    {
        private string ItemStatus_Id = "";
        private readonly WMSDB_PWBContext _context;
        private readonly ImportGradeMovingSetting _setting;
        public ImportGradeMoving_Dialog()
        {
            _setting = new ImportGradeMovingSetting();
            _context = new WMSDB_PWBContext();
            InitializeComponent();
        }

        private void BtnPullStockTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                var saveAsFilePath = _setting.SaveAsFilePath;
                var defaultGrade1 = _setting.DefaultGrade1;
                var defaultGrade2 = _setting.DefaultGrade2;


                if (defaultGrade1!=defaultGrade2)
                {
                    var handler = new PullStockTemplateHandler(_context, _setting);
                    var excelData = handler.Handle(defaultGrade1, defaultGrade2);
                    #region save excel
                    var saveDatas = new List<ShopeeImportManualTemplate>();
                    foreach (var data in excelData)
                    {
                        saveDatas.Add(data);
                    }
                    OfficeTableConfig excelConfig = new OfficeTableConfig()
                    {
                        HasHeader = true,
                        OutputPathFile = saveAsFilePath,
                        MapHeaders = OfficeHelper.AutoMapHeader<ShopeeImportManualTemplate>()
                    };
                    OfficeHelper.SaveAsExcel<List<ShopeeImportManualTemplate>>(saveDatas, excelConfig);
                    #endregion
                }
                else
                {
                    rtbLogDataImportPreparing.Clear();
                    rtbLogDataImportPreparing.AppendText("ไม่สามารถเปลี่ยนเกรด ที่เป็นเกรดเดิมได้");
                }
                //testttttttt

            }
            catch (Exception ex)
            {
                rtbLogDataImportPreparing.Clear();
                rtbLogDataImportPreparing.AppendText("Error : " + ex.Message);
                return;
            }
        }
        private void BtImportGrade_Click(object sender, EventArgs e)
        {
            rtbLogDataImportPreparing.Clear();
            try
            {
                string batchId = DateTime.Now.ToString("yyyyMMddHHmmssff");
                using (OpenFileDialog fileDialog = new OpenFileDialog())
                {
                    fileDialog.InitialDirectory = @"D:\ExcelDocument"; // C:
                    fileDialog.RestoreDirectory = true;
                    fileDialog.Title = "Browse xlsx Files";
                    fileDialog.DefaultExt = "xlsx";
                    fileDialog.Filter = "xls files (*.xls)|*.xls|csv files (*.csv)|*.csv|xlsx files (*.xlsx)|*.xlsx";
                    fileDialog.FilterIndex = 0;
                    fileDialog.CheckFileExists = true;
                    fileDialog.CheckPathExists = true;
                    fileDialog.ShowDialog();

                    if (!string.IsNullOrEmpty(fileDialog.FileName))
                    {
                        List<ShopeeImportManualTemplate> excelResults = OfficeHelper.ReadExcel<ShopeeImportManualTemplate>(fileDialog.FileName);
                        if (excelResults.Count != 0)
                        {
                            //เช็ค Product ซ้ำ
                            var duplicateProducts = excelResults.GroupBy(by => by.product_id).Where(condition => condition.Count() > 1).Select(selector => new { product_id = selector.Key, count_product = selector.Count() }).ToList();
                            if (duplicateProducts.Count > 0)
                            {
                                foreach (var duplicateProduct in duplicateProducts)
                                {
                                    var errorText = $"ProductId : {duplicateProduct.product_id} ไม่สามารถซ้ำกันได้ \n";
                                    rtbLogDataImportPreparing.AppendText(errorText);
                                }
                                return;
                            }

                            //เช็คจำนวน Qty_move
                            var existQtyMoves = excelResults.Where(condition => condition.move_qty == null || condition.move_qty == 0).ToList();
                            if (existQtyMoves.Count > 0)
                            {
                                foreach (var existQtyMove in existQtyMoves)
                                {
                                    var errorText = $"ProductId : {existQtyMove.product_id} จำนวน QtyMove ไม่ถูกต้อง \n";
                                    rtbLogDataImportPreparing.AppendText(errorText);
                                }
                                return;
                            }

                            // Save ลง table ImportGradeMovingTemp
                            SaveImportGradeMovingTemp(excelResults, batchId);

                            //Validate Step After Save ImportGradeMovingTemp
                            ValidateManualGradeChangeEventHandler handler = new ValidateManualGradeChangeEventHandler(_context, _setting);
                            var importGradeMovingTemps = handler.Handle(batchId);
                            if (importGradeMovingTemps.Count == 0)
                            {
                                rtbLogDataImportPreparing.Text = "Import ข้อมูลสำเร็จ";
                            }
                            else
                            {
                                foreach (var importGradeMovingTemp in importGradeMovingTemps)
                                {
                                    var errorText = $"Error : {importGradeMovingTemp.ProductId} {importGradeMovingTemp.ProductName} {importGradeMovingTemp.FromAvailQty} {importGradeMovingTemp.FromOnOrderQty} {importGradeMovingTemp.ToAvailQty} " +
                                        $"{importGradeMovingTemp.ToOnOrderQty} {importGradeMovingTemp.MoveQty} {importGradeMovingTemp.StatusCode} {importGradeMovingTemp.StatusDesc} \n";
                                    rtbLogDataImportPreparing.AppendText(errorText);
                                }
                            }
                        }
                        else
                        {
                            rtbLogDataImportPreparing.Text = "ไม่พบข้อมูลในไฟล์ Excel";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                rtbLogDataImportPreparing.Text = $"Error : {ex.Message}";
            }
        }

        //Mick 03/08/2021 (Shoppee)
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selector = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            if (selector == "Grade AAA")
            {
                ItemStatus_Id = "A";
                rtbLogDataImportPreparing.Clear();
                rtbLogDataImportPreparing.AppendText("select Grade AAA");
            }
            else if (selector == "SP")
            {
                ItemStatus_Id = "SP";
                rtbLogDataImportPreparing.Clear();
                rtbLogDataImportPreparing.AppendText("select Shopee");

            }

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selector = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            if (selector == "Grade AAA")
            {
                ItemStatus_Id = "A";
                rtbLogDataImportPreparing.Clear();
                rtbLogDataImportPreparing.AppendText("select Grade AAA");
            }
            else if (selector == "SP")
            {
                ItemStatus_Id = "SP";
                rtbLogDataImportPreparing.Clear();
                rtbLogDataImportPreparing.AppendText("select Shopee");

            }
        }
        private void ImportOrderTransfer_Dialog_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox3.SelectedIndex = 1;
            //Console.WriteLine(EncryptionHelper.DecodeAndDecrypt(connectionString));
            //pgbPercent.Maximum = 100;
            //comboBox1.SelectedIndex = 0;
            //result dataRes = IsEnableToUse();
            //if (!dataRes.isEnable)
            //{
            //    MessageBox.Show(dataRes.description);
            //    Application.Exit();
            //}
        }


        #region Method
        private void SaveImportGradeMovingTemp(List<ShopeeImportManualTemplate> excelResults, string batchId)
        {
            try
            {
                List<ExwmsImportGradeMovingTemp> importGradeMovingTemps = new List<ExwmsImportGradeMovingTemp>();
                foreach (var excelResult in excelResults)
                {
                    ExwmsImportGradeMovingTemp importGradeMovingTemp = new ExwmsImportGradeMovingTemp()
                    {
                        ProductId = excelResult.product_id,
                        ProductName = excelResult.product_name,
                        GradeFrom = excelResult.grade_from,
                        GradeTo = excelResult.grade_to,
                        FromAvailQty = excelResult.from_avail_qty,
                        FromOnOrderQty = excelResult.from_on_order_qty,
                        ToAvailQty = excelResult.to_avail_qty,
                        ToOnOrderQty = excelResult.to_on_order_qty,
                        FromTotalAvail = excelResult.from_total_avail,
                        ToTotalAvail = excelResult.to_total_avail,
                        MoveQty = excelResult.move_qty,
                        DocumentStatus = "0",
                        BatchId = batchId,
                        CreateDate = DateTime.Now,
                        CreateBy = "importchangegrademanual"
                    };
                    importGradeMovingTemps.Add(importGradeMovingTemp);
                }
                _context.AddRange(importGradeMovingTemps);
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
        #endregion
    }
}
