using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3August
{
    internal class Account
    {
        public string Login(string userName, string password)
        {
            if (userName == "cavid123" || password == "Cavid1993") 
            return "Giris ugurludur";

            return "email veya password sehvdir";
        }
    }
}
