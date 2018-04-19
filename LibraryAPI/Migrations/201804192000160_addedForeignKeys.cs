namespace LibraryAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedForeignKeys : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "AuthorID", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "GenreID", c => c.Int(nullable: false));
            AddColumn("dbo.CheckoutLedgers", "BookID", c => c.Int(nullable: false));
            CreateIndex("dbo.Books", "AuthorID");
            CreateIndex("dbo.Books", "GenreID");
            CreateIndex("dbo.CheckoutLedgers", "BookID");
            AddForeignKey("dbo.Books", "AuthorID", "dbo.Authors", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Books", "GenreID", "dbo.Genres", "ID", cascadeDelete: true);
            AddForeignKey("dbo.CheckoutLedgers", "BookID", "dbo.Books", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CheckoutLedgers", "BookID", "dbo.Books");
            DropForeignKey("dbo.Books", "GenreID", "dbo.Genres");
            DropForeignKey("dbo.Books", "AuthorID", "dbo.Authors");
            DropIndex("dbo.CheckoutLedgers", new[] { "BookID" });
            DropIndex("dbo.Books", new[] { "GenreID" });
            DropIndex("dbo.Books", new[] { "AuthorID" });
            DropColumn("dbo.CheckoutLedgers", "BookID");
            DropColumn("dbo.Books", "GenreID");
            DropColumn("dbo.Books", "AuthorID");
        }
    }
}
