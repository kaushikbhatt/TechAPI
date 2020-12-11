﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TechnicalAssignment.IRepository
{
   
    public interface IBase<T>
    {
        IEnumerable<T> FindAll();
         void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}
