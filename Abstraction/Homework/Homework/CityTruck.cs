using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class CityTruck : Truck
    {
        public override int Capacity { get; }
        public override int MaxRPM { get; set; }
        public int CurrentCargo { get; set; } = 0;

        public override int WheelsCount { get; set; }

        public override int GetCargo()
        {
            Console.WriteLine("How much cargo will you take?");
            int cargoAdd = Convert.ToInt32(Console.ReadLine());
            if (this.CurrentCargo + cargoAdd <= this.Capacity)
            {
                this.CurrentCargo += cargoAdd;
                return this.CurrentCargo;
            }

            else
            {
                Console.WriteLine("Cannot add cargo. Check Capacity.");
                return 0;
            }
        }

        public CityTruck(int capacity, int maxRPM, int wheelsCount)
        {
           this.Capacity = capacity;
             this.MaxRPM = maxRPM;
            this.WheelsCount = wheelsCount;
        }

        public bool IsGood()
        {
            if (this.Capacity > 50)
            {
                Console.WriteLine("The Truck is good.");
                return true;
            }
            else
            {
                Console.WriteLine("The Truck is not efficient.");
                return false;
            }
        }

            public override string ToString()
            {
                return "City Truck with " + Capacity + " kg. Capacity. It has " + WheelsCount + " wheels and currently carries " + CurrentCargo + " kg. cargo.";
            }
    
    }
}
