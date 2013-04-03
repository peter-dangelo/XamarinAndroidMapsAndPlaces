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
using Android.Locations;

namespace XamarinAndroidSandbox
{
    [Activity(Label = "My Activity")]
    public class LocationActivity : Activity
    {
        private LocationManager _locMgr;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // use location service directly       
            _locMgr = GetSystemService(LocationService) as LocationManager;
        }


    }
}