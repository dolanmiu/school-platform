using Domain.GPS;
using System;

namespace Backend.Gateways
{
    public class GPSGateway : IGPSGateway
    {
        public bool InsertToDatabase(string userID, GPSData gpsData)
        {
            //Add LINQ database logic
            return true;
        }

        public string[] GetFromDatabase(string userID, DateTime fromDate)
        {
            return new string[] { "234", "344" };
        }
    }

    public interface IGPSGateway
    {
        bool InsertToDatabase(string userID, GPSData gpsData);
        string[] GetFromDatabase(string userID, DateTime fromDate);
    }
}