using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecondFloorWebApp.Models
{
    public class Anunciante : Usuario
    {
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public virtual ICollection<Endereco> Enderecos{ get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
        public Login Login { get; set; }

        public Anunciante()
        {
            this.Enderecos = new HashSet<Endereco>();
            this.Produtos = new HashSet<Produto>();
        }
    }
}