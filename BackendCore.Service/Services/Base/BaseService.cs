using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using BackendCore.Common.Core;
using BackendCore.Common.DTO.Base;
using BackendCore.Common.Helpers.FileHelpers.Token;
using BackendCore.Common.Helpers.HttpClient;
using BackendCore.Common.Infrastructure.UnitOfWork;
using BackendCore.Entities.Enum;
using BackendCore.Integration.CacheRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using static System.Enum;
namespace BackendCore.Service.Services.Base
{
    public class BaseService<T, TDto, TGetDto, TKey, TKeyDto>
        : IBaseService<T, TDto, TGetDto, TKey, TKeyDto>
        where T : class
        where TDto : IEntityDto<TKeyDto>
        where TGetDto : IEntityDto<TKeyDto>
    {
        private readonly MicroServicesUrls _urls;
        protected readonly IUnitOfWork<T> UnitOfWork;
        protected readonly IMapper Mapper;
        protected readonly IResponseResult ResponseResult;
        protected IFinalResult Result;
        protected IHttpContextAccessor HttpContextAccessor;
        protected IConfiguration Configuration;
        protected ICacheRepository CacheRepository;
        protected TokenClaimDto ClaimData { get; set; }

        protected internal BaseService(IServiceBaseParameter<T> businessBaseParameter)
        {
            _urls = businessBaseParameter.Urls;
            HttpContextAccessor = businessBaseParameter.HttpContextAccessor;
            UnitOfWork = businessBaseParameter.UnitOfWork;
            ResponseResult = businessBaseParameter.ResponseResult;
            Mapper = businessBaseParameter.Mapper;
            CacheRepository = businessBaseParameter.CacheRepository;
            Configuration = businessBaseParameter.Configuration;
            var claims = HttpContextAccessor?.HttpContext?.User;
            ClaimData = GetTokenClaimDto(claims);

        }

        /// <summary>
        /// Get By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual async Task<IFinalResult> GetByIdAsync(object id)
        {

            T query = await UnitOfWork.Repository.GetAsync(id);
            var data = Mapper.Map<T, TGetDto>(query);
            return ResponseResult.PostResult(result: data, status: HttpStatusCode.OK,
                message: "Data Retrieved Successfully");

        }

        /// <summary>
        /// Get All
        /// </summary>
        /// <param name="disableTracking"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual async Task<IFinalResult> GetAllAsync(bool disableTracking = false, Expression<Func<T, bool>> predicate = null)
        {

            IEnumerable<T> query;
            if (predicate != null)
            {
                query = await UnitOfWork.Repository.FindAsync(predicate);
            }
            else
            {
                query = await UnitOfWork.Repository.GetAllAsync(disableTracking: disableTracking);
            }

            var data = Mapper.Map<IEnumerable<T>, IEnumerable<TGetDto>>(query);
            return ResponseResult.PostResult(data, status: HttpStatusCode.OK,
                message: HttpStatusCode.OK.ToString());

        }
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public virtual async Task<IFinalResult> AddAsync(TDto model)
        {

            T entity = Mapper.Map<TDto, T>(model);
            SetEntityCreatedBaseProperties(entity);
            UnitOfWork.Repository.Add(entity);
            var affectedRows = await UnitOfWork.SaveChangesAsync();
            if (affectedRows > 0)
            {
                Result = new ResponseResult(result: null, status: HttpStatusCode.Created,
                    message: "Data Inserted Successfully");
            }

            Result.Data = model;
            return Result;

        }
        /// <summary>
        /// Add List
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public virtual async Task<IFinalResult> AddListAsync(List<TDto> model)
        {

            var entities = Mapper.Map<List<TDto>, List<T>>(model);
            UnitOfWork.Repository.AddRange(entities);
            var affectedRows = await UnitOfWork.SaveChangesAsync();
            if (affectedRows > 0)
            {
                Result = new ResponseResult(result: null, status: HttpStatusCode.Created,
                    message: "Data Inserted Successfully");
            }
            Result.Data = model;
            return Result;

        }
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public virtual async Task<IFinalResult> UpdateAsync(TDto model)
        {

            T entityToUpdate = await UnitOfWork.Repository.GetAsync(model.Id);
            var newEntity = Mapper.Map(model, entityToUpdate);
            SetEntityModifiedBaseProperties(newEntity);
            UnitOfWork.Repository.Update(entityToUpdate, newEntity);
            var affectedRows = await UnitOfWork.SaveChangesAsync();
            if (affectedRows > 0)
            {
                Result = ResponseResult.PostResult(result: true, status: HttpStatusCode.Accepted,
                    message: "Data Updated Successfully");
            }

            return Result;

        }
        /// <summary>
        /// Delete Physical
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual async Task<IFinalResult> DeleteAsync(object id)
        {

            var entityToDelete = await UnitOfWork.Repository.GetAsync(id);
            UnitOfWork.Repository.Remove(entityToDelete);
            var affectedRows = await UnitOfWork.SaveChangesAsync();
            if (affectedRows > 0)
            {
                Result = ResponseResult.PostResult(result: true, status: HttpStatusCode.Accepted,
                    message: "Data Deleted Successfully");
            }

            return Result;

        }
        /// <summary>
        /// Delete Soft
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual async Task<IFinalResult> DeleteSoftAsync(object id)
        {

            var entityToDelete = await UnitOfWork.Repository.GetAsync(id);
            SetEntityModifiedBaseProperties(entityToDelete);
            UnitOfWork.Repository.RemoveLogical(entityToDelete);
            var affectedRows = await UnitOfWork.SaveChangesAsync();
            if (affectedRows > 0)
            {
                Result = ResponseResult.PostResult(result: true, status: HttpStatusCode.Accepted,
                    message: "Data Deleted Successfully");
            }

            return Result;

        }
        /// <summary>
        /// Set Add Audit
        /// </summary>
        /// <param name="entity"></param>
        protected void SetEntityCreatedBaseProperties(T entity)
        {
            var type = entity.GetType();
            var createdBy = type.GetProperty("CreatedById");
            if (createdBy != null) createdBy.SetValue(entity, Guid.Parse(ClaimData.UserId));
            var createdDate = type.GetProperty("CreatedDate");
            if (createdDate != null) createdDate.SetValue(entity, DateTime.Now);

        }
        /// <summary>
        /// Set Update Audit
        /// </summary>
        /// <param name="entity"></param>
        protected void SetEntityModifiedBaseProperties(T entity)
        {
            var type = entity.GetType();
            var createdBy = type.GetProperty("ModifiedById");
            if (createdBy != null) createdBy.SetValue(entity, Guid.Parse(ClaimData.UserId));
            var createdDate = type.GetProperty("ModifiedDate");
            if (createdDate != null) createdDate.SetValue(entity, DateTime.Now);

        }

        protected string GetDownloadFileUrl(Guid? id)
        {
            if (id == null)
            {
                return "";
            }
            var securityKey = Configuration.GetValue<string>("FileSecurityToken:SecurityKey");

            var token = TokenHelper.GenerateJsonWebToken(60, securityKey, id.GetValueOrDefault()).FirstOrDefault()?.Token;

            var url = _urls.DownloadFileWithAppCode + $"/{id}?token={token}";

            return url;
        }


        #region Private Methods
        /// <summary>
        /// Get Claims From Token
        /// </summary>
        /// <param name="claims"></param>
        /// <returns></returns>
        private TokenClaimDto GetTokenClaimDto(ClaimsPrincipal claims)
        {
            _ = TryParse(claims?.FindFirst(t => t.Type == "UserType")?.Value ?? "1", out UserType userType);
            var claimData = new TokenClaimDto
            {
                UserId = claims?.FindFirst(t => t.Type == "UserId")?.Value,
                Email = claims?.FindFirst(t => t.Type == "Email")?.Value,
                UserShopId = claims?.FindFirst(t => t.Type == "UserShopId")?.Value,
                UserType = userType
            };
            if (!string.IsNullOrWhiteSpace(claims?.FindFirst(t => t.Type == "UserTypeId")?.Value))
            {
                claimData.UserTypeId = long.Parse(claims.FindFirst(t => t.Type == "UserTypeId")?.Value ?? "0");
            }
            return claimData;
        }

        #endregion


    }
}
