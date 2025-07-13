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
    public class SellerUserConfiguration : IEntityTypeConfiguration<SellerUser>
    {
        public void Configure(EntityTypeBuilder<SellerUser> builder)
        {
            builder.ToTable("seller_users", "identity");
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id).HasColumnName("id");
            builder.Property(s => s.SubscriptionPlan).HasColumnName("subscription_plan");
            builder.Property(s => s.SubscriptionExpiry).HasColumnName("subscription_expiry");
            builder.Property(s => s.MaxLoginHours).HasColumnName("max_login_hours");
            builder.Property(s => s.CurrentSessionStart).HasColumnName("current_session_start");
            builder.Property(s => s.TotalSales).HasColumnName("total_sales").HasColumnType("decimal(18,2)");
            builder.Property(s => s.CommissionRate).HasColumnName("commission_rate").HasColumnType("decimal(5,4)");
            builder.Property(s => s.PaymentDueDate).HasColumnName("payment_due_date");
            builder.Property(s => s.IsSubscriptionActive).HasColumnName("is_subscription_active");
        }
    }
}
