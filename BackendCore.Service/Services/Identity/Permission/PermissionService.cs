using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;
using BackendCore.Common.Core;
using BackendCore.Common.DTO.Base;
using BackendCore.Common.DTO.Identity.Permission;
using BackendCore.Common.DTO.Identity.Permission.Parameters;
using BackendCore.Entities.Entities.Identity;
using BackendCore.Service.Services.Base;
using LinqKit;

namespace BackendCore.Service.Services.Identity.Permission;

public class PermissionService :
    BaseService<Entities.Entities.Identity.Permission, AddPermissionDto, PermissionDto, Guid, Guid?>, IPermissionService
{
    #region Constructors

    public PermissionService(IServiceBaseParameter<Entities.Entities.Identity.Permission> parameters) : base(parameters)
    {
    }

    #endregion


    #region Private Methods

    private static Expression<Func<Entities.Entities.Identity.Permission, bool>> PredicateBuilderFunction(
        PermissionFilter filter)
    {
        var predicate = PredicateBuilder.New<Entities.Entities.Identity.Permission>(true);
        predicate = predicate.And(b => b.IsDeleted==false);

        if (!string.IsNullOrWhiteSpace(filter?.NameAr))
            predicate = predicate.And(b => b.NameAr.ToLower().Contains(filter.NameAr.ToLower()));
        if (!string.IsNullOrWhiteSpace(filter?.NameEn))
            predicate = predicate.And(b => b.NameEn.ToLower().Contains(filter.NameEn.ToLower()));
        return predicate;
    }

    #endregion

    #region Properties

    #endregion


    #region Public Methods

    public async Task<DataPaging> GetAllPagedAsync(BaseParam<PermissionFilter> filter)
    {
        var limit = filter.PageSize;
        var offset = --filter.PageNumber * filter.PageSize;
        var query = await UnitOfWork.Repository.FindPagedAsync(PredicateBuilderFunction(filter.Filter), offset, limit,
            filter.OrderByValue);
        var data =
            Mapper.Map<IEnumerable<Entities.Entities.Identity.Permission>, IEnumerable<PermissionDto>>(query.Item2);
        return new DataPaging(++filter.PageNumber, filter.PageSize, query.Item1, data, HttpStatusCode.OK,
            HttpStatusCode.OK.ToString());
    }

    public async Task<IFinalResult> GetAllAsync()
    {
       
        var query = await UnitOfWork.Repository.FindAsync(t=>t.IsDeleted==false);
        var data =
            Mapper.Map<IEnumerable<Entities.Entities.Identity.Permission>, IEnumerable<PermissionDto>>(query);
        return ResponseResult.PostResult(data, HttpStatusCode.OK, message: HttpStatusCode.OK.ToString());

    }

    public async Task<IFinalResult> AssignPermissionsToRole(AssignPermissionsToRoleDto dto)
    {
        if (dto.PermissionsIds != null)
        {
            var rolePermissions = await UnitOfWork.GetRepository<RolePermission>().FindAsync(t => t.RoleId == dto.RoleId);
            UnitOfWork.GetRepository<RolePermission>().RemoveRange(rolePermissions);
            foreach (var permission in dto.PermissionsIds)
                UnitOfWork.GetRepository<RolePermission>().Add(new RolePermission
                    { PermissionId = permission, RoleId = dto.RoleId });

        }

        var affectedRows = await UnitOfWork.SaveChangesAsync();
        if (affectedRows > 0)
            Result = new ResponseResult(null, HttpStatusCode.Created,
                message: "Data Updated Successfully");


        return Result;
    }


    public async Task<IFinalResult> GetRolePermissions(Guid roleId)
    {
        var rolePermissions = await UnitOfWork.GetRepository<Entities.Entities.Identity.Permission>().FindAsync(a => a.RolePermissions.Any(p => p.RoleId == roleId)&a.IsDeleted==false);
        var permissions = (Mapper.Map<IEnumerable<PermissionDto>>(rolePermissions));
        return ResponseResult.PostResult(permissions, HttpStatusCode.OK, message: HttpStatusCode.OK.ToString());

    }

    #endregion
}