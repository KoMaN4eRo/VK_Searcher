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
    public class GetWallController : ApiController
    {
        private VkUserInfo vkUserInf;
        private LikeInfo likeInformation;
        public Dictionary<string, User> usersLike;
        public Dictionary<string, bool> likesInfo;
        public Dictionary<string, List<User>> tempDict;
        public List<User> tempList;
        private User tempUser;
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
            tempUser = new User();
            autoEvent = new AutoResetEvent(false);
            base.Initialize(requestContext);
        }
       
        // GET: api/GetWall
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: возвращает информацию о лайках targetUser на стену другу или любому другому пользователю
        public List<UserInfo> Get(string friendsId, string targetUserId)
        {
            tempUser.id = friendsId;
            tempList.Add(tempUser);
            var wallDictionary = vkUserInf.GetWallInfo(tempList);
            var likeDictionary = vkUserInf.GetUsesLike_Wall(wallDictionary,targetUserId);

            return likeDictionary;
        }

        // POST: api/GetWall
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/GetWall/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/GetWall/5
        public void Delete(int id)
        {
        }
    }
}
