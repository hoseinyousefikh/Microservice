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
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Confirm password is required")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Phone(ErrorMessage = "Invalid phone number format")]
        public string? PhoneNumber { get; set; }

        [Url(ErrorMessage = "Invalid image URL format")]
        public string? ProfileImageUrl { get; set; }

        // Seller-specific
        [RequiredIf(nameof(UserType), UserType.Seller, ErrorMessage = "Subscription plan is required for sellers")]
        public SubscriptionPlan? SubscriptionPlan { get; set; }

        // Employee-specific
        [RequiredIf(nameof(UserType), UserType.Employee, ErrorMessage = "Department is required for employees")]
        public string? Department { get; set; }

        [RequiredIf(nameof(UserType), UserType.Employee, ErrorMessage = "Position is required for employees")]
        public string? Position { get; set; }

        // Buyer-specific
        [RequiredIf(nameof(UserType), UserType.Buyer, ErrorMessage = "Address is required for buyers")]
        public string? Address { get; set; }

        // Warehouse-specific
        [RequiredIf(nameof(UserType), UserType.WarehouseManager, ErrorMessage = "Warehouse ID is required for warehouse managers")]
        public int? WarehouseId { get; set; }

        // Accountant-specific
        [RequiredIf(nameof(UserType), UserType.Accountant, ErrorMessage = "Audit permission is required for accountants")]
        public bool? CanAuditRecords { get; set; }
    }
}
