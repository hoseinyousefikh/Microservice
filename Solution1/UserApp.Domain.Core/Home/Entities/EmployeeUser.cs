using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp.Domain.Core.Home.Entities
{
    [Table("employee_users", Schema = "identity")]
    public class EmployeeUser : UserBase
    {
        [Column("department")]
        public string Department { get; set; } = string.Empty;

        [Column("position")]
        public string Position { get; set; } = string.Empty;

        [Column("hire_date")]
        public DateTime HireDate { get; set; } = DateTime.UtcNow;
    }
}
