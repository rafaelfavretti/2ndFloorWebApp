using SecondFloorWebApp.DataAccess;
using SecondFloorWebApp.IRepository;
using SecondFloorWebApp.Models;
using SecondFloorWebApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecondFloorWebApp
{
    class Teste
    {
       static void Main(string[] args){
          
           Anunciante anunciante = new Anunciante();
           SecondFloorContext context = new SecondFloorContext();
           IAnuncianteRepository repo = new AnuncianteRepository(context);

           anunciante.IdUsuario = 1;
           anunciante.Nome = "Rafael";
           anunciante.Sobrenome = "Silva";
           anunciante.Email = "rafael@teste.cm";
           anunciante.TipoUsuario = "Anunciante";
           anunciante.Cnpj = "111111111111111";
           anunciante.RazaoSocial ="Lalala";

           repo.insert(anunciante);
           
       }
    }
}