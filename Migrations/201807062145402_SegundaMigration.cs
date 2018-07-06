namespace Blog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SegundaMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PostBs", "Category", c => c.String(nullable: false));
            AlterColumn("dbo.PostBs", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.PostBs", "Content", c => c.String(nullable: false));
            DropColumn("dbo.PostBs", "IdCategory");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PostBs", "IdCategory", c => c.Int(nullable: false));
            AlterColumn("dbo.PostBs", "Content", c => c.String());
            AlterColumn("dbo.PostBs", "Title", c => c.String());
            DropColumn("dbo.PostBs", "Category");
        }
    }
}
