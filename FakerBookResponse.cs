using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace cs_working_with_apis
{
    public class FakerBookResponse
    {
        [JsonPropertyName("status")]
        public string Status { get; set; } = "OK";
        [JsonPropertyName("data")]
        public List<Book> Data { get; set; } = new List<Book>();

    }
}
