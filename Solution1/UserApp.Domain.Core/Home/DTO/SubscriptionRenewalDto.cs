using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.Domain.Core.Home.Enum;

namespace UserApp.Domain.Core.Home.DTO
{
    public class SubscriptionRenewalDto
    {
        [Required(ErrorMessage = "Subscription plan is required")]
        public SubscriptionPlan Plan { get; set; }

        [Required(ErrorMessage = "Months is required")]
        [Range(1, 12, ErrorMessage = "Months must be between 1 and 12")]
        public int Months { get; set; }
    }
}
