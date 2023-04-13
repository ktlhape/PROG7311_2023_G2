using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Interfaces
{
    internal class Rectangle : IShape, IDrawable
    {
        public void ApplyColor()
        {
            throw new NotImplementedException();
        }

        public void CalcArea(double x, double y)
        {
            throw new NotImplementedException();
        }

        public void DrawShape()
        {
            throw new NotImplementedException();
        }

        public double getArea(double x, double y)
        {
            return x * y;
        }
    }
}
