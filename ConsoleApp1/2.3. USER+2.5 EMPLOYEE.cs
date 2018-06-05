using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace person
{
    public class User
    {
        private string surname;
        private string name;
        private string patronymic;
        private string date;
        private int age;

        public User() { }

        public User(string surname, string name, string patronymic, string date, int age)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.date = date;
            this.age = age;
        }

        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name =  value; }
        public string Patronymic { get => patronymic; set => patronymic = value; }
        public string Date { get => date; set => date = value; }
        public int Age { get => age; set => age = value; }
    }

    public class Employee : User
    {
        private string company;
        private string pos;
        private int exp;

        private bool isName(string name)
        {
            int result;
            Match match = Regex.Match(name, "[0-9]");
            return Int32.TryParse(match.ToString(), out result);
        }

        public Employee(string surname, string name, string patronymic, string date, int age, string company, string pos, int exp) : base(surname, name, patronymic, date, age)
        {
            if (isName(surname) || isName(name) || isName(patronymic))
            {
                throw new ArgumentException();
            }

            this.company = company;
            this.pos = pos;
            this.exp = exp;
        }

        public string Company { get => company; set => company = value; }
        public string Pos { get => pos; set => pos = value; }
        public int Exp { get => exp; set => exp = value; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var Person = new User("Иванов", "Василий", "Батькович", "01.01.2000", 18);

            Console.Write($"{Person.Surname} {Person.Name} {Person.Patronymic}\n");
            Console.ReadLine();

            var Employee = new Employee("Петров", "Иван", "Сидорович", "02.04.1995", 23, "Random&Co","Manager", 5);

            Console.Write($"{Employee.Surname} {Employee.Company} {Employee.Pos}\n");
            Console.ReadLine();
        }
    }
}
