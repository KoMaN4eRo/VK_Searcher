using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VkSearcher.JsonModel
{   
    [JsonObject]
    public class Friend
    {
            [JsonProperty("count")]
            public string count { get; set; }

            [JsonProperty("items")]
            public List<User> items { get; set; }
    }
}
