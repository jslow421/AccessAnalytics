using System.Collections.Generic;

namespace AccessAnalytics.Web.Models.PlaceApi
{
    public class PlaceResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<PlaceLocationsResponse> Locations { get; set; }
    }

    public class PlaceLocationsResponse
    {
        public long Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public PlaceLocationFeaturesResponse Features { get; set; }
        public List<PlaceLocationReviewsResponse> Reviews { get; set; }
    }

    public class PlaceLocationFeaturesResponse
    {
        // Wasn't 100% sure how this will be stored/displayed so just used
        // a generic placeholder.
        public object Ramps { get; set; }
        public object Lighting { get; set; }
        public object Parking { get; set; }
        public object NoiseLevel { get; set; }
    }

    public class PlaceLocationReviewsResponse
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
    }
}