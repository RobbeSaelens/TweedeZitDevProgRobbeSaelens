using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TweedeZitDevProgRobbeSaelens.Models
{
    public class ImageShort
    {
        [JsonProperty(propertyName: "id")]
        public string Id { get; set; }  

        [JsonProperty(propertyName: "url")]
        public string Url { get; set; }

        [JsonProperty(propertyName: "categories")]
        public Category[] Categories { get; set; }

        [JsonProperty(propertyName: "breeds")]
        public Breed[] Breeds { get; set; }
    }
}
