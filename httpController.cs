using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Sykehusinnkjop.Function
{
    public static class graphController
    {
        public static readonly HttpClient Client;
        static graphController()
        {
            Client = new HttpClient()
            {
                BaseAddress = new Uri("https://graph.microsoft.com"),
                Timeout = new TimeSpan(0, 0, 15),
            };
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}