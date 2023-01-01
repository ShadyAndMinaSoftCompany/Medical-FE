using BackendCore.Common.DTO.Identity.Role;
using BackendCore.Common.DTO.Identity.User;
using BackendCore.Entities.Entities;
using BackendCore.Entities.Entities.Identity;

// ReSharper disable once CheckNamespace
namespace BackendCore.Service.Mapping
{
    public partial class MappingService
    {
        public void MapUser()
        {
            CreateMap<User, UserDto>()
                .ReverseMap();

            CreateMap<User, AddUserDto>()
                .ReverseMap();

            CreateMap<UserRole, UserRoleDto>()
                .ReverseMap();

        }
    }
}