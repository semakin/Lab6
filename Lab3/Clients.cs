using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Clients // Класс клиенты
    {
        public string name;
        public string surname;
        public string middlename;
        
        public Clients(string name, string surname, string middlename)
        {
            this.name = name;
            this.surname = surname;
            this.middlename = middlename;
        }
        public void showClients()
        {
            Console.WriteLine("Клиент: \n" + name + "\n" + surname + "\n" + middlename + "\n");
        }
    }
}
