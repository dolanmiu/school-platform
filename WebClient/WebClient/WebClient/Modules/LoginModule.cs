using Nancy;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClient.Modules
{
    public class LoginModule : NancyModule
    {
        public LoginModule() : base("/login")
        {
            Get["/"] = parameters =>
            {
                return View["login"];
            };

            Get["/auth"] = parameters =>
            {
                var client = new RestClient("https://euw.api.pvp.net");
                // client.Authenticator = new HttpBasicAuthenticator(username, password);

                var request = new RestRequest("api/lol/euw/v1.2/champion?api_key=e511e298-0729-48e1-9f2c-20639de4741a", Method.GET);
                //request.AddParameter("name", "value"); // adds to POST or URL querystring based on Method
                //request.AddUrlSegment("id", 123); // replaces matching token in request.Resource

                // easily add HTTP Headers
                //request.AddHeader("header", "value");

                // add files to upload (works with compatible verbs)
                //request.AddFile(path);

                // execute the request
                IRestResponse response = client.Execute(request);
                var content = response.Content; // raw content as string

                return content;
            };
        }
    }
}