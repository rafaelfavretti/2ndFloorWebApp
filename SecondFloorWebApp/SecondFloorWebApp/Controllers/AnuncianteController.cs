using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecondFloorWebApp.DataAccess;
using SecondFloorWebApp.Models;
using SecondFloorWebApp.Repository;
using SecondFloorWebApp.Services;

namespace SecondFloorWebApp.Controllers
{
    public class AnuncianteController : Controller
    {

        private AnuncianteService _anuncianteService;

       
        [HttpGet]
        public ActionResult CadastroAnunciante()
        {
            return View();
        }

        // GET: Anunciante
        [HttpPost]
        public ActionResult CadastroAnunciante(Anunciante anunciante, Collection<Endereco> enderecos)
        {
           _anuncianteService = new AnuncianteService(new AnuncianteRepository(new SecondFloorContext()),new EnderecoRepository(new SecondFloorContext()),new LoginRepository(new SecondFloorContext())  );
          _anuncianteService.CadastrarAnunciante(anunciante, enderecos);

            return View();
        }

    }
}