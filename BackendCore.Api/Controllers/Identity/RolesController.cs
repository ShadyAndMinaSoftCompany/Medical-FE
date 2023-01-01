using System;
using System.Threading.Tasks;
using BackendCore.Api.Controllers.Base;
using BackendCore.Common.Core;
using BackendCore.Common.DTO.Base;
using BackendCore.Common.DTO.Identity.Role;
using BackendCore.Common.DTO.Identity.Role.Parameters;
using BackendCore.Service.Services.Identity.Role;
using Microsoft.AspNetCore.Mvc;

namespace BackendCore.Api.Controllers.Identity
{
    /// <summary>
    /// Roles Controller
    /// </summary>
    public class RolesController : BaseController
    {
        private readonly IRoleService _roleService;
        /// <summary>
        /// Constructor
        /// </summary>
        public RolesController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        /// <summary>
        /// Get By Id 
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IFinalResult> GetAsync(Guid id)
        {
            var result = await _roleService.GetByIdAsync(id);
            return result;
        }

        /// <summary>
        /// Get All 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IFinalResult> GetAllAsync()
        {
            var result = await _roleService.GetAllAsync();
            return result;
        }

        /// <summary>
        /// GetAll Data paged
        /// </summary>
        /// <param name="filter">Filter responsible for search and sort</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<DataPaging> GetPagedAsync([FromBody] BaseParam<RoleFilter> filter)
        {
            return await _roleService.GetAllPagedAsync(filter);
        }

        /// <summary>
        /// Add 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IFinalResult> AddAsync([FromBody] AddRoleDto dto)
        {
            var result = await _roleService.AddAsync(dto);
            return result;
        }


        /// <summary>
        /// Update  
        /// </summary>
        /// <param name="model">Object content</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IFinalResult> UpdateAsync(AddRoleDto model)
        {

            return await _roleService.UpdateAsync(model);
        }
        /// <summary>
        /// Remove  by id
        /// </summary>
        /// <param name="id">PK</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IFinalResult> DeleteAsync(Guid id)
        {
            return await _roleService.DeleteAsync(id);
        }

        /// <summary>
        /// Soft Remove  by id
        /// </summary>
        /// <param name="id">PK</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IFinalResult> DeleteSoftAsync(Guid id)
        {
            return await _roleService.DeleteSoftAsync(id);
        }


    }
}
