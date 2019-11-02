using System;

namespace Newt_Salamander
{
    public class NumberNegativeOrZeroException : Exception
    {
        public NumberNegativeOrZeroException() : base("Number negative or zero") { }
    }
}