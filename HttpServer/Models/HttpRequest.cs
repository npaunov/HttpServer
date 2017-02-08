﻿using HttpServer.Enums;
using System.Text;

namespace HttpServer.Models
{
    public class HttpRequest
    {
        public HttpRequest(RequestMethod method, string url)
        {
            this.Method = method;
            this.Url = url;
            this.Header = new Header(HeaderType.HttpRequest);
        }

        public RequestMethod Method { get; set; }

        public string Url { get; set; }

        public Header Header { get; set; }

        public string Content { get; set; }

        public override string ToString()
        {
            StringBuilder request = new StringBuilder();

            request.AppendLine($"{this.Method} {this.Url} HTTP/1.0");
            request.AppendLine(this.Header.ToString());

            if (!string.IsNullOrEmpty(Content))
            {
                request.AppendLine();
                request.AppendLine(Content);
            }

            return request.ToString();
        }
    }
}
