using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string img { get; set; }
        public string description { get; set; }
        public string country { get; set; }
        public string sort { get; set; }
        public string brand { get; set; }
        public decimal price { get; set; }
        public int minAmount { get; set; }
        public bool active { get; set; }
        public int type { get; set; }

    }
}