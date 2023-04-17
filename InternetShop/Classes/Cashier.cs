using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.Classes
{
    internal class Cashier:Person
    {
        public Cashier(int id, string firstname, string lastname, int age, string email) :
            base(id, firstname, lastname, age, email)
        {
        }
    }
}
