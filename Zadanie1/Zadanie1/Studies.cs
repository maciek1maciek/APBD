using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Zadanie1
{
    public class Studies
    {
         
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

        public Studies(string name, string mode)
        {
            Name = name;
            Mode = mode; 
        }
 
    }
}
