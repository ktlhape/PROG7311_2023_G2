using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactory
{
    internal class Circle : IShape
    {
        private double radius;
        public Circle(double r)
        {
            this.radius = r;
        }
        public double CalcArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public void Print()
        {
            Console.WriteLine($"Area of {this} is: {CalcArea()}");
        }
    }


}
