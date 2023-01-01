using System.Threading.Tasks;
using BackendCore.Api.Controllers.Base;
using BackendCore.Common.Core;
using BackendCore.Common.DTO.Base;
using BackendCore.Common.DTO.Identity.LoginHistory.Parameters;
using BackendCore.Service.Services.Identity.LoginHistory;
using Microsoft.AspNetCore.Mvc;

namespace BackendCore.Api.Controllers.Identity
{
    /// <summary>
    /// Login History Controller
    /// </summary>
    public class LoginHistoriesController : BaseController
    {
        private readonly ILoginHistoryService _loginHistoryService;
        /// <summary>
        /// Constructor
        /// </summary>
        public LoginHistoriesController(ILoginHistoryService loginHistoryService)
        {
            _loginHistoryService = loginHistoryService;
        }
        /// <summary>
        /// Get By Id 
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IFinalResult> GetAsync(long id)
        {
            var result = await _loginHistoryService.GetByIdAsync(id);
            return result;
        }

        /// <summary>
        /// Get All 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IFinalResult> GetAllAsync()
        {
            var result = await _loginHistoryService.GetAllAsync();
            return result;
        }

        /// <summary>
        /// GetAll Data paged
        /// </summary>
        /// <param name="filter">Filter responsible for search and sort</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<DataPaging> GetPagedAsync([FromBody] BaseParam<LoginHistoryFilter> filter)
        {
            return await _loginHistoryService.GetAllPagedAsync(filter);
        }

        

    }
}
