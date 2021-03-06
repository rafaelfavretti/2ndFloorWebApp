﻿using SecondFloorWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondFloorWebApp.IRepository
{
    public interface IAnuncianteRepository : IRepository<Anunciante, int>
    {
        Anunciante BuscaRazaoSocial(string razaoSocial);
    }
}
