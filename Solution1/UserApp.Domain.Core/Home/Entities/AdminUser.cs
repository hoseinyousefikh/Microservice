using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp.Domain.Core.Home.Entities
{
    [Table("admin_users", Schema = "identity")]
    public class AdminUser : UserBase
    {
        [Column("admin_level")]
        public int AdminLevel { get; set; } = 1;

        [Column("can_manage_users")]
        public bool CanManageUsers { get; set; } = true;

        [Column("can_manage_products")]
        public bool CanManageProducts { get; set; } = true;
    }
}
