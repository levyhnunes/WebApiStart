﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiStart.Application.ViewModels
{
    public class UserViewModel
    {
        public Guid? Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
