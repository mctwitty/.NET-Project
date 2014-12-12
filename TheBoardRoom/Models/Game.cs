using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheBoardRoom.Models
{
    public class Game
    {
        [Key]
        public int GameID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int InLibrary { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        public decimal PriceModifier { get; set; }
        public int ReleaseYear { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public virtual ICollection<CustomerReview> CustomerReviews { get; set; }
        public string LargeImage { get; set; }
        public string SmallImage { get; set; }
    }
}