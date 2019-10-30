using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;

namespace Shrooms.Models
{
    public class Mushroom
    {
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

        public static List<Mushroom> MushroomList()
        {
            var apiCallTask = ApiHelper.ApiCallIndex();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Mushroom> mushrooms = JsonConvert.DeserializeObject<List<Mushroom>>(jsonResponse.ToString());

            return mushrooms;
        }        
        public static Mushroom MushroomDetails(int id)
        {
            var apiCallTask = ApiHelper.ApiCallDetails(id);
            var result = apiCallTask.Result;

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            Mushroom mushroom = JsonConvert.DeserializeObject<Mushroom>(jsonResponse.ToString());
            Console.WriteLine("mushroomDetails", mushroom.Name);

            return mushroom;
        }

    }
}