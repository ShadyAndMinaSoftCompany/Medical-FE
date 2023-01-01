using System;
using BackendCore.Common.Core;

namespace BackendCore.Common.DTO.Identity.User
{
    public class EditUserDto : IEntityDto<Guid?>
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string FileId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public long RoleId { get; set; }
    }
}
