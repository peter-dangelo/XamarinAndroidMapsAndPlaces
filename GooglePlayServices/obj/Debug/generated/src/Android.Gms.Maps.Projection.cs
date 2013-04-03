using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps {

	[global::Android.Runtime.Register ("com/google/android/gms/maps/Projection", DoNotGenerateAcw=true)]
	public sealed partial class Projection : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/Projection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Projection); }
		}

		internal Projection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getVisibleRegion;
		public global::Android.Gms.Maps.Model.VisibleRegion VisibleRegion {
			[Register ("getVisibleRegion", "()Lcom/google/android/gms/maps/model/VisibleRegion;", "GetGetVisibleRegionHandler")]
			get {
				if (id_getVisibleRegion == IntPtr.Zero)
					id_getVisibleRegion = JNIEnv.GetMethodID (class_ref, "getVisibleRegion", "()Lcom/google/android/gms/maps/model/VisibleRegion;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.VisibleRegion> (JNIEnv.CallObjectMethod  (Handle, id_getVisibleRegion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_fromScreenLocation_Landroid_graphics_Point_;
		[Register ("fromScreenLocation", "(Landroid/graphics/Point;)Lcom/google/android/gms/maps/model/LatLng;", "")]
		public global::Android.Gms.Maps.Model.LatLng FromScreenLocation (global::Android.Graphics.Point p0)
		{
			if (id_fromScreenLocation_Landroid_graphics_Point_ == IntPtr.Zero)
				id_fromScreenLocation_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "fromScreenLocation", "(Landroid/graphics/Point;)Lcom/google/android/gms/maps/model/LatLng;");
			global::Android.Gms.Maps.Model.LatLng __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_fromScreenLocation_Landroid_graphics_Point_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_toScreenLocation_Lcom_google_android_gms_maps_model_LatLng_;
		[Register ("toScreenLocation", "(Lcom/google/android/gms/maps/model/LatLng;)Landroid/graphics/Point;", "")]
		public global::Android.Graphics.Point ToScreenLocation (global::Android.Gms.Maps.Model.LatLng p0)
		{
			if (id_toScreenLocation_Lcom_google_android_gms_maps_model_LatLng_ == IntPtr.Zero)
				id_toScreenLocation_Lcom_google_android_gms_maps_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "toScreenLocation", "(Lcom/google/android/gms/maps/model/LatLng;)Landroid/graphics/Point;");
			global::Android.Graphics.Point __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallObjectMethod  (Handle, id_toScreenLocation_Lcom_google_android_gms_maps_model_LatLng_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
