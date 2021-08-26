using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using HttpFactory.Abstractions;

namespace HttpFactory.Implementations
{
    public class BasicHttpService : AbstractHttpService
    {
        private int _timeout = 1;

        public BasicHttpService()
        {

        }

        public BasicHttpService(int timeout)
        {
            _timeout = timeout;
        }
        public override string SendHttp(string method, string url, string body)
        {
            switch(method)
            {
                case "GET":
                    return SendHttpGet(url);
                case "PUT":
                    return SendHttpPut(url, body);
                case "POST":
                    return SendHttpPost(url, body);
                case "PATCH":
                    return SendHttpPatch(url, body);
            }
            return "";
        }
        public override string SendHttpGet(string url)
        {
            clearHttpLog();
            APIEndpoint = url;
            string contentResult = "";
            try
            {

                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.Timeout = TimeSpan.FromMinutes(_timeout);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    //append 2020-05-14 collect log
                    ReqHeaderHttp = client.DefaultRequestHeaders;
                    ReqData = "";
                    HttpMethod = "SendHttpGet";
                    DateReqHttp = DateTime.Now;
                    try
                    {
                        var result = client.GetAsync(url).Result;
                        contentResult = result.Content.ReadAsStringAsync().Result;
                        if (result != null)
                        {
                            ResHeaderHttp = result.Content.Headers;
                        }
                    }
                    catch (Exception ex)
                    {
                        string dlog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff");
                        InfoTmp = "" + $"[{dlog}][{ex.Message}]" + $"[{(ex.InnerException != null ? ex.InnerException.Message : "")}]";
                        ReturnMessage = "" + InfoTmp;
                        contentResult = InfoTmp;
                    }
                    ResData = contentResult + "";
                }
            }
            catch (Exception ex)
            {
                string dlog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff");
                InfoTmp = "" + $"[{dlog}][{ex.Message}]" + $"[{(ex.InnerException != null ? ex.InnerException.Message : "")}]";
                ReturnMessage = "" + InfoTmp;
                contentResult = InfoTmp;
                ResData = contentResult + "";
            }
            return contentResult;
        }
        public override string SendHttpPost(string url, string body)
        {
            clearHttpLog();
            string contentResult = "";
            APIEndpoint = url;
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.Timeout = TimeSpan.FromMinutes(this._timeout);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var content = new StringContent(body, Encoding.UTF8, "application/json");
                    if (headers != null)
                    {
                        if (headers.Count > 0)
                        {
                            foreach (var item in headers)
                            {
                                client.DefaultRequestHeaders.Add(item.Key, item.Value);
                            }
                        }
                    }

                    //append 2020-05-14 collect log
                    ReqHeaderHttp = client.DefaultRequestHeaders;
                    ReqData = body;
                    HttpMethod = "SendHttpPost";
                    DateReqHttp = DateTime.Now;
                    HttpResponseMessage result;

                    try
                    {
                        result = client.PostAsync(url, content).Result;
                        contentResult = result.Content.ReadAsStringAsync().Result;
                        if (result != null)
                        {
                            ResHeaderHttp = result.Content.Headers;
                        }
                    }
                    catch (Exception ex)
                    {
                        string dlog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff");
                        InfoTmp = "" + $"[{dlog}][{ex.Message}]" + $"[{(ex.InnerException != null ? ex.InnerException.Message : "")}]";
                        ReturnMessage = "" + InfoTmp;
                        contentResult = InfoTmp;
                    }
                    ResData = contentResult + "";
                }
            }
            catch (Exception ex)
            {
                string dlog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff");
                InfoTmp = "" + $"[{dlog}][{ex.Message}]" + $"[{(ex.InnerException != null ? ex.InnerException.Message : "")}]";
                ReturnMessage = "" + InfoTmp;
                contentResult = InfoTmp;
                ResData = contentResult + "";
            }

            return contentResult;
        }
        public override string SendHttpPut(string url, string body)
        {
            clearHttpLog();
            APIEndpoint = url;
            string contentResult = "";
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.Timeout = TimeSpan.FromMinutes(this._timeout);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var content = new StringContent(body, Encoding.UTF8, "application/json");
                    //append 2020-05-14 collect log
                    ReqHeaderHttp = client.DefaultRequestHeaders;
                    ReqData = body;
                    HttpMethod = "SendHttpPut";
                    DateReqHttp = DateTime.Now;
                    try
                    {
                        var result = client.PutAsync(url, content).Result;
                        contentResult = result.Content.ReadAsStringAsync().Result;
                        if (result != null)
                        {
                            ResHeaderHttp = result.Content.Headers;
                        }
                    }
                    catch (Exception ex)
                    {
                        string dlog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff");
                        InfoTmp = "" + $"[{dlog}][{ex.Message}]" + $"[{(ex.InnerException != null ? ex.InnerException.Message : "")}]";
                        ReturnMessage = "" + InfoTmp;
                        contentResult = InfoTmp;
                    }

                    ResData = contentResult + "";

                }

            }
            catch (Exception ex)
            {
                string dlog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff");
                InfoTmp = "" + $"[{dlog}][{ex.Message}]" + $"[{(ex.InnerException != null ? ex.InnerException.Message : "")}]";
                ReturnMessage = "" + InfoTmp;
                contentResult = InfoTmp;
                ResData = contentResult + "";
            }

            return contentResult;
        }
        public override string SendHttpPatch(string url, string body)
        {
            clearHttpLog();
            APIEndpoint = url;
            string contentResult = "";
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.Timeout = TimeSpan.FromMinutes(this._timeout);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var content = new StringContent(body, Encoding.UTF8, "application/json");
                    //append 2020-05-14 collect log
                    ReqHeaderHttp = client.DefaultRequestHeaders;
                    ReqData = body;
                    HttpMethod = "SendHttpPatch";
                    DateReqHttp = DateTime.Now;
                    try
                    {
                        var result = client.PatchAsync(url, content).Result;
                        contentResult = result.Content.ReadAsStringAsync().Result;
                        if (result != null)
                        {
                            ResHeaderHttp = result.Content.Headers;
                        }
                    }
                    catch (Exception ex)
                    {
                        string dlog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff");
                        InfoTmp = "" + $"[{dlog}][{ex.Message}]" + $"[{(ex.InnerException != null ? ex.InnerException.Message : "")}]";
                        ReturnMessage = "" + InfoTmp;
                        contentResult = InfoTmp;
                    }

                    ResData = contentResult + "";

                }

            }
            catch (Exception ex)
            {
                string dlog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff");
                InfoTmp = "" + $"[{dlog}][{ex.Message}]" + $"[{(ex.InnerException != null ? ex.InnerException.Message : "")}]";
                ReturnMessage = "" + InfoTmp;
                contentResult = InfoTmp;
                ResData = contentResult + "";
            }

            return contentResult;
        }
    }
}