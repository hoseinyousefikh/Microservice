using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.Domain.Core.Home.Entities;

namespace UserApp.Infra.Data.Db.SqlServer.Ef.Configoration
{
    public class AdminUserConfiguration : IEntityTypeConfiguration<AdminUser>
    {
        public void Configure(EntityTypeBuilder<AdminUser> builder)
        {
            builder.ToTable("admin_users", "identity");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id).HasColumnName("id");
            builder.Property(a => a.AdminLevel).HasColumnName("admin_level");
            builder.Property(a => a.CanManageUsers).HasColumnName("can_manage_users");
            builder.Property(a => a.CanManageProducts).HasColumnName("can_manage_products");
        }
    }
}
