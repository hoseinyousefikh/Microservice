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
    public class EmployeeUserConfiguration : IEntityTypeConfiguration<EmployeeUser>
    {
        public void Configure(EntityTypeBuilder<EmployeeUser> builder)
        {
            builder.ToTable("employee_users", "identity");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Department).HasColumnName("department").HasMaxLength(50);
            builder.Property(e => e.Position).HasColumnName("position").HasMaxLength(50);
            builder.Property(e => e.HireDate).HasColumnName("hire_date");
            builder.Property(e => e.Salary).HasColumnName("salary").HasColumnType("decimal(18,2)");
        }
    }
}
