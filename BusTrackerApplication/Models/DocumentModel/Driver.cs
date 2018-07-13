using Newtonsoft.Json;

namespace BusTrackerApplication.Models.DocumentModel
{
    public class Driver
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Phone")]
        public string Phone { get; set; }
    }
}