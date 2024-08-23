using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Person
    {
        public string FirstName;
        public string LastName;
        public string Gender;
        public int Age;
        public string City;
        public double Weight;
        public double Height;

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public bool IsAdult()
        {
            return Age >= 18;
        }

        public double CalculateBMI()
        {
            return Weight / (Height * Height);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть ім'я: ");
            string firstName = Console.ReadLine();
            Console.Write("Введіть прізвище: ");
            string lastName = Console.ReadLine();
            Console.Write("Введіть вік: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Введіть стать (чоловіча/жіноча): ");
            string gender = Console.ReadLine();
            Console.Write("Введіть місто проживання: ");
            string city = Console.ReadLine();
            Console.Write("Введіть вагу (кг): ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Введіть зріст (м): ");
            double height = double.Parse(Console.ReadLine());

            Person person = new Person();
            person.FirstName = firstName;
            person.LastName = lastName;
            person.Gender = gender;
            person.Age = age;
            person.City = city;
            person.Weight = weight;
            person.Height = height;

            string fullName = person.GetFullName();
            bool isAdult = person.IsAdult();
            double bmi = person.CalculateBMI();

            Console.WriteLine("\nІнформація про особу:");
            Console.WriteLine($"Повне ім'я: {fullName}");
            Console.WriteLine($"Вік: {person.Age}");
            Console.WriteLine($"Повнолітній: {(isAdult ? "Так" : "Ні")}");
            Console.WriteLine($"Місто проживання: {person.City}");
            Console.WriteLine($"Вага: {person.Weight} кг");
            Console.WriteLine($"Зріст: {person.Height} м");
            Console.WriteLine($"ІМТ: {bmi:F2}");
        }
    }
}
