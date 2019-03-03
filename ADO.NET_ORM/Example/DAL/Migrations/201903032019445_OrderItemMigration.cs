namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderItemMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_order_items", "cln_quantity", c => c.Int(nullable: false));

            this.Sql(@"update tbl_order_items
                set cln_quantity=4
                where cln_order_id=125 and cln_item_id=563");

            this.Sql(@"update tbl_order_items
                set cln_quantity=32
                where cln_order_id=125 and cln_item_id=851");

            this.Sql(@"update tbl_order_items
                set cln_quantity=5
                where cln_order_id=125 and cln_item_id=652");

            this.Sql(@"update tbl_order_items
                set cln_quantity=500
                where cln_order_id=126 and cln_item_id=563");

            this.Sql(@"update tbl_order_items
                set cln_quantity=750
                where cln_order_id=126 and cln_item_id=652");
        }
        
        public override void Down()
        {
            DropColumn("dbo.tbl_order_items", "cln_quantity");
        }
    }
}
