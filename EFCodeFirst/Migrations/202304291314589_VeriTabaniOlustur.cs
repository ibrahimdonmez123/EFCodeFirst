namespace EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VeriTabaniOlustur : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ogrencis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Isim = c.String(),
                        Yas = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sinifs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Yer = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sinifs");
            DropTable("dbo.Ogrencis");
        }
    }
}
