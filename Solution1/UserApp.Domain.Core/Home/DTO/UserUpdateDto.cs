using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.Domain.Core.Home.Enum;

namespace UserApp.Domain.Core.Home.DTO
{
    public class UserUpdateDto
    {
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Full name must be 2-100 characters")]
        public string? FullName { get; set; }

        [Phone(ErrorMessage = "Invalid phone number format")]
        public string? PhoneNumber { get; set; }

        public UserStatus? Status { get; set; }

        // Seller-specific
        public SubscriptionPlan? SubscriptionPlan { get; set; }
        public int? MaxLoginHours { get; set; }

        // Employee-specific
        public string? Department { get; set; }
        public string? Position { get; set; }

        // Buyer-specific
        public string? Address { get; set; }

        // Warehouse-specific
        public int? WarehouseId { get; set; }
    }
}
