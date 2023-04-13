using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Polymorphism
{
    internal class ExecuteShape
    {
        static void Main(string[] args)
        {
            Shape s = new Shape(5, 7);
            Console.WriteLine("Area: " + s.calcArea());
            Square sq = new Square(6);
            Console.WriteLine("Sq: " + sq.calcArea());
            Circle c = new Circle(5);
            Console.WriteLine("Circle: " + c.calcArea());

        }
    }
}
