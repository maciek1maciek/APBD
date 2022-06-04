using System;
using System.Collections.Generic;
using System.IO;
using Zadanie_3.Models;

namespace Zadanie_3
{
    public class Read : IRead
    {   

        private List<Student> students = new List<Student>();
         
        public List<Student> readFile(string inputPath)
        {   
            
            using (StreamReader sr = new StreamReader(inputPath))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    string[] fields = line.Split(','); 
                    var student = new Student(fields[0], fields[1], fields[2], fields[3], fields[4], fields[5], fields[6], fields[7], fields[8]);
                    students.Add(student);
                }
            }
             
            return students;
        }

        
    }
}
