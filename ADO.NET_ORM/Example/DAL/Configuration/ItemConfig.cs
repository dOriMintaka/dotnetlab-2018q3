using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configuration
{
    using System.Data.Entity.ModelConfiguration;
    using System.Runtime.CompilerServices;

    using DAL.Entities;

    public class ItemConfig: EntityTypeConfiguration<Item>
    {
        public ItemConfig()
        {
            this.ToTable("tbl_items");
            this.HasKey(e => e.Id);
            this.Property(e => e.Id).HasColumnName("cln_item_id");
            this.Property(e => e.Description).HasColumnName("cln_item_description");
            this.Property(e => e.Price).HasColumnName("cln_item_price");
        }
    }
}
