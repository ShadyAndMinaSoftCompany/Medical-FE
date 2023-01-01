using BackendCore.Common.Core;
using BackendCore.Common.DTO.Business.Brand;
using BackendCore.Common.DTO.Business.Device;
using BackendCore.Service.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Service.Services.Business.Brand
{
    public interface IBrandService : IBaseService<Entities.Entities.Business.Brand, AddBrandDto, BrandDto, Guid, Guid?>
    {
        Task<IFinalResult> GetAllAsync(Guid deviceId);
    }
}
