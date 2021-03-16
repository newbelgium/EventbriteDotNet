using Newtonsoft.Json;

namespace EventbriteNET
{
    public class FullDescription
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
