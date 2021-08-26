using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Headers;
using System.Text;

namespace HttpFactory.Abstractions
{
    public interface IHttpLog
    {
        public string APIEndpoint { get; set; }
        public DateTime? DateReqHttp { get; set; }
        public DateTime? DateResHttp { get; set; }
        //public string ReqHeaderHttp { get; set; }
        public HttpRequestHeaders ReqHeaderHttp { get; set; }
        public string HttpMethod { get; set; }
        public string ReqData { get; set; }
      //  public string ResHeaderHttp { get; set; }
        public string ResData { get; set; }
        //public string HttpStatusCodeStr { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        //   private Hashtable HeaderRes;
        public HttpContentHeaders ResHeaderHttp { get; set; }
        public Dictionary<string, string> headers { get; set; }

        public string ReturnMessage { get; set; }
    }
}
