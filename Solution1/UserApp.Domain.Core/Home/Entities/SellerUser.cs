﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.Domain.Core.Home.Enum;

namespace UserApp.Domain.Core.Home.Entities
{
    [Table("seller_users", Schema = "identity")]
    public class SellerUser
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("subscription_plan")]
        public SubscriptionPlan SubscriptionPlan { get; set; } = SubscriptionPlan.Basic;

        [Column("subscription_expiry")]
        public DateTime SubscriptionExpiry { get; set; } = DateTime.UtcNow.AddMonths(1);

        [Column("max_login_hours")]
        public int MaxLoginHours { get; set; } = 3;

        [Column("current_session_start")]
        public DateTime? CurrentSessionStart { get; set; }

        [Column("total_sales")]
        public decimal TotalSales { get; set; } = 0;

        [Column("commission_rate")]
        public decimal CommissionRate { get; set; } = 0.1m;

        [Column("payment_due_date")]
        public DateTime PaymentDueDate { get; set; } = DateTime.UtcNow.AddMonths(1);

        [Column("is_subscription_active")]
        public bool IsSubscriptionActive { get; set; } = true;

        [ForeignKey("Id")]
        public required virtual ApplicationUser User { get; set; }
    }
}
