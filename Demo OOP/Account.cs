using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP
{
    // Account class to manage user accounts, has two properties: Username and Password
    class Account
    {
        // Use properties to encapsulate data fields
        public string Username { get; set; }
        public string Password { get; set; }

        // Method to check login
        public bool Login(string username, string password)
        {
            return username == Username && password == Password;
        }
    }
}
