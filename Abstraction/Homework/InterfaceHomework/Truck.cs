using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHomework
{
    class Truck : IVehicle, IEngine, IHasSpeed
    {
        public int WheelsCount { get; set; }
        public int MaxRPM { get; set; }
        public int EngineMaxRPM { get; set; }
        public double MaxSpeed { get; set; } = 90;

        public bool EngineState { get; set; } = true;
        public Truck(int wheelsCount, int maxRPM, int engineMaxRPM)
        {
            this.WheelsCount = wheelsCount;
            this.MaxRPM = maxRPM;
            this.EngineMaxRPM = engineMaxRPM;
        }
        public void ForceEngine(int currentRPM)
        {

            if (this.EngineState == false)
            {
                Console.WriteLine("Engine is broken, it cannot get forced");
            }

            else
            {
                if (currentRPM > this.EngineMaxRPM)
                {
                    Console.WriteLine("Engine broke");
                    this.EngineState = false;
                }

                else
                {
                    Console.WriteLine("Engine forced with {} RPM", currentRPM);
                }
            }
        }
        public double CalculateSpeed()

        {
            double maxSpeed = 2 * Math.PI * 0.001 * this.MaxRPM * 60;
            this.MaxSpeed = maxSpeed;
            return maxSpeed;
        }

        public override string ToString()
        {
            Console.WriteLine( "\nTruck with " + this.WheelsCount + " wheels. The maximum speed of the truck is " + this.MaxSpeed + " km/h.\n");
            return " ";
        }
    }
}
