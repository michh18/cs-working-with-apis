using cs_working_with_apis.FakerBookAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace cs_working_with_apis.SchipholAirportAPI
{
    internal class SchipholAirport
    {
        private static readonly string BASE_URL = "https://api.schiphol.nl/public-flights/flights";
        private static readonly string ResourceVersion = "v4";
        private static readonly string Accept = "application/json";

        public static async Task<FlightsResponse?> GetFlightsAsync(string id)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string url = $"{BASE_URL}/{id}";

                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    //if (!string.IsNullOrEmpty(responseBody))
                    //{
                    //    return JsonSerializer.Deserialize<FlightsResponse>(responseBody);
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Could not be deserialized");
                    //    return null;
                    //}
                    Console.WriteLine(responseBody);

                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request error:{e.Message}");
                }
                return null;
            }
        }
    }
}
