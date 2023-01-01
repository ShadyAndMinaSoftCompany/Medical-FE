using BackendCore.Entities.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackendCore.Data.Configuration
{
    public class DeviceBrandConfig : IEntityTypeConfiguration<DeviceBrand>
    {
        public void Configure(EntityTypeBuilder<DeviceBrand> builder)
        {
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();
         
        }
    }
}