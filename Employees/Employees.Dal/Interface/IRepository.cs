﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Employees.Dal.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            int? pageNumber = null, int? pageSize = null,
            params string[] includeProperties);

        TEntity Get(int id);
        void Insert(TEntity entity);
        void Delete(int id);
        void Delete(TEntity entityToDelete);
        void Update(TEntity entityToUpdate);
    }
}