using BackendCore.Entities.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackendCore.Data.Configuration
{
    public class ModelDetailConfig : IEntityTypeConfiguration<ModelDetail>
    {
        public void Configure(EntityTypeBuilder<ModelDetail> builder)
        {
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();
         
        }
    }
}