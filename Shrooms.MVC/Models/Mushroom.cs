using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace Shrooms.Models {
    public class Mushroom {
        public int MushroomId { get; set; }

        public string Name { get; set; }

        public string Family { get; set; }

        public bool Psycho { get; set; }

        public bool Poisonous { get; set; }

        public string Region { get; set; }

        public string SporePrintDetails { get; set; }

        public string VisualDetails { get; set; }

        public int CapDimensions { get; set; }

        public int StemDimensions { get; set; }

        public static List<Mushroom> MushroomListSearch (string search) {
            List<Mushroom> mushrooms;
            if (string.IsNullOrEmpty (search)) {
                var apiCallTask = ApiHelper.ApiCallIndex ();
                var result = apiCallTask.Result;

                JArray jsonResponse = JsonConvert.DeserializeObject<JArray> (result);
                mushrooms = JsonConvert.DeserializeObject<List<Mushroom>> (jsonResponse.ToString ());
            } 
            else {
                var apiCallTask = ApiHelper.ApiCallIndexSearch (search);
                var result = apiCallTask.Result;

                JArray jsonResponse = JsonConvert.DeserializeObject<JArray> (result);
                mushrooms = JsonConvert.DeserializeObject<List<Mushroom>> (jsonResponse.ToString ());
            }
            return mushrooms;
        }

        public static Mushroom MushroomDetails (int id) {
            var apiCallTask = ApiHelper.ApiCallDetails (id);
            var result = apiCallTask.Result;
            JObject jsonResponse = JsonConvert.DeserializeObject<JObject> (result);
            Mushroom mushroom = JsonConvert.DeserializeObject<Mushroom> (jsonResponse.ToString ());
            Console.WriteLine (mushroom);
            return mushroom;
        }

        public async Task<int> MushroomCreate () {
            var result = await ApiHelper.ApiCallCreate (this);
            return 0;
        }

        public async static Task<int> MushroomDelete (int id) {
            Console.WriteLine ($"mushroom delete id = {id}");
            var result = await ApiHelper.ApiCallDelete (id);
            return 0;
        }

        public async static Task<int> MushroomEdit (Mushroom mushroom) {
            var result = await ApiHelper.ApiCallEdit (mushroom);
            return 0;
        }
    }
}