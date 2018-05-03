using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDatabaseApp
{
    public class Customer
    {
        string Name;
        int ID;

        public Customer(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }
}
