using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._02
{
    internal class Employee
    {
        public override bool Equals(object o)
        {
            if (o == null)
                return false;

            var second = o as Employee;

            return second != null && Payday == second.Payday;
        }

        public override int GetHashCode()
        {
            return Payday;
        }
        private static string Fullname { get; set; }
        private static string Birthday { get; set; }
        private static string Number { get; set; }
        private static string Description { get; set; }
        private static string Type { get; set; }
        private static string Email { get; set; }
        private int Payday { get; set; }
        public Employee() { }
        public Employee(string fullname, string birthday, string number, string description, string type, string email, int payday)
        {
            Fullname = fullname;
            Birthday = birthday;
            Number = number;
            Description = description;
            Type = type;
            Email = email;
            Payday = payday;
        }

        static Employee()
        {
            Console.WriteLine("Введите Имя: ");
            Fullname = Console.ReadLine();
            Console.WriteLine("Введите дату рождения: ");
            Birthday = Console.ReadLine();
            Console.WriteLine("Введите номер телефона: ");
            Number = Console.ReadLine();
            Console.WriteLine("Введите описание: ");
            Description = Console.ReadLine();
            Console.WriteLine("Введите должность: ");
            Type = Console.ReadLine();
            Console.WriteLine("Введите почту: ");
            Email = Console.ReadLine();

        }

        public void Print()
        {
            Console.WriteLine($"\nИмя: {Fullname}\nДата Рождения: {Birthday}\nНомер телефона: {Number}\nИмейл: {Email}\nОписание: {Description}\nДолжность: {Type}\nЗарплата: {Payday}$");
        }

        public override string ToString()
        {
            return $"\nИмя: {Fullname}\nДата Рождения: {Birthday}\nНомер телефона: {Number}\nИмейл: {Email}\nОписание: {Description}\nДолжность: {Type}\nЗарплата: {Payday}$";
        }
        public static Employee operator +(Employee a, int b)
        {
            a.Payday += b;
            return a;
        }
        public static Employee operator -(Employee a, int b)
        {
            a.Payday -= b;
            return a;
        }
        public static bool operator ==(Employee a, Employee b)
        {
            if (a.Payday == b.Payday)
                return true;
            else
                return false;
        }
        public static bool operator !=(Employee a, Employee b) => !(a == b);

        public static bool operator >(Employee a, Employee b)
        {
            if (a.Payday > b.Payday)
                return true;
            else
                return false;
        }
        public static bool operator <(Employee a, Employee b) => !(a.Payday > b.Payday);
    }
}
