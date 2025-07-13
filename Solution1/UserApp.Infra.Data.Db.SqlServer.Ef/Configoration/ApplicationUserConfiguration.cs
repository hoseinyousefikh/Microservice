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
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.ToTable("users", "identity");

            builder.Property(u => u.Id).HasColumnName("id");
            builder.Property(u => u.FullName).HasColumnName("full_name").HasMaxLength(100);
            builder.Property(u => u.Email).HasColumnName("email").HasMaxLength(100);
            builder.Property(u => u.UserName).HasColumnName("username").HasMaxLength(50);
            builder.Property(u => u.CreatedAt).HasColumnName("created_at");
            builder.Property(u => u.LastLoginAt).HasColumnName("last_login_at");
            builder.Property(u => u.Status).HasColumnName("status");
            builder.Property(u => u.ActivityStatus).HasColumnName("activity_status");
            builder.Property(u => u.RefreshToken).HasColumnName("refresh_token");
            builder.Property(u => u.RefreshTokenExpiry).HasColumnName("refresh_token_expiry");
            builder.Property(u => u.UserType).HasColumnName("user_type");
            builder.Property(u => u.ProfileImageUrl).HasColumnName("profile_image_url");
            builder.Property(u => u.ImageUploadDate).HasColumnName("image_upload_date");

            builder.HasIndex(u => u.Email).IsUnique();

            // Relationships
            builder.HasOne(u => u.AdminUser)
                .WithOne(a => a.User)
                .HasForeignKey<AdminUser>(a => a.Id);

            builder.HasOne(u => u.EmployeeUser)
                .WithOne(e => e.User)
                .HasForeignKey<EmployeeUser>(e => e.Id);

            builder.HasOne(u => u.SellerUser)
                .WithOne(s => s.User)
                .HasForeignKey<SellerUser>(s => s.Id);

            builder.HasOne(u => u.BuyerUser)
                .WithOne(b => b.User)
                .HasForeignKey<BuyerUser>(b => b.Id);

            builder.HasOne(u => u.WarehouseUser)
                .WithOne(w => w.User)
                .HasForeignKey<WarehouseUser>(w => w.Id);

            builder.HasOne(u => u.AccountantUser)
                .WithOne(a => a.User)
                .HasForeignKey<AccountantUser>(a => a.Id);
        }
    }
}
