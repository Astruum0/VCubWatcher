using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http;

namespace VCubWatcher.Models
{
    public class StationList
    {
        public List<Station> ListOfStations { get; set; }
        public static readonly HttpClient client = new HttpClient();
        public static async Task<List<Station>> ApiCall() {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var streamTask = client.GetStreamAsync("https://api.alexandredubois.com/vcub-backend/vcub.php");
            var stations = await JsonSerializer.DeserializeAsync<List<Station>>(await streamTask);
            return stations;
        }

        public async Task fetchData() {
            ListOfStations = await StationList.ApiCall();
        }

    }
}