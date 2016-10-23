using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VKS.JsonModel.Video
{
    [JsonObject]
    public class UsersVideo
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("owner_id")]
        public string owner_id { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("duration")]
        public string duration { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("date")]
        public string date { get; set; }

        [JsonProperty("photo_75")]
        public string photo_75 { get; set; }

        [JsonProperty("photo_130")]
        public string photo_130 { get; set; }

        [JsonProperty("photo_320")]
        public string photo_320 { get; set; }

        [JsonProperty("photo_800")]
        public string photo_800 { get; set; }

        [JsonProperty("access_key")]
        public string access_key { get; set; }

    }
}