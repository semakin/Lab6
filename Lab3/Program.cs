using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Clients newap = new Clients("Игорь", "Крюков", "Александрович");

            newap.showClients();
            Staff newup = new Staff("Олег", "Молчанов", "Алексеевич", "экскурсовод", "свободен");
            newup.ShowStaff();
            Console.ReadKey();
        }
    }
    
}
