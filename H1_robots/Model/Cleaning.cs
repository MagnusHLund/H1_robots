using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_robots.Model
{
    internal class Cleaning
    {
        private decimal _soapCapacity;

        Cleaning()
        {
            _soapCapacity = 2.3m; // liters
        }

        Cleaning(decimal soapCapacity) : this ()
        {
            _soapCapacity = soapCapacity;
        }
    }
}
