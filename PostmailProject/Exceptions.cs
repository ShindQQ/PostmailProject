using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostmailProject
{
    internal class IntException : Exception
    {
        public int Value { get; set; }

        public IntException(string message, int value) : base(message)
        {
            Value = value;
        }
        
        public IntException(string message, Exception InnerException, int value) : base(message, InnerException)
        {
            Value = value;
        }
    }

    internal class DoubleException : Exception
    {
        public double Value { get; set; }

        public DoubleException(string message, double value) : base(message)
        {
            Value = value;
        }

        public DoubleException(string message, Exception InnerException, double value) : base(message, InnerException)
        {
            Value = value;
        }
    }
}