using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
	public abstract class Car : IVehicle
	{
		public abstract string Brand { get; }
		public abstract int MaxRPM { get; set; }
		public abstract string Color { get; }
		public bool Drivable { get; set; } = true;
		public int WheelsCount { get; set; } = 4;

		public virtual void DriveBad(bool Drivable)
		{
			if (Drivable)
			{
				Drivable = false;
				Console.WriteLine("The car needs repair");
			}
			else
				Console.WriteLine("You may not drive the car!");
		}
		public virtual void Repair(bool Drivable)
		{
			if (Drivable == false)
			{
				Drivable = true;
				Console.WriteLine("The car has been repaired");
			}
			else
				Console.WriteLine("You do not need repair!");
		}
		public double CalculateSpeed(int maxRPM) 
		
		{
			return 2 * Math.PI * 0.0008 * maxRPM*60;
		}

		public abstract void ChangeColor(string color);

	}
}
