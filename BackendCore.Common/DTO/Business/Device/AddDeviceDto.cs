using BackendCore.Common.Core;
using BackendCore.Common.DTO.Business.Department;
using BackendCore.Common.DTO.Business.DeviceBrand;
using BackendCore.Common.DTO.Lookup.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Common.DTO.Business.Device
{
    public class AddDeviceDto : IEntityDto<Guid?>
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? FileId { get; set; }
        public Guid? DepartmentId { get; set; }
        public AddDepartmentDto Department { get; set; }
        public List<AddDeviceBrandDto> DeviceBrands { get; set; } = new List<AddDeviceBrandDto>();

    }
}
