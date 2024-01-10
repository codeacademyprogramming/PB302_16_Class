using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Hikmet";
            byte age = 45;

            var human1 = new
            {
                name="Abbas",
                age=20,
                surname="Hikmetov"
            };

            var human2 = new
            {
                fullname = "Abbas Hikmetov",
                age = 20
            };

            var human3 = new
            {
                name = "Abbas",
                age = 20
            };


            Console.WriteLine(human1.name);
            Console.WriteLine(human1.age);

            Human hmn1 = new Human
            {
                Name = "Nermine",
                Surname = "Abbaszade",
                Age = 35
            };

            Human hmn2 = new Human();
            hmn2.Name = "Hikmet";
            hmn2.Age = 55;


            Human hmn3 = new Human
            {
                Name = "Tofiq"
            };
            hmn3.Age = 16;


            Console.WriteLine(hmn2.Name);
            Console.WriteLine(hmn2.Age);

            Human[] humans = new Human[] { hmn1, hmn2, hmn3, new Human { Name = "Abdulla", Age = 24 } };

            humans[3].Name = "Abdul";

            for (int i = 0; i < humans.Length; i++)
            {
                Console.WriteLine($"{humans[i].Name}-{humans[i].Age}");
            }

            Console.WriteLine(hmn1.GetFullname());
            hmn1.ShowInfo();

            Human hmn4 = new Human("Gunay", "Abbasova");
            hmn4.BirthDate = new DateTime(1995, 10, 20);
            Console.WriteLine(hmn4.Name);
            Console.WriteLine(hmn4.Age);
            hmn4.ShowInfo();

            Console.WriteLine("\n==============================\n");

            Car car1 = new Car("Mercedes","E200",2020);

            Console.WriteLine(car1.Brand);
            Console.WriteLine(car1.Model);
            Console.WriteLine(car1.Year);

            Student std = new Student
            {
                Fullname = "Abbas Abbasov",
                GroupNo = "PB302",
                Exams = new Exam[]
                {
                    new Exam
                    {
                        StartedAt=new DateTime(2020,10,20,14,0,0),
                        FinishedAt = new DateTime(2020,10,20,17,0,0),
                        Subject="Math"
                    },
                     new Exam
                    {
                        StartedAt=new DateTime(2020,11,20,14,0,0),
                        FinishedAt = new DateTime(2020,12,20,17,0,0),
                        Subject="IT"
                    }
                }
            };

            for (int i = 0; i < std.Exams.Length; i++)
            {
                Console.WriteLine(std.Exams[i].Subject);
            }

        }


    }
}
