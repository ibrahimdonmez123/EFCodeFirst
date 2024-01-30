namespace EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VeriTabanıGüncelle : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Ogrencis", newName: "Ogrenciler");
            RenameTable(name: "dbo.Sinifs", newName: "Siniflar");
            AddColumn("dbo.Ogrenciler", "Cinsiyet", c => c.String());
            AlterColumn("dbo.Ogrenciler", "Isim", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Siniflar", "Yer", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Siniflar", "Yer", c => c.String());
            AlterColumn("dbo.Ogrenciler", "Isim", c => c.String());
            DropColumn("dbo.Ogrenciler", "Cinsiyet");
            RenameTable(name: "dbo.Siniflar", newName: "Sinifs");
            RenameTable(name: "dbo.Ogrenciler", newName: "Ogrencis");
        }
    }
}
