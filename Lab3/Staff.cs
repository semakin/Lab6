using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Staff : Human // Класс наследник персонал
    {
        
        public string middlename;
        public string position;
        public string status;
        public Staff(string name, string Surname, string middlename, string position, string status) : base(name, Surname) 
        {
            
            this.middlename = middlename;
            this.position = position;
            this.status = status;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Сотрудник: \n" + name + "\n" + surname + "\n" + middlename + "\n" + position + "\n" + status);
        }
    }
}