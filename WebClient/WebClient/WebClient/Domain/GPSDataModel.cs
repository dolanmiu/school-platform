using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClient.Domain
{
    public class GPSDataModel
    {
        public IList<Coordinate> Coordinates { get; set; }
    }

    public struct Coordinate {
        public float x;
        public float y;
    }
}