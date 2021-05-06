using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHomework
{
    class RowBoat:IWaterCraft, IHasSpeed
    {
        public double MaxSpeed { get; set; }
        public int PassengersOnBoard { get; set; }

        public int Capacity { get; set; }
        public RowBoat(double maxSpeed, int passengersOnBoard, int capacity)
        {
            this.MaxSpeed = maxSpeed;
            this.PassengersOnBoard = passengersOnBoard;
            this.Capacity = capacity;
        }

        public void Sail()
        {
            if (this.PassengersOnBoard <= this.Capacity)
            {
                Console.WriteLine("Ahoy!");
            }
            else
            {
                Console.WriteLine("Cannot Sail!");
            }

        }

        public double CalculateCurrentSpeed()
        {
            if (this.PassengersOnBoard > Capacity)
            {
                throw new ArgumentException("Too many Passengers to sail!");
            }
            double currentSpeed = this.MaxSpeed - 0.8 * this.MaxSpeed * (this.PassengersOnBoard / this.Capacity);
            Console.WriteLine("The Current Speed is {}", currentSpeed);
            return currentSpeed;
        }
    }
}
