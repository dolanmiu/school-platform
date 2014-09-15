using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebClient.Domain;
using WebClient.Domain.Factories;
using WebClient.Gateways;
using WebClient.Repositories;

namespace WebClient.Modules
{
    public class StudentProfileModule : NancyModule
    {
        public StudentProfileModule() : base("/profile") {

            Get["/{id}"] = parameters =>
            {
                IGPSRepository repo = new GPSRepository(new GPSGateway(), new GPSFactory());
                IList<GPSData> model = repo.GetStudentGPSCoordinates("sdf", 234234);
                return View["/studentmap", model]; ;
            };
        }
    }
}