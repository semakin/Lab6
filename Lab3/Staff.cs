using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Staff // Класс персонал
    {
        public string name;
        public string Surname;
        public string middlename;
        public string position;
        public string status;
        public Staff(string name, string Surname, string middlename, string position, string status)
        {
            this.name = name;
            this.Surname = Surname;
            this.middlename = middlename;
            this.position = position;
            this.status = status;
        }
        public void ShowStaff()
        {
            Console.WriteLine("Сотрудник: \n" + name + "\n" + Surname + "\n" + middlename + "\n" + position + "\n" + status + "\n");
        }
    }
}
