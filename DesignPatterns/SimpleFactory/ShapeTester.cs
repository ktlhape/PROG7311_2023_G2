using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactory
{
    internal class ShapeTester
    {
        static void Main(string[] args)
        {
            string option;
            Console.Write("Enter (R - Rectangle, S - Square)");
            option = Console.ReadLine().ToUpper();

            ShapeFactory fac = new ShapeFactory();
            IShape shape = fac.GetShape(option);
            shape.Print();


            Console.Read();
        }
    }
}
