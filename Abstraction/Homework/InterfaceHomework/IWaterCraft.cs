using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHomework
{
    interface IWaterCraft
    {
        int PassengersOnBoard { get; set;}
        int Capacity { get; set; }

        double CalculateCurrentSpeed();
        void Sail();
    }
}
