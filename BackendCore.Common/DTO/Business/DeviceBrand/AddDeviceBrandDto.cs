using BackendCore.Common.Core;
using BackendCore.Common.DTO.Business.Brand;
using BackendCore.Common.DTO.Business.Device;
using BackendCore.Common.DTO.Business.ModelDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Common.DTO.Business.DeviceBrand
{
    public class AddDeviceBrandDto : IEntityDto<Guid?>
    {
        public Guid? Id { get; set; }
        public Guid? DeviceId { get; set; }
        public AddDeviceDto Device { get; set; }
        public Guid? BrandId { get; set; }
        public AddBrandDto Brand { get; set; }
        public List<AddModelDetailDto> ModelDetails { get; set; } = new List<AddModelDetailDto>();

    }
}