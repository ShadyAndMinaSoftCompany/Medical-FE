using AutoMapper;
using BackendCore.Common.Core;
using BackendCore.Common.DTO.Business.Brand;
using BackendCore.Common.DTO.Business.Device;
using BackendCore.Service.Services.Base;
using BackendCore.Service.Services.Business.Device;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Service.Services.Business.Brand
{
    public class BrandService :
        BaseService<Entities.Entities.Business.Brand, AddBrandDto, BrandDto, Guid, Guid?>, IBrandService

    {
        #region constructor

        public BrandService(IServiceBaseParameter<Entities.Entities.Business.Brand> businessBaseParameter) : base(
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
       
        public async Task<IFinalResult> GetAllAsync(Guid deviceId)
        {
            var entities = await UnitOfWork.GetRepository<Entities.Entities.Business.DeviceBrand>().FindAsync(x => x.DeviceId==deviceId,include:r=>r.Include(y=>y.Brand));
            var data = Mapper.Map<IEnumerable<Entities.Entities.Business.Brand>, List<BrandDto>>(entities.Select(t=>t.Brand));
            return new ResponseResult(data, HttpStatusCode.OK, null, "Success");
        }


        #endregion


        #region Private Methods

        #endregion

    }
}