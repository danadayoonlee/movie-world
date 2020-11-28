using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace MovieClient.Helper
{
    public class MovieAPI
    {
        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://movieapi-test.us-east-2.elasticbeanstalk.com/");
            return client;
        }

        /* https://localhost:44328/ */
    }
}
