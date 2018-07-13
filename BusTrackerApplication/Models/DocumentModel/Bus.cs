using Newtonsoft.Json;

namespace BusTrackerApplication.Models.DocumentModel
{
    public class Bus
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("route")]
        public string Route { get; set; }
        [JsonProperty("routedescription")]
        public string RouteDescription { get; set; }
        [JsonProperty("driver")]
        public Driver Driver{ get; set; }
        [JsonProperty("currentlocation")]
        public Location Location { get; set; }
    }
}