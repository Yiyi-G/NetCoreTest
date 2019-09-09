using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Api;
using static Tgnet.Web.HttpRequestGrab;

namespace Tgnet.FootChat.FCRMAPI
{
    public class RequstUtility
    {
        private const string host = "Http://api.neo4j.tgnet.coms";
        public static void TransmitToMQ(string url, NameValueCollection query, NameValueCollection body)
        {
            var grab = new  Tgnet.Web.HttpRequestGrab();
            if (query != null&&query.Count>0)
            {
                url += "?" + string.Join("&", query.AllKeys.Select(p => p + "=" + query[p]));
            }
            var bodyStr = "";
            if(body!=null&&body.Count>0)
                bodyStr = string.Join("&", body.AllKeys.Select(p => p + "=" + body[p]));
            var requestBody = new NameValueCollection();
            requestBody.Add("queue_kind", "1");
            requestBody.Add("handle_url", url);
            requestBody.Add("body", bodyStr);
            var responseJson = grab.GetContent("Http://api.mq.tgnet.com/Api/Send", requestBody, null, Method.POST);
            var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Tgnet.Api.Result>(responseJson);
            if (response.state_code != Tgnet.Api.ErrorCode.None.Code)
                throw new Tgnet.Api.ExceptionWithErrorCode(new Api.ErrorCode(response.state_code, response.message));
        }
        public static void TransmitToMQByJson(string url, NameValueCollection query, string content)
        {
            var grab = new Tgnet.Web.HttpRequestGrab();
            if (query != null && query.Count > 0)
            {
                url += "?" + string.Join("&", query.AllKeys.Select(p => p + "=" + query[p]));
            }
            var requestBody = new NameValueCollection();
            requestBody.Add("queue_kind", "1");
            requestBody.Add("handle_url", url);
            requestBody.Add("body", content);
            requestBody.Add("content_type", RequestContentType.Application_Json);
            var responseJson = grab.GetContent("Http://api.mq.tgnet.com/Api/Send", requestBody, null, Method.POST);
            var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Tgnet.Api.Result>(responseJson);
            if (response.state_code != Tgnet.Api.ErrorCode.None.Code)
                throw new Tgnet.Api.ExceptionWithErrorCode(new Api.ErrorCode(response.state_code, response.message));
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pathname"></param>
        /// <param name="type"></param>
        /// <param name="urlParams"></param>
        /// <param name="bodyParms"></param>
        /// <param name="contentType">
        /// 选择body参数是已键值对传输还是对象传输
        /// </param>
        public static void SendRequst(string pathname, RequstType type, object urlParams = null, object bodyParms = null, ContentType contentType= ContentType.FormUrlEncodedContent)
        {
            Response response;
            var url = host + pathname;
            try
            {
                var urlParamsDic = GetPropertyDic(urlParams);
                var urlParamsCombineStr = "";
                if (urlParamsDic.Any())
                {
                    urlParamsCombineStr += "?";
                    urlParamsCombineStr += string.Join("&", urlParamsDic.Select(p => p.Key + "=" + p.Value));
                }
                if (!string.IsNullOrWhiteSpace(urlParamsCombineStr))
                    url += urlParamsCombineStr;

                switch (type)
                {
                    case RequstType.Post:
                        response = Post(url, bodyParms,contentType);
                        break;
                    case RequstType.Put:
                        response = Put(url, bodyParms, contentType);
                        break;
                    case RequstType.Delete:
                        response = Delete(url);
                        break;
                    default:
                        response = GET(url);
                        break;
                }
            }
            catch (HttpRequestException e)
            {
                Tgnet.Log.LoggerResolver.Current.Error("请求失败", e);
                throw e;
            }
            ExceptionHelper.ThrowIfTrue(response.Code != 0, string.Format("请求API失败!:code is {0},msg is {1}", response.Code, response.Message));
        }
        public static T SendRequst<T>(string pathname, RequstType type, object urlParams = null, object bodyParms = null, ContentType contentType = ContentType.FormUrlEncodedContent)
        {
            Response<T> response;
            var url = host + pathname;
            try
            {
                var urlParamsDic = GetPropertyDic(urlParams);
                var urlParamsCombineStr = "";
                if (urlParamsDic.Any())
                {
                    urlParamsCombineStr += "?";
                    urlParamsCombineStr += string.Join("&", urlParamsDic.Select(p => p.Key + "=" + p.Value));
                }
                if (!string.IsNullOrWhiteSpace(urlParamsCombineStr))
                    url += urlParamsCombineStr;

                switch (type)
                {
                    case RequstType.Post:
                        response =  Post<T>(url, bodyParms,contentType);
                        break;
                    case RequstType.Put:
                        response = Put<T>(url, bodyParms, contentType);
                        break;
                    case RequstType.Delete:
                        response = Delete<T>(url);
                        break;
                    default:
                        response = GET<T>(url);
                        break;
                }
            }
            catch (HttpRequestException e)
            {
                Tgnet.Log.LoggerResolver.Current.Error("请求失败", e);
                throw e;
            }
            ExceptionHelper.ThrowIfTrue(response.Code != 0, string.Format("请求API失败!:code is {0},msg is {1}", response.Code, response.Message));
            return response.Body;
            
        }
        private static Response GET(string url)
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync(url).Result;
            response.EnsureSuccessStatusCode();
            var responseJson = response.Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Response>(responseJson);
        }
        private static Response<T> GET<T>(string url)
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync(url).Result;
            response.EnsureSuccessStatusCode();
            var responseJson = response.Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Response<T>>(responseJson);
        }

        private static Response Post(string url, object bodyParms, ContentType type)
        {
            HttpContent httpContent;
            if (type == ContentType.StringContent && bodyParms != null)
            {
                httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(bodyParms));
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            }
            else
            {
                var bodyParamsDic = GetPropertyDic(bodyParms);
                httpContent = new FormUrlEncodedContent(bodyParamsDic);
            }

            var httpClient = new HttpClient();
            var response = httpClient.PostAsync(url, httpContent).Result;
            response.EnsureSuccessStatusCode();
            var responseJson = response.Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Response>(responseJson);
        }
        private static Response<T> Post<T>(string url, object bodyParms, ContentType type)
        {
            var httpClient = new HttpClient();
            HttpContent httpContent;
            if (type == ContentType.StringContent && bodyParms != null)
            {
                httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(bodyParms));
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("text/json");
            }
            else
            {
                var bodyParamsDic = GetPropertyDic(bodyParms);
                httpContent = new FormUrlEncodedContent(bodyParamsDic);
            }
            var response = httpClient.PostAsync(url, httpContent).Result;
            response.EnsureSuccessStatusCode();
            var responseJson = response.Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Response<T>>(responseJson);
        }
        private static Response Put(string url, object bodyParms, ContentType type)
        {
            var httpClient = new HttpClient();
            HttpContent httpContent;
            if (type == ContentType.StringContent && bodyParms != null)
            {
                httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(bodyParms));
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("text/json");
            }
            else
            {
                var bodyParamsDic = GetPropertyDic(bodyParms);
                httpContent = new FormUrlEncodedContent(bodyParamsDic);
            }
            var response = httpClient.PutAsync(url, httpContent).Result;
            response.EnsureSuccessStatusCode();
            var responseJson = response.Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Response>(responseJson);
        }
        private static Response<T> Put<T>(string url, object bodyParms, ContentType type)
        {
            var httpClient = new HttpClient();
            HttpContent httpContent;
            if (type == ContentType.StringContent && bodyParms != null)
            {
                httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(bodyParms));
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("text/json");
            }
            else
            {
                var bodyParamsDic = GetPropertyDic(bodyParms);
                httpContent = new FormUrlEncodedContent(bodyParamsDic);
            }
            var response = httpClient.PutAsync(url,httpContent).Result;
            response.EnsureSuccessStatusCode();
            var responseJson = response.Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Response<T>>(responseJson);
        }
        private static Response Delete(string url)
        {
            var httpClient = new HttpClient();
            var response = httpClient.DeleteAsync(url).Result;
            response.EnsureSuccessStatusCode();
            var responseJson = response.Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Response>(responseJson);
        }
        private static Response<T> Delete<T>(string url)
        {
            var httpClient = new HttpClient();
            var response = httpClient.DeleteAsync(url).Result;
            response.EnsureSuccessStatusCode();
            var responseJson = response.Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Response<T>>(responseJson);
        }
        private static Dictionary<string, string> GetPropertyDic(object o)
        {
            try
            {
                var data = new Dictionary<string, string>();
                if (o != null)
                {
                    var type = o.GetType();
                    var propertys = type.GetProperties();
                    foreach (var property in propertys)
                    {
                        if (property.MemberType == MemberTypes.Property && property.CanRead)
                        {
                            var value = property.GetValue(o);
                            if (value != null)
                                data.Add(property.Name, value.ToString());
                        }
                    }
                }
                return data;
            }
            catch (Exception e) {
                Tgnet.Log.LoggerResolver.Current.Error("请求参数反射失败", e);
                throw e;
            }
            
        }

        public static NameValueCollection GetNameValueCollection(object o)
        {
            try
            {
                var data = new NameValueCollection();
                if (o != null)
                {
                    var type = o.GetType();
                    var propertys = type.GetProperties();
                    foreach (var property in propertys)
                    {
                        if (property.MemberType == MemberTypes.Property && property.CanRead)
                        {
                            var value = property.GetValue(o);
                            if (value != null)
                                data.Add(property.Name, value.ToString());
                        }
                    }
                }
                return data;
            }
            catch (Exception e)
            {
                Tgnet.Log.LoggerResolver.Current.Error("请求参数反射失败", e);
                throw e;
            }

        }
    }

    public enum ContentType
    {
        /// <summary>
        /// 键值对传输
        /// </summary>
        FormUrlEncodedContent=1,
        /// <summary>
        /// json对象传输
        /// </summary>
        StringContent=2
    }

    public static class RequestContentType
    {
        public const string Application_Json = "application/json";
        public const string Application_x_www_form_urlencoded = "application/x-www-form-urlencoded";
    }
    public enum RequstType
    {
        Get = 1,
        Post = 2,
        Put = 3,
        Delete = 4
    }
}
