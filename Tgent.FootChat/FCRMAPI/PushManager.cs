using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Core;
using Tgnet.FootChat.FCRMAPI.Models;
using Tgnet.FootChat.FCRMAPI.Request;

namespace Tgnet.FootChat.FCRMAPI
{
    public interface IPushManager
    {
        /// <summary>
        /// 发布单条足迹(第一次审核的时候推送)
        /// </summary>
        /// <param name="request"></param>
        void PublisSingleFootPrint(PushFootPrintRequest request, bool transmitToMQ = false);
        /// <summary>
        /// 修改绑定的项目id
        /// </summary>
        /// <param name="fid"></param>
        /// <param name="pid"></param>
        void UpdateFootPrintProj(long fid, long pid, bool transmitToMQ = false);
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="Mobile"></param>
        void AddUser(long uid, string Mobile, bool transmitToMQ = false);
        /// <summary>
        /// 手机号绑定uid
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="uid"></param>
        void BindUid(string mobile, long uid, bool transmitToMQ = false);
        /// <summary>
        /// 添加足迹查看记录
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="fid"></param>
        void ViewFootPrint(long uid, long fid, bool transmitToMQ = false);
        
        /// <summary>
        /// 收藏项目
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="fid"></param>
        /// <param name="fid"></param>
        /// <param name="scoreUser">收藏加分</param>
        void CollectProj(long uid, long pid, int scoreUser = 0, bool transmitToMQ = false);

        /// <summary>
        /// 取消项目收藏
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="fid"></param>
        /// /// <param name="scoreUser">取消收藏减分</param>
        void CancelCollectProj(long uid, long pid, int scoreUser = 0, bool transmitToMQ = false);

        /// <summary>
        /// 构建通讯录
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="mobile"></param>
        /// <param name="contacts"></param>
        void GenContact(long uid, string mobile, Contact[] contacts, bool transmitToMQ = false);
        /// <summary>
        /// 拉黑好友
        /// </summary>
        /// <param name="uid">发起人</param>
        /// <param name="beblockUid">被拉黑人</param>
        void Block(long uid, long beblockUid, bool transmitToMQ = false);

        /// <summary>
        /// 取消拉黑
        /// </summary>
        /// <param name="uid">发起人</param>
        /// <param name="beblockUid">被拉黑人</param>
        void CancelBlock(long uid, long beblockUid, bool transmitToMQ = false);

        /// <summary>
        /// 设置对接人关系
        /// </summary>
        /// <param name="fromUid">发起人</param>
        /// <param name="tagetUid">目标用户</param>
        void SetDocking(long fromUid, long tagetUid, bool transmitToMQ = false);

        /// <summary>
        /// 添加点击足迹联系人电话记录
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="fid"></param>
        void CallFootPoint(long uid, long fid, bool transmitToMQ = false);

        /// <summary>
        /// 添加点击足迹留言记录
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="fid"></param>
        void MessageFootPoint(long uid, long fid, bool transmitToMQ = false);

        /// <summary>
        /// 修改用户手机号
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="mobile"></param>
        void UpdateFootUserMobile(long uid, string mobile, bool transmitToMQ = false);

        /// <summary>
        /// 删除足迹
        /// </summary>
        /// <param name="fid"></param>
        /// <param name="transmitToMQ"></param>
        void DeleteFootPrint(long fid, bool transmitToMQ = false);

        void TouristViewFootPrint(string deviceId, long fid, bool transmitToMQ = false);
        /// <summary>
        /// 添加查看多条足迹查看记录
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="fids"></param>
        /// <param name="transmitToMQ"></param>
        void ViewFootPrints(long uid, long[] fids, bool transmitToMQ = false);
        /// <summary>
        /// 添加游客查看多条足迹记录
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="fids"></param>
        /// <param name="transmitToMQ"></param>
        void TouristViewFootPrints(string deviceId, long[] fids, bool transmitToMQ = false);
    }
    public class PushManager : IPushManager
    {
        private const string nosqlHost = " Http://api.neo4j.tgnet.com";
        public void BindUid(string mobile, long uid, bool transmitToMQ = false)
        {
            try
            {
                ExceptionHelper.ThrowIfTrue(uid <= 0, nameof(uid));
                ExceptionHelper.ThrowIfNullOrWhiteSpace(mobile, nameof(mobile));
                var body = new NameValueCollection();
                body.Add("mobile", mobile);
                body.Add("uid", uid.ToString());
                var url = nosqlHost + "/api/FootUser/BindFootUserMobile";
                if (transmitToMQ)
                {
                    RequstUtility.TransmitToMQ(url, null, body);
                }
                else
                {
                    var grab = new Tgnet.Web.HttpRequestGrab();
                    var responseJson = grab.GetContent(url, body, null, Web.HttpRequestGrab.Method.POST);
                    var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Tgnet.Core.Api.Result>(responseJson);
                    if (response.state_code != Tgnet.Core.Api.ErrorCode.None.Code)
                        throw new Tgnet.Core.Api.ExceptionWithErrorCode(new Tgnet.Core.Api.ErrorCode(response.state_code, response.message));
                }

            }
            catch (System.Exception e)
            {
                var title = string.Format("BindUid绑定用户推送图数据库{0}", transmitToMQ ? ",By MQ" : "");
                Tgnet.Core.Log.LoggerResolver.Current.Debug(title, e.Message);
                Tgnet.Core.Log.LoggerResolver.Current.Fail(title, e);
            }

        }
        public void AddUser(long uid, string Mobile, bool transmitToMQ = false)
        {
            try
            {
                ExceptionHelper.ThrowIfTrue(uid <= 0, nameof(uid));
                var request = new
                {
                    uid = uid,
                    mobile = Mobile
                };
                var content = Newtonsoft.Json.JsonConvert.SerializeObject(request);
                var url = nosqlHost + "/api/FootUser/GenUser";
                if (transmitToMQ)
                {
                    RequstUtility.TransmitToMQByJson(url, null, content);
                }
                else
                {
                    var grab = new Tgnet.Web.HttpRequestGrab();
                    grab.ContentType = RequestContentType.Application_Json;
                    var responseJson = grab.GetContent(url, null, null, Web.HttpRequestGrab.Method.POST, content);
                    var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Tgnet.Core.Api.Result>(responseJson);
                    if (response.state_code != Tgnet.Core.Api.ErrorCode.None.Code)
                        throw new Tgnet.Core.Api.ExceptionWithErrorCode(new Tgnet.Core.Api.ErrorCode(response.state_code, response.message));
                }

            }
            catch (System.Exception e)
            {
                var title = string.Format("新增用户推送图数据库{0}", transmitToMQ ? ",By MQ" : "");
                Tgnet.Core.Log.LoggerResolver.Current.Debug(title, e.Message);
                Tgnet.Core.Log.LoggerResolver.Current.Fail(title, e);
            }
        }

        public void PublisSingleFootPrint(PushFootPrintRequest request, bool transmitToMQ = false)
        {
            try
            {
                request.CheckPropertyIsVaild();
                var body = RequstUtility.GetNameValueCollection(request);
                var url = nosqlHost + "/api/FootPoint/PublishSingleFootPoint";
                if (transmitToMQ)
                {
                    RequstUtility.TransmitToMQ(url, null, body);
                }
                else
                {
                    var grab = new Tgnet.Web.HttpRequestGrab();
                    var responseJson = grab.GetContent(url, body, null, Web.HttpRequestGrab.Method.POST);
                    var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Tgnet.Core.Api.Result>(responseJson);
                    if (response.state_code != Tgnet.Core.Api.ErrorCode.None.Code)
                        throw new Tgnet.Core.Api.ExceptionWithErrorCode(new Tgnet.Core.Api.ErrorCode(response.state_code, response.message));
                }
            }
            catch (System.Exception e)
            {
                var title = string.Format("PublisSingleFootPrint添加足迹推送图数据库{0}", transmitToMQ ? ",By MQ" : "");
                Tgnet.Core.Log.LoggerResolver.Current.Debug(title, e.Message);
                Tgnet.Core.Log.LoggerResolver.Current.Fail(title, e);
            }

        }

        public void UpdateFootPrintProj(long fid, long pid, bool transmitToMQ = false)
        {
            try
            {
                ExceptionHelper.ThrowIfTrue(fid <= 0, "fid必须大于0");
                ExceptionHelper.ThrowIfTrue(pid <= 0, "pid必须大于0");
                var bodyParm = new
                {
                    fid = fid,
                    pid = pid
                };
                var body = RequstUtility.GetNameValueCollection(bodyParm);
                var url = nosqlHost + "/api/FootPoint/SetFootPointProjectId";
                if (transmitToMQ)
                {
                    RequstUtility.TransmitToMQ(url, null, body);
                }
                else
                {
                    var grab = new Tgnet.Web.HttpRequestGrab();
                    var responseJson = grab.GetContent(url, body, null, Web.HttpRequestGrab.Method.POST);
                    var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Tgnet.Core.Api.Result>(responseJson);
                    if (response.state_code != Tgnet.Core.Api.ErrorCode.None.Code)
                        throw new Tgnet.Core.Api.ExceptionWithErrorCode(new Tgnet.Core.Api.ErrorCode(response.state_code, response.message));
                }
            }
            catch (System.Exception e)
            {
                var title = string.Format("UpdateFootPrintProj修改足迹绑定的项目推送图数据库{0}", transmitToMQ ? ",By MQ" : "");
                Tgnet.Core.Log.LoggerResolver.Current.Debug(title, e.Message);
                Tgnet.Core.Log.LoggerResolver.Current.Fail(title, e);
            }

        }

        public void ViewFootPrint(long uid, long fid, bool transmitToMQ = false)
        {
            try
            {
                ExceptionHelper.ThrowIfTrue(fid <= 0, "pid必须大于0");
                ExceptionHelper.ThrowIfTrue(uid <= 0, "uid必须大于0");
                var bodyParams = new
                {
                    uid = uid,
                    fid = fid
                };
                var body = RequstUtility.GetNameValueCollection(bodyParams);
                var url = nosqlHost + "/api/FootUser/ViewFootPoint";
                if (transmitToMQ)
                {
                    RequstUtility.TransmitToMQ(url, null, body);
                }
                else
                {
                    var grab = new Tgnet.Web.HttpRequestGrab();
                    var responseJson = grab.GetContent(url, body, null, Web.HttpRequestGrab.Method.POST);
                    var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Tgnet.Core.Api.Result>(responseJson);
                    if (response.state_code != Tgnet.Core.Api.ErrorCode.None.Code)
                        throw new Tgnet.Core.Api.ExceptionWithErrorCode(new Tgnet.Core.Api.ErrorCode(response.state_code, response.message));
                }
            }
            catch (System.Exception e)
            {
                var title = string.Format("ViewFootPrint添加足迹查看记录推送图数据库{0}", transmitToMQ ? ",By MQ" : "");
                Tgnet.Core.Log.LoggerResolver.Current.Debug(title, e.Message);
                Tgnet.Core.Log.LoggerResolver.Current.Fail(title, e);
            }

        }

        public void CollectProj(long uid, long pid, int scoreUser = 0, bool transmitToMQ = false)
        {
            try
            {
                ExceptionHelper.ThrowIfTrue(pid <= 0, "pid必须大于0");
                ExceptionHelper.ThrowIfTrue(uid <= 0, "uid必须大于0");
                var bodyParams = new
                {
                    uid = uid,
                    pid = pid,
                    scoreUser = scoreUser
                };
                var body = RequstUtility.GetNameValueCollection(bodyParams);
                var url = nosqlHost + "/api/FootUser/CollectProject";
                if (transmitToMQ)
                { 
                    RequstUtility.TransmitToMQ(url, null, body);
                }
                else
                {
                    var grab = new Tgnet.Web.HttpRequestGrab();
                    var responseJson = grab.GetContent(url, body, null, Web.HttpRequestGrab.Method.POST);
                    var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Tgnet.Core.Api.Result>(responseJson);
                    if (response.state_code != Tgnet.Core.Api.ErrorCode.None.Code)
                        throw new Tgnet.Core.Api.ExceptionWithErrorCode(new Tgnet.Core.Api.ErrorCode(response.state_code, response.message));
                }
            }
            catch (System.Exception e)
            {
                var title = string.Format("CollectFootPoint添加足迹收藏推送图数据库{0}", transmitToMQ ? ",By MQ" : "");
                Tgnet.Core.Log.LoggerResolver.Current.Debug(title, e.Message);
                Tgnet.Core.Log.LoggerResolver.Current.Fail(title, e);
            }

        }


        public void GenContact(long uid, string mobile, Contact[] contacts, bool transmitToMQ = false)
        {
            try
            {
                ExceptionHelper.ThrowIfTrue(uid <= 0, nameof(uid));
                ExceptionHelper.ThrowIfNull(contacts, nameof(contacts));
                if (contacts.Length == 0) return;
                var request = new
                {
                    user = new
                    {
                        uid = uid,
                        mobile = mobile
                    },
                    contacts = contacts
                };
                var content = Newtonsoft.Json.JsonConvert.SerializeObject(request);
                var url = nosqlHost + "/api/FootUser/GenContact";
                if (transmitToMQ)
                {
                    RequstUtility.TransmitToMQByJson(url, null, content);
                }
                else
                {
                    var grab = new Tgnet.Web.HttpRequestGrab();
                    grab.ContentType = RequestContentType.Application_Json;
                    var responseJson = grab.GetContent(url, null, null, Web.HttpRequestGrab.Method.POST, content);
                    var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Tgnet.Core.Api.Result>(responseJson);
                    if (response.state_code != Tgnet.Core.Api.ErrorCode.None.Code)
                        throw new Tgnet.Core.Api.ExceptionWithErrorCode(new Tgnet.Core.Api.ErrorCode(response.state_code, response.message));
                }

            }
            catch (System.Exception e)
            {
                var title = string.Format("GenRelatContact添加好友关系推送图数据库{0}", transmitToMQ ? ",By MQ" : "");
                Tgnet.Core.Log.LoggerResolver.Current.Debug(title, e.Message);
                Tgnet.Core.Log.LoggerResolver.Current.Fail(title, e);
            }

        }

        public void Block(long uid, long beblockUid, bool transmitToMQ = false)
        {
            try
            {
                ExceptionHelper.ThrowIfTrue(uid <= 0, nameof(uid));
                ExceptionHelper.ThrowIfTrue(beblockUid <= 0 || uid == beblockUid, nameof(beblockUid));
                var requst = new
                {
                    fromUid = uid,
                    tarUid = beblockUid
                };

                var body = RequstUtility.GetNameValueCollection(requst);
                var url = nosqlHost + "/api/FootUser/Block";
                if (transmitToMQ)
                {
                    RequstUtility.TransmitToMQ(url, null, body);
                }
                else
                {
                    var grab = new Tgnet.Web.HttpRequestGrab();
                    var responseJson = grab.GetContent(url, body, null, Web.HttpRequestGrab.Method.POST);
                    var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Tgnet.Core.Api.Result>(responseJson);
                    if (response.state_code != Tgnet.Core.Api.ErrorCode.None.Code)
                        throw new Tgnet.Core.Api.ExceptionWithErrorCode(new Tgnet.Core.Api.ErrorCode(response.state_code, response.message));

                }
            }
            catch (System.Exception e)
            {
                var title = string.Format("Block拉黑推送图数据库{0}", transmitToMQ ? ",By MQ" : "");
                Tgnet.Core.Log.LoggerResolver.Current.Debug(title, e.Message);
                Tgnet.Core.Log.LoggerResolver.Current.Fail(title, e);
            }

        }

        public void CancelBlock(long uid, long beblockUid, bool transmitToMQ = false)
        {
            try
            {
                ExceptionHelper.ThrowIfTrue(uid <= 0, nameof(uid));
                ExceptionHelper.ThrowIfTrue(beblockUid <= 0 || uid == beblockUid, nameof(beblockUid));
                var requst = new
                {
                    fromUid = uid,
                    tarUid = beblockUid
                };

                var body = RequstUtility.GetNameValueCollection(requst);
                var url = nosqlHost + "/api/FootUser/CancelBlock";
                if (transmitToMQ)
                {
                    RequstUtility.TransmitToMQ(url, null, body);
                }
                else
                {
                    var grab = new Tgnet.Web.HttpRequestGrab();
                    var responseJson = grab.GetContent(url, body, null, Web.HttpRequestGrab.Method.POST);
                    var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Tgnet.Core.Api.Result>(responseJson);
                    if (response.state_code != Tgnet.Core.Api.ErrorCode.None.Code)
                        throw new Tgnet.Core.Api.ExceptionWithErrorCode(new Tgnet.Core.Api.ErrorCode(response.state_code, response.message));

                }
            }
            catch (System.Exception e)
            {
                var title = string.Format("CancelBlock取消拉黑推送图数据库{0}", transmitToMQ ? ",By MQ" : "");
                Tgnet.Core.Log.LoggerResolver.Current.Debug(title, e.Message);
                Tgnet.Core.Log.LoggerResolver.Current.Fail(title, e);
            }

        }

        public void SetDocking(long fromUid, long tagetUid, bool transmitToMQ = false)
        {
            try
            {
                ExceptionHelper.ThrowIfTrue(fromUid <= 0, nameof(fromUid));
                ExceptionHelper.ThrowIfTrue(tagetUid <= 0 || fromUid == tagetUid, nameof(tagetUid));
                var requst = new
                {
                    fromUid = fromUid,
                    tarUid = tagetUid
                };

                var body = RequstUtility.GetNameValueCollection(requst);
                var url = nosqlHost + "/api/FootUser/SetDocking";
                if (transmitToMQ)
                {
                    RequstUtility.TransmitToMQ(url, null, body);
                }
                else
                {
                    var grab = new Tgnet.Web.HttpRequestGrab();
                    var responseJson = grab.GetContent(url, body, null, Web.HttpRequestGrab.Method.POST);
                    var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Tgnet.Core.Api.Result>(responseJson);
                    if (response.state_code != Tgnet.Core.Api.ErrorCode.None.Code)
                        throw new Tgnet.Core.Api.ExceptionWithErrorCode(new Tgnet.Core.Api.ErrorCode(response.state_code, response.message));
                }
            }
            catch (System.Exception e)
            {
                var title = string.Format("SetDocking设置对接关系拉黑推送图数据库{0}", transmitToMQ ? ",By MQ" : "");
                Tgnet.Core.Log.LoggerResolver.Current.Debug(title, e.Message);
                Tgnet.Core.Log.LoggerResolver.Current.Fail(title, e);
            }

        }

        public void CallFootPoint(long uid, long fid, bool transmitToMQ = false)
        {
            try
            {
                ExceptionHelper.ThrowIfTrue(uid <= 0, nameof(uid));
                ExceptionHelper.ThrowIfTrue(fid <= 0, nameof(fid));
                var requst = new
                {
                    uid,
                    fid,
                };

                var body = RequstUtility.GetNameValueCollection(requst);
                var url = nosqlHost + "/api/FootUser/CallFootPoint";
                if (transmitToMQ)
                {
                    RequstUtility.TransmitToMQ(url, null, body);
                }
                else
                {
                    var grab = new Tgnet.Web.HttpRequestGrab();
                    var responseJson = grab.GetContent(url, body, null, Web.HttpRequestGrab.Method.POST);
                    var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Tgnet.Core.Api.Result>(responseJson);
                    if (response.state_code != Tgnet.Core.Api.ErrorCode.None.Code)
                        throw new Tgnet.Core.Api.ExceptionWithErrorCode(new Tgnet.Core.Api.ErrorCode(response.state_code, response.message));
                }
            }
            catch (System.Exception e)
            {
                var title = string.Format("CallFootPoint添加足迹打电话记录推送图数据库{0}", transmitToMQ ? ",By MQ" : "");
                Tgnet.Core.Log.LoggerResolver.Current.Debug(title, e.Message);
                Tgnet.Core.Log.LoggerResolver.Current.Fail(title, e);
            }

        }
        public void MessageFootPoint(long uid, long fid, bool transmitToMQ = false)
        {
            try
            {
                ExceptionHelper.ThrowIfTrue(uid <= 0, nameof(uid));
                ExceptionHelper.ThrowIfTrue(fid <= 0, nameof(fid));
                var requst = new
                {
                    uid,
                    fid,
                };

                var body = RequstUtility.GetNameValueCollection(requst);
                var url = nosqlHost + "/api/FootUser/MessageFootPoint";
                if (transmitToMQ)
                {
                    RequstUtility.TransmitToMQ(url, null, body);
                }
                else
                {
                    var grab = new Tgnet.Web.HttpRequestGrab();
                    var responseJson = grab.GetContent(url, body, null, Web.HttpRequestGrab.Method.POST);
                    var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Tgnet.Core.Api.Result>(responseJson);
                    if (response.state_code != Tgnet.Core.Api.ErrorCode.None.Code)
                        throw new Tgnet.Core.Api.ExceptionWithErrorCode(new Tgnet.Core.Api.ErrorCode(response.state_code, response.message));
                }
            }
            catch (System.Exception e)
            {
                var title = string.Format("MessageFootPoint添加足迹发信息记录推送图数据库{0}", transmitToMQ ? ",By MQ" : "");
                Tgnet.Core.Log.LoggerResolver.Current.Debug(title, e.Message);
                Tgnet.Core.Log.LoggerResolver.Current.Fail(title, e);
            }

        }


        public void UpdateFootUserMobile(long uid, string mobile, bool transmitToMQ = false)
        {
            try
            {
                ExceptionHelper.ThrowIfTrue(uid <= 0, nameof(uid));
                ExceptionHelper.ThrowIfNullOrWhiteSpace(mobile, nameof(mobile));
                var requst = new
                {
                    uid,
                    mobile,
                };

                var body = RequstUtility.GetNameValueCollection(requst);
                var url = nosqlHost + "/api/FootUser/SetFootUserMobile";
                if (transmitToMQ)
                {
                    RequstUtility.TransmitToMQ(url, null, body);
                }
                else
                {
                    var grab = new Tgnet.Web.HttpRequestGrab();
                    var responseJson = grab.GetContent(url, body, null, Web.HttpRequestGrab.Method.POST);
                    var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Tgnet.Core.Api.Result>(responseJson);
                    if (response.state_code != Tgnet.Core.Api.ErrorCode.None.Code)
                        throw new Tgnet.Core.Api.ExceptionWithErrorCode(new Tgnet.Core.Api.ErrorCode(response.state_code, response.message));
                }

            }
            catch (System.Exception e)
            {
                var title = string.Format("UpdateFootUserMobile修改手机号推送图数据库{0}", transmitToMQ ? ",By MQ" : "");
                Tgnet.Core.Log.LoggerResolver.Current.Debug(title, e.Message);
                Tgnet.Core.Log.LoggerResolver.Current.Fail(title, e);
            }
        }

        public void CancelCollectProj(long uid, long pid, int scoreUser = 0, bool transmitToMQ = false)
        {
            try
            {
                ExceptionHelper.ThrowIfTrue(pid <= 0, "pid必须大于0");
                ExceptionHelper.ThrowIfTrue(uid <= 0, "uid必须大于0");
                var bodyParams = new
                {
                    uid = uid,
                    pid = pid,
                    scoreUser = scoreUser
                };
                var body = RequstUtility.GetNameValueCollection(bodyParams);
                var url = nosqlHost + "/api/FootUser/CancelCollectProject";
                if (transmitToMQ)
                {
                    RequstUtility.TransmitToMQ(url, null, body);
                }
                else
                {
                    var grab = new Tgnet.Web.HttpRequestGrab();
                    var responseJson = grab.GetContent(url, body, null, Web.HttpRequestGrab.Method.POST);
                    var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Tgnet.Core.Api.Result>(responseJson);
                    if (response.state_code != Tgnet.Core.Api.ErrorCode.None.Code)
                        throw new Tgnet.Core.Api.ExceptionWithErrorCode(new Tgnet.Core.Api.ErrorCode(response.state_code, response.message));
                }
            }
            catch (System.Exception e)
            {
                var title = string.Format("CollectFootPoint取消项目收藏推送图数据库{0}", transmitToMQ ? ",By MQ" : "");
                Tgnet.Core.Log.LoggerResolver.Current.Debug(title, e.Message);
                Tgnet.Core.Log.LoggerResolver.Current.Fail(title, e);
            }
        }

        public void DeleteFootPrint(long fid, bool transmitToMQ = false)
        {
            try
            {
                ExceptionHelper.ThrowIfTrue(fid <= 0, "pid必须大于0");
                var bodyParams = new
                {
                    fid = fid,
                };
                var body = RequstUtility.GetNameValueCollection(bodyParams);
                var url = nosqlHost + "/api/FootPoint/DelFootPoint";
                if (transmitToMQ)
                {
                    RequstUtility.TransmitToMQ(url, null, body);
                }
                else
                {
                    var grab = new Tgnet.Web.HttpRequestGrab();
                    var responseJson = grab.GetContent(url, body, null, Web.HttpRequestGrab.Method.POST);
                    var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Tgnet.Core.Api.Result>(responseJson);
                    if (response.state_code != Tgnet.Core.Api.ErrorCode.None.Code)
                        throw new Tgnet.Core.Api.ExceptionWithErrorCode(new Tgnet.Core.Api.ErrorCode(response.state_code, response.message));
                }
            }
            catch (System.Exception e)
            {
                var title = string.Format("DelFootPoint删除足迹推送图数据库{0}", transmitToMQ ? ",By MQ" : "");
                Tgnet.Core.Log.LoggerResolver.Current.Debug(title, e.Message);
                Tgnet.Core.Log.LoggerResolver.Current.Fail(title, e);
            }
        }

        public void TouristViewFootPrint(string deviceId, long fid, bool transmitToMQ = false)
        {
            try
            {
                ExceptionHelper.ThrowIfTrue(fid <= 0, "pid必须大于0");
                ExceptionHelper.ThrowIfNullOrWhiteSpace(deviceId, "deviceId必须大于0");
                var bodyParams = new
                {
                    gid = deviceId,
                    fid = fid
                };
                var body = RequstUtility.GetNameValueCollection(bodyParams);
                var url = nosqlHost + "/api/Guest/ViewFootPoint";
                if (transmitToMQ)
                {
                    RequstUtility.TransmitToMQ(url, null, body);
                }
                else
                {
                    var grab = new Tgnet.Web.HttpRequestGrab();
                    var responseJson = grab.GetContent(url, body, null, Web.HttpRequestGrab.Method.POST);
                    var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Tgnet.Core.Api.Result>(responseJson);
                    if (response.state_code != Tgnet.Core.Api.ErrorCode.None.Code)
                        throw new Tgnet.Core.Api.ExceptionWithErrorCode(new Tgnet.Core.Api.ErrorCode(response.state_code, response.message));
                }
            }
            catch (System.Exception e)
            {
                var title = string.Format("TouristViewFootPrint添加足迹查看记录推送图数据库{0}", transmitToMQ ? ",By MQ" : "");
                Tgnet.Core.Log.LoggerResolver.Current.Debug(title, e.Message);
                Tgnet.Core.Log.LoggerResolver.Current.Fail(title, e);
            }

        }

        public void ViewFootPrints(long uid, long[] fids, bool transmitToMQ = false)
        {
            try
            {
                fids = (fids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
                if (fids.Length == 0) return;
                ExceptionHelper.ThrowIfTrue(uid <= 0, "uid必须大于0");
                var bodyParams = new
                {
                    uid = uid,
                    fids = fids
                };
                var content = Newtonsoft.Json.JsonConvert.SerializeObject(bodyParams);
                var url = nosqlHost + "/api/FootUser/ViewFootPointMultiple";
                if (transmitToMQ)
                {
                    RequstUtility.TransmitToMQByJson(url, null, content);
                }
                else
                {
                    var grab = new Tgnet.Web.HttpRequestGrab();
                    grab.ContentType = RequestContentType.Application_Json;
                    var responseJson = grab.GetContent(url, null, null, Web.HttpRequestGrab.Method.POST, content);
                    var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Tgnet.Core.Api.Result>(responseJson);
                    if (response.state_code != Tgnet.Core.Api.ErrorCode.None.Code)
                        throw new Tgnet.Core.Api.ExceptionWithErrorCode(new Tgnet.Core.Api.ErrorCode(response.state_code, response.message));
                }
            }
            catch (System.Exception e)
            {
                var title = string.Format("ViewFootPrint添加多条足迹查看记录推送图数据库{0}", transmitToMQ ? ",By MQ" : "");
                Tgnet.Core.Log.LoggerResolver.Current.Debug(title, e.Message);
                Tgnet.Core.Log.LoggerResolver.Current.Fail(title, e);
            }
        }

        public void TouristViewFootPrints(string deviceId, long[] fids, bool transmitToMQ = false)
        {
            try
            {
                fids = (fids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
                if (fids.Length == 0) return;
                ExceptionHelper.ThrowIfNullOrWhiteSpace(deviceId, nameof(deviceId));
                var bodyParams = new
                {
                    gid = deviceId,
                    fids = fids
                };
                var content = Newtonsoft.Json.JsonConvert.SerializeObject(bodyParams);
                var url = nosqlHost + "/api/Guest/ViewFootPointMultiple";
                if (transmitToMQ)
                {
                    RequstUtility.TransmitToMQByJson(url, null, content);
                }
                else
                {
                    var grab = new Tgnet.Web.HttpRequestGrab();
                    grab.ContentType = RequestContentType.Application_Json;
                    var responseJson = grab.GetContent(url, null, null, Web.HttpRequestGrab.Method.POST, content);
                    var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Tgnet.Core.Api.Result>(responseJson);
                    if (response.state_code != Tgnet.Core.Api.ErrorCode.None.Code)
                        throw new Tgnet.Core.Api.ExceptionWithErrorCode(new Tgnet.Core.Api.ErrorCode(response.state_code, response.message));
                }
            }
            catch (System.Exception e)
            {
                var title = string.Format("ViewFootPrint添加多条足迹查看记录推送图数据库{0}", transmitToMQ ? ",By MQ" : "");
                Tgnet.Core.Log.LoggerResolver.Current.Debug(title, e.Message);
                Tgnet.Core.Log.LoggerResolver.Current.Fail(title, e);
            }
        }
    }
}
