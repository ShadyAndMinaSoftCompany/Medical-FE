using BackendCore.Common.Core;
using BackendCore.Common.DTO.Business.Department;
using BackendCore.Common.DTO.Lookup.Department;
using BackendCore.Service.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Service.Services.Business.Department
{
    public interface IDepartmentService : IBaseService<Entities.Entities.Business.Department, AddDepartmentDto, DepartmentDto, Guid, Guid?>
    {
        Task<IFinalResult> GetAllAsync();
    }
}
