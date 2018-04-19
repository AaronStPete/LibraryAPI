namespace LibraryAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeReturnByNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "ReturnBy", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "ReturnBy", c => c.DateTime(nullable: false));
        }
    }
}
