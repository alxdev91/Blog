namespace Blog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrimerMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdPost = c.Int(nullable: false),
                        TextComment = c.String(),
                        NameVisitor = c.String(),
                        PostB_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PostBs", t => t.PostB_Id)
                .Index(t => t.PostB_Id);
            
            CreateTable(
                "dbo.PostBs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        IdCategory = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "PostB_Id", "dbo.PostBs");
            DropIndex("dbo.Comments", new[] { "PostB_Id" });
            DropTable("dbo.PostBs");
            DropTable("dbo.Comments");
            DropTable("dbo.Categories");
        }
    }
}
