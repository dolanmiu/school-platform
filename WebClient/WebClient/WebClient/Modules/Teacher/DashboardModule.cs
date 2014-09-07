using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClient.Modules.Teacher
{
    public class DashboardModule : NancyModule
    {
        public DashboardModule() : base("/teacher")
        {

        }
    }
}