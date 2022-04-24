using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
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
}
