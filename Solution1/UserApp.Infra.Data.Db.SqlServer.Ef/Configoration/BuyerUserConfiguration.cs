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
    public class BuyerUserConfiguration : IEntityTypeConfiguration<BuyerUser>
    {
        public void Configure(EntityTypeBuilder<BuyerUser> builder)
        {
            builder.ToTable("buyer_users", "identity");
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Id).HasColumnName("id");
            builder.Property(b => b.Address).HasColumnName("address").HasMaxLength(255);
            builder.Property(b => b.PreferredPaymentMethod).HasColumnName("preferred_payment_method").HasMaxLength(50);
            builder.Property(b => b.TotalPurchases).HasColumnName("total_purchases").HasColumnType("decimal(18,2)");
            builder.Property(b => b.LoyaltyPoints).HasColumnName("loyalty_points");
            builder.Property(b => b.LastPurchaseDate).HasColumnName("last_purchase_date");
        }
    }
}
