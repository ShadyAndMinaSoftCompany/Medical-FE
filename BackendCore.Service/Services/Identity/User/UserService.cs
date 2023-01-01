using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;
using BackendCore.Common.Core;
using BackendCore.Common.DTO.Base;
using BackendCore.Common.DTO.Common.File;
using BackendCore.Common.DTO.Identity.Permission;
using BackendCore.Common.DTO.Identity.Role;
using BackendCore.Common.DTO.Identity.User;
using BackendCore.Common.DTO.Identity.User.Parameters;
using BackendCore.Common.Extensions;
using BackendCore.Entities.Entities.Identity;
using BackendCore.Service.Services.Base;
using LinqKit;
using Microsoft.EntityFrameworkCore;

namespace BackendCore.Service.Services.Identity.User
{
    public class UserService : BaseService<Entities.Entities.Identity.User, AddUserDto, UserDto, Guid, Guid?>, IUserService
    {
        public UserService(IServiceBaseParameter<Entities.Entities.Identity.User> parameters) : base(parameters)
        {

        }

        #region Public Methods

        /// <summary>
        ///     Get By Id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<IFinalResult> GetAsync(Guid userId)
        {
            var entity = await UnitOfWork.Repository.FirstOrDefaultAsync(x => x.Id == userId);
            if (entity == null)
            {
                Result = new ResponseResult(null, HttpStatusCode.BadRequest,
                    message: "This user not found in database");
                return ResponseResult.PostResult(Result, HttpStatusCode.OK, message: HttpStatusCode.OK.ToString());
            }

            var data = Mapper
                .Map<Entities.Entities.Identity.User, UserDto>(entity);
            data.ImageUrl = GetDownloadFileUrl(data.FileId);

            var userImage = await UnitOfWork.GetRepository<Entities.Entities.Common.File>()
                .FirstOrDefaultAsync(r => r.Id == entity.FileId);

            data.UserImage = Mapper
                .Map<Entities.Entities.Common.File, FileDto>(userImage);

            return ResponseResult.PostResult(data, HttpStatusCode.OK, message: HttpStatusCode.OK.ToString());
        }

        public override async Task<IFinalResult> GetAllAsync(bool disableTracking = false, Expression<Func<Entities.Entities.Identity.User, bool>> predicate = null)
        {
            IEnumerable<Entities.Entities.Identity.User> query;
            if (predicate != null)
            {
                query = await UnitOfWork.Repository.FindAsync(predicate);
            }
            else
            {
                query = await UnitOfWork.Repository.GetAllAsync(disableTracking: disableTracking);
            }

            var data = Mapper.Map<IEnumerable<Entities.Entities.Identity.User>, IEnumerable<UserDto>>(query);
            data.ForEach(e =>
            {
                if (e.FileId == null)
                {
                    e.ImageUrl = "assets/images/empty/user.svg";
                }
                else
                {
                    e.ImageUrl = GetDownloadFileUrl(e.FileId);

                }
            });
            return ResponseResult.PostResult(data, status: HttpStatusCode.OK,
                message: HttpStatusCode.OK.ToString());
        }

        public async Task<DataPaging> GetAllPagedAsync(BaseParam<UserFilter> filter)
        {

            var limit = filter.PageSize;
            var offset = ((--filter.PageNumber) * filter.PageSize);
            var query = await UnitOfWork.Repository.FindPagedAsync(predicate: PredicateBuilderFunction(filter.Filter), skip: offset, take: limit, filter.OrderByValue);
            var data = Mapper.Map<IEnumerable<Entities.Entities.Identity.User>, IEnumerable<UserDto>>(query.Item2);
            return new DataPaging(++filter.PageNumber, filter.PageSize, query.Item1, result: data, status: HttpStatusCode.OK, HttpStatusCode.OK.ToString());

        }

        public override async Task<IFinalResult> AddAsync(AddUserDto model)
        {
            var entity = Mapper.Map<AddUserDto, Entities.Entities.Identity.User>(model);
            entity.PasswordHash = CryptoHasher.HashPassword(model.Password);
            SetEntityCreatedBaseProperties(entity);
            UnitOfWork.Repository.Add(entity);

            if (model.RoleIds != null)
                foreach (var rolId in model.RoleIds)
                    UnitOfWork.GetRepository<UserRole>().Add(new UserRole()
                        { RoleId = rolId, UserId = entity.Id });

            var affectedRows = await UnitOfWork.SaveChangesAsync();
            if (affectedRows > 0)
            {
                Result = new ResponseResult(result: null, status: HttpStatusCode.Created,
                    message: "Data Inserted Successfully");
            }

            Result.Data = model;
            return Result;
        }
        public override async Task<IFinalResult> UpdateAsync(AddUserDto model)
        {
            var entity = await UnitOfWork.Repository.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (entity == null)
            {
                Result = new ResponseResult(null, HttpStatusCode.BadRequest,
                    message: "This user not found in database");
            }
            else
            {
                var newUserEntity = Mapper.Map(model, entity);
                await UnitOfWork.Repository.UpdateAsync(newUserEntity.Id, newUserEntity);
                var userRoles = await UnitOfWork.GetRepository<UserRole>().FindAsync(r => r.UserId == entity.Id);
                UnitOfWork.GetRepository<UserRole>().RemoveRange(userRoles);
                if (model.RoleIds != null)
                {
                    foreach (var rolId in model.RoleIds)
                        UnitOfWork.GetRepository<UserRole>().Add(new UserRole()
                            { RoleId = rolId, UserId = entity.Id });
                }
                    

                var affectedRows = await UnitOfWork.SaveChangesAsync();
                if (affectedRows > 0)
                    Result = new ResponseResult(null, HttpStatusCode.Created,
                        message: "Data Updated Successfully");
            }


            return ResponseResult.PostResult(Result, HttpStatusCode.OK, message: HttpStatusCode.OK.ToString());
        }

        public async Task<IFinalResult> GetUserRoles(Guid userId)
        {
           var userRoles=await UnitOfWork.GetRepository<UserRole>().FindAsync(r=>r.UserId==userId & r.IsDeleted==false,include:r=>r.Include(t=>t.Role));
           var roles = (Mapper.Map<IEnumerable<RoleDto>>(userRoles.Select(t=>t.Role)));
           return ResponseResult.PostResult(roles, HttpStatusCode.OK, message: HttpStatusCode.OK.ToString());

        }

        public async Task<IFinalResult> GetUserPermissions(Guid userId)
        {
            var userPermissions = new List<PermissionDto>();
            var userRoles =await UnitOfWork.GetRepository<UserRole>().FindAsync(r => r.UserId == userId&r.Role.IsDeleted==false);
            var rolesIds = (Mapper.Map<IEnumerable<UserRoleDto>>(userRoles)).Select(r=>r.RoleId);

            foreach (var roleId in rolesIds)
            {
                var rolePermissions = await UnitOfWork.GetRepository<Entities.Entities.Identity.Permission>().FindAsync(a => a.RolePermissions.Any(p => p.RoleId == roleId)&a.IsDeleted==false);
                var permissions = (Mapper.Map<IEnumerable<PermissionDto>>(rolePermissions)).ToList();
                userPermissions.AddRange(permissions);
            }
            return ResponseResult.PostResult(userPermissions, HttpStatusCode.OK, message: HttpStatusCode.OK.ToString());

        }

        #endregion

        #region Private Methods
        static Expression<Func<Entities.Entities.Identity.User, bool>> PredicateBuilderFunction(UserFilter filter)
        {
            var predicate = PredicateBuilder.New<Entities.Entities.Identity.User>(true);
            predicate = predicate.And(b => b.IsDeleted==false);
            if (!string.IsNullOrWhiteSpace(filter?.NameAr))
            {
                predicate = predicate.And(b => b.Name.ToLower().Contains(filter.Name.ToLower()));
            }
            return predicate;
        }

        #endregion


    }
}
