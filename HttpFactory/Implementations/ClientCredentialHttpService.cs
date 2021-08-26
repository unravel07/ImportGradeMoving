using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using HttpFactory.Abstractions;

namespace HttpFactory.Implementations
{
    public class ClientCredentialHttpService : AbstractHttpService
    {
        private int _timeout = 1;
        private string clientId;
        private string clientSecret;




        public ClientCredentialHttpService(string clientId, string clientSecret, int timeout)
        {
            this.clientId = clientId;
            this.clientSecret = clientSecret;
            _timeout = timeout;
            headers = new Dictionary<string, string>();
            StatusCode = HttpStatusCode.NotFound;
        }
        public ClientCredentialHttpService()
        {
            headers = new Dictionary<string, string>();
        }
        public void AddHeader(string key, string value)
        {
            this.headers.Add(key, value);
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

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.Timeout = TimeSpan.FromMinutes(1);

                client.DefaultRequestHeaders.Add("client_id", clientId);
                client.DefaultRequestHeaders.Add("client_secret", clientSecret);

                if (headers.Count > 0)
                {
                    foreach ( var header in headers)
                    {
                        client.DefaultRequestHeaders.Add(header.Key, header.Value);
                    }
                }
                
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                //append 2020-05-14 collect log
                ReqHeaderHttp = client.DefaultRequestHeaders;
                ReqData = "";
                HttpMethod = "SendHttpGet";
                DateReqHttp = DateTime.Now;

                var result = client.GetAsync(url).Result;
                var contentResult = result.Content.ReadAsStringAsync().Result;
                if (result != null)
                {
                    ResHeaderHttp = result.Content.Headers;
                }
                ResData = contentResult + "";
                return contentResult;
            }
        }
        public override string SendHttpPost(string url, string body)
        {
            clearHttpLog();
            APIEndpoint = url;
           
            using (var client = new HttpClient())
            {
                ReturnMessage = "";
                client.DefaultRequestHeaders.Accept.Clear();
                client.Timeout = TimeSpan.FromMinutes(1);

                client.DefaultRequestHeaders.Add("client_id", clientId);
                client.DefaultRequestHeaders.Add("client_secret", clientSecret);

     

                if (headers.Count > 0)
                {
                    foreach ( var header in headers)
                    {
                        client.DefaultRequestHeaders.Add(header.Key, header.Value);
                    }
                }

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
             
                var content = new StringContent(body, Encoding.UTF8, "application/json");

                //append 2020-05-14 collect log
                ReqHeaderHttp = client.DefaultRequestHeaders;
                ReqData = body + "";
                DateReqHttp = DateTime.Now;


                var result = client.PostAsync(url, content).Result;
                
                
                //2020-05-14 collect log
                DateResHttp = DateTime.Now;
                
                try
                {
                   //append on 2020-05-12
                   if(result != null)
                    {
                        StatusCode = result.StatusCode;
                    }
                    if( result.Content != null)
                    {
                        ResHeaderHttp = result.Content.Headers;
                    }
                }
                catch (Exception ex)
                {
                    InfoTmp =  "" + ex.Message;
                    ReturnMessage = InfoTmp;
                }  
      

                var contentResult = result.Content.ReadAsStringAsync().Result;
                if (result != null)
                {
                    ResHeaderHttp = result.Content.Headers;
                }
                ResData = contentResult + "";
                return contentResult;
            }
        }
        public override string SendHttpPut(string url, string body)
        {
            clearHttpLog();
            APIEndpoint = url;

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.Timeout = TimeSpan.FromMinutes(1);

                client.DefaultRequestHeaders.Add("client_id", clientId);
                client.DefaultRequestHeaders.Add("client_secret", clientSecret);

                if (headers.Count > 0)
                {
                    foreach ( var header in headers)
                    {
                        client.DefaultRequestHeaders.Add(header.Key, header.Value);
                    }
                }

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var content = new StringContent(body, Encoding.UTF8, "application/json");

                //append 2020-05-14 collect log
                ReqHeaderHttp = client.DefaultRequestHeaders;
                ReqData = body + "";
                HttpMethod = "SendHttpPut";
                DateReqHttp = DateTime.Now;

                var result = client.PutAsync(url, content).Result;
                var contentResult = result.Content.ReadAsStringAsync().Result;


                if(result != null)
                {
                    ResHeaderHttp =  result.Content.Headers;
                }
                ResData = contentResult + "";
                return contentResult;
            }
        }
        public override string SendHttpPatch(string url, string body)
        {
            clearHttpLog();
            APIEndpoint = url;

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.Timeout = TimeSpan.FromMinutes(1);

                client.DefaultRequestHeaders.Add("client_id", clientId);
                client.DefaultRequestHeaders.Add("client_secret", clientSecret);

                if (headers.Count > 0)
                {
                    foreach ( var header in headers)
                    {
                        client.DefaultRequestHeaders.Add(header.Key, header.Value);
                    }
                }

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var content = new StringContent(body, Encoding.UTF8, "application/json");

                //append 2020-05-14 collect log
                ReqHeaderHttp = client.DefaultRequestHeaders;
                ReqData = body + "";
                HttpMethod = "SendHttpPatch";
                DateReqHttp = DateTime.Now;

                var result = client.PatchAsync(url, content).Result;
                var contentResult = result.Content.ReadAsStringAsync().Result;


                if(result != null)
                {
                    ResHeaderHttp =  result.Content.Headers;
                }
                ResData = contentResult + "";
                return contentResult;
            }
        }
    }
}