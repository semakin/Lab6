using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{

    abstract class Human // Абстрактный класс человек
    {
        public string name;
        public string surname;
        public Human(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public abstract void ShowInfo();

    }
}
