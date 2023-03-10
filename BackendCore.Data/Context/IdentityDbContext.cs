using BackendCore.Entities.Entities.Identity;
using Microsoft.EntityFrameworkCore;

namespace BackendCore.Data.Context
{
    public partial class BackendCoreDbContext
    {
        #region Identity Entities
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<RolePermission> RolePermissions { get; set; }
        public virtual DbSet<UserRole> UserRoles{ get; set; }
        
        public virtual DbSet<LoginHistory> LoginHistories { get; set; }
        #endregion

    }
}
