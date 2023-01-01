using System;
using BackendCore.Common.Core;

namespace BackendCore.Common.DTO.Business.Product
{
    public class AddProductDto : IEntityDto<Guid?>
    {
        public Guid? Id { get; set; }
        public string Code { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SellPrice { get; set; }
        public decimal OldUnitPrice { get; set; }
        public decimal OldSellPrice { get; set; }
        public int Quantity { get; set; }
        public double? MeasureValue { get; set; }
        public string Note { get; set; }
        public string UpdateQntType { get; set; }
        public string UpdateQntNote { get; set; }
        public string StockKeepingUnit { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Barcode { get; set; }
        public Guid? FileId { get; set; }
        public Guid? BarcodeId { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? WarehouseId { get; set; }
        public Guid? ShopId { get; set; }
        public int? WarehouseQuantity { get; set; }
        public Guid? SupplierId { get; set; }
        public Guid? UnitsOfMeasureId { get; set; }
        public bool IsUpdateQuantity { get; set; } = false;
        public int AddNewQuantity { get; set; } = 0;
    }
}
