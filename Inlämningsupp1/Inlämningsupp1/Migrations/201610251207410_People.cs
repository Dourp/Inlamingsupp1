namespace Inlämningsupp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class People : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PeopleId = c.Int(nullable: false, identity: true),
                        Namn = c.String(),
                        Gatuadress = c.String(),
                        Postnummer = c.String(),
                        Postort = c.String(),
                        Telefon = c.String(),
                        Epost = c.String(),
                        Födelsedag = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PeopleId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
