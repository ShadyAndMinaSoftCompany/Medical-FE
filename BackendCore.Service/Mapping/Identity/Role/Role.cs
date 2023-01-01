using BackendCore.Common.DTO.Identity.Role;
using BackendCore.Entities.Entities.Identity;


// ReSharper disable once CheckNamespace
namespace BackendCore.Service.Mapping
{
    public partial class MappingService
    {
        public void MapRole()
        {
            CreateMap<Role, RoleDto>()
                .ReverseMap();

            CreateMap<Role, AddRoleDto>()
                .ReverseMap();
        }
    }
}