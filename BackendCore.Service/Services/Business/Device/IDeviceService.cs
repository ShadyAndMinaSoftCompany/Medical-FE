using BackendCore.Common.Core;
using BackendCore.Common.DTO.Business.Device;
using BackendCore.Service.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Service.Services.Business.Device
{
    public interface IDeviceService : IBaseService<Entities.Entities.Business.Device, AddDeviceDto, DeviceDto, Guid, Guid?>
    {
        Task<IFinalResult> GetAllAsync(Guid departmentId);
    }
}
