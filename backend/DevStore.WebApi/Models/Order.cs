using System;
using System.Collections.Generic;

#nullable disable

namespace DevStore.WebApi.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsCanceled { get; set; }
        public bool IsReceived { get; set; }
        public decimal AmountPaid { get; set; }
        public string PaymentType { get; set; }
        public string MobileNumber { get; set; }
        public int? UserId { get; set; }
        public int? CartId { get; set; }

        public virtual CartItem Cart { get; set; }
        public virtual User User { get; set; }
    }
}
