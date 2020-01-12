using System;
using System.Collections.Generic;
using System.Text;

namespace coffee
{
    interface ICup
    {
        public String Color { get; set; }
        public String Volume { get; set; }
        public void Refill();
        public void Wash();
    }
}
