// Configoration/ApplicationRoleConfiguration.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserApp.Domain.Core.Home.DTO;
using UserApp.Domain.Core.Home.Entities;

namespace UserApp.Infra.Data.Db.SqlServer.Ef.Configoration
{
    public class ApplicationRoleConfiguration : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder.ToTable("roles", "identity");

            builder.Property(r => r.Id).HasColumnName("id");
            builder.Property(r => r.Name).HasColumnName("name").HasMaxLength(50);
            builder.Property(r => r.NormalizedName).HasColumnName("normalized_name").HasMaxLength(50);
            builder.Property(r => r.Description).HasColumnName("description").HasMaxLength(255);

            builder.HasData(
                new ApplicationRole { Id = 1, Name = "Admin", NormalizedName = "ADMIN", Description = "Administrator role" },
                new ApplicationRole { Id = 2, Name = "Employee", NormalizedName = "EMPLOYEE", Description = "Employee role" }
                // ... سایر نقش‌ها
            );
        }
    }
}