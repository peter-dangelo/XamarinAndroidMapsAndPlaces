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
    [Activity(Label = "Main Activity", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var mapWithOverlayButton = FindViewById<Button>(Resource.Id.MapWithOverlayButton);

            mapWithOverlayButton.Click += (sender, args) =>
                                              {
                                                  var mapIntent = new Intent(this, typeof(MapWithMarkersActivity));
                                                  StartActivity(mapIntent);
                                              };

            var placesSearchButton = FindViewById<Button>(Resource.Id.PlacesSearchButton);
            placesSearchButton.Click += (sender, args) =>
                                            {
                                                var placesSearchIntent = new Intent(this, typeof (PlacesSearchActivity));
                                                StartActivity(placesSearchIntent);
                                            };

        }
    }
}