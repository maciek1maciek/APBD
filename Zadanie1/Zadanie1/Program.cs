using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Zadanie1
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            var log = new Log();
            if ( args.Length != 3 )
            {
                log.addLog("Za mało argumentow");
                throw new Exceptions.MissingParametersException("Za mało argumentow");
            }
            if (!File.Exists(args[0]))
            {
                log.addLog($"Plik {args[0]} nie istnieje ");
                throw new FileNotFoundException($"Plik {args[0]} nie istnieje");
            }
            var str = args[1];
            if (!Directory.Exists(str = str.Substring(0, str.LastIndexOf('\\'))))
            {
                log.addLog($"Podana ścieżka jest niepoprawna {args[1]}");
                throw new ArgumentException("Podana ścieżka jest niepoprawna");
            }

            Uczelnia uczelnia = new Uczelnia();

            using (StreamReader sr = new StreamReader(args[0]))
            {
                int counter = 1;
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {   
                    string[] fields = line.Split(',');
                    if (fields.Length != 9)
                    {
                        log.addLog($"Nieprawidlowa liczba kolumn: {line }");
                    }
                    else
                    {
                        var student = new Student(fields[0], fields[1], fields[4], fields[5], fields[6], fields[7], fields[8], fields[2], fields[3]);
                        uczelnia.Students.Add(student);
                    }
                    if (fields.Any(x => String.IsNullOrEmpty(x)))
                    {
                        log.addLog($"Puste pole: {line }");
                    }
                    else
                    {
                        var student = new Student(fields[0], fields[1], fields[4], fields[5], fields[6], fields[7], fields[8], fields[2], fields[3]);
                        uczelnia.Students.Add(student);
                    }
                    
                    
                }
            }

            uczelnia.deleteDuplicates();
            

            //JSON  
            string jsonString = JsonConvert.SerializeObject(uczelnia);
            File.WriteAllText(args[1], jsonString);


        }
    }
 
}
