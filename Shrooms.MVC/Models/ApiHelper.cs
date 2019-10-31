using System.Threading.Tasks;
using RestSharp;
using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Shrooms.Models
{
    class ApiHelper
    {
        public static async Task<string> ApiCallIndex()
        {
            RestClient client = new RestClient("http://localhost:5000/api/mushrooms");
            RestRequest request = new RestRequest(Method.GET);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }

        public static async Task<string> ApiCallDetails(int id)
        {
            RestClient client = new RestClient("http://localhost:5000");
            RestRequest request = new RestRequest("/api/mushrooms/{id}", Method.GET);
            request.AddUrlSegment("id", id);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }
        
        public static async Task<string> ApiCallCreate(Mushroom mushroom)
        {
            RestClient client = new RestClient("http://localhost:5000");
            RestRequest request = new RestRequest("api/mushrooms", Method.POST);
            request.AddJsonBody(mushroom);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }

        public static async Task<string> ApiCallDelete(int id)
        {
            RestClient client = new RestClient("http://localhost:5000");
            RestRequest request = new RestRequest("api/mushrooms/{id}", Method.DELETE);
            request.AddUrlSegment("id", id);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }
    }
}