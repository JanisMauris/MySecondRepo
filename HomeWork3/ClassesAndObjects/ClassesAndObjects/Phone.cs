using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Phone
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Size { get; set; }
    }


    public class Car
    {
        public string Brand { get; set; }
        public string NumberPlate { get; set; }
        public double Speed { get; set; }

        public void StartToDrive()
        {
            Speed = 10;
            Console.WriteLine("Sakam braukšanu");
        }

        public double GoFaster()
        {
            Speed += 10;
            Console.WriteLine("Ātrums - " + Speed);
            return Speed;
        }

        public void Beep()
        {
            Console.WriteLine("BEEP");
        }

        public double SlowDown()
        {
            Speed -= 10;
            Console.WriteLine("Ātrums - " + Speed);
            return Speed;
        }

        public void Stop()
        {
            Speed = 0;
            Console.WriteLine("Apstāšanās");
        }
    }
    public class Product
    {
        public Product(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public double Length { get; }
        public double Width { get; }
        public double Height { get; }
        public double Weight { get; set; }
        }

    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Hobby { get; set; }
        public bool Gender { get; set; }

        public int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
    }


}



