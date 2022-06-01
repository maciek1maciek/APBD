using System;
using System.Collections.Generic;
using System.Linq; 
using Newtonsoft.Json;

namespace Zadanie1
{
    public class Uczelnia
    {
        [JsonProperty(PropertyName = "studenci", Order = 3)]
        public List<Student> Students { get; set; }

        [JsonProperty(PropertyName = "activeStudies", Order = 4)]
        public List<ActiveStudies> ActiveStudies { get; set; }

        [JsonProperty(PropertyName = "createdAt", Order = 2)]

        [JsonIgnore]
        public DateTime CreatedAt { get; set; }

        [JsonProperty(PropertyName = "createdAt", Order = 2)]
        public string CreatedAtString { get { return CreatedAt.ToString("dd.MM.yyyy"); } }

        [JsonProperty(PropertyName = "author", Order = 1)]
        public String Author { get; set; }

        public Uczelnia()
        {
            ActiveStudies = new List<ActiveStudies>();
            Students = new List<Student>();
            CreatedAt = DateTime.Now;
            Author = "Koczyk Maciej";
        }

        public void deleteDuplicates()
        {

            //duplikates
            List<Student> withoutDuplicateStudents = Students.GroupBy(s => new { s.imie, s.nazwisko, s.index })
              .Select(g => g.First())
              .ToList();

            withoutDuplicateStudents.GroupBy(s => new { s.Studies.Name }).Distinct();

            Students.Clear();
            Students = withoutDuplicateStudents;

        }

    }
}
