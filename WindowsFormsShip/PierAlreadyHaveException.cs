using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
    class PierAlreadyHaveException : Exception
    {
        public PierAlreadyHaveException() : base("На пристани уже есть такой корабль")
        { }
    }
}
