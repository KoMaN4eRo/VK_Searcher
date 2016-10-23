using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VkSearcher.JsonModel.Audio
{
    [JsonObject]
    public class UsersAudio
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("owner_id")]
        public string owner_id { get; set; }

        [JsonProperty("artist")]
        public string artist { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("duration")]
        public string duration { get; set; }

        [JsonProperty("date")]
        public string date { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("lyrics_id")]
        public string lyrics_id { get; set; }

        [JsonProperty("genre_id")]
        public string genre_id { get; set; }
    }
}