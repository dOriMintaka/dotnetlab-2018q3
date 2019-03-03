using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configuration
{
    using System.Data.Entity.ModelConfiguration;

    using DAL.Entities;

    public class OrderConfig:EntityTypeConfiguration<Order>
    {
        public OrderConfig()
        {
            this.ToTable("tbl_orders");
            this.HasKey(e => e.Id);
            this.Property(e => e.Id).HasColumnName("cln_order_id");
            this.Property(e => e.Date).HasColumnName("cln_order_date");
            this.HasMany(e => e.OrderItems).WithRequired().HasForeignKey(e => e.OrderId);
        }
    }
}
