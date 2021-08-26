using ImportGradeMoving.ViewModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UtilityByWaii.OfficeHelper;

namespace ImportGradeMoving
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ShopeeImportManualTemplate> ls = new List<ShopeeImportManualTemplate>();
            var config = new OfficeTableConfig();
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = @"D:\ExcelDocument";
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

                    List<ShopeeImportManualTemplate> results = OfficeHelper.ReadExcel<ShopeeImportManualTemplate>(fileDialog.FileName);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<ShopeeImportManualTemplate> saveDatas = new List<ShopeeImportManualTemplate>() { };
            saveDatas.Add(new ShopeeImportManualTemplate()
            {
                product_id = "4034527",
                product_name = "Testtrhyethjter",
                grade_from = "A",
                grade_to = "SP",
                from_avail_qty = 100,
                from_on_order_qty = 20,
                to_avail_qty = 0,
                to_on_order_qty = 0,
                from_total_avail = 80,
                to_total_avail = 0,
                move_qty = 15
            } );
            saveDatas.Add(new ShopeeImportManualTemplate()
            {
                product_id = "4035699",
                product_name = "สีไม้สีน้ำ 14 สี ตราม้า กล่องกระดาษ",
                grade_from = "A",
                grade_to = "SP",
                from_avail_qty = 50,
                from_on_order_qty = 10,
                to_avail_qty = 0,
                to_on_order_qty = 0,
                from_total_avail = 20,
                to_total_avail = 0,
                move_qty = 5
            });
            OfficeTableConfig config = new OfficeTableConfig()
            {
                HasHeader = true,
                OutputPathFile = "D:\\SaveExcelAs\\test.xlsx",
                MapHeaders = OfficeHelper.AutoMapHeader<ShopeeImportManualTemplate>()
            };
            OfficeHelper.SaveAsExcel<List<ShopeeImportManualTemplate>>(saveDatas, config);
        }
    }
}
