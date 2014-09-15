using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebClient.Domain;
using WebClient.Domain.Factories;
using WebClient.Gateways;

namespace WebClient.Repositories
{
    public interface IGPSRepository
    {
        IList<GPSData> GetStudentGPSCoordinates(string studentID, long timestamp);
    }
    public class GPSRepository : IGPSRepository
    {
        private IGPSGateway gateway;
        private IGPSFactory factory;
        public GPSRepository(IGPSGateway gateway, IGPSFactory factory)
        {
            this.gateway = gateway;
            this.factory = factory;
        }
        public IList<GPSData> GetStudentGPSCoordinates(string studentID, long timestamp)
        {
            IList<GPSData> gpsCoords = new List<GPSData>();
            float[,] coords = this.gateway.GetStudentGPSCoordinates(studentID, timestamp);
            
            for (int i = 0; i < coords.GetLength(0); i++)
            {
                gpsCoords.Add(factory.Instance(coords[i, 0], coords[i, 1]));
            }
            return gpsCoords;
        }
    }
}