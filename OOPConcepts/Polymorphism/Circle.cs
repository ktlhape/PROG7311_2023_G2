using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Polymorphism
{
    internal class Circle : Shape
    {
        public Circle(double radius) :base(0,radius)
        {
            
        }

        public override double calcArea()
        {
            return Math.PI * (width * width);
        }
    }
}
