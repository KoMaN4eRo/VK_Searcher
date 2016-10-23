using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using VkSearcher.Code;
using VkSearcher.JsonModel;

namespace VkSearcher.Controllers
{
    public class UserController : ApiController
    {
        private VkUserInfo vkUserInf;
        private LikeInfo likeInformation;
        public Dictionary<string, User> usersLike;
        public Dictionary<string, bool> likesInfo;
        public Dictionary<string, List<User>> tempDict;
        public List<User> tempList;
        private static System.Timers.Timer aTimer;
        private AutoResetEvent autoEvent;

        protected override void Initialize(HttpControllerContext requestContext)
        {
            vkUserInf = new VkUserInfo();
            likeInformation = new LikeInfo();
            usersLike = new Dictionary<string, User>();
            likesInfo = new Dictionary<string, bool>();
            tempDict = new Dictionary<string, List<User>>();
            tempList = new List<User>();
            autoEvent = new AutoResetEvent(false);
            base.Initialize(requestContext);
        }

        public IEnumerable<string> Get()
        {
            return new string[] { "user1", "user2" };
        }

        public string Get(int id)
        {
            return "user_id";
        }

        public void Post([FromBody]string value)
        {
        }

        public void Put(int id, [FromBody]string value)
        {
        }

        public void Delete(int id)
        {
        }
    }
}
