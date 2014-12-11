using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheBoardRoom.Models
{
    public class CustomerReview
    {
        [Key]
        public int ReviewID { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int? Rating { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool isApproved { get; set; }
    }
}