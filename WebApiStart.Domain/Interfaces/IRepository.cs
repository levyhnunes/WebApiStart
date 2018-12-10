using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebApiStart.Domain.Interfaces
{
    public interface IRepository<T>
    {
        T GetById(Guid id);
        IQueryable<T> All();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate, string include);
        void Add(T entity);
        void AddAndSave(T entity);
        void Update(T entity);
        void UpdateAndSave(T entity);
        void Delete(T entity);
        void DeleteAndSave(T entity);
    }
}
