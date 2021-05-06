using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
	public abstract class Truck: IVehicle
	{
		public abstract int Capacity { get; }
		public abstract int MaxRPM { get; set; }

		public abstract int WheelsCount { get; set; }
		public int UnlockedDoors { get; set; } = 2;

		public abstract int GetCargo();
		public virtual int LockDoor(int unlockedDoors)
		{
			unlockedDoors = this.UnlockedDoors;
			if (unlockedDoors >= 1)
			{
				unlockedDoors--;
			}
			return unlockedDoors;
		}

		public double CalculateSpeed(int maxRPM)

		{
			return 2 * Math.PI * 0.001 * maxRPM*60;
		}
	}
}

