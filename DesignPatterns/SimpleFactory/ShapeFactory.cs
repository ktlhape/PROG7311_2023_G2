using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactory
{
    internal class ShapeFactory
    {
        public IShape GetShape(string type)
        {
            IShape obj = null;
            if (type.Equals("R"))
            {
                double x, y;
                Console.Write("Enter length: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter width: ");
                y = Convert.ToDouble(Console.ReadLine());
                obj = new Rectangle(x, y);

            }else if (type.Equals("S"))
            {
                double s;
                Console.Write("Enter side: ");
                s = Convert.ToDouble(Console.ReadLine());
                obj = new Square(s);
            }

            return obj;
        }
    }
}
