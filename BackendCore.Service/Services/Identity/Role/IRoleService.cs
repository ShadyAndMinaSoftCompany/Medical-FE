using System;
using System.Threading.Tasks;
using BackendCore.Common.Core;
using BackendCore.Common.DTO.Base;
using BackendCore.Common.DTO.Identity.Role;
using BackendCore.Common.DTO.Identity.Role.Parameters;
using BackendCore.Service.Services.Base;

namespace BackendCore.Service.Services.Identity.Role
{
    public interface IRoleService : IBaseService<Entities.Entities.Identity.Role, AddRoleDto, RoleDto , Guid, Guid?>
    {
        Task<DataPaging> GetAllPagedAsync(BaseParam<RoleFilter> filter);
        Task<IFinalResult> GetAllAsync();
    }
}