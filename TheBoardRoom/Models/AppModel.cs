namespace TheBoardRoom.Models
{
    using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

    public class AppModel : DbContext
    {
        // Your context has been configured to use a 'AppModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TheBoardRoom.Models.AppModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'AppModel' 
        // connection string in the application configuration file.
        public AppModel()
            : base("name=AppModel")
        {
        }

        private void Seed()
        {
#if DEBUG
            Database.ExecuteSqlCommand("DELETE FROM Articles");

            var games = new List<Game>()
            {
                {new Game()
                {
                    Name = "Carcassonne",
                    Description = "Tile-laying goodness.",
                    ReleaseYear = 2004,
                    MinPlayers = 2,
                    MaxPlayers = 5,
                    InLibrary = 1,
                    InStock = 5,
                    Price = 34.99m,
                    PriceModifier = 1
                }},
                {new Game()
                {
                    Name = "Machi Koro",
                    Description = "Dice-rolling Engine Builder.",
                    ReleaseYear = 2014,
                    MinPlayers = 2,
                    MaxPlayers = 4,
                    InLibrary = 2,
                    InStock = 1,
                    Price = 29.99m,
                    PriceModifier = 1
                }},
                {new Game()
                {
                    Name = "Pandemic",
                    Description = "Can you cure four deadly diseases before they wipe out mankind?",
                    ReleaseYear = 2008,
                    MinPlayers = 2,
                    MaxPlayers = 4,
                    InLibrary = 2,
                    InStock = 0,
                    Price = 39.99m,
                    PriceModifier = 1
                }},
                {new Game()
                {
                    Name = "One Night Ultimate Werewolf",
                    Description = "Bluff, lie, and hang your friends in this hidden role game.",
                    ReleaseYear = 2013,
                    MinPlayers = 3,
                    MaxPlayers = 10,
                    InLibrary = 3,
                    InStock = 2,
                    Price = 24.99m,
                    PriceModifier = 1
                }},
                {new Game()
                {
                    Name = "Escape: The Curse of the Temple",
                    Description = "Lost in the crumbling ruins of an ancient temple, can you escape in this frantic dice-chucking thriller?",
                    ReleaseYear = 2013,
                    MinPlayers = 1,
                    MaxPlayers = 5,
                    InLibrary = 1,
                    InStock = 1,
                    Price = 49.99m,
                    PriceModifier = 1
                }}
            };
            foreach(Game game in games)
            {
                game.CustomerReviews = new List<CustomerReview>();
                game.CustomerReviews.Add(new CustomerReview()
                    {
                        ReviewID = game.GameID,
                        Author = "Anonymous",
                        Title = "A Sample Review",
                        Body = "It's a pretty fun game",
                        TimeStamp = DateTime.Now,
                        Rating = 5,
                        isApproved = true
                    });
            }
            Games.AddRange(games);
            SaveChanges();
#else

#endif
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<CustomerReview> CustomerReviews { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}