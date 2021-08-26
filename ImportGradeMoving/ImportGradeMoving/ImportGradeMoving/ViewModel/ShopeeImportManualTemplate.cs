namespace ImportGradeMoving.ViewModel
{
    public class ShopeeImportManualTemplate
    {
        public string product_id { get; set; }
        public string product_name { get; set; }
        public string grade_from { get; set; }
        public string grade_to { get; set; }
        public decimal? from_avail_qty { get; set; }
        public decimal? from_on_order_qty { get; set; }
        public decimal? to_avail_qty { get; set; }
        public decimal? to_on_order_qty { get; set; }
        public decimal? from_total_avail { get; set; }
        public decimal? to_total_avail { get; set; }
        public decimal? move_qty { get; set; }
    }
}
