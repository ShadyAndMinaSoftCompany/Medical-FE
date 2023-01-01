using System;
using System.Threading.Tasks;
using BackendCore.Common.Core;
using BackendCore.Common.DTO.Base;
using BackendCore.Common.DTO.Identity.LoginHistory;
using BackendCore.Common.DTO.Identity.LoginHistory.Parameters;
using BackendCore.Service.Services.Base;

namespace BackendCore.Service.Services.Identity.LoginHistory
{
    public interface ILoginHistoryService : IBaseService<Entities.Entities.Identity.LoginHistory, AddLoginHistoryDto, LoginHistoryDto , Guid , Guid?>
    {
        Task<DataPaging> GetAllPagedAsync(BaseParam<LoginHistoryFilter> filter);
    }
}