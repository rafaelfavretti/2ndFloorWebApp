using SecondFloorWebApp.DataAccess;
using SecondFloorWebApp.IRepository;
using SecondFloorWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecondFloorWebApp.Repository
{
    public class LoginRepository : Repository<Login, int> , ILoginRepository
    {
        public LoginRepository(SecondFloorContext context) : base(context)
        {
            this._context = context;
        }

        private SecondFloorContext _context { get; set; }
    }
}