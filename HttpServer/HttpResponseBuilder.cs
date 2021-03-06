﻿using HttpServer.Enums;
using HttpServer.Models;
using System.IO;

namespace HttpServer
{
    public static class HttpResponseBuilder
    {
        public static HttpResponse InternalServerError()
        {
            string content = File.ReadAllText("Resources/Pages/500.html");

            return new HttpResponse()
            {
                StatusCode = ResponseStatusCode.InternalServerError,
                ContentAsUTF8 = content
            };
        }

        public static HttpResponse NotFound()
        {
            string content = File.ReadAllText(@"C:\Users\NPaunov\Downloads\Google Drive\Study\Web Basics\HttpServer\HttpServer\Resources\Pages\404.html");

            return new HttpResponse()
            {
                StatusCode = ResponseStatusCode.NotFound,
                ContentAsUTF8 = content
            };
        }

    }
}
