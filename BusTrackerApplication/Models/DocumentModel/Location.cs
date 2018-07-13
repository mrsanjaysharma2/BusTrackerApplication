using Newtonsoft.Json;
using Microsoft.Azure.Documents.Spatial;

namespace BusTrackerApplication.Models.DocumentModel
{
    public class Location
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("coordinates")]
        public Point Coordinates{ get; set; }
    }
}