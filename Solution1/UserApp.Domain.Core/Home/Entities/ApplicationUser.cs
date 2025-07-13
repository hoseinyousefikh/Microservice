using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.Domain.Core.Home.Enum;

namespace UserApp.Domain.Core.Home.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        [Column("full_name")]
        public string FullName { get; set; } = string.Empty;

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("last_login_at")]
        public DateTime? LastLoginAt { get; set; }

        [Column("status")]
        public UserStatus Status { get; set; } = UserStatus.Active;

        [Column("activity_status")]
        public ActivityStatus ActivityStatus { get; set; } = ActivityStatus.Offline;

        [Column("refresh_token")]
        public string? RefreshToken { get; set; }

        [Column("refresh_token_expiry")]
        public DateTime? RefreshTokenExpiry { get; set; }

        [Column("user_type")]
        public UserType UserType { get; set; }

        [Column("profile_image_url")]
        public string? ProfileImageUrl { get; set; }

        [Column("image_upload_date")]
        public DateTime? ImageUploadDate { get; set; }

        // Navigation properties (nullable)
        public virtual AdminUser? AdminUser { get; set; }
        public virtual EmployeeUser? EmployeeUser { get; set; }
        public virtual SellerUser? SellerUser { get; set; }
        public virtual BuyerUser? BuyerUser { get; set; }
        public virtual WarehouseUser? WarehouseUser { get; set; }
        public virtual AccountantUser? AccountantUser { get; set; }
    }
}
