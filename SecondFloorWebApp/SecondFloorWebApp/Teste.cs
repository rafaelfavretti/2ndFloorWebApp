using SecondFloorWebApp.DataAccess;
using SecondFloorWebApp.IRepository;
using SecondFloorWebApp.Models;
using SecondFloorWebApp.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace SecondFloorWebApp
{
    class Teste
    {
       static void Main(string[] args){
          
           var anunciante = new Anunciante();
           var endereco = new Endereco();
           var endereco2 = new Endereco();
           var produto = new Produto();
           var context = new SecondFloorContext();
           IAnuncianteRepository repo = new AnuncianteRepository(context);
           IEnderecoRepository erepo = new EnderecoRepository(context);
           IProdutoRepository prepo = new ProdutoRepository(context);

           
           anunciante.Nome = "Rafael";
           anunciante.Sobrenome = "Silva";
           anunciante.Email = "rafael@teste.cm";
           anunciante.TipoUsuario = "Anunciante";
           anunciante.Cnpj = "111111111111111";
           anunciante.RazaoSocial ="Lalala";

           endereco.TipoEndereco = "Rua";
           endereco.Logradouro = "Pedro Gomes Cardim";
           endereco.Numero = 128;
           endereco.Estado = "SP";
           endereco.Cidade = "São Paulo";
           endereco.Bairro = "Jardim Guedala";
           endereco.Vendedor = anunciante;

           endereco2.TipoEndereco = "Rua";
           endereco2.Logradouro = "Pedro Gomes Cardim";
           endereco2.Numero = 157;
           endereco2.Complemento = "Apto. 112";
           endereco2.Estado = "SP";
           endereco2.Cidade = "São Paulo";
           endereco2.Bairro = "Jardim Guedala";
           endereco2.Vendedor = anunciante;

           produto.RefProduto = "CA001";
           produto.NomeProduto = "Camiseta Polo";
           produto.Fabricante = "Nike";
           produto.ValorProduto = 30f;
           produto.Anunciante = anunciante;

           prepo.insert(produto);
           erepo.insert(endereco);
           erepo.insert(endereco2);
           repo.insert(anunciante);
           
           
       }
    }
}