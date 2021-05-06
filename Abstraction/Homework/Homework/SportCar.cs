using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class SportCar : Car
    {
        public override string Brand { get; }
        public override int MaxRPM { get; set; }
        public override string Color { get; }

        public double From0to100 { get; set; }

        public SportCar(string type, int maxRPM, string color, double from0to100)
        {
            this.Brand = type;
            this.MaxRPM = maxRPM;
            this.Color = color;
            this.From0to100 = from0to100;
        }

        public override void ChangeColor(string color)
        {
            Console.WriteLine("Enter new Color:");
            string newColor = Console.ReadLine();
            newColor = this.Color;
        }

        public bool IsGood(double from0to100)
        {
            from0to100 = this.From0to100;
            if (from0to100 < 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "Sport Car  " + Brand + ". The color of the car is " + Color + " an it can accelerate from 0 km/h to 100 km/h for  " + From0to100 + " seconds.";
        }
    }
}
