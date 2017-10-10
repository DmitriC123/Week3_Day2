using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day2
{
    class Boat
    {
        public int NumberOfPassengers;

        private string name;
        private double engineSize;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Boat()
        {

        }

        public Boat(int NumberOfPassengers, string name, double engineSize)
        {
            this.NumberOfPassengers = NumberOfPassengers;
            this.name = name;
            this.engineSize = engineSize;
        }
        public void Move()
        {
            Console.WriteLine(name+ " moves forward.");
        }
        public double CalculateMPG()
        {
            double MPG = engineSize * .7d;
            //code to calculate the MPG
            return MPG;
        }
        public void BoatInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Passengers: " + NumberOfPassengers);
            Console.WriteLine("Engine Size: " + engineSize);
            Console.WriteLine("MPG " + CalculateMPG());
            Console.WriteLine();
        }
    }                                                                   
}
