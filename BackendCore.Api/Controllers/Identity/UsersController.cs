using System;
using System.Net;
using System.Threading.Tasks;
using BackendCore.Api.Controllers.Base;
using BackendCore.Common.Core;
using BackendCore.Common.DTO.Base;
using BackendCore.Common.DTO.Identity.User;
using BackendCore.Common.DTO.Identity.User.Parameters;
using BackendCore.Common.Services;
using BackendCore.Service.Services.Identity.User;
using Microsoft.AspNetCore.Mvc;

namespace BackendCore.Api.Controllers.Identity
{
    /// <summary>
    /// Users Controller
    /// </summary>
    public class UsersController : BaseController
    {
        private readonly IUserService _userService;
        private readonly IClaimService _claimService;
        /// <summary>
        /// Constructor
        /// </summary>
        public UsersController(IClaimService claimService, IUserService userService)
        {
            _userService = userService;
            _claimService = claimService;
        }
        /// <summary>
        /// Get By Id 
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IFinalResult> GetAsync(Guid id)
        {
            var result = await _userService.GetAsync(id);
            return result;
        }

        /// <summary>
        /// Get All 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IFinalResult> GetAllAsync()
        {
            var result = await _userService.GetAllAsync();
            return result;
        }

        /// <summary>
        /// GetAll Data paged
        /// </summary>
        /// <param name="filter">Filter responsible for search and sort</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<DataPaging> GetPagedAsync([FromBody] BaseParam<UserFilter> filter)
        {
            return await _userService.GetAllPagedAsync(filter);
        }

        /// <summary>
        /// Add 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IFinalResult> AddAsync([FromBody] AddUserDto dto)
        {
            var result = await _userService.AddAsync(dto);
            return result;
        }


        /// <summary>
        /// Update  
        /// </summary>
        /// <param name="model">Object content</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IFinalResult> UpdateAsync(AddUserDto model)
        {

            return await _userService.UpdateAsync(model);
        }
        /// <summary>
        /// Remove  by id
        /// </summary>
        /// <param name="id">PK</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IFinalResult> DeleteAsync(Guid id)
        {
            return await _userService.DeleteAsync(id);
        }

        /// <summary>
        /// Soft Remove  by id
        /// </summary>
        /// <param name="id">PK</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IFinalResult> DeleteSoftAsync(Guid id)
        {
            return await _userService.DeleteSoftAsync(id);
        }

        /// <summary>
        /// Get User Roles
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet("{userId}")]
        public async Task<IFinalResult> GetUserRoles(Guid userId)
        {
            var result = await _userService.GetUserRoles(userId);
            return result;
        }

        /// <summary>
        /// Get User Permissions
        /// </summary>
        /// /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet("{userId}")]
        public async Task<IFinalResult> GetUserPermissions(Guid userId)
        {

            var result = await _userService.GetUserPermissions(userId);
            return result;

        }
    }
}
