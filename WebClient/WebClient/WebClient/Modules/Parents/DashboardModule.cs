﻿using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClient.Modules.Parents
{
    public class DashboardModule : NancyModule
    {
        public DashboardModule() : base("/parent")
        {
            Get["/"] = parameters =>
            {
                return View["/Parents/dashboard"];
            };

            Get["/GetStudents"] = parameters =>
            {
                return "List";
            };

        }
    }
}