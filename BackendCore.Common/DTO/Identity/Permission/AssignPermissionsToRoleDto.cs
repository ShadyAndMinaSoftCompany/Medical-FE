using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Common.DTO.Identity.Permission
{
    public class AssignPermissionsToRoleDto
    {
        public Guid RoleId { get; set; }
        public List<Guid> PermissionsIds { get; set; }
    }
}
