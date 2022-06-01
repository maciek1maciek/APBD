using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1.Exceptions
{
    public class MissingParametersException : Exception
    {
        public MissingParametersException() : base() { }
        public MissingParametersException(string message) : base(message) { }
        public MissingParametersException(string message, Exception e) : base(message, e) { }
    }
}

