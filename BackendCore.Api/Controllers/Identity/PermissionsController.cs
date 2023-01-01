using System;
using System.Threading.Tasks;
using BackendCore.Api.Controllers.Base;
using BackendCore.Common.Core;
using BackendCore.Common.DTO.Base;
using BackendCore.Common.DTO.Identity.Permission;
using BackendCore.Common.DTO.Identity.Permission.Parameters;
using BackendCore.Service.Services.Identity.Permission;
using Microsoft.AspNetCore.Mvc;

namespace BackendCore.Api.Controllers.Identity
{
    /// <summary>
    /// Permissions Controller
    /// </summary>
    public class PermissionsController : BaseController
    {
        private readonly IPermissionService _permissionService;
        /// <summary>
        /// Constructor
        /// </summary>
        public PermissionsController(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }
        /// <summary>
        /// Get By Id 
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IFinalResult> GetAsync(Guid id)
        {
            var result = await _permissionService.GetByIdAsync(id);
            return result;
        }

        /// <summary>
        /// Get All 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IFinalResult> GetAllAsync()
        {
            var result = await _permissionService.GetAllAsync();
            return result;
        }

        /// <summary>
        /// GetAll Data paged
        /// </summary>
        /// <param name="filter">Filter responsible for search and sort</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<DataPaging> GetPagedAsync([FromBody] BaseParam<PermissionFilter> filter)
        {
            return await _permissionService.GetAllPagedAsync(filter);
        }

        /// <summary>
        /// Add 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IFinalResult> AddAsync([FromBody] AddPermissionDto dto)
        {
            var result = await _permissionService.AddAsync(dto);
            return result;
        }


        /// <summary>
        /// Update  
        /// </summary>
        /// <param name="model">Object content</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IFinalResult> UpdateAsync(AddPermissionDto model)
        {

            return await _permissionService.UpdateAsync(model);
        }
        /// <summary>
        /// Remove  by id
        /// </summary>
        /// <param name="id">PK</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IFinalResult> DeleteAsync(Guid id)
        {
            return await _permissionService.DeleteAsync(id);
        }

        /// <summary>
        /// Soft Remove  by id
        /// </summary>
        /// <param name="id">PK</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IFinalResult> DeleteSoftAsync(Guid id)
        {
            return await _permissionService.DeleteSoftAsync(id);
        }


        /// <summary>
        /// Assign Permissions To Role
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IFinalResult> AssignPermissionsToRole([FromBody]AssignPermissionsToRoleDto dto)
        {
            return await _permissionService.AssignPermissionsToRole(dto);
        }

        /// <summary>
        /// Get Role Permissions
        /// </summary>
        /// <param name="roleId">PK</param>
        /// <returns></returns>
        [HttpGet("{roleId}")]
        public async Task<IFinalResult> GetRolePermissions(Guid roleId)
        {
            return await _permissionService.GetRolePermissions(roleId);
        }
    }
}
