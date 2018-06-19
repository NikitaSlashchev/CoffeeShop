using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop.Models
{
    public class Review
    {
        public int ID { get; set; }
        public string name { get; set; }
        public DateTime creationDate { get; set; }
        public int age { get; set; }
        public string content { get; set; }
        public bool active { get; set; }

        public Review()
        {
            creationDate = DateTime.Now;
        }
    }
}