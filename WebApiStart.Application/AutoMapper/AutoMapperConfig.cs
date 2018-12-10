using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiStart.Application.ViewModels;
using WebApiStart.Domain.Models;

namespace WebApiStart.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize((config) =>
                {
                    config.CreateMap<UserViewModel, User>().ReverseMap();
                });
        }
    }
}
