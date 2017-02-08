﻿using HttpServer.Models;
using System.IO;
using System.Text;
using System.Threading;

namespace HttpServer
{
    public static class StreamUtils
    {
        public static string ReadLine(Stream stream)
        {
            int nextChar;
            StringBuilder data = new StringBuilder();

            while (true)
            {
                nextChar = stream.ReadByte();
                if (nextChar == '\n') break;
                if (nextChar == '\r') continue;
                if (nextChar == -1) { Thread.Sleep(1);continue; };
                data.Append((char)nextChar);
            }

            return data.ToString();
        }

        public static void WriteResponse(Stream stream, HttpResponse response)
        {
            byte[] responseheader = Encoding.UTF8.GetBytes(response.ToString());
            stream.Write(responseheader, 0, responseheader.Length);
            stream.Write(response.Content, 0, response.Content.Length);
        }
    }
}