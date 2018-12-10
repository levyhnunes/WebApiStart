using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiStart.Domain.Models;

namespace WebApiStart.Domain.Interfaces
{
    public interface IUserRepository
    {
        User Login(string userName, string password);
    }
}
