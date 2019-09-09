using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.FootChat.FCRMAPI.Models;

namespace Tgnet.FootChat.FCRMAPI
{
    public interface ISearchManager
    {
        /// <summary>
        /// 获取指定条数的推荐足迹
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="limit"></param>
        /// <param name="areaNos"></param>
        /// <returns></returns>
        RecommenedFootPrinModel[] GetRecommedFootPrints(long? uid, int limit, string[] areaNos, long[] exceptFids);
        /// <summary>
        /// 获取游客指定条数的推荐足迹
        /// </summary>
        /// <param name="gid">设备id</param>
        /// <param name="limit"></param>
        /// <param name="areaNos"></param>
        /// <returns></returns>
        RecommenedFootPrinModel[] GetGuestRecommedFootPrints(string gid, int limit, string[] areaNos, long[] exceptFids);
        /// <summary>
        /// 根据id查询某用户的直接好友数和二度好友数
        /// </summary>
        /// <param name="uid"></param>
        UserFriendCountModel GetFriendCountd(long uid);
    }
    public class SearchManager:ISearchManager
    {
        private const string nosqlHost = " Http://api.neo4j.tgnet.com";
        public RecommenedFootPrinModel[] GetRecommedFootPrints(long? uid, int limit, string[] areaNos, long[] exceptFids)
        {
            ExceptionHelper.ThrowIfNotId(uid, nameof(uid));
            RecommenedFootPrinModel[] list = null;
            var requst = new
            {
                uid = uid,
                count = limit,
                areaNos = areaNos,
                filterFids = exceptFids
            };
            var param = Newtonsoft.Json.JsonConvert.SerializeObject(requst);
            var query = RequstUtility.GetNameValueCollection(new { param = param });
            var grab = new Tgnet.Web.HttpRequestGrab();
            var responseJson = grab.GetContent(nosqlHost + "/api/FootPoint/PutFootPoints", query, null, Web.HttpRequestGrab.Method.GET, null);
            var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Tgnet.Api.Result<RecommenedFootPrinResultData>>(responseJson);
            if (response.state_code != Tgnet.Api.ErrorCode.None.Code)
                throw new System.Exception("请求失败");
            list = response.data.Body.FootPointList ?? new RecommenedFootPrinModel[0];
            return list;
        }
        public RecommenedFootPrinModel[] GetGuestRecommedFootPrints(string gid, int limit, string[] areaNos, long[] exceptFids)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(gid, nameof(gid));
            RecommenedFootPrinModel[] list = null;
            var requst = new
            {
                gid = gid,
                count = limit,
                areaNos = areaNos,
                filterFids = exceptFids
            };
            var param = Newtonsoft.Json.JsonConvert.SerializeObject(requst);
            var query = RequstUtility.GetNameValueCollection(new { param = param });
            var grab = new Tgnet.Web.HttpRequestGrab();
            var responseJson = grab.GetContent(nosqlHost + "/api/Guest/PutFootPoints", query, null, Web.HttpRequestGrab.Method.GET, null);
            var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Tgnet.Api.Result<RecommenedFootPrinResultData>>(responseJson);
            if (response.state_code != Tgnet.Api.ErrorCode.None.Code)
                throw new System.Exception("请求失败");
            list = response.data.Body.FootPointList ?? new RecommenedFootPrinModel[0];
            return list;
        }
        public UserFriendCountModel GetFriendCountd(long uid)
        {

            ExceptionHelper.ThrowIfTrue(uid <= 0, nameof(uid));
            var requst = new
            {
                uid,
            };

            var query = RequstUtility.GetNameValueCollection(requst);
            var url = nosqlHost + "/api/FootUser/FriendCount";
            var grab = new Tgnet.Web.HttpRequestGrab();
            var responseJson = grab.GetContent(url, query, null, Web.HttpRequestGrab.Method.GET, null);
            var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Tgnet.Api.Result<UserFriendCountBody>>(responseJson);
            if (response.state_code != Tgnet.Api.ErrorCode.None.Code)
                throw new Tgnet.Api.ExceptionWithErrorCode(new Api.ErrorCode(response.state_code, response.message));
            return response.data.Body;
        }
    }
}
