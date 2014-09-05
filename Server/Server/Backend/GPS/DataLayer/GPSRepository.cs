using Backend.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.GPS.DataLayer
{
    public class GPSRepository : IGPSRepository
    {
        //Gateway is a fancy word for the layer just above the database
        private IGPSGateway gateway;
        private IGPSDataFactory factory;

        public GPSRepository(IGPSGateway gateway, IGPSDataFactory factory)
        {
            if (gateway == null || factory == null)
            {
                throw new ArgumentException("Gateway or Factory must not be null");
            }

            this.gateway = gateway;
            this.factory = factory;
        }

        //Returns false if failed, true if successful insert
        public bool AddGPSData(string userID, GPSData data)
        {
            bool isSuccess = gateway.InsertToDatabase(userID, data);
            return isSuccess;
        }

        public GPSData GetGPSData(string userID, DateTime fromDate)
        {
            string[] rawData = gateway.GetFromDatabase(userID, fromDate);
            return factory.Instance(Double.Parse(rawData[0]), Double.Parse(rawData[1]));
        }
    }

    public interface IGPSRepository
    {
        bool AddGPSData(string userID, GPSData data);
        GPSData GetGPSData(string userID, DateTime fromDate);
    }

}