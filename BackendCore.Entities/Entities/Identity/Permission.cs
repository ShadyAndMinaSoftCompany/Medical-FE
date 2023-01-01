using System;
using System.Collections.Generic;
using BackendCore.Entities.Entities.Base;

namespace BackendCore.Entities.Entities.Identity
{
    public class Permission : Lookup<Guid>
    {
        public ICollection<RolePermission> RolePermissions { get; set; }
    }
}