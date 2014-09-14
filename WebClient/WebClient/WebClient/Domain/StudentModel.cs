using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClient.Domain
{
    public class StudentModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GPSDataModel LocationData { get; set; }
    }
}