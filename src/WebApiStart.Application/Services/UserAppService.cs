using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiStart.Application.Interfaces;
using WebApiStart.Application.ViewModels;
using WebApiStart.Domain.Models;
using WebApiStart.Infra.Data.Interfaces;
using WebApiStart.Application.AutoMapper;

namespace WebApiStart.Application.Services
{
    public class UserAppService : IUserAppService
    {
        IUnitOfWork _unitOfWork;

        public UserAppService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public UserViewModel Login(string userName, string password)
        {
            User user = _unitOfWork.User.Login(userName, password);
            
            return user.Map<User, UserViewModel>();
        }
    }
}
