using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecondFloorWebApp.Models
{
    public class Endereco
    {
        public int IdEndereco { get; set; }
        public string TipoEndereco { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Anunciante Vendedor { get; set; }

        public Endereco()
        {

        }
    }
}