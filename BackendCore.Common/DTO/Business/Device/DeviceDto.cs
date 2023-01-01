using BackendCore.Common.Core;
using BackendCore.Common.DTO.Business.DeviceBrand;
using BackendCore.Common.DTO.Lookup.Department;
using BackendCore.Entities.Entities.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Common.DTO.Business.Device
{
    public class DeviceDto : IEntityDto<Guid?>
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? FileId { get; set; }
        public Guid? DepartmentId { get; set; }
        public DepartmentDto Department { get; set; }
        public List<DeviceBrandDto> DeviceBrands { get; set; } = new List<DeviceBrandDto>();

    }
}
