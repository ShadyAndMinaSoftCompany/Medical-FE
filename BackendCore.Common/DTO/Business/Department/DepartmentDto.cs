using BackendCore.Common.Core;
using BackendCore.Common.DTO.Business.Device;
using BackendCore.Entities.Entities.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Common.DTO.Lookup.Department
{
    public class DepartmentDto : IEntityDto<Guid?>
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? FileId { get; set; }
        public List<DeviceDto> Devices { get; set; } = new List<DeviceDto>();


    }
}
