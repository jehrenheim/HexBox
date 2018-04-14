using System;
using System.Collections.Generic;

namespace StoreFront.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public List<Image> Images { get; set; }
        public List<Color> Colors { get; set; }

        public Product()
        {
        }

    }
}
