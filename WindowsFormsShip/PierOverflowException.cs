using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
    class PierOverflowException : Exception
    {
        public PierOverflowException() : base("На пристани нет свободных мест")
        {
        }
    }
}
