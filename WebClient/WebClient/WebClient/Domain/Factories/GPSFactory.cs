using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClient.Domain.Factories
{
    public interface IGPSFactory
    {
        GPSData Instance(float longitude, float latitude);
    }
    public class GPSFactory
    {
        public GPSData Instance(float longitude, float latitude)
        {
            return new GPSData
            {
                Latitude = latitude,
                Longitude = longitude
            };
        }
    }
}