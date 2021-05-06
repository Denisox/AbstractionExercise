using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class RegularCar:Car
    {
        public override string Brand { get; }
        public override int MaxRPM { get; set; }
        public override string Color { get; }

        public int FreePassengerSeats { get; set; }

        public RegularCar(string brand, int maxRPM, string color)
        {
            this.Brand=brand;
            this.MaxRPM = maxRPM;
            this.Color = color;
            this.FreePassengerSeats=4;
        }

        public override void ChangeColor(string color)
        {
            Console.WriteLine("Enter new Color:");
            string newColor = Console.ReadLine();
            Random random = new Random();
            int num = random.Next(1000);
            if (num > 200)
            {
                newColor = this.Color;
                Console.WriteLine("Color changed");
            }
            else
            {
                Console.WriteLine("Color unchanged");
            }
        }

        public void TakeSeat()
        {
            if (FreePassengerSeats > 0)
            {
                FreePassengerSeats--;
                Console.WriteLine("There are {0} free seats now.", this.FreePassengerSeats);
            }
            else
            {
                Console.WriteLine("There is no seat left!");
            }
        }

        public override string ToString()
        {
            return "Regular Car  " + Brand + ". The color of the car is " + Color + " and it currently has " + FreePassengerSeats + " free passenger seats.";
        }
    }
}
