using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Clients : Human // Класс клиенты
    {
        
        public string middlename;
        
        public Clients(string name, string surname, string middlename) : base(name, surname)
        {
            
            this.middlename = middlename;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Клиент:");
            base.ShowInfo();
            Console.WriteLine( "\n" + middlename);
        }
    }
}
