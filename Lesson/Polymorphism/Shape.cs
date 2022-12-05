using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Shape
    {
        //circle
        public double Area(double radius)
        {
            // return Convert.ToInt32(Math.Pow(radius, 2)); // bu 2 verende 14 donderir int olsa method niye?
            Console.WriteLine("Circle:");
            return ((radius * radius) * Math.PI);
        }

        //Square
        public double Area(double length,string bos)
        {
            Console.WriteLine("Square");
            return Math.Pow(length, 2);
        }

        //Rectangle
        public double Area(double length, double widht)
        {
            Console.WriteLine("Rectangle");
            return length * widht;
        }
    }
}
