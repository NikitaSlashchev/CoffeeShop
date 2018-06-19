using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop.Models
{
    public class Article
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string content { get; set; }
        public DateTime creationDate { get; set; }
        public bool active { get; set; }
        public string description { get; set; }
        public string img { get; set; }
        public string author { get; set; }
        public int type { get; set; }

        public Article()
        {
            creationDate = DateTime.Now;
        }
    }
}