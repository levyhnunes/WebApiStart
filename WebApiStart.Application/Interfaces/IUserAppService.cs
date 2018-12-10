using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiStart.Application.ViewModels;

namespace WebApiStart.Application.Interfaces
{
    public interface IUserAppService
    {
        UserViewModel Login(string userName, string password);
    }
}
