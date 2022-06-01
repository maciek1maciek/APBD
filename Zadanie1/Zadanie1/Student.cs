using Newtonsoft.Json;
using System.Collections.Generic;

namespace Zadanie1
{
    public class Student
    {
        [JsonProperty(PropertyName = "firstName")]
        public string imie { get; set; }

        [JsonProperty(PropertyName = "lastName")]
        public string nazwisko { get; set; }

        [JsonProperty(PropertyName = "index")]
        public string index { get; set; }

        [JsonProperty(PropertyName = "birthdate")]
        public string dataUrodzenia { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string email { get; set; }

        [JsonProperty(PropertyName = "motherName")]
        public string mother { get; set; }

        [JsonProperty(PropertyName = "fatherName")]
        public string father { get; set; }

        [JsonProperty(PropertyName = "studies")]
        public Studies Studies { get; set; }

        public Student(string imie, string nazwisko, string index, string dataUrodzenia, string email, string mother, string father, string name , string mode )
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.index = index;
            this.dataUrodzenia = dataUrodzenia;
            this.email = email;
            this.mother = mother;
            this.father = father;
            Studies studied = new Studies(name, mode);
            Studies = studied;

        }
    }
}