using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;
using BackendCore.Common.Core;
using BackendCore.Common.DTO.Base;
using BackendCore.Common.DTO.Identity.Role;
using BackendCore.Common.DTO.Identity.Role.Parameters;
using BackendCore.Service.Services.Base;
using LinqKit;

namespace BackendCore.Service.Services.Identity.Role
{
    public class RoleService : BaseService<Entities.Entities.Identity.Role, AddRoleDto, RoleDto, Guid, Guid?>, IRoleService
    {
        #region Properties
        #endregion

        #region Constructors
        public RoleService(IServiceBaseParameter<Entities.Entities.Identity.Role> parameters) : base(parameters)
        {

        }
        #endregion


        #region Public Methods
        
        public async Task<DataPaging> GetAllPagedAsync(BaseParam<RoleFilter> filter)
        {

            var limit = filter.PageSize;
            var offset = ((--filter.PageNumber) * filter.PageSize);
            var query = await UnitOfWork.Repository.FindPagedAsync(predicate: PredicateBuilderFunction(filter.Filter), skip: offset, take: limit, filter.OrderByValue);
            var data = Mapper.Map<IEnumerable<Entities.Entities.Identity.Role>, IEnumerable<RoleDto>>(query.Item2);
            return new DataPaging(++filter.PageNumber, filter.PageSize, query.Item1, result: data, status: HttpStatusCode.OK, HttpStatusCode.OK.ToString());

        }

        public  async Task<IFinalResult> GetAllAsync()
        {

          
            var query = await UnitOfWork.Repository.FindAsync(t=>t.IsDeleted==false);
            var data = Mapper.Map<IEnumerable<Entities.Entities.Identity.Role>, IEnumerable<RoleDto>>(query);
            return ResponseResult.PostResult(data, HttpStatusCode.OK, message: HttpStatusCode.OK.ToString());

        }

        #endregion


        #region Private Methods

        static Expression<Func<Entities.Entities.Identity.Role, bool>> PredicateBuilderFunction(RoleFilter filter)
        {
            var predicate = PredicateBuilder.New<Entities.Entities.Identity.Role>(true);

            predicate = predicate.And(b => b.IsDeleted==false);

            if (!string.IsNullOrWhiteSpace(filter?.NameAr))
            {
                predicate = predicate.And(b => b.NameAr.ToLower().Contains(filter.NameAr.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(filter?.NameEn))
            {
                predicate = predicate.And(b => b.NameEn.ToLower().Contains(filter.NameEn.ToLower()));
            }
            return predicate;
        }
        #endregion

    }
}
