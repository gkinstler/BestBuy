using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuy
{
    class Drones : Product
    {
        public int DistanceAllowed { get; set; }
        public int Frequency { get; set; }
        public int CameraResolution { get; set; }
        public bool IsHeavyDuty { get; set; }
    }
}
