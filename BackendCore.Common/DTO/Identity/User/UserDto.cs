using System;
using BackendCore.Common.Core;
using BackendCore.Common.DTO.Common.File;

namespace BackendCore.Common.DTO.Identity.User
{
    public class UserDto : IEntityDto<Guid?>
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public Guid? FileId { get; set; }
        public string ImageUrl { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public long RoleId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public FileDto UserImage { get; set; }
    }
}
