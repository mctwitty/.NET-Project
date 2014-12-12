namespace TheBoardRoom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class smallImageInGame : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "SmallImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "SmallImage");
        }
    }
}
