using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Human // Класс человек
    {
        public string name;
        public string surname;
        public Human (string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine(name + "\n" + surname);
        }
       
    }
}
