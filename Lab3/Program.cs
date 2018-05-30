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

            newap.ShowInfo();
            Staff newup = new Staff("Олег", "Молчанов", "Алексеевич", "экскурсовод", "свободен");
            newup.ShowInfo();

            Route obj = new Route();

            obj.RoutHell();
            Console.ReadKey();
        }
    }
    
}
