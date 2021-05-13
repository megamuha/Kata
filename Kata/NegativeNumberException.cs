using System;
using System.Runtime.Serialization;

namespace Kata
{
    [Serializable]
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException()
        {
        }

        /*
        public NegativeNumberException(string message) : base(message)
        {
        }

        public NegativeNumberException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NegativeNumberException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }*/

        public string Numbers { get; set; }
        public NegativeNumberException(string nums)
        {
            Numbers = nums;
        }
    }
}