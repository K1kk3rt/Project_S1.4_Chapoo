using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public struct Login
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Login(string _username, string _password)
        {
            Username = _username;
            Password = _password;
        }
    }
}
