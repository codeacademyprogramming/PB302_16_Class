using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Car
    {
        public Car(string brand)
        {
            Console.WriteLine("C 1 called");
            this.Brand = brand;
        }

        public Car (string brand,string model):this(brand)
        {
            Console.WriteLine("C 2 called");
            this.Model = model;
        }

        public Car(string brand,string model,int year):this(brand,model)
        {
            Console.WriteLine("C 3 called");
            this.Year = year;
        }

        public string Brand;
        public string Model;
        public int Year;
    }
}
