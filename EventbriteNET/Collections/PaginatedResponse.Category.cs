using Newtonsoft.Json;
using System.Collections.Generic;

namespace EventbriteHelper.Collections
{
    public partial class PaginatedResponse<T> : IPaginatedResponse<T> where T : EventbriteObject
    {
        [JsonProperty("categories")]
        public IList<Category> Categories { get; set; }
    }
}
