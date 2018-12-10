using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiStart.Domain.Interfaces;
using WebApiStart.Infra.Data.Context;
using WebApiStart.Infra.Data.Interfaces;
using WebApiStart.Infra.Data.Repository;

namespace WebApiStart.Infra.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private WebApiStartContext context;
        private Dictionary<Type, object> repositories;

        public UnitOfWork(WebApiStartContext context)
        {
            this.context = context;
            //this.context.Database.CommandTimeout = 900;
            this.User = new UserRepository(context);
        }

        public IUserRepository User { get; set; }

        public IRepository<T> GetRepository<T>()
            where T : class
        {
            if (this.repositories == null)
            {
                this.repositories = new Dictionary<Type, object>();
            }

            var type = typeof(T);
            if (!this.repositories.ContainsKey(type))
            {
                this.repositories[type] = new Repository<T>(this.context);
            }

            return (IRepository<T>)this.repositories[type];
        }

        public WebApiStartContext Context
        {
            get { return this.context; }
        }

        public void Commit()
        {
            try
            {
                this.context.SaveChanges();
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }
    }
}
