using System;
using System.Collections.Generic;
using Zadanie_3.Models;

namespace Zadanie_3
{
    public interface IRead
    {

        public List<Student> readFile(string inputPath);

    }
}
