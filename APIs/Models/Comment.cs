using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIs.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        // Foreign Key to link with the parent table **
        public int? StockId {get; set;}

        // Navigation Property that help navigate in to the Parent Model **
        public Stock? Stock {get; set;}
    }
}