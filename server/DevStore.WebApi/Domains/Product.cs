using System;
using System.Collections.Generic;

#nullable disable

namespace DevStore.WebApi.Domains
{
    public partial class Product
    {
        public Product()
        {
            CartItems = new HashSet<CartItem>();
            Discounts = new HashSet<Discount>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public bool? IsAvaliable { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public byte[] ProductImage { get; set; }
        public bool IsFeatured { get; set; }
        public decimal PricePerUnity { get; set; }
        public int Stock { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<Discount> Discounts { get; set; }
    }
}
