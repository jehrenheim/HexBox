using System;
using System.Collections.Generic;

namespace StoreFront.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public List<Product> Products { get; set; }


        public Category()
        {
        }
    }
}
