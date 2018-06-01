namespace DeGaverbeekProject.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bestellingen",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GebruikersID = c.String(maxLength: 128),
                        TotaalBedrag = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Gebruikers", t => t.GebruikersID)
                .Index(t => t.GebruikersID);
            
            CreateTable(
                "dbo.Bestellijns",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BestellingID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Aantal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Bestellingen", t => t.BestellingID, cascadeDelete: true)
                .Index(t => t.BestellingID);
            
            CreateTable(
                "dbo.Gebruikers",
                c => new
                    {
                        GebruikersID = c.String(nullable: false, maxLength: 128),
                        KlantCode = c.Int(nullable: false),
                        BedrijfsNaam = c.String(nullable: false),
                        VoornaamContact = c.String(nullable: false),
                        AchternaamContact = c.String(nullable: false),
                        Straat = c.String(nullable: false),
                        Nummer = c.String(nullable: false),
                        Postcode = c.String(nullable: false),
                        Stad = c.String(nullable: false),
                        Land = c.String(nullable: false),
                        Ondernemingsnummer = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Telefoon = c.String(),
                        GSM = c.String(),
                        Fax = c.String(),
                    })
                .PrimaryKey(t => t.GebruikersID);
            
            CreateTable(
                "dbo.Winkelmandlijnen",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        Aantal = c.Int(nullable: false),
                        GebruikerID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Gebruikers", t => t.GebruikerID)
                .Index(t => t.GebruikerID);
            
            CreateTable(
                "dbo.Categorieën",
                c => new
                    {
                        cat_id = c.Long(nullable: false, identity: true),
                        cat_code = c.String(),
                        cat_naam = c.String(),
                        cat_seq = c.Short(),
                        cat_type_mag = c.Long(),
                        created_on = c.DateTime(),
                        created_by = c.String(),
                        modified_on = c.DateTime(),
                        modified_by = c.String(),
                        IndelingID = c.Int(),
                    })
                .PrimaryKey(t => t.cat_id)
                .ForeignKey("dbo.Indelingen", t => t.IndelingID)
                .Index(t => t.IndelingID);
            
            CreateTable(
                "dbo.Indelingen",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndelingNaam = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categorieën", "IndelingID", "dbo.Indelingen");
            DropForeignKey("dbo.Bestellingen", "GebruikersID", "dbo.Gebruikers");
            DropForeignKey("dbo.Winkelmandlijnen", "GebruikerID", "dbo.Gebruikers");
            DropForeignKey("dbo.Bestellijns", "BestellingID", "dbo.Bestellingen");
            DropIndex("dbo.Categorieën", new[] { "IndelingID" });
            DropIndex("dbo.Winkelmandlijnen", new[] { "GebruikerID" });
            DropIndex("dbo.Bestellijns", new[] { "BestellingID" });
            DropIndex("dbo.Bestellingen", new[] { "GebruikersID" });
            DropTable("dbo.Indelingen");
            DropTable("dbo.Categorieën");
            DropTable("dbo.Winkelmandlijnen");
            DropTable("dbo.Gebruikers");
            DropTable("dbo.Bestellijns");
            DropTable("dbo.Bestellingen");
        }
    }
}
