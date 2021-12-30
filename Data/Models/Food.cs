using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Data.Models
{
    public class Food
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string IamgeUrl { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category category { get; set; }

    }
}
