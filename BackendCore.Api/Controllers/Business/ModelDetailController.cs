using BackendCore.Common.Core;
using BackendCore.Service.Services.Business.Brand;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using BackendCore.Service.Services.Business.ModelDetail;
using BackendCore.Common.DTO.Base;
using BackendCore.Common.DTO.Business.ModelDetail.Filter;

namespace BackendCore.Api.Controllers.Business
{
    public class ModelDetailController : Controller
    {
        private readonly IModelDetailService _modelDetailService;


        /// <summary>
        /// Constructor
        /// </summary>
        public ModelDetailController(IModelDetailService modelDetailService)
        {
            _modelDetailService = modelDetailService;
        }



        /// <summary>
        /// Get ModelDetails
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IFinalResult> GetModelDetails([FromBody] BaseParam<SearchFilter> filter)
        {
            var result = await _modelDetailService.GetAllAsync(filter);
            return result;
        }
    }
}
