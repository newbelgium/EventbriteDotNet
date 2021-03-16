using Newtonsoft.Json;

namespace EventbriteHelper
{
    public class FullDescription
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
