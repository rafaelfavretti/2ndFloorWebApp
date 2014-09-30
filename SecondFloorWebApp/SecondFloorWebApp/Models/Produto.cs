using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecondFloorWebApp.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string RefProduto { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public string Fabricante { get; set; }
        public float ValorProduto { get; set; }
        public Anunciante Anunciante { get; set; }

        public Produto()
        {

        }
    }
}