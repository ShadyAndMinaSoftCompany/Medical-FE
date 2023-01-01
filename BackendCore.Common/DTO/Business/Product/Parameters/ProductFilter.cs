using System;
using BackendCore.Entities.Enum;

namespace BackendCore.Common.DTO.Business.Product.Parameters
{
    public class ProductFilter 
    {
        public Guid? Id { get; set; }
        public string Code { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public Guid? ShopId { get; set; }
        public int? Quantity { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Barcode { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? WarehouseId { get; set; }
        public Guid? SupplierId { get; set; }
        public Guid? UnitsOfMeasureId { get; set; }
        public bool IsOutOfStock { get; set; }
        public bool IsLowInStock { get; set; }
        public bool? IsPriceApproved { get; set; }
        
    }

    public class ProductReportFilter
    {
        public ReportType ReportType { get; set; }
        public SortType SortType { get; set; }
        public int Count { get; set; }
    }
}
