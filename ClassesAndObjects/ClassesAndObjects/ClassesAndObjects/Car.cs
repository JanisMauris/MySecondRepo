using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Car
    {
        public string Brand { get; set; }
    
        public void BeepBeep()
        {
            Console.WriteLine($"{Brand} beep beep ");
        }
    }
}
