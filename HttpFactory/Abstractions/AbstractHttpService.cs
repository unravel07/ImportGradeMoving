using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Headers;

namespace HttpFactory.Abstractions
{
    public abstract class AbstractHttpService : IHttpLog
    {
        #region Interface Httplog

        #endregion
        #region function
        protected string InfoTmp { get; set; }
        public string APIEndpoint { get; set; }
        public DateTime? DateReqHttp { get; set; }
        public DateTime? DateResHttp { get; set; }
        public HttpRequestHeaders ReqHeaderHttp { get; set; }
        public string HttpMethod { get; set; }
        public string ReqData { get; set; }
        public string ResData { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public HttpContentHeaders ResHeaderHttp { get; set; }
        public Dictionary<string, string> headers { get; set; }
        public string ReturnMessage { get; set; }

        public IHttpLog getLog()
        {
            IHttpLog output = null;
            try
            {
                output = this;

            }
            catch (Exception ex)
            {
                InfoTmp = "" + ex.Message;
            }

            return output;
        }
        protected void clearHttpLog()
        {
            try
            {
                this.APIEndpoint = ""; // 
                this.DateReqHttp = null; // 
                this.DateResHttp = null; // 
                this.ReqHeaderHttp = null; // 
                this.ReqData = ""; // 
                this.ResHeaderHttp = null; // 
                this.ResData = ""; // 
                this.StatusCode = HttpStatusCode.NotFound; // 
                //this.Classname = ""; // 
                //this.MethodName = ""; // 
             //   this.headers = new Dictionary<string, string>();
                this.ReturnMessage = "";
                this.HttpMethod = "";
            }
            catch (Exception ex)
            {
                InfoTmp = "" + ex.Message;
            }
        }
        #endregion
        #region get response

        //2020-05-12

        // private string InfoTmp = "";
        #endregion

        public abstract string SendHttp(string method, string url, string body);
        public abstract string SendHttpGet(string url);
        public abstract string SendHttpPost(string url, string body);
        public abstract string SendHttpPut(string url, string body);
        public abstract string SendHttpPatch(string url, string body);
    }
}