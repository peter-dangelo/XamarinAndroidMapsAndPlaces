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
    public class PlacesListAdapter : BaseAdapter<GooglePlacesApi.Place>
    {
        private readonly Activity _context;
        private readonly IList<GooglePlacesApi.Place> _places;

        public PlacesListAdapter(Activity context, IList<GooglePlacesApi.Place> places)
        {
            _context = context;
            _places = places;
        }

        public override GooglePlacesApi.Place this[int position]
        {
            get { return _places[position]; }
        }

        public override int Count
        {
            get { return _places.Count; }
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? _context.LayoutInflater.Inflate(Resource.Layout.PlaceListItem, null);

            var place = _places[position];
            view.FindViewById<TextView>(Resource.Id.Name).Text = place.name;
            return view;
        }
    }
}