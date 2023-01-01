using BackendCore.Common.Core;
using BackendCore.Service.Services.Business.Brand;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using BackendCore.Api.Controllers.Base;
using BackendCore.Service.Services.Business.Device;

namespace BackendCore.Api.Controllers.Business
{
    public class DevicesController : BaseController
    {
        private readonly IDeviceService _deviceservice;


    /// <summary>
    /// Constructor
    /// </summary>
    public DevicesController(IDeviceService deviceservice)
    {
            _deviceservice = deviceservice;
    }



        /// <summary>
        /// Get Devices
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns></returns>
        [HttpGet("{departmentId}")]
    public async Task<IFinalResult> GetDevices(Guid departmentId)
    {
        var result = await _deviceservice.GetAllAsync(departmentId);
        return result;
    }
}
}
