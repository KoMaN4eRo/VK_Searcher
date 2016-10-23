using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VkSearcher.JsonModel.UsersLike
{
    public class LikesData
    {
        [JsonProperty("response")]
        public List<Like> like { get; set; }
    }
}