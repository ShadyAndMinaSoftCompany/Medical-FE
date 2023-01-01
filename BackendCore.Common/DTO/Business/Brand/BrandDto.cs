using BackendCore.Common.Core;
using BackendCore.Common.DTO.Business.DeviceBrand;
using BackendCore.Common.DTO.Business.ModelDetail;
using BackendCore.Entities.Entities.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Common.DTO.Business.Brand
{
    public class BrandDto : IEntityDto<Guid?>
    {
        public Guid? Id { get; set; }
        public string Manufacturer { get; set; }
        public string Bidder { get; set; }
        public string CountryOfOrigin { get; set; }
        public  List<DeviceBrandDto> DeviceBrands { get; set; } = new List<DeviceBrandDto>();

    }
}
