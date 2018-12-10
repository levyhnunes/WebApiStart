using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebApiStart.Domain.Interfaces;
using WebApiStart.Infra.Data.Context;
using System.Data.Entity;

namespace WebApiStart.Infra.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected WebApiStartContext context;

        public Repository(WebApiStartContext contexto)
        {
            this.context = contexto;
        }

        public T GetById(Guid id)
        {
            return context.Set<T>().Find(id);
        }

        public IQueryable<T> All()
        {
            return context.Set<T>() as IQueryable<T>;
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().Where(predicate);
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate, string include)
        {
            return context.Set<T>().Where(predicate).Include(include);
        }

        public void Add(T entidade)
        {
            context.Entry<T>(entidade).State = System.Data.Entity.EntityState.Added;
        }

        public void AddAndSave(T entidade)
        {
            this.Add(entidade);
            context.SaveChanges();
        }

        public void Update(T entidade)
        {
            context.Entry<T>(entidade).State = System.Data.Entity.EntityState.Modified;
        }

        public void UpdateAndSave(T entidade)
        {
            this.Update(entidade);
            context.SaveChanges();
        }

        public void Delete(T entidade)
        {
            context.Entry<T>(entidade).State = System.Data.Entity.EntityState.Deleted;
        }

        public void DeleteAndSave(T entidade)
        {
            this.Delete(entidade);
            context.SaveChanges();
        }
    }
}
