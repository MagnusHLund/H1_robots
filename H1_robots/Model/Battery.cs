using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_robots.Model
{
    internal class Battery
    {
        private byte _capacity;

        Battery()
        {
            _capacity = 255;
        }

        Battery(byte capacity) : this()
        {
            _capacity = capacity;
        }
    }
}
