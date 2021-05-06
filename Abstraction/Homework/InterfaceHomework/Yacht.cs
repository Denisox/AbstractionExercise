using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHomework
{
    class Yacht:IEngine, IWaterCraft, IHasSpeed
    {
        public int EngineMaxRPM { get; set; }
        public bool EngineState { get; set; } = true;
        public double MaxSpeed { get; set; }
        public int PassengersOnBoard { get; set; }

        public int Capacity { get; set; }

        public Yacht(int engineRPM, double maxSpeed, int passengersOnBoard, int capacity)
        {
            this.EngineMaxRPM = engineRPM;
            this.MaxSpeed = maxSpeed;
            this.PassengersOnBoard = passengersOnBoard;
            this.Capacity = capacity;
        }
        public void ForceEngine(int currentRPM) {

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

        public double CalculateCurrentSpeed()
        {
            if (this.PassengersOnBoard > Capacity)
            {
                throw new ArgumentException("Too many Passengers to sail!");
            }
            double currentSpeed = this.MaxSpeed - 0.65 * this.MaxSpeed * (this.PassengersOnBoard / this.Capacity);
            Console.WriteLine("The Current Speed is {}", currentSpeed);
            return currentSpeed;
        }

        public void Sail()
        {
            if (this.PassengersOnBoard <= this.Capacity)
            {
                Console.WriteLine("Let's have party in the sea!");
            }
            else
            {
                Console.WriteLine("Cannot Sail!");
            }

        }

        public override string ToString()
        {
            return "\nYacht with " + this.Capacity + " Passangers at most. Currently there are " + this.PassengersOnBoard + " Passengers. The yacht has maximum speed of " + this.MaxSpeed + " km/h.\n";
        }
    }
}
