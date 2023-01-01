using BackendCore.Common.Core;
using BackendCore.Common.DTO.Base;
using BackendCore.Common.DTO.Business.ModelDetail.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Service.Services.Business.ModelDetail
{
    public interface IModelDetailService
    {
        Task<IFinalResult> GetAllAsync(BaseParam<SearchFilter> filter);
    }
}
