using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PriutWebAPI.Models.JSON
{
    public class RegisterUser
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string FIO { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}