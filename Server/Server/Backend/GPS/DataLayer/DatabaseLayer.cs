using Backend.GPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.DataLayer
{
    public class DatabaseLayer : IDatabaseLayer
    {
        public string InsertToDatabase(string userID, GPSData gpsData)
        {
            return "Inserting: " + gpsData.Latitude + " " + gpsData.Longitude + " for user: " + userID;
        }
    }

    public interface IDatabaseLayer
    {
        string InsertToDatabase(string userID, GPSData gpsData);
    }
}