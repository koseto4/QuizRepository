namespace QuizzApp.Data1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _534 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Choices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ChoiceText = c.String(),
                        QuestionId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.QuestionId)
                .Index(t => t.QuestionId);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        Answer = c.String(),
                        ModeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Modes", t => t.ModeId, cascadeDelete: true)
                .Index(t => t.ModeId);
            
            CreateTable(
                "dbo.Modes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "ModeId", "dbo.Modes");
            DropForeignKey("dbo.Choices", "QuestionId", "dbo.Questions");
            DropIndex("dbo.Questions", new[] { "ModeId" });
            DropIndex("dbo.Choices", new[] { "QuestionId" });
            DropTable("dbo.Modes");
            DropTable("dbo.Questions");
            DropTable("dbo.Choices");
        }
    }
}
