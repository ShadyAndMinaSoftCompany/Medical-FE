using BackendCore.Common.Core;
using BackendCore.Service.Services.Business.Brand;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using BackendCore.Service.Services.Business.ModelDetail;
using BackendCore.Common.DTO.Base;
using BackendCore.Common.DTO.Business.ModelDetail.Filter;
using BackendCore.Api.Controllers.Base;

namespace BackendCore.Api.Controllers.Business
{
    public class ModelDetailController : BaseController
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

        /// <summary>
        /// Get Model Details by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IFinalResult> GetModelDetails(Guid id)
        {
            var result = await _modelDetailService.GetAsync(id);
            return result;
        }
    }
}
