using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendCore.Entities.Entities.Base;

namespace BackendCore.Entities.Entities.Identity
{
    public class UserRole : BaseEntity<Guid>
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
    }
}