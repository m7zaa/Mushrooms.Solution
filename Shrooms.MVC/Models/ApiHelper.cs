using System.Threading.Tasks;
using RestSharp;

namespace Shrooms.Models
{
    class ApiHelper
    {
        public static async Task<string> ApiCallIndex()
        {
            RestClient client = new RestClient("http://localhost5000/api/mushrooms");
            RestRequest request = new RestRequest(Method.GET);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }
    }
}