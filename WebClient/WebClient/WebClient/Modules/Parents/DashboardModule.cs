using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebClient.Domain;
using WebClient.Domain.Factories;
using WebClient.Gateways;
using WebClient.Repositories;

namespace WebClient.Modules.Parents
{
    public class DashboardModule : NancyModule
    {
        public DashboardModule() : base("/parent")
        {
            IStudentRepository repo = new StudentRepository(new StudentGateway(), new StudentFactory());


            Get["/"] = parameters =>
            {

                IList<StudentModel> model = repo.GetStudents("parentID");
                return View["/Parents/dashboard", model];
            };

            Get["/GetStudents"] = parameters =>
            {
                return "List";
            };

        }
    }
}