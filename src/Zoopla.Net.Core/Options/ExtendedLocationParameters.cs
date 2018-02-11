namespace Zoopla.Net.Core.Options
{
    public class ExtendedLocationParameters : StandardLocationParameters
    {
        public float Latitude
        {
            set => UrlValues["latitude"] = value.ToString();
        }
        public float Longitude
        {
            set => UrlValues["longitude"] = value.ToString();
        }
        public float LatMax
        {
            set => UrlValues["lat_max"] = value.ToString();
        }
        public float LatMin
        {
            set => UrlValues["lat_min"] = value.ToString();
        }
        public float LonMax
        {
            set => UrlValues["lon_max"] = value.ToString();
        }
        public float LonMin
        {
            set => UrlValues["lon_min"] = value.ToString();
        }
    }
}
