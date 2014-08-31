using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.Authentication.Forms;
using Nancy.Security;

namespace Backend.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            //this.RequiresAuthentication();

            Get["/"] = _ =>
            {
                return Response.AsJson(new { ServerState = "Running"});
            };
        }
    }
}