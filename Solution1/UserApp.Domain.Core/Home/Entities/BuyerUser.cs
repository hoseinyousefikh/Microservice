using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp.Domain.Core.Home.Entities
{
    [Table("buyer_users", Schema = "identity")]
    public class BuyerUser : UserBase
    {
        [Column("address")]
        public string? Address { get; set; }

        [Column("preferred_payment_method")]
        public string? PreferredPaymentMethod { get; set; }

        [Column("total_purchases")]
        public decimal TotalPurchases { get; set; } = 0;

        [Column("loyalty_points")]
        public int LoyaltyPoints { get; set; } = 0;
    }
}
