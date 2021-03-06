﻿using HttpServer.Enums;

namespace HttpServer.Models
{
    public class HttpRequest
    {
        public HttpRequest()
        {
            this.Header = new Header(HeaderType.HttpRequest);
        }

        public RequestMethod Method { get; set; }

        public string Url { get; set; }

        public Header Header { get; set; }

        public string Content { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} HTTP/1.0\r\n{2}{3}",
                this.Method,
                this.Url,
                this.Header,
                this.Content);
        }
    }
}
