using HttpServer.Enums;
using HttpServer.Models;
using System.Collections.Generic;

namespace ServerStart
{
    public class ServerStart
    {
        static void Main()
        {
            var routes = new List<Route>()
            {
                new Route
                {
                    Name = "Hello Handler",
                    UrlRegex = @"^/hello$",
                    Method = RequestMethod.GET,
                    Callable = (HttpRequest request) =>
                    {
                        return new HttpResponse()
                        {
                            ContentAsUTF8 = "<h3>Hello From HttpServer! :)<h3><h2>I GOT A FLYING MACHINE<h2>",
                            StatusCode = ResponseStatusCode.Ok
                            
                        };
                    }
                }
            };

            HttpServer.HttpServer httpServer = new HttpServer.HttpServer(8081, routes);
            httpServer.Listen(); 
        }
    }
}
