using AutoMapper;
using BackendCore.Common.Core;
using BackendCore.Common.DTO.Base;
using BackendCore.Common.DTO.Business.Device;
using BackendCore.Common.DTO.Business.ModelDetail;
using BackendCore.Common.DTO.Business.ModelDetail.Filter;
using BackendCore.Common.DTO.Business.Product.Parameters;
using BackendCore.Entities.Entities.Business;
using BackendCore.Service.Services.Base;
using BackendCore.Service.Services.Business.Device;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Service.Services.Business.ModelDetail
{
    public class ModelDetailService :
        BaseService<Entities.Entities.Business.ModelDetail, AddModelDetailDto, ModelDetailDto, Guid, Guid?>, IModelDetailService

    {
        #region constructor

        public ModelDetailService(IServiceBaseParameter<Entities.Entities.Business.ModelDetail> businessBaseParameter) : base(
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
        public async Task<IFinalResult> GetAllAsync(BaseParam<SearchFilter> filter)
        {
            var limit = filter.PageSize;
            var offset = --filter.PageNumber * filter.PageSize;
            var userShopId = ClaimData.UserShopId;

            var entities = await UnitOfWork.Repository.FindAsync(x => x.DeviceBrand.BrandId == filter.Filter.BrandID && x.DeviceBrand.DeviceId == filter.Filter.DeviceID);
            var data = Mapper.Map<IEnumerable<Entities.Entities.Business.ModelDetail>, List<ModelDetailDto>>(entities);
            return new ResponseResult(data, HttpStatusCode.OK, null, "Success");
        }

        /// <summary>
        /// Get All Paged
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public async Task<IFinalResult> GetAsync(Guid? id)
        {
           

            var entities = await UnitOfWork.Repository.FirstOrDefaultAsync(x => x.Id== id);
            var data = Mapper.Map<Entities.Entities.Business.ModelDetail, ModelDetailDto>(entities);
            data.ImageUrl = GetDownloadFileUrl(data.FileId);
            return new ResponseResult(data, HttpStatusCode.OK, null, "Success");
        }

        #endregion


        #region Private Methods

        #endregion

    }
}
