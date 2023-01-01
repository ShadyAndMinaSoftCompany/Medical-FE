using BackendCore.Entities.Enum;
using System;

namespace BackendCore.Common.DTO.Business.Transaction.Parameters
{
    public class TransactionFilter
    {
        public bool PerDay { get; set; }
        public bool PerMonth { get; set; }
        public bool PerYear { get; set; }
        public int? Day { get; set; }
        public  int? Month { get; set; }
        public int? Year { get; set; }
        public Guid? UserId { get; set; }
        public Guid? ShopId { get; set; }
    }
}
