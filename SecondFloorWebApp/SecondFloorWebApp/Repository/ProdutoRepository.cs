using SecondFloorWebApp.DataAccess;
using SecondFloorWebApp.IRepository;
using SecondFloorWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecondFloorWebApp.Repository
{
    public class ProdutoRepository : Repository<Produto, int>, IProdutoRepository
    {
        private SecondFloorContext _context { get; set; }
        
        public ProdutoRepository(SecondFloorContext context) : base(context)
        {
            this._context = context;
        }

        public Produto FindByName(string nomeProduto)
        {
            return _context.Produtos.Find(nomeProduto);
        }

        public Produto FindByRef(string codigoProduto)
        {
            return _context.Produtos.Find(codigoProduto);
        }

        public ICollection<Produto> ListarProdutos(int codigoAnunciante)
        {
            return _context.Produtos.Where(a => a.Anunciante.IdUsuario == codigoAnunciante).ToList();
        }
    }
}