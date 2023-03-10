using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;
using BackendCore.Common.Core;
using BackendCore.Common.DTO.Base;
using BackendCore.Common.DTO.Identity.LoginHistory;
using BackendCore.Common.DTO.Identity.LoginHistory.Parameters;
using BackendCore.Service.Services.Base;
using LinqKit;

namespace BackendCore.Service.Services.Identity.LoginHistory
{
    public class LoginHistoryService : BaseService<Entities.Entities.Identity.LoginHistory, AddLoginHistoryDto, LoginHistoryDto, Guid, Guid?>, ILoginHistoryService
    {
        #region Properties
        #endregion

        #region Constructors
        public LoginHistoryService(IServiceBaseParameter<Entities.Entities.Identity.LoginHistory> parameters) : base(parameters)
        {

        }
        #endregion


        #region Public Methods
        public async Task<DataPaging> GetAllPagedAsync(BaseParam<LoginHistoryFilter> filter)
        {

            var limit = filter.PageSize;
            var offset = ((--filter.PageNumber) * filter.PageSize);
            var query = await UnitOfWork.Repository.FindPagedAsync(predicate: PredicateBuilderFunction(filter.Filter), skip: offset, take: limit, filter.OrderByValue);
            var data = Mapper.Map<IEnumerable<Entities.Entities.Identity.LoginHistory>, IEnumerable<LoginHistoryDto>>(query.Item2);
            return new DataPaging(++filter.PageNumber, filter.PageSize, query.Item1, result: data, status: HttpStatusCode.OK, HttpStatusCode.OK.ToString());

        }

        #endregion


        #region Private Methods
        static Expression<Func<Entities.Entities.Identity.LoginHistory, bool>> PredicateBuilderFunction(LoginHistoryFilter filter)
        {
            var predicate = PredicateBuilder.New<Entities.Entities.Identity.LoginHistory>(true);

            if (!string.IsNullOrWhiteSpace(filter?.NameAr))
            {
                predicate = predicate.And(b => b.Username.ToLower().Contains(filter.Username.ToLower()));
            }
            return predicate;
        }
        #endregion

    }
}
