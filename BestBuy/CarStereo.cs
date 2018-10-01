using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuy
{
    class CarStereo : Product
    {
        public bool HasBluetooth { get; set; }
        public bool HasSirius { get; set; }
        public int NumberOfAuxPorts { get; set; }
    }
}
