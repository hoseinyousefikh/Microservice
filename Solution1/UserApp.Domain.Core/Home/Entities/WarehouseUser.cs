using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp.Domain.Core.Home.Entities
{
    [Table("warehouse_users", Schema = "identity")]
    public class WarehouseUser
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("warehouse_id")]
        public int WarehouseId { get; set; }

        [Column("can_manage_inventory")]
        public bool CanManageInventory { get; set; } = true;

        [Column("can_process_orders")]
        public bool CanProcessOrders { get; set; } = true;

        [Column("can_manage_shipments")]
        public bool CanManageShipments { get; set; } = true;

        [ForeignKey("Id")]
        public required virtual ApplicationUser User { get; set; }
    }
}
