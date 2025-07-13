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
    public class AccountantUserConfiguration : IEntityTypeConfiguration<AccountantUser>
    {
        public void Configure(EntityTypeBuilder<AccountantUser> builder)
        {
            builder.ToTable("accountant_users", "identity");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id).HasColumnName("id");
            builder.Property(a => a.CanViewFinancialReports).HasColumnName("can_view_financial_reports");
            builder.Property(a => a.CanManagePayments).HasColumnName("can_manage_payments");
            builder.Property(a => a.CanGenerateInvoices).HasColumnName("can_generate_invoices");
            builder.Property(a => a.CanAuditRecords).HasColumnName("can_audit_records");
        }
    }
}
