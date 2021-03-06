using Cebolla.Infraestructure.Context;
using Cebolla.Infraestructure.Interfaces.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Cebolla.Infraestructure.Repositories.Base
{
        public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
        {
            protected EntityContext RepositoryContext { get; set; }

            public RepositoryBase(EntityContext repositoryContext)
            {
                this.RepositoryContext = repositoryContext;
            }

            public IQueryable<T> FindAll()
            {
                return this.RepositoryContext.Set<T>().AsNoTracking();
            }

            public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
            {
                return this.RepositoryContext.Set<T>().Where(expression).AsNoTracking();
            }

            public IQueryable<T> FindByConditionSolo(Expression<Func<T, bool>> expression)
            {
                return this.RepositoryContext.Set<T>().Where(expression).AsNoTracking();
            }

            public T Create(T entity)
            {
                return this.RepositoryContext.Set<T>().Add(entity).Entity;
            }

            public void Update(T entity)
            {
                this.RepositoryContext.Set<T>().Update(entity);
            }

            public void Delete(T entity)
            {
                this.RepositoryContext.Set<T>().Remove(entity);
            }
        }
    }
