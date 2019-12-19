using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
    class PierOccupiedPlaceException : Exception
    {
        public PierOccupiedPlaceException(int i) : base("На месте " + i +
            " уже стоит корабль")
        {

        }
    }
}
