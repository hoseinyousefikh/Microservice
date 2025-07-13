using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp.Domain.Core.Home.Entities
{
    [Table("accountant_users", Schema = "identity")]
    public class AccountantUser : UserBase
    {
        [Column("can_view_financial_reports")]
        public bool CanViewFinancialReports { get; set; } = true;

        [Column("can_manage_payments")]
        public bool CanManagePayments { get; set; } = true;

        [Column("can_generate_invoices")]
        public bool CanGenerateInvoices { get; set; } = true;
    }
}
