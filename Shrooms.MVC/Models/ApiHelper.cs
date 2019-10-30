using System.Threading.Tasks;
using RestSharp;
using System;

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
            Console.WriteLine(id);
            RestClient client = new RestClient("http://localhost:5000/api");
            RestRequest request = new RestRequest("/mushrooms/{id}", Method.GET);
            request.AddUrlSegment("id", id);
            var response = await client.ExecuteTaskAsync(request);
            Console.WriteLine("sup", response);
            return response.Content;
        }
    }
}