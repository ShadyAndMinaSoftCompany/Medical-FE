using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Common.DTO.Business.Product
{
    public class ProductStatisticsDto
    {
        public string ProductNameAr { get; set; }
        public string ProductNameEn { get; set; }
        public decimal? ProductTotal { get; set; }
    }
}
