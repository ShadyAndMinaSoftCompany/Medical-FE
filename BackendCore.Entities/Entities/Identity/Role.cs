using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BackendCore.Entities.Entities.Base;

namespace BackendCore.Entities.Entities.Identity
{
    public class Role : Lookup<Guid>
    {
        public ICollection<RolePermission> RolePermissions { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
