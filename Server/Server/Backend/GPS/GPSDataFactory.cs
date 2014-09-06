namespace Backend.GPS
{
    public class GPSDataFactory : IGPSDataFactory
    {
        public GPSData Instance(double longitude, double latitude)
        {
            var gpsData = new GPSData
            {
                Longitude = longitude,
                Latitude = latitude
            };
            return gpsData;
        }
    }

    public interface IGPSDataFactory
    {
        GPSData Instance(double longitude, double latitude);
    }
}