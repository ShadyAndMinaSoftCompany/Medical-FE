using System;
using System.Collections.Generic;
using BackendCore.Common.Core;

namespace BackendCore.Common.DTO.Identity.User
{
    public class AddUserDto : IEntityDto<Guid?>
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string FileId { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Guid? ShopId { get; set; }
        public List<Guid> RoleIds { get; set; }
    }
}
