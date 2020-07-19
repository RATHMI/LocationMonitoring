using System;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace LocationMonitoring.BL
{
    public static class LocationHelper
    {
        public static async Task<Model.Location> GetLocationAsync()
        {
            try
            {
                var location = await Geolocation.GetLocationAsync(new GeolocationRequest(GeolocationAccuracy.Best));

                if (location != null)
                {
                    return new Model.Location() { TimeStamp = DateTime.Now, Alt = location?.Altitude, Long = location.Longitude, Lat = location.Latitude };
                }

                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
