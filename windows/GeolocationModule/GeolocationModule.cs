using Microsoft.ReactNative.Managed;
using System;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace GeolocationModule
{
    [ReactModule]
    class GeolocationModule
    {
        [ReactMethod("getCoordinates")]
        public async Task<string> GetCoordinatesAsync()
        {
            try
            {
                Geolocator geolocator = new Geolocator();
                var position = await geolocator.GetGeopositionAsync();

                string result = $"Latitude: {position.Coordinate.Point.Position.Latitude} - Longitude: {position.Coordinate.Point.Position.Longitude}";

                return result;
            }
            catch (Exception e)
            {
                return $"An error occured: {e.Message}";
            }
        }        
    }
}
