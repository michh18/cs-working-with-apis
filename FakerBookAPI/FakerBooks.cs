using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace cs_working_with_apis.FakerBookAPI
{
    internal class FakerBooks
    {
        private static readonly string BASE_URL = "https://fakerapi.it/api/v1/books";

        public static async Task<FakerBookResponse?> GetBooksAsync(int quantity)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string url = $"{BASE_URL}?_quantity={quantity}";

                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(responseBody))
                    {
                        return JsonSerializer.Deserialize<FakerBookResponse>(responseBody);
                    }
                    else
                    {
                        Console.WriteLine("Could not be deserialized");
                        return null;
                    }
                    //Console.WriteLine(responseBody);

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
