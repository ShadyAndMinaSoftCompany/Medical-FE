using BackendCore.Common.Core;
using BackendCore.Common.DTO.Business.Brand;
using BackendCore.Common.DTO.Business.Device;
using BackendCore.Common.DTO.Business.ModelDetail;
using BackendCore.Entities.Entities.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Common.DTO.Business.DeviceBrand
{
    public class DeviceBrandDto : IEntityDto<Guid?>
    {
        public Guid? Id { get; set; }
        public Guid? DeviceId { get; set; }
        public DeviceDto Device { get; set; }
        public Guid? BrandId { get; set; }
        public BrandDto Brand { get; set; }
        public List<ModelDetailDto> ModelDetails { get; set; } = new List<ModelDetailDto>();

    }
}
