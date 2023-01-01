using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Common.DTO.Business.Transaction
{
    public class TransactionSummaryDto
    {
        public string TranDate { get; set; }
        public int QuantitySold { get; set; }
        public int TotalTran { get; set; }
        public decimal? TotalEarned { get; set; }
        public decimal TotalDue { get; set; }
        public decimal? CasherCashHand { get; set; }
        public decimal? Total { get; set; }
    }
}
