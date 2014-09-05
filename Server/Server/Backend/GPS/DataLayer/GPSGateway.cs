using Backend.GPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.DataLayer
{
    public class GPSGateway : IGPSGateway
    {
        public bool InsertToDatabase(string userID, GPSData gpsData)
        {
            //Add LINQ database logic
            return true;
        }

        public string[] GetFromDatabase(string userID)
        {
            return new string[] { "234", "344" };
        }
    }

    public interface IGPSGateway
    {
        bool InsertToDatabase(string userID, GPSData gpsData);
        string[] GetFromDatabase(string userID);
    }
}