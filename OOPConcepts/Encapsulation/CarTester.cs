﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Encapsulation
{
    internal class CarTester
    {
        static void Main(string[] args)
        {
            Car c = new Car("BMW");
            c.StartEngine();
            c.Drive();
            c.SpeedUp();
            c.SpeedUp();
            c.SpeedUp();
            c.SpeedUp();
            c.SpeedUp();

            c.Dashboard();

            Console.Read();
        }
    }
}
