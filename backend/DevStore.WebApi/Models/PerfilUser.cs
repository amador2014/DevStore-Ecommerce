using System;
using System.Collections.Generic;

#nullable disable

namespace DevStore.WebApi.Models
{
    public partial class PerfilUser
    {
        public PerfilUser()
        {
            Users = new HashSet<User>();
        }

        public int IdPerfil { get; set; }
        public string PerfilType { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
