using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace cs_working_with_apis.SchipholAirportAPI
{
    internal class Flight
    {
        [JsonPropertyName("flightName")]
        public string FlightName { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("scheduledDate")]
        public string ScheduledDate { get; set; }
        [JsonPropertyName("terminal")]
        public int Terminal { get; set; }
        [JsonPropertyName("actualLandingTime")]
        public string ActualLandingTime { get; set; }
        //aircraftType
        //route
    }
}
