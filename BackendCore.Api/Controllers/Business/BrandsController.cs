using BackendCore.Common.Core;
using BackendCore.Service.Services.Business.Brand;
using BackendCore.Service.Services.Business.Department;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BackendCore.Api.Controllers.Business
{
    public class BrandsController : Controller
    {
        private readonly IBrandService _brandService;


        /// <summary>
        /// Constructor
        /// </summary>
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }



        /// <summary>
        /// Get Brands
        /// </summary>
        /// <param name="deviceId"></param>
        /// <returns></returns>
        [HttpGet("{deviceId}")]
        public async Task<IFinalResult> GetBrands(Guid deviceId)
        {
            var result = await _brandService.GetAllAsync(deviceId);
            return result;
        }
    }
}
