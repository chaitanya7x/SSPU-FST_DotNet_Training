using System;

namespace ConsoleApp2.ExceptionHandling
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
            
        }
    }
}
