using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configuration
{
    using DAL.Entities;
    using System.Data.Entity.ModelConfiguration;

    public class CustomerConfig: EntityTypeConfiguration<Customer>
    {
        public CustomerConfig()
        {
            this.ToTable("tbl_customers");
            this.HasKey(e => e.Id);
            this.Property(e => e.Id).HasColumnName("cln_customer_id");
            this.Property(e => e.Name).HasColumnName("cln_customer_name");
            this.Property(e => e.Address).HasColumnName("cln_customer_address");
            this.Property(e => e.City).HasColumnName("cln_customer_city");
            this.Property(e => e.State).HasColumnName("cln_customer_state");
            this.HasMany(e => e.Orders).WithOptional().HasForeignKey(e => e.CustomerId);
        }
    }
}
