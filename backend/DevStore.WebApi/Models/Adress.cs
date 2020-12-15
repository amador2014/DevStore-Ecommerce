using System;
using System.Collections.Generic;

#nullable disable

namespace DevStore.WebApi.Models
{
    public partial class Adress
    {
        public int AdressId { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Ddd { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
