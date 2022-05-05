using System;

namespace Vis2
{
    public class RomanNumberException : Exception
    {
        public short Value { get; }
        public RomanNumberException(string message) : base(message)
        {

        }
    }
}