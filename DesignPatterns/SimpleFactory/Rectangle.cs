using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactory
{
    internal class Rectangle : IShape
    {
        private double length, width;
        public Rectangle(double x, double y)
        {
            this.length = x;
            this.width = y;
        }
        public double CalcArea()
        {
            return length * width;
        }

        public void Print()
        {
            Console.WriteLine($"Area of {this} is: {CalcArea()}");
        }
    }
}
