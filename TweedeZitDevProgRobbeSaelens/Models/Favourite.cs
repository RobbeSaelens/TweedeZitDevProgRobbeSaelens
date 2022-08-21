using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TweedeZitDevProgRobbeSaelens.Models
{
    public class Favourite
    {
        [JsonProperty(propertyName: "id")]
        public string Id { get; set; }
        [JsonProperty(propertyName: "image_id")]
        public string Image_id { get; set; }
        [JsonProperty(propertyName: "sub_id")]
        public string Sub_id { get; set; }
        [JsonProperty(propertyName: "created_at")]
        public string Created_at { get; set; }

        [JsonProperty(propertyName: "image")]
        public ImageShort Image { get; set; }

    }
}
