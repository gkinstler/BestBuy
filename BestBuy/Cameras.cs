using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuy
{
    class Cameras : Product
    {
        public int Resolution { get; set; }
        public string Lens { get; set; }
        public bool HasCase { get; set; }
        public bool HasAutoFocus { get; set; }
    }
}
