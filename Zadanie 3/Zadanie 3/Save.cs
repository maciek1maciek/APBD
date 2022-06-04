using System.Collections.Generic;
using System.IO;
using Zadanie_3.Models;

namespace Zadanie_3
{
    public class Save : ISave
    {
        public void SaveList(List<Student> students, string path)
        {
            using var streamWriter = new StreamWriter(path);
            foreach (var student in students)
                streamWriter.WriteLine(student);
        }
    }
}
