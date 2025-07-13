using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp.Domain.Core.Home.Entities
{
    [Table("employee_users", Schema = "identity")]
    public class EmployeeUser
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("department")]
        public string Department { get; set; } = string.Empty;

        [Column("position")]
        public string Position { get; set; } = string.Empty;

        [Column("hire_date")]
        public DateTime HireDate { get; set; } = DateTime.UtcNow;

        [Column("salary")]
        public decimal Salary { get; set; }

        [ForeignKey("Id")]
        public required virtual ApplicationUser User { get; set; }
    }
}
