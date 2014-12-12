namespace TheBoardRoom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imagesInModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "Image", c => c.String());
            AddColumn("dbo.Games", "LargeImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "LargeImage");
            DropColumn("dbo.Articles", "Image");
        }
    }
}
