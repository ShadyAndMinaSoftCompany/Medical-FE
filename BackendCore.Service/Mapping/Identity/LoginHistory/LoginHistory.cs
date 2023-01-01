using BackendCore.Common.DTO.Identity.LoginHistory;
using BackendCore.Entities.Entities.Identity;


// ReSharper disable once CheckNamespace
namespace BackendCore.Service.Mapping
{
    public partial class MappingService
    {
        public void MapLoginHistory()
        {
            CreateMap<LoginHistory, LoginHistoryDto>()
                .ReverseMap();

            CreateMap<LoginHistory, AddLoginHistoryDto>()
                .ReverseMap();
        }
    }
}