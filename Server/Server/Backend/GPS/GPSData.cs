using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.GPS
{
    public class GPSData : IGPSData
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public interface IGPSData
    {
        double Latitude { get; set; }
        double Longitude { get; set; }
    }
}