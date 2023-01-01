using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Common.DTO.Business.ModelDetail.Filter
{
    public class SearchFilter
    {
        public Guid? DeviceID { get; set; }
        public Guid? BrandID { get; set; }
    }
}
