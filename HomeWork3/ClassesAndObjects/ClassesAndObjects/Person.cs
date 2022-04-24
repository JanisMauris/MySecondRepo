using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
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
