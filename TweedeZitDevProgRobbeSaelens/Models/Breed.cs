using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace TweedeZitDevProgRobbeSaelens.Models
{
    public class Breed
    {
            [JsonProperty(propertyName: "id")]
            public string Id { get; set; }

            [JsonProperty(propertyName: "name")]
            public string Name { get; set; }

            [JsonProperty(propertyName: "life_span")]
            public string LifeSpan { get; set; }

            [JsonProperty(propertyName: "temperament")]
            public string Temperament { get; set; }

            [JsonProperty(propertyName: "origin")]
            public string Origin { get; set; }

            //[JsonProperty(propertyName: "alt_name")]
            //public string AltName { get; set; }

            //[JsonProperty(propertyName: "wikipedia_url")]
            //public string WikipediaUrl { get; set; }

            [JsonProperty(propertyName: "country_code")]
            public string CountryCode { get; set; }

            [JsonProperty(propertyName: "height")]
            public Height height { get; set; }

            [JsonProperty(propertyName: "weight")]
            public Weight weight { get; set; }
            [JsonProperty(propertyName: "image")]
            public Image image { get; set; }


            public class Height
            {
                [JsonProperty(propertyName: "imperial")]
                public string Imperial { get; set; }

                [JsonProperty(propertyName: "metric")]
                public string Metric { get; set; }
            }

            public class Weight
            {
                [JsonProperty(propertyName: "imperial")]
                public string Imperial { get; set; }

                [JsonProperty(propertyName: "metric")]
                public string Metric { get; set; }
            }

            public class Image
            {
                [JsonProperty(propertyName: "id")]
                public string Id { get; set; }

                [JsonProperty(propertyName: "width")]
                public int Width { get; set; }

                [JsonProperty(propertyName: "height")]
                public int Height { get; set; }

                [JsonProperty(propertyName: "url")]
                public string Url { get; set; }
            }

        }
    }
