using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHomework
{
    interface IVehicle
    {
        int WheelsCount { get; set; }
        int MaxRPM { get; set; }
        double CalculateSpeed();
    }
}
