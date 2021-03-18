using System;
using System.Text.Json.Serialization;

namespace VCubWatcher.Models 
{
    public class Station 
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("bike_count")]
        public int BikeCount { get; set; }

        [JsonPropertyName("electric_bike_count")]
        public int ElectricBikeCount { get; set; }

        [JsonPropertyName("bike_count_total")]
        public int BikeCountTotal { get; set; }

        [JsonPropertyName("slot_count")]
        public int SlotCount { get; set; }

        [JsonPropertyName("is_online")]
        public bool IsOnline { get; set; }

        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }
    
    }

}