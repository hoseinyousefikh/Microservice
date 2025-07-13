using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.Domain.Core.Home.Enum;

namespace UserApp.Domain.Core.Home.DTO
{
    public class UserProfileDto
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
        public UserType UserType { get; set; }
        public UserStatus Status { get; set; }
        public ActivityStatus ActivityStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public string? ProfileImageUrl { get; set; }
        public DateTime? ImageUploadDate { get; set; }

        // Admin-specific
        public int? AdminLevel { get; set; }
        public bool? CanManageUsers { get; set; }

        // Seller-specific
        public SubscriptionPlan? SubscriptionPlan { get; set; }
        public DateTime? SubscriptionExpiry { get; set; }
        public int? MaxLoginHours { get; set; }
        public TimeSpan? CurrentSessionDuration { get; set; }
        public decimal? TotalSales { get; set; }
        public DateTime? PaymentDueDate { get; set; }
        public bool? IsSubscriptionActive { get; set; }

        // Employee-specific
        public string? Department { get; set; }
        public string? Position { get; set; }
        public DateTime? HireDate { get; set; }
        public decimal? Salary { get; set; }

        // Buyer-specific
        public string? Address { get; set; }
        public decimal? TotalPurchases { get; set; }
        public int? LoyaltyPoints { get; set; }
        public DateTime? LastPurchaseDate { get; set; }

        // Warehouse-specific
        public int? WarehouseId { get; set; }
        public bool? CanManageInventory { get; set; }
        public bool? CanProcessOrders { get; set; }

        // Accountant-specific
        public bool? CanViewFinancialReports { get; set; }
        public bool? CanGenerateInvoices { get; set; }
        public bool? CanAuditRecords { get; set; }
    }
}
