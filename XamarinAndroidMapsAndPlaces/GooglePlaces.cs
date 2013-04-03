using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using ServiceStack.Text;

namespace GooglePlacesApi
{
    public class GooglePlaces
    {
        //private const string PLACES_SEARCH_URL = "https://maps.googleapis.com/maps/api/place/search/json?";

        private const string PlacesSearchUrl =
            "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location={0},{1}&radius={2}&sensor=false&key={3}&rankBy=distance";
        private const string PLACES_TEXT_SEARCH_URL = "https://maps.googleapis.com/maps/api/place/search/json?";
        private const string PLACES_DETAILS_URL = "https://maps.googleapis.com/maps/api/place/details/json?";

        // Google API Key
        private const string ApiKey = "AIzaSyBrVI0ZIrpj5CzKMy1e2tdnGfP1_50I5fk"; // place your API key here

        private double _latitude;
        private double _longitude;
        private double _radius;

        public void Search(double latitude, double longitude, double radius, string types, Action<PlacesList> callback)
        {
            var client = new WebClient();
            string url = string.Format(PlacesSearchUrl, latitude, longitude, radius, ApiKey);
            //string url = string.Format(PlacesSearchUrl, 40.6878666, -73.9918935, radius, ApiKey);
            Log.Info("PlacesUrl", url);

            client.DownloadStringCompleted += (sender, args) =>
                                                  {
                                                      var placeList = args.Result;
                                                      callback(placeList.FromJson<PlacesList>());
                                                  };

            client.DownloadStringAsync(new Uri(url));
        }
    }

    public class Place
    {
        public string id { get; set; }
        public string name { get; set; }
        public string reference { get; set; }
        public string icon { get; set; }
        public string vicinity { get; set; }
        public Geometry geometry { get; set; }
        public string formatted_address { get; set; }
        public string formatted_phone_number { get; set; }
    }

    public class PlacesList
    {
        public string status { get; set; }
        public List<Place> results { get; set; }
    }

    public class PlaceDetails
    {
        public string status { get; set; }
        public Place result { get; set; }
    }

    public class Geometry
    {
        public Location location { get; set; }
    }

    public class Location
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }
}