using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Modules
{
    public class StudentModule : NancyModule
    {
        public StudentModule() : base("/student")
        {
            Get["/parents/{parentID}"] = parameters =>
            {
                return "Should return a list of students the parent gave birth to";
            };

            Get["/class/{classID}"] = parameters =>
            {
                return "Should return a list of students in a particular class";
            };

            Get["/year/{year}"] = parameters =>
            {
                return "Should return a list of students in a particular year";
            };
        }
    }
}