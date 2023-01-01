using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendCore.Common.Core;

namespace BackendCore.Common.DTO.Identity.Role
{
    public class UserRoleDto 
    {
       
        public Guid RoleId { get; set; }
        public virtual RoleDto Role { get; set; }
     
    }
}
