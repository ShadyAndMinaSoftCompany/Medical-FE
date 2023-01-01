using BackendCore.Common.Core;
using BackendCore.Common.DTO.Business.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Common.DTO.Business.Department
{
    public class AddDepartmentDto : IEntityDto<Guid?>
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? FileId { get; set; }
        public List<DeviceDto> Devices { get; set; } = new List<DeviceDto>();

    }
}
