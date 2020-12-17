using System;
using System.Collections.Generic;

#nullable disable

namespace DevStore.WebApi.Domains
{
    public partial class CartItem
    {
        public CartItem()
        {
            Orders = new HashSet<Order>();
        }

        public int CartId { get; set; }
        public int ProductQuantity { get; set; }
        public int? ProductId { get; set; }
        public int? UserId { get; set; }

        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
