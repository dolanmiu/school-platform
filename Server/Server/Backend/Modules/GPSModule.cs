﻿using Backend.Repositories.GPSRepository;
using Nancy;
using Nancy.ModelBinding;
using System;
using Domain.GPS;
using Backend.Gateways;

namespace Backend.Modules
{
    public class GPSModule : NancyModule
    {

        public GPSModule(IGPSRepository repository) : base("/gps")
        {
            //this.repository = new GPSRepository(new GPSGateway(), new GPSDataFactory());

            Get["/{userID}/{latitude}/{longitude}"] = parameters =>
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

            Get["/{userID}/{fromDate:int}"] = parameters =>
            {
                string userID = parameters.userID;
                long dateTime = parameters.fromDate;
                var dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(dateTime);

                GPSData gpsData = repository.GetGPSData(userID, dt);
                return Negotiate
                    .WithStatusCode(HttpStatusCode.OK)
                    .WithModel(dt);
            };
        }
    }
}