using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Polymorphism
{
    internal class Shape
    {
       protected double length;
       protected double width;

        public Shape()
        {}
        public Shape(double theLength, double theWidth)
        {
            this.length = theLength;
            this.width = theWidth;
        }
        public virtual double calcArea()
        {
            return length * width;
        }
        public void printName()
        {
            Console.WriteLine("This is just a shape");
        }
    }
}
