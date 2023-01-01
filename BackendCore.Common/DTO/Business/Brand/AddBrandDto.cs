using BackendCore.Common.Core;
using BackendCore.Common.DTO.Business.DeviceBrand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Common.DTO.Business.Brand
{
    public class AddBrandDto : IEntityDto<Guid?>
    {
        public Guid? Id { get; set; }
        public string Manufacturer { get; set; }
        public string Bidder { get; set; }
        public string CountryOfOrigin { get; set; }
        public List<AddDeviceBrandDto> DeviceBrands { get; set; } = new List<AddDeviceBrandDto>();

    }
}
