﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worldskills
{
    class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; } = "Заказчик";
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }

    }
}
