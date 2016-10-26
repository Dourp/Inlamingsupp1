namespace Inlämningsupp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class People1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Födelsedag", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Födelsedag", c => c.DateTime(nullable: false));
        }
    }
}
