using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TweedeZitDevProgRobbeSaelens.Models
{
    public class Category
    {
        [JsonProperty(propertyName: "id")]
        public string Id { get; set; }

        [JsonProperty(propertyName: "name")]
        public string Name { get; set; }
    }
}
