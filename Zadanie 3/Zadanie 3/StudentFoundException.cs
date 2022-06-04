using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zadanie_3
{
    public class StudentFoundException : Exception
    {
        public StudentFoundException(string message) : base(message) { }
    }
}