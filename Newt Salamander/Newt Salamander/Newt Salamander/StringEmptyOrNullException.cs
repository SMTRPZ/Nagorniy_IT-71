using System;

namespace NewtSalamanderTests
{
    public class StringEmptyOrNullException : Exception
    {

        public StringEmptyOrNullException() : base("String is empty or null") { }
    }
}