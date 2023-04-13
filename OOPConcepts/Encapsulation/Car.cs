using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Encapsulation
{
    internal class Car
    {
        private int fuel;
        private int speed;
        private string strName;

        public Car(string name)
        {
            this.strName = name;
            fuel = 100;
            speed = 0;
        }
        public void StartEngine()
        {
            TurnMotor();
            Console.WriteLine("Engine Started");
        }

       public void Drive()
        {
           
            SpeedUp();
            Console.WriteLine("Driving");
        }
       public void SpeedUp()
        {
            fuel -= 10;
            speed += 15;
        }
       private void BurnFuel()
        {
            fuel--;
        }
       private void TurnMotor()
        {
            BurnFuel();
        }

        public int GetSpeed()
        {
            return speed;
        }
        public int GetFuel()
        {
            return fuel;
        }
        public void Dashboard()
        {
            Console.WriteLine($"{strName} Driving at {speed} KM/H. \nThe Fuel level is: {fuel}");
        }

    }
}
