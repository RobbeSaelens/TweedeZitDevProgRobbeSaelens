using System;
using System.Collections.Generic;
using System.Text;

using System.Net.Http;
using TweedeZitDevProgRobbeSaelens.Models;
using System.Threading.Tasks;
using Newtonsoft.Json;

using RestSharp;

namespace TweedeZitDevProgRobbeSaelens.Repositories
{
    class DogRepository
    {
        private const string _BASEKEY = "30a8049d-7b20-4923-b0c4-ec2920f958c2";
        private static HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("accept", "application/json");
            return client;
        }

        private static string AddKey(string url)
        {
            return $"{url}?api_key={_BASEKEY}";
        }

        //Get all breeds
        public static async Task<List<Breed>> GetAllBreedsAsync()
        {
            using (HttpClient client = GetClient())
            {
                try
                {
                    string url = AddKey("https://api.thedogapi.com/v1/breeds");
                    string json = await client.GetStringAsync(url);
                    if (json != null)
                    {
                        return JsonConvert.DeserializeObject<List<Breed>>(json);
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }

        //Get all images
        public static async Task<List<ImageShort>> GetImagesAsync()
        {
            using (HttpClient client = GetClient())
            {
                try
                {
                    string url = AddKey("https://api.thedogapi.com/v1/images/search");
                    string json = await client.GetStringAsync(url);
                    if (json != null)
                    {
                        return JsonConvert.DeserializeObject<List<ImageShort>>(json);
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }

        //Get all favourites
        public static async Task<List<Favourite>> GetAllFavouritesAsync()
        {
            using (HttpClient client = GetClient())
            {
                try
                {
                    string url = AddKey("https://api.thedogapi.com/v1/favourites");
                    string json = await client.GetStringAsync(url);
                    if (json != null)
                    {
                        return JsonConvert.DeserializeObject<List<Favourite>>(json);
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }

        // Post favourite
        public static string PostFavourite(string id)
        {
            var client = new RestClient("https://api.thedogapi.com/v1/favourites");
            var request = new RestRequest(Method.POST);
            request.AddHeader("x-api-key", _BASEKEY);
            request.AddHeader("content-type", "application/json");
            var body = @"{" + "\n" +
            $@"    ""image_id"":""{id}""," + "\n" +
            @"    ""sub_id"": ""Robbe Saelens""" + "\n" +
            @"}";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        // Delete favourite
        public static string DeleteFavourite(string id)
        {
            var client = new RestClient("https://api.thedogapi.com/v1/favourites/" + id);
            var request = new RestRequest(Method.DELETE);
            request.AddHeader("content-type", "application/json");
            var body = @"";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            request.AddHeader("x-api-key", _BASEKEY);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}
