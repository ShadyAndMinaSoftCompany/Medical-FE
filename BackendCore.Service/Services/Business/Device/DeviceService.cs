using BackendCore.Common.Core;
using BackendCore.Common.DTO.Business.Department;
using BackendCore.Common.DTO.Business.Device;
using BackendCore.Common.DTO.Lookup.Department;
using BackendCore.Service.Services.Base;
using BackendCore.Service.Services.Business.Department;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Service.Services.Business.Device
{
    public class DeviceService :
        BaseService<Entities.Entities.Business.Device, AddDeviceDto, DeviceDto, Guid, Guid?>, IDeviceService

    {
        #region constructor

        public DeviceService(IServiceBaseParameter<Entities.Entities.Business.Device> businessBaseParameter) : base(
            businessBaseParameter)
        {
        }

        #endregion


        #region Public Methods
        /// <summary>
        /// Get All Paged
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public async Task<IFinalResult> GetAllAsync(Guid departmentId)
        {
            var entities = await UnitOfWork.Repository.FindAsync(t=>t.DepartmentId==departmentId);
            var data = Mapper.Map<IEnumerable<Entities.Entities.Business.Device>, List<DeviceDto>>(entities);
            return new ResponseResult(data, HttpStatusCode.OK, null, "Success");
        }



        #endregion


        #region Private Methods

        #endregion

    }
}