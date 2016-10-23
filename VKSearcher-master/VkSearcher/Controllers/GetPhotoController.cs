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
using VkSearcher.JsonModel.Photo;
using VkSearcher.JsonModel.Video;

namespace VkSearcher.Controllers
{
    public class GetPhotoController : ApiController//skdjfskladhclaisudhclasdhlfuasdlfhasldiu
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

        // GET: api/GetAlbums
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/GetAlbums/5
        //public List<AlbumInfo> Get(string targetUserId)
        public List<UsersPhoto> Get(string friendsId, string targetUserId)
        {

            var albumInfo = vkUserInf.GetAlbums(targetUserId);
            albumInfo.photoItems.albumInfo.Remove(albumInfo.photoItems.albumInfo[1]);
            albumInfo.photoItems.albumInfo.Remove(albumInfo.photoItems.albumInfo[1]);
            var photoInfo = vkUserInf.GetPhoto(albumInfo, targetUserId);
            var likes = vkUserInf.GetUsesLike_Photo(photoInfo,friendsId, targetUserId);
            return likes;
        }

        // POST: api/GetAlbums
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/GetAlbums/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/GetAlbums/5
        public void Delete(int id)
        {
        }
    }
}
