using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StdCoreApp.Data.EF.Extensitions;
using StdCoreApp.Data.Entities;

namespace StdCoreApp.Data.EF.Configurations
{
    public class AdvertistmentPositionConfiguration : DbEntityConfiguration<AdvertistmentPosition>
    {
        public override void Configure(EntityTypeBuilder<AdvertistmentPosition> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(20).IsRequired();
        }
    }
}