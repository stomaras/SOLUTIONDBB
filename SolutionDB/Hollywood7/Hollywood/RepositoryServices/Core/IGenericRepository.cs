﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices.Core
{
    public interface IGenericRepository<T> where T : HollywoodEntity
    {
        IEnumerable<T> GetAll();
        T GetById(object id);

        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        T SingleOrDefault(Expression<Func<T, bool>> predicate);

        void Insert(T obj);

        void Update(T obj);

        void Delete(object id);

        void Save();


    }
}
