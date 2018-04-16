using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreFront.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
        public string NumberOfPlayers { get; set; }
        public string PlayTime { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [NotMapped]
        public Product RelatedProduct { get; set; }
        public string DefaultImage { get; set; }
        public List<Image> Images { get; set; }

        public Product()
        {
        }

    }
}
