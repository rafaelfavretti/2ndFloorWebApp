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
        public ProdutoRepository(SecondFloorContext context) : base(context)
        {
            this._context = context;
        }

        private SecondFloorContext _context { get; set; }
    }
}