using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Common.DTO.Business.Product
{
    public class BarcodeDto
    {
        public Guid? Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public Guid? BarcodeId { get; set; }
        public string ImageUrl { get; set; }
        public string BarcodeImageUrl { get; set; }
    }
}
