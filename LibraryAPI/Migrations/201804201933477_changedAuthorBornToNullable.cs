namespace LibraryAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedAuthorBornToNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Authors", "Born", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Authors", "Born", c => c.DateTime(nullable: false));
        }
    }
}
