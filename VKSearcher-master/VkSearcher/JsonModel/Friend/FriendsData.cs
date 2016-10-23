using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VkSearcher.JsonModel
{
    //[JsonObject]
    public class FriendsData
    {
        [JsonProperty("response")]
        public Friend friend { get; set; }
    }
}