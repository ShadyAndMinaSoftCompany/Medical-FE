using BackendCore.Common.Services;
using BackendCore.Data.Configuration;
using BackendCore.Data.DataInitializer;
using BackendCore.Entities.Entities.Business;
using BackendCore.Entities.Entities.Common;
using BackendCore.Entities.Entities.Identity;
using Microsoft.EntityFrameworkCore;


namespace BackendCore.Data.Context
{
    public partial  class BackendCoreDbContext : DbContext
    {
        private readonly IDataInitializer _dataInitializer;
        private readonly IClaimService _claimService;
        public BackendCoreDbContext(DbContextOptions<BackendCoreDbContext> options, IDataInitializer dataInitializer, IClaimService claimService) : base(options)
        {
            _dataInitializer = dataInitializer;
            _claimService = claimService;
        }

        #region Business
      
     
      
        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual  DbSet<Brand> Brands { get; set; }

        public virtual DbSet<DeviceBrand> DeviceBrands { get; set; }
        public virtual DbSet<ModelDetail> ModelDetails { get; set; }

        #endregion

        #region Common Entities

        public virtual DbSet<File> Files { get; set; }
        
        #endregion

        #region Overriden Methods
        /// <summary>
        /// On Model Creating
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Configuration
         

            modelBuilder.ApplyConfiguration(new PermissionConfig());
            modelBuilder.ApplyConfiguration(new RoleConfig());
            modelBuilder.ApplyConfiguration(new RolePermissionConfig());
            modelBuilder.ApplyConfiguration(new UserRoleConfig());

            modelBuilder.ApplyConfiguration(new DepartmentConfig());
            modelBuilder.ApplyConfiguration(new DeviceConfig());
            modelBuilder.ApplyConfiguration(new BrandConfig());
            modelBuilder.ApplyConfiguration(new DeviceBrandConfig());
            modelBuilder.ApplyConfiguration(new ModelDetailConfig());

            

            #endregion

            #region Seed

            //modelBuilder.Entity<Role>().HasData(_dataInitializer.SeedRoles());
            modelBuilder.Entity<User>().HasData(_dataInitializer.SeedUsers());
            //modelBuilder.Entity<Permission>().HasData(_dataInitializer.SeedPermissions());
           
            #endregion
            base.OnModelCreating(modelBuilder);
        }
        

        #endregion

        #region Private Methods
        #endregion

    }
}
