using System;
namespace CSharpCrash
{
    public class CustomException : Exception
    {
        public CustomException()
        {
        }
        public CustomException(string message) : base(message)
        {

        }
    }
}