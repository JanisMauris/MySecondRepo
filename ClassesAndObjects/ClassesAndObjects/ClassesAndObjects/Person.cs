using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        private int _age;
        public int Age
            {
                    get
                { 
                    return _age;
                }
                    set
                {
                    _age = value; 
                }
            }

        public bool IsMale { get; set; }

        public bool isAdult
        {
            get
            {
                return Age >= 18;
            }
        }
        public Car Car { get; set; }

        public void Greeting()
        {
            Console.WriteLine($"Hello my name is : {Name} and I am {Age} years old");
        }

        public bool GetIsAdult()
        {
            return Age >= 18;
        }

    }
}
