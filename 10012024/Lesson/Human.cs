using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Human
    {
        public Human()
        {
            Console.WriteLine("Constructor 1 called");
        }

        public Human(string name)
        {
            Console.WriteLine("Constructor 2 called");
            this.Name = name;
        }
        public Human(string name,byte age)
        {
            Console.WriteLine("Constucror 3 called");
            this.Name=name;
            this.Age = age;
        }
        public Human(string name,string surname, byte age=18)
        {
            Console.WriteLine("Constucror 4 called");
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }


        public string Name;
        public string Surname;
        public byte Age=18;
        public DateTime BirthDate;
        public Car Car;
        public string GetFullname()
        {
            string fullname = this.Name + " " + this.Surname;
            return fullname;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {this.Name}-Surname:{this.Surname}-Age:{this.Age}-BirthDate:{this.BirthDate.ToString("dd.MM.yyyy")}");
        }
    }
}
