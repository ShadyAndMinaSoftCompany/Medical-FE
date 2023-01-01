using System.Collections.Generic;
using BackendCore.Entities.Entities.Identity;

namespace BackendCore.Data.DataInitializer
{
    public interface IDataInitializer
    {
        //IEnumerable<Role> SeedRoles();
        IEnumerable<User> SeedUsers();
        //IEnumerable<Permission> SeedPermissions();
       
    }
}