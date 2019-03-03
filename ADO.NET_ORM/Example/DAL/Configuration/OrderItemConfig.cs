using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configuration
{
    using System.Data.Entity.ModelConfiguration;

    using DAL.Entities;

    public class OrderItemConfig: EntityTypeConfiguration<OrderItem>
    {
        public OrderItemConfig()
        {
            this.ToTable("tbl_order_items");
            this.HasKey(e => new { e.OrderId, e.ItemId });
            this.Property(e => e.OrderId).HasColumnName("cln_order_id");
            this.Property(e => e.ItemId).HasColumnName("cln_item_id");
            this.Property(e => e.Quantity).HasColumnName("cln_quantity");
        }
    }
}
