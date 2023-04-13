using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Polymorphism
{
    internal class Square : Shape
    {
        public Square(double theSide) :base(theSide,0)
        {
            //length = theSide;
        }
        public override double calcArea()
        {
            return length * length;
        }
    }
}
