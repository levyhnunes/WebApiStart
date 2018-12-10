using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiStart.Domain.Interfaces;
using WebApiStart.Infra.Data.Context;

namespace WebApiStart.Infra.Data.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository User { get; set; }

        IRepository<T> GetRepository<T>() where T : class;

        WebApiStartContext Context { get; }

        void Commit();
    }
}
