using System;
using System.Collections.Generic;

#nullable disable

namespace DevStore.WebApi.Domains
{
    public partial class User
    {
        public User()
        {
            Adresses = new HashSet<Adress>();
            CartItems = new HashSet<CartItem>();
            Orders = new HashSet<Order>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public byte[] ProfileImage { get; set; }
        public int? IdPerfil { get; set; }

        public virtual PerfilUser IdPerfilNavigation { get; set; }
        public virtual ICollection<Adress> Adresses { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
