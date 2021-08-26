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

            // check enable and version
            //result dataRes = IsEnableToUse();
            //if (!dataRes.isEnable)
            //{
            //    MessageBox.Show(dataRes.description);
            //    return;
            //}

            //using (OpenFileDialog fileDialog = new OpenFileDialog())
            //{
            //    fileDialog.InitialDirectory = @"C:\";
            //    fileDialog.RestoreDirectory = true;
            //    fileDialog.Title = "Browse xlsx Files";
            //    fileDialog.DefaultExt = "xlsx";
            //    fileDialog.Filter = "xls files (*.xls)|*.xls|csv files (*.csv)|*.csv|xlsx files (*.xlsx)|*.xlsx";
            //    fileDialog.FilterIndex = 0;
            //    fileDialog.CheckFileExists = true;
            //    fileDialog.CheckPathExists = true;

            //    fileDialog.ShowDialog();

            //    string fileName = fileDialog.FileName;

            //    if (!string.IsNullOrEmpty(fileName))
            //    {
            //        try
            //        {
            //            DataTable dt = GetDataExcelToTable(fileName, "");
            //            dataExcel = dt;

            //            HashSet<string> planGoodsIssueProductStrings = new HashSet<string>(); //for sql query
            //            HashSet<string> planGoodsIssueProducts = new HashSet<string>();
            //            HashSet<string> planGoodsIssueOrderNoStrings = new HashSet<string>();//for sql query
            //            HashSet<string> planGoodsReceiveProductStrings = new HashSet<string>(); //for sql query
            //            HashSet<string> planGoodsReceiveProducts = new HashSet<string>();
            //            HashSet<string> planGoodsReceiveOrderNoStrings = new HashSet<string>();
            //            var importPlanGoodsIssueDict = new Dictionary<string, PlanGoodsIssueViewModel>();
            //            var importPlanGoodsReceiveDict = new Dictionary<string, PlanGoodsReceiveViewModel>();
            //            string documentId = string.Empty;
            //            string documentName = string.Empty;
            //            Guid documentIndex = new Guid();
            //            bool isMissingRequiredFields = false;
            //            bool isImportFail = false;
            //            bool isDocumentTypeNotExist = false;
            //            var documentTypes = GetDocumentTypes(new List<string>() { "RTW", "STS", "FN-007" });
            //            foreach (var item in dataExcel.AsEnumerable())
            //            {
            //                string fromStore = item.Field<string>("FR_STR1");
            //                string toStore = item.Field<string>("TO_STR3");
            //                string toStoreName = item.Field<string>("TO_STRNAM4");
            //                string productId = item.Field<string>("SKU17");
            //                string orderNo = item.Field<string>("TRF_NUMBER5");
            //                decimal qty = Convert.ToDecimal(item.Field<string>("RCV_QTY27"));

            //                if (string.IsNullOrWhiteSpace(orderNo))
            //                {
            //                    isMissingRequiredFields = true;
            //                    isImportFail = true;
            //                    break;
            //                }

            //                //Case: PlangoodsIssue
            //                if (fromStore.Equals(_b2sStoreId))
            //                {
            //                    planGoodsIssueProductStrings.Add($"'{productId}'");
            //                    planGoodsIssueProducts.Add(productId);
            //                    planGoodsIssueOrderNoStrings.Add($"'{orderNo}'");

            //                    // Return to Warehouse
            //                    if (toStore.Equals(_dcId))
            //                    {
            //                        var document = documentTypes.Where(x => x.DocumentTypeId.ToUpper().Equals("RTW")).FirstOrDefault();
            //                        if (document == null)
            //                        {
            //                            isDocumentTypeNotExist = true;
            //                            isImportFail = true;
            //                            break;
            //                        }

            //                        documentId = document.DocumentTypeId;
            //                        documentIndex = document.DocumentTypeIndex;
            //                        documentName = document.DocumentTypeName;
            //                    }
            //                    // Store To Store
            //                    else
            //                    {
            //                        var document = documentTypes.Where(x => x.DocumentTypeId.ToUpper().Equals("STS")).FirstOrDefault();
            //                        if (document == null)
            //                        {
            //                            isDocumentTypeNotExist = true;
            //                            isImportFail = true;
            //                            break;
            //                        }

            //                        documentId = document.DocumentTypeId;
            //                        documentIndex = document.DocumentTypeIndex;
            //                        documentName = document.DocumentTypeName;
            //                    }

            //                    if (importPlanGoodsIssueDict.ContainsKey($"{toStore}_{orderNo}_{productId}"))
            //                    {
            //                        importPlanGoodsIssueDict[$"{toStore}_{orderNo}_{productId}"].Qty += qty;
            //                    }
            //                    else
            //                    {
            //                        importPlanGoodsIssueDict[$"{toStore}_{orderNo}_{productId}"] = new PlanGoodsIssueViewModel()
            //                        {
            //                            StoreId = toStore, // assign to Warehouse_To_Id
            //                            StoreIdName = toStoreName,
            //                            OrderNo = orderNo,
            //                            ProductId = productId,
            //                            DocumentTypeId = documentId,
            //                            DocumentTypeIndex = documentIndex,
            //                            DocumentTypeName = documentName,
            //                            Qty = qty
            //                        };
            //                    }
            //                }
            //                //Case: PlanGoodsReceive
            //                else if (toStore.Equals(_b2sStoreId))
            //                {
            //                    string vendorId = item.Field<string>("VENDOR10");
            //                    //Transfer to DC
            //                    if (fromStore.Equals(_dcId))
            //                    {
            //                        planGoodsReceiveProductStrings.Add($"'{productId}'");
            //                        planGoodsReceiveProducts.Add(productId);
            //                        planGoodsReceiveOrderNoStrings.Add($"'{orderNo}'");

            //                        var document = documentTypes.Where(x => x.DocumentTypeId.ToUpper().Equals("FN-007")).FirstOrDefault();
            //                        documentId = document.DocumentTypeId;
            //                        documentIndex = document.DocumentTypeIndex;
            //                        documentName = document.DocumentTypeName;
            //                    }
            //                    //Store To Store
            //                    else
            //                    {
            //                        planGoodsReceiveProductStrings.Add($"'{productId}'");
            //                        planGoodsReceiveProducts.Add(productId);
            //                        planGoodsReceiveOrderNoStrings.Add($"'{orderNo}'");

            //                        var document = documentTypes.Where(x => x.DocumentTypeId.ToUpper().Equals("STS")).FirstOrDefault();
            //                        documentId = document.DocumentTypeId;
            //                        documentIndex = document.DocumentTypeIndex;
            //                        documentName = document.DocumentTypeName;
            //                    }

            //                    if (importPlanGoodsReceiveDict.ContainsKey($"{vendorId}_{orderNo}_{productId}"))
            //                    {
            //                        importPlanGoodsReceiveDict[$"{vendorId}_{orderNo}_{productId}"].Qty += qty;
            //                    }
            //                    else
            //                    {
            //                        importPlanGoodsReceiveDict[$"{vendorId}_{orderNo}_{productId}"] = new PlanGoodsReceiveViewModel()
            //                        {
            //                            VendorId = vendorId, // assign to Warehouse_To_Id
            //                            OrderNo = orderNo,
            //                            ProductId = productId,
            //                            DocumentTypeId = documentId,
            //                            DocumentTypeIndex = documentIndex,
            //                            DocumentTypeName = documentName,
            //                            Qty = qty
            //                        };
            //                    }
            //                }
            //            }

            //            if (isImportFail == false &&
            //                importPlanGoodsReceiveDict.Count <= 0 && importPlanGoodsIssueDict.Count <= 0)
            //            {
            //                rtbLogDataImportPreparing.ForeColor = Color.Black;
            //                statusCanImport = false;
            //                rtbLogDataImportPreparing.AppendText("Validate Success, No DocumentType qualify." + Environment.NewLine);
            //                return;
            //            }

            //            // Validate Orders
            //            string composedIssueOrderNos = string.Join(",", planGoodsIssueOrderNoStrings);
            //            var invalidPlanGoodsIssueOrders = GetDataOrderForPlanGoodsIssue(composedIssueOrderNos).AsEnumerable()
            //                                                .Select(row => row.Field<string>("PlanGoodsIssue_No")).ToList();

            //            string composedRecieveOrderNos = string.Join(",", planGoodsReceiveOrderNoStrings);
            //            var invalidPlanGoodsReceiveOrders = GetDataOrderForPlanGoodsReceive(composedRecieveOrderNos).AsEnumerable()
            //                                                .Select(row => row.Field<string>("Plangoodsreceive_no")).ToList();

            //            var totalInvalidOrders = invalidPlanGoodsIssueOrders.Union(invalidPlanGoodsReceiveOrders).Distinct().ToList();

            //            // Validate Product
            //            string composedIssueProductIds = string.Join(",", planGoodsIssueProductStrings);
            //            _dtIssueProduct = GetDataProductForPlanGoodsIssue(composedIssueProductIds);
            //            var validPlanGoodsIssueProducts = _dtIssueProduct.AsEnumerable().Select(row => row.Field<string>("productconversionbarcode")).ToList();
            //            var invalidIssueProductIds = planGoodsIssueProducts.Except(validPlanGoodsIssueProducts).ToList();

            //            string composedReceiveProductIds = string.Join(",", planGoodsReceiveProductStrings);
            //            _dtReceiveProduct = GetDataProductForPlanGoodsReceive(composedReceiveProductIds);
            //            var validPlanGoodsReceiveProducts = _dtReceiveProduct.AsEnumerable().Select(row => row.Field<string>("productconversionbarcode")).ToList();
            //            var invalidReceiveProductIds = planGoodsReceiveProducts.Except(validPlanGoodsReceiveProducts).ToList();

            //            var totalInvalidProductIds = invalidIssueProductIds.Union(invalidReceiveProductIds).Distinct().ToList();

            //            rtbLogDataImportPreparing.Clear();

            //            if (isMissingRequiredFields == true)
            //            {
            //                rtbLogDataImportPreparing.AppendText("Import Problems:\nThere are required fields missing." + Environment.NewLine);
            //                rtbLogDataImportPreparing.ForeColor = Color.Red;
            //                statusCanImport = false;
            //                isImportFail = true;
            //            }

            //            if (isDocumentTypeNotExist == true)
            //            {
            //                rtbLogDataImportPreparing.AppendText("Order Problem Reports:There are invalid documentType." + Environment.NewLine);
            //                rtbLogDataImportPreparing.ForeColor = Color.Red;
            //                statusCanImport = false;
            //                isImportFail = true;
            //            }

            //            if (totalInvalidOrders.Count() > 0)
            //            {
            //                rtbLogDataImportPreparing.AppendText("Order Problem Reports" + Environment.NewLine);
            //                rtbLogDataImportPreparing.ForeColor = Color.Red;
            //                totalInvalidOrders.ForEach(x => rtbLogDataImportPreparing.AppendText(x + " is processed" + Environment.NewLine));
            //                statusCanImport = false;
            //                isImportFail = true;
            //            }

            //            if (totalInvalidProductIds.Count() > 0)
            //            {
            //                rtbLogDataImportPreparing.AppendText(Environment.NewLine + "=========================" + Environment.NewLine);
            //                rtbLogDataImportPreparing.AppendText("Product Problem Reports" + Environment.NewLine);
            //                rtbLogDataImportPreparing.ForeColor = Color.Red;
            //                totalInvalidProductIds.ForEach(x => rtbLogDataImportPreparing.AppendText(x + " not found" + Environment.NewLine));
            //                statusCanImport = false;
            //                isImportFail = true;
            //            }

            //            if (isImportFail == false)
            //            {
            //                importPlanGoodsIssues = importPlanGoodsIssueDict.Values.Select(x => x).ToList();
            //                importPlanGoodsReceives = importPlanGoodsReceiveDict.Values.Select(x => x).ToList();

            //                rtbLogDataImportPreparing.ForeColor = Color.Black;
            //                statusCanImport = true;
            //                rtbLogDataImportPreparing.AppendText("Validate Success Please press import button" + Environment.NewLine);
            //            }
            //            else
            //            {
            //                ClearImportItemsCatch();
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            //reset catch data
            //            ClearImportItemsCatch();
            //            MessageBox.Show("Error when getting data as follow : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //            return;
            //        }
            //    }
            //}
        }
        private void BtImportGrade_Click(object sender, EventArgs e)
        {
            rtbLogDataImportPreparing.Clear();
            try
            {
                string batchId = DateTime.Now.ToString();
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
                        List<ShopeeImportManualTemplate> excelResults  = OfficeHelper.ReadExcel<ShopeeImportManualTemplate>(fileDialog.FileName);
                        if (excelResults.Count != 0)
                        {
                            //เช็ค Product ซ้ำ
                            var duplicateProducts = excelResults.GroupBy(by => by.product_id).Where(condition => condition.Key.Count() > 1).Select(selector => new { product_id = selector.Key, count_product = selector.Key.Count() }).ToList();
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
                            foreach (var excelResult in excelResults)
                            {
                                //excelResult.move_qty
                            }
                            return;

                            // Save ลง table ImportGradeMovingTemp
                            SaveImportGradeMovingTemp(excelResults);

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
        private void SaveImportGradeMovingTemp(List<ShopeeImportManualTemplate> excelResults)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
