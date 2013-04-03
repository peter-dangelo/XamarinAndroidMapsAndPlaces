using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/google/android/gms/maps",
						"com/google/android/gms/maps/model",
					},
					new Converter<string, Type>[]{
						lookup_com_google_android_gms_maps_package,
						lookup_com_google_android_gms_maps_model_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_google_android_gms_maps_mappings;
		static Type lookup_com_google_android_gms_maps_package (string klass)
		{
			if (package_com_google_android_gms_maps_mappings == null) {
				package_com_google_android_gms_maps_mappings = new string[]{
					"com/google/android/gms/maps/CameraUpdate:Android.Gms.Maps.CameraUpdate",
					"com/google/android/gms/maps/CameraUpdateFactory:Android.Gms.Maps.CameraUpdateFactory",
					"com/google/android/gms/maps/GoogleMap:Android.Gms.Maps.GoogleMap",
					"com/google/android/gms/maps/GoogleMapOptions:Android.Gms.Maps.GoogleMapOptions",
					"com/google/android/gms/maps/MapsInitializer:Android.Gms.Maps.MapsInitializer",
					"com/google/android/gms/maps/MapView:Android.Gms.Maps.MapView",
					"com/google/android/gms/maps/Projection:Android.Gms.Maps.Projection",
					"com/google/android/gms/maps/SupportMapFragment:Android.Gms.Maps.SupportMapFragment",
					"com/google/android/gms/maps/UiSettings:Android.Gms.Maps.UiSettings",
				};
			}

			return Lookup (package_com_google_android_gms_maps_mappings, klass);
		}

		static string[] package_com_google_android_gms_maps_model_mappings;
		static Type lookup_com_google_android_gms_maps_model_package (string klass)
		{
			if (package_com_google_android_gms_maps_model_mappings == null) {
				package_com_google_android_gms_maps_model_mappings = new string[]{
					"com/google/android/gms/maps/model/BitmapDescriptor:Android.Gms.Maps.Model.BitmapDescriptor",
					"com/google/android/gms/maps/model/BitmapDescriptorFactory:Android.Gms.Maps.Model.BitmapDescriptorFactory",
					"com/google/android/gms/maps/model/CameraPosition:Android.Gms.Maps.Model.CameraPosition",
					"com/google/android/gms/maps/model/CameraPosition$Builder:Android.Gms.Maps.Model.CameraPosition/Builder",
					"com/google/android/gms/maps/model/Circle:Android.Gms.Maps.Model.Circle",
					"com/google/android/gms/maps/model/CircleOptions:Android.Gms.Maps.Model.CircleOptions",
					"com/google/android/gms/maps/model/GroundOverlay:Android.Gms.Maps.Model.GroundOverlay",
					"com/google/android/gms/maps/model/GroundOverlayOptions:Android.Gms.Maps.Model.GroundOverlayOptions",
					"com/google/android/gms/maps/model/LatLng:Android.Gms.Maps.Model.LatLng",
					"com/google/android/gms/maps/model/LatLngBounds:Android.Gms.Maps.Model.LatLngBounds",
					"com/google/android/gms/maps/model/LatLngBounds$Builder:Android.Gms.Maps.Model.LatLngBounds/Builder",
					"com/google/android/gms/maps/model/Marker:Android.Gms.Maps.Model.Marker",
					"com/google/android/gms/maps/model/MarkerOptions:Android.Gms.Maps.Model.MarkerOptions",
					"com/google/android/gms/maps/model/Polygon:Android.Gms.Maps.Model.Polygon",
					"com/google/android/gms/maps/model/PolygonOptions:Android.Gms.Maps.Model.PolygonOptions",
					"com/google/android/gms/maps/model/Polyline:Android.Gms.Maps.Model.Polyline",
					"com/google/android/gms/maps/model/PolylineOptions:Android.Gms.Maps.Model.PolylineOptions",
					"com/google/android/gms/maps/model/RuntimeRemoteException:Android.Gms.Maps.Model.RuntimeRemoteException",
					"com/google/android/gms/maps/model/Tile:Android.Gms.Maps.Model.Tile",
					"com/google/android/gms/maps/model/TileOverlay:Android.Gms.Maps.Model.TileOverlay",
					"com/google/android/gms/maps/model/TileOverlayOptions:Android.Gms.Maps.Model.TileOverlayOptions",
					"com/google/android/gms/maps/model/UrlTileProvider:Android.Gms.Maps.Model.UrlTileProvider",
					"com/google/android/gms/maps/model/VisibleRegion:Android.Gms.Maps.Model.VisibleRegion",
				};
			}

			return Lookup (package_com_google_android_gms_maps_model_mappings, klass);
		}
	}
}
