namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.tbl_items",
                    c => new
                             {
                                 cln_item_id = c.Int(nullable: false, identity: true),
                                 cln_item_description = c.String(nullable: false),
                                 cln_item_price = c.Decimal(nullable: false)
                             })
                .PrimaryKey(t => t.cln_item_id);
            this.Sql(@"set identity_insert tbl_items on
                insert into tbl_items (cln_item_id, cln_item_description, cln_item_price) values
                (563, '56'' Blue Freen', 3.5),
                (851, 'Spline End (Xtra Large)', 0.25),
                (652, '3'' Red Freen', 12.00)
                set identity_insert tbl_items off
                ");
        }
       
        public override void Down()
        {
            DropTable("dbo.tbl_items");
        }
    }
}
