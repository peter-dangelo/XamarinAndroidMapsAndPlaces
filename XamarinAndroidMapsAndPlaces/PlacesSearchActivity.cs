using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamarinAndroidSandbox
{
    [Activity(Label = "My Activity")]
    public class PlacesSearchActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Places);

            // Create your application here
            var gpsTracker = new GPSTracker(this);
            var googlePlaces = new GooglePlacesApi.GooglePlaces();
            var loading = ProgressDialog.Show(this, "Retrieving Nearby Places", "Please wait...", true);

            googlePlaces.Search(gpsTracker.Latitude, gpsTracker.Longitude, 500, null, placesList => RunOnUiThread(() =>
                                                                                                                      {
                                                                                                                          var placesListView = FindViewById<ListView>(Resource.Id.Places);
                                                                                                                          placesListView.Adapter = new PlacesListAdapter(this, placesList.results);
                                                                                                                          loading.Hide();
                                                                                                                      }));

        }
    }
}