using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace cs_working_with_apis
{
    public class Book
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; } = "";
        [JsonPropertyName("author")]
        public string Author { get; set; } = "";
        [JsonPropertyName("genre")]
        public string Genre { get; set; } = "";
        [JsonPropertyName("description")]
        public string Description { get; set; } = "";
    }
}
