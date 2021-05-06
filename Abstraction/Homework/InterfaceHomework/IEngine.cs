using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHomework
{
    interface IEngine
    {
        int EngineMaxRPM { get; set;}
        bool EngineState { get; set; }
        void ForceEngine(int currentRPM);
    }
}
