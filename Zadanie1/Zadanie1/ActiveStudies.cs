using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Zadanie1
{
    public class ActiveStudies
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "numberOfStudents")]
        public int NumberOfStudents { get; set; }

        public ActiveStudies()
        {
         
        }
    }
}
