using Backend.DataLayer;
using Backend.GPS;
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
        public GPSModule() 
        {
            Get["/gps/{latitude}/{longitude}"] = parameters =>
            {
                var data = this.Bind<GPSData>();
                var gpsData = new GPSData
                {
                    Longitude = data.Longitude,
                    Latitude = data.Latitude
                };


                var dbLayer = new DatabaseLayer();
                var result = dbLayer.InsertToDatabase("dolan", gpsData);

                return Negotiate
                    .WithStatusCode(HttpStatusCode.OK)
                    .WithContentType("text/html")
                    .WithModel(result);
            };
        }

    }
}