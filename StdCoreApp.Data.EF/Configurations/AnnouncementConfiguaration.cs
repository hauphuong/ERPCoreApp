using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StdCoreApp.Data.EF.Extensitions;
using StdCoreApp.Data.Entities;

namespace StdCoreApp.Data.EF.Configurations
{
    public class AnnouncementConfiguaration : DbEntityConfiguration<Announcement>
    {
        public override void Configure(EntityTypeBuilder<Announcement> entity)
        {
            entity.Property(c =>c.Id).HasMaxLength(128).IsRequired();
        }
    }
}