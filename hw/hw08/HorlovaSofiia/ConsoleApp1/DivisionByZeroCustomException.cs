using System;

namespace ConsoleApp1
{
    internal class DivisionByZeroCustomException : Exception
    {
        public DivisionByZeroCustomException()
            : base("Division by zero is not allowed.")
        {
        }

        public DivisionByZeroCustomException(string message)
            : base(message)
        {
        }
    }
}