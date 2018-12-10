using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiStart.Domain.Interfaces;
using WebApiStart.Domain.Models;
using WebApiStart.Infra.Data.Context;

namespace WebApiStart.Infra.Data.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        WebApiStartContext context;

        public UserRepository(WebApiStartContext context)
            : base(context)
        {
            this.context = context;
        }

        public User Login(string userName, string password)
        {
            return FindBy(x => x.UserName.Equals(userName) && x.Password.Equals(password)).FirstOrDefault();
        }

    }
}
