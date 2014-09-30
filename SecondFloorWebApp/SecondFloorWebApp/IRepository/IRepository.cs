﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondFloorWebApp.IRepository
{
    public interface IRepository<T, K> where T : class
    {
        void insert(T entity);
        void update(T entity);
        T findById(K id);
        void remove(K id);
    }
}
