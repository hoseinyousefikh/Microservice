using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.Domain.Core.Home.Enum;

namespace UserApp.Domain.Core.Home.DTO
{
    public class UserRegisterDto
    {
        [Required(ErrorMessage = "User type is required")]
        public UserType UserType { get; set; }

        [Required(ErrorMessage = "Full name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Full name must be 2-100 characters")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be 8-100 characters")]
        public string Password { get; set; } = string.Empty;

        [Phone(ErrorMessage = "Invalid phone number format")]
        public string? PhoneNumber { get; set; }

        // Seller-specific
        public SubscriptionPlan? SubscriptionPlan { get; set; }

        // Employee-specific
        public string? Department { get; set; }
        public string? Position { get; set; }

        // Buyer-specific
        public string? Address { get; set; }

        // Warehouse-specific
        public int? WarehouseId { get; set; }
    }
}
