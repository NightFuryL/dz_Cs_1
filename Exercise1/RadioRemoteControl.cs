using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_Cs_1.Exercise1
{
    internal class RadioRemoteControl : IRemoteControl
    {
        public void TurnOn() { Console.WriteLine("Radio is ON"); }
        public void TurnOff() { Console.WriteLine("Radio is OFF"); }
        public void SetChannel(int channel) { Console.WriteLine("Radio tuned to " + channel); }
    }
}
