using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TweedeZitDevProgRobbeSaelens.Models
{
    public class Category
    {
        [JsonProperty(propertyName: "id")]
        public int id { get; set; }

        [JsonProperty(propertyName: "name")]
        public string name { get; set; }
    }
}
