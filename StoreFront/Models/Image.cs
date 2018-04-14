using System;

namespace StoreFront.Models
{
    public class Image
    {
        public int ID { get; set; }
        public string Url { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Place { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }
        public Image()
        {
        }
    }
}
