using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop.Models
{
    public class Slider
    {
        public int ID { get; set; }
        public string img { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string pageSrc { get; set; }
        public bool active { get; set; }
       
    }
}