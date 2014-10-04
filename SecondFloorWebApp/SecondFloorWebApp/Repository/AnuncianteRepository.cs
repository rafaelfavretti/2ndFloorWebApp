using SecondFloorWebApp.DataAccess;
using SecondFloorWebApp.IRepository;
using SecondFloorWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecondFloorWebApp.Repository
{
    public class AnuncianteRepository : Repository<Anunciante, int> , IAnuncianteRepository
    {
        private SecondFloorContext _context { get; set; }

        public AnuncianteRepository(SecondFloorContext context) : base(context)
        {
            this._context = context;
        }
        
        public Anunciante BuscaRazaoSocial(string razaoSocial)
        {
            return _context.Anunciantes.Find(razaoSocial);
        }
    }
}