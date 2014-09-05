using Backend.DataLayer;
using Backend.GPS;
using Backend.GPS.DataLayer;
using Nancy;
using Nancy.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Backend.Modules
{
    public class GPSModule : NancyModule
    {
        private IGPSRepository repository;

        public GPSModule() 
        {
            this.repository = new GPSRepository(new GPSGateway(), new GPSDataFactory());

            Get["/gps/{userID}/{latitude}/{longitude}"] = parameters =>
            {
                GPSData data = this.Bind<GPSData>();

                var isSuccess = repository.AddGPSData("dolan", data);

                if (isSuccess)
                {
                    return Negotiate
                        .WithStatusCode(HttpStatusCode.OK)
                        .WithModel(data);
                }
                else
                {
                    return Negotiate
                        .WithStatusCode(HttpStatusCode.InternalServerError);
                }

            };

            Get["/gps/{userID}"] = parameters =>
            {
                string userID = parameters.userID;
                GPSData gpsData = repository.GetGPSData(userID);
                return Negotiate
                    .WithStatusCode(HttpStatusCode.OK)
                    .WithModel(gpsData);
            };
        }

    }
}