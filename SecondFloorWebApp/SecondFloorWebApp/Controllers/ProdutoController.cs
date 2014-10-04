using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecondFloorWebApp.DataAccess;
using SecondFloorWebApp.Models;
using SecondFloorWebApp.Repository;
using SecondFloorWebApp.Services;

namespace SecondFloorWebApp.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutoService _produtoService;
        // GET: Produto
        [HttpGet]
        public ActionResult CadastrarProduto()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastrarProduto(Produto produto)
        {   
            _produtoService = new ProdutoService(new ProdutoRepository(new SecondFloorContext()));
            _produtoService.CadastrarProduto(produto);
            return View();
        }
    }
}