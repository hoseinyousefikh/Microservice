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
    public class WarehouseUserConfiguration : IEntityTypeConfiguration<WarehouseUser>
    {
        public void Configure(EntityTypeBuilder<WarehouseUser> builder)
        {
            builder.ToTable("warehouse_users", "identity");
            builder.HasKey(w => w.Id);

            builder.Property(w => w.Id).HasColumnName("id");
            builder.Property(w => w.WarehouseId).HasColumnName("warehouse_id");
            builder.Property(w => w.CanManageInventory).HasColumnName("can_manage_inventory");
            builder.Property(w => w.CanProcessOrders).HasColumnName("can_process_orders");
            builder.Property(w => w.CanManageShipments).HasColumnName("can_manage_shipments");
        }
    }
}
