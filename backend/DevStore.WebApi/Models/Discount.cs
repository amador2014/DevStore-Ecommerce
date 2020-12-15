using System;
using System.Collections.Generic;

#nullable disable

namespace DevStore.WebApi.Models
{
    public partial class Discount
    {
        public int DiscountId { get; set; }
        public decimal NewPrice { get; set; }
        public bool? IsActive { get; set; }
        public DateTime EndDate { get; set; }
        public int? ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
