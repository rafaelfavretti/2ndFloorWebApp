using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SecondFloorWebApp.IRepository;
using SecondFloorWebApp.Models;

namespace SecondFloorWebApp.Services
{
    public class ProdutoService
    {
        private IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void CadastrarProduto(Produto produto)
        {
            _produtoRepository.insert(produto);
        }
    }
}