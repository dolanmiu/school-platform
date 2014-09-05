using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.GPS
{
    public class GPSDataFactory : IGPSDataFactory
    {
        public GPSData Instance(double longitude, double latitude)
        {
            var gpsData = new GPSData
            {
                Longitude = longitude,
                Latitude = latitude
            };
            return gpsData;
        }
    }

    public interface IGPSDataFactory
    {
        GPSData Instance(double longitude, double latitude);
    }
}