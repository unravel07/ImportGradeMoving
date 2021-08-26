using ImportGradeMoving.ViewModel;
using OmniWMS.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImportGradeMoving.Events.EventHandlings
{
    public class PullStockTemplateHandler
    {
        private readonly WMSDB_PWBContext _context;
        private readonly ImportGradeMovingSetting _setting;

        public PullStockTemplateHandler(WMSDB_PWBContext context, ImportGradeMovingSetting setting)
        {
            _context = context;
            _setting = setting;
        }

        public List<ShopeeImportManualTemplate> Handle(string gradeFrom, string gradeTo)
        {

            var listPullStockTemplate = new List<ShopeeImportManualTemplate>();
            var orderTypeAgaint = "";
            var orderType = "";
            List<ExwmsConfig> exwmsConfigs = _context.ExwmsConfig.Where(condition => condition.ConfigGroupKey == "shopee").ToList();
            var ProductId = exwmsConfigs.Where(condition => condition.ConfigIssue == "MINIMUM_MOVE_GRADE" && condition.ConfigKey == "product_id").Select(selector => selector.ConfigValue).ToList();
            var zone = _setting.Zone;
            if (gradeFrom == "A" && gradeTo == "SP")
            {
                orderTypeAgaint = _setting.OrderTypeA;
                orderType = _setting.OrderTypeSP;
            }
            else
            {
                orderTypeAgaint = _setting.OrderTypeSP;
                orderType = _setting.OrderTypeA;
            }
            try
            {

                foreach (var productId in ProductId)
                {
                    #region get Binbalance
                    var binbalanceDest = _context.WmBinBalance
                           .Join(_context.MsLocation, src => src.LocationIndex, des => des.LocationIndex, (src, des) => new { Binbalance = src, Location = des })
                           .Join(_context.MsZoneLocation, src => src.Location.LocationIndex, des => des.LocationIndex,
                                (src, des) => new { Binbalance = src.Binbalance, Location = src.Location, ZoneLocation = des })
                           .Join(_context.MsZone, src => src.ZoneLocation.ZoneIndex, des => des.ZoneIndex,
                                (src, des) => new { Binbalance = src.Binbalance, Location = src.Location, ZoneLocation = src.ZoneLocation, Zone = des })
                           .Where(condition => condition.Binbalance.ProductId == productId && condition.Binbalance.ItemStatusId == gradeTo &&
                               condition.Zone.ZoneId == zone && (condition.Binbalance.BinBalanceQtyBal - condition.Binbalance.BinBalanceQtyReserve) > 0)
                           .Select(selector => selector.Binbalance).ToList();//equation-1
                    decimal? sumBinbalanceDest = 0;
                    foreach (var sum in binbalanceDest)
                    {
                        sumBinbalanceDest = sumBinbalanceDest + sum.BinBalanceQtyBal;
                    }
                    var binbalanceSource = _context.WmBinBalance
                           .Join(_context.MsLocation, src => src.LocationIndex, des => des.LocationIndex, (src, des) => new { Binbalance = src, Location = des })
                           .Join(_context.MsZoneLocation, src => src.Location.LocationIndex, des => des.LocationIndex,
                                (src, des) => new { Binbalance = src.Binbalance, Location = src.Location, ZoneLocation = des })
                           .Join(_context.MsZone, src => src.ZoneLocation.ZoneIndex, des => des.ZoneIndex,
                                (src, des) => new { Binbalance = src.Binbalance, Location = src.Location, ZoneLocation = src.ZoneLocation, Zone = des })
                           .Where(condition => condition.Binbalance.ProductId == productId && condition.Binbalance.ItemStatusId == gradeFrom &&
                               condition.Zone.ZoneId == zone && (condition.Binbalance.BinBalanceQtyBal - condition.Binbalance.BinBalanceQtyReserve) > 0)
                           .Select(selector => selector.Binbalance).ToList();//equation-2
                    decimal? sumBinbalanceSource = 0;
                    foreach (var sum in binbalanceDest)
                    {
                        sumBinbalanceSource = sumBinbalanceSource + sum.BinBalanceQtyBal;
                    }
                    #endregion

                    #region Qty on Order
                    var plangoodsissueOnorderDest = _context.ImPlanGoodsIssueItem
                            .Join(_context.ImPlanGoodsIssue, src => src.PlanGoodsIssueIndex, des => des.PlanGoodsIssueIndex, (src, des) => new { planGoodItem = src, planGood = des })
                            .Where(condition => condition.planGoodItem.ProductId == productId && orderTypeAgaint.Contains(condition.planGood.DocumentTypeId) && condition.planGood.DocumentStatus < 3 && condition.planGoodItem.ItemStatusId == gradeFrom)
                            .Select(selector => selector.planGoodItem.TotalQty).Sum();//equation-3
                    
                    var plangoodsissueOnorderSource = _context.ImPlanGoodsIssueItem
                        .Join(_context.ImPlanGoodsIssue, src => src.PlanGoodsIssueIndex, des => des.PlanGoodsIssueIndex, (src, des) => new { planGoodItem = src, planGood = des })
                            .Where(condition => condition.planGoodItem.ProductId == productId && orderType.Contains(condition.planGood.DocumentTypeId) && condition.planGoodItem.DocumentStatus < 3 && condition.planGoodItem.ItemStatusId == gradeTo)
                            .Select(selector => selector.planGoodItem.TotalQty).Sum();//equation-4
                    #endregion

                    decimal? gradeFromTotalAvail = sumBinbalanceSource - plangoodsissueOnorderSource;//equation-5 (2-4)
                    decimal? gradeToTotalAvail = sumBinbalanceDest - plangoodsissueOnorderDest;//equation-6 (1-3)
                    var productName = _context.MsProduct.Where(condition => condition.ProductId == productId).Select(selector => selector.ProductName).FirstOrDefault();

                    //insert to excel 
                    var pullStockTemplate = new ShopeeImportManualTemplate();
                    pullStockTemplate.product_id = productId;
                    pullStockTemplate.product_name = (productName != null) ? productName : "";
                    pullStockTemplate.grade_from = gradeFrom;
                    pullStockTemplate.grade_to = gradeTo;
                    pullStockTemplate.from_avail_qty = sumBinbalanceSource;
                    pullStockTemplate.from_on_order_qty = plangoodsissueOnorderSource;
                    pullStockTemplate.to_avail_qty = sumBinbalanceDest;
                    pullStockTemplate.to_on_order_qty = plangoodsissueOnorderDest;
                    pullStockTemplate.from_total_avail = gradeFromTotalAvail;
                    pullStockTemplate.to_total_avail = gradeToTotalAvail;

                    listPullStockTemplate.Add(pullStockTemplate);

                }
                return listPullStockTemplate;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
