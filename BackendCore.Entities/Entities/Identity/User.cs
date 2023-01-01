using System;
using System.Collections.Generic;
using BackendCore.Entities.Entities.Base;

namespace BackendCore.Entities.Entities.Identity
{
    public class User : BaseEntity<Guid>
    {
 
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public Guid? FileId { get; set; }
        public Guid? ShopId { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
