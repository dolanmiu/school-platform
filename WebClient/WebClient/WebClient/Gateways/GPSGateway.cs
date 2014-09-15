using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClient.Gateways
{
    public interface IGPSGateway
    {
        float[,] GetStudentGPSCoordinates(string studentID, float timestamp);

    }
    public class GPSGateway : IGPSGateway
    {
        public float[,] GetStudentGPSCoordinates(string studentID, float timestamp)
        {
            return new float[,] { { 2.334f, 4.33423f }, { 54.5345f, 44.3453f }, { 33.345f, 45.3453f } };
        }
    }
}