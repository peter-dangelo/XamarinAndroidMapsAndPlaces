using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps.Model {

	[global::Android.Runtime.Register ("com/google/android/gms/maps/model/GroundOverlayOptions", DoNotGenerateAcw=true)]
	public sealed partial class GroundOverlayOptions : global::Java.Lang.Object {


		[Register ("NO_DIMENSION")]
		public const float NoDimension = (float) -1.000000;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/model/GroundOverlayOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GroundOverlayOptions); }
		}

		internal GroundOverlayOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public GroundOverlayOptions () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GroundOverlayOptions)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getAnchorU;
		public float AnchorU {
			[Register ("getAnchorU", "()F", "GetGetAnchorUHandler")]
			get {
				if (id_getAnchorU == IntPtr.Zero)
					id_getAnchorU = JNIEnv.GetMethodID (class_ref, "getAnchorU", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getAnchorU);
			}
		}

		static IntPtr id_getAnchorV;
		public float AnchorV {
			[Register ("getAnchorV", "()F", "GetGetAnchorVHandler")]
			get {
				if (id_getAnchorV == IntPtr.Zero)
					id_getAnchorV = JNIEnv.GetMethodID (class_ref, "getAnchorV", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getAnchorV);
			}
		}

		static IntPtr id_getBearing;
		public float Bearing {
			[Register ("getBearing", "()F", "GetGetBearingHandler")]
			get {
				if (id_getBearing == IntPtr.Zero)
					id_getBearing = JNIEnv.GetMethodID (class_ref, "getBearing", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getBearing);
			}
		}

		static IntPtr id_getBounds;
		public global::Android.Gms.Maps.Model.LatLngBounds Bounds {
			[Register ("getBounds", "()Lcom/google/android/gms/maps/model/LatLngBounds;", "GetGetBoundsHandler")]
			get {
				if (id_getBounds == IntPtr.Zero)
					id_getBounds = JNIEnv.GetMethodID (class_ref, "getBounds", "()Lcom/google/android/gms/maps/model/LatLngBounds;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLngBounds> (JNIEnv.CallObjectMethod  (Handle, id_getBounds), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getHeight;
		public float Height {
			[Register ("getHeight", "()F", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getHeight);
			}
		}

		static IntPtr id_getImage;
		public global::Android.Gms.Maps.Model.BitmapDescriptor Image {
			[Register ("getImage", "()Lcom/google/android/gms/maps/model/BitmapDescriptor;", "GetGetImageHandler")]
			get {
				if (id_getImage == IntPtr.Zero)
					id_getImage = JNIEnv.GetMethodID (class_ref, "getImage", "()Lcom/google/android/gms/maps/model/BitmapDescriptor;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.BitmapDescriptor> (JNIEnv.CallObjectMethod  (Handle, id_getImage), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isVisible;
		public bool IsVisible {
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isVisible);
			}
		}

		static IntPtr id_getLocation;
		public global::Android.Gms.Maps.Model.LatLng Location {
			[Register ("getLocation", "()Lcom/google/android/gms/maps/model/LatLng;", "GetGetLocationHandler")]
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Lcom/google/android/gms/maps/model/LatLng;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getTransparency;
		public float Transparency {
			[Register ("getTransparency", "()F", "GetGetTransparencyHandler")]
			get {
				if (id_getTransparency == IntPtr.Zero)
					id_getTransparency = JNIEnv.GetMethodID (class_ref, "getTransparency", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getTransparency);
			}
		}

		static IntPtr id_getWidth;
		public float Width {
			[Register ("getWidth", "()F", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getWidth);
			}
		}

		static IntPtr id_getZIndex;
		public float ZIndex {
			[Register ("getZIndex", "()F", "GetGetZIndexHandler")]
			get {
				if (id_getZIndex == IntPtr.Zero)
					id_getZIndex = JNIEnv.GetMethodID (class_ref, "getZIndex", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getZIndex);
			}
		}

		static IntPtr id_anchor_FF;
		[Register ("anchor", "(FF)Lcom/google/android/gms/maps/model/GroundOverlayOptions;", "")]
		public global::Android.Gms.Maps.Model.GroundOverlayOptions Anchor (float p0, float p1)
		{
			if (id_anchor_FF == IntPtr.Zero)
				id_anchor_FF = JNIEnv.GetMethodID (class_ref, "anchor", "(FF)Lcom/google/android/gms/maps/model/GroundOverlayOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.GroundOverlayOptions> (JNIEnv.CallObjectMethod  (Handle, id_anchor_FF, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_bearing_F;
		[Register ("bearing", "(F)Lcom/google/android/gms/maps/model/GroundOverlayOptions;", "")]
		public global::Android.Gms.Maps.Model.GroundOverlayOptions InvokeBearing (float p0)
		{
			if (id_bearing_F == IntPtr.Zero)
				id_bearing_F = JNIEnv.GetMethodID (class_ref, "bearing", "(F)Lcom/google/android/gms/maps/model/GroundOverlayOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.GroundOverlayOptions> (JNIEnv.CallObjectMethod  (Handle, id_bearing_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_describeContents;
		[Register ("describeContents", "()I", "")]
		public int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_describeContents);
		}

		static IntPtr id_image_Lcom_google_android_gms_maps_model_BitmapDescriptor_;
		[Register ("image", "(Lcom/google/android/gms/maps/model/BitmapDescriptor;)Lcom/google/android/gms/maps/model/GroundOverlayOptions;", "")]
		public global::Android.Gms.Maps.Model.GroundOverlayOptions InvokeImage (global::Android.Gms.Maps.Model.BitmapDescriptor p0)
		{
			if (id_image_Lcom_google_android_gms_maps_model_BitmapDescriptor_ == IntPtr.Zero)
				id_image_Lcom_google_android_gms_maps_model_BitmapDescriptor_ = JNIEnv.GetMethodID (class_ref, "image", "(Lcom/google/android/gms/maps/model/BitmapDescriptor;)Lcom/google/android/gms/maps/model/GroundOverlayOptions;");
			global::Android.Gms.Maps.Model.GroundOverlayOptions __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.GroundOverlayOptions> (JNIEnv.CallObjectMethod  (Handle, id_image_Lcom_google_android_gms_maps_model_BitmapDescriptor_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_position_Lcom_google_android_gms_maps_model_LatLng_F;
		[Register ("position", "(Lcom/google/android/gms/maps/model/LatLng;F)Lcom/google/android/gms/maps/model/GroundOverlayOptions;", "")]
		public global::Android.Gms.Maps.Model.GroundOverlayOptions Position (global::Android.Gms.Maps.Model.LatLng p0, float p1)
		{
			if (id_position_Lcom_google_android_gms_maps_model_LatLng_F == IntPtr.Zero)
				id_position_Lcom_google_android_gms_maps_model_LatLng_F = JNIEnv.GetMethodID (class_ref, "position", "(Lcom/google/android/gms/maps/model/LatLng;F)Lcom/google/android/gms/maps/model/GroundOverlayOptions;");
			global::Android.Gms.Maps.Model.GroundOverlayOptions __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.GroundOverlayOptions> (JNIEnv.CallObjectMethod  (Handle, id_position_Lcom_google_android_gms_maps_model_LatLng_F, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_position_Lcom_google_android_gms_maps_model_LatLng_FF;
		[Register ("position", "(Lcom/google/android/gms/maps/model/LatLng;FF)Lcom/google/android/gms/maps/model/GroundOverlayOptions;", "")]
		public global::Android.Gms.Maps.Model.GroundOverlayOptions Position (global::Android.Gms.Maps.Model.LatLng p0, float p1, float p2)
		{
			if (id_position_Lcom_google_android_gms_maps_model_LatLng_FF == IntPtr.Zero)
				id_position_Lcom_google_android_gms_maps_model_LatLng_FF = JNIEnv.GetMethodID (class_ref, "position", "(Lcom/google/android/gms/maps/model/LatLng;FF)Lcom/google/android/gms/maps/model/GroundOverlayOptions;");
			global::Android.Gms.Maps.Model.GroundOverlayOptions __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.GroundOverlayOptions> (JNIEnv.CallObjectMethod  (Handle, id_position_Lcom_google_android_gms_maps_model_LatLng_FF, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_positionFromBounds_Lcom_google_android_gms_maps_model_LatLngBounds_;
		[Register ("positionFromBounds", "(Lcom/google/android/gms/maps/model/LatLngBounds;)Lcom/google/android/gms/maps/model/GroundOverlayOptions;", "")]
		public global::Android.Gms.Maps.Model.GroundOverlayOptions PositionFromBounds (global::Android.Gms.Maps.Model.LatLngBounds p0)
		{
			if (id_positionFromBounds_Lcom_google_android_gms_maps_model_LatLngBounds_ == IntPtr.Zero)
				id_positionFromBounds_Lcom_google_android_gms_maps_model_LatLngBounds_ = JNIEnv.GetMethodID (class_ref, "positionFromBounds", "(Lcom/google/android/gms/maps/model/LatLngBounds;)Lcom/google/android/gms/maps/model/GroundOverlayOptions;");
			global::Android.Gms.Maps.Model.GroundOverlayOptions __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.GroundOverlayOptions> (JNIEnv.CallObjectMethod  (Handle, id_positionFromBounds_Lcom_google_android_gms_maps_model_LatLngBounds_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_transparency_F;
		[Register ("transparency", "(F)Lcom/google/android/gms/maps/model/GroundOverlayOptions;", "")]
		public global::Android.Gms.Maps.Model.GroundOverlayOptions InvokeTransparency (float p0)
		{
			if (id_transparency_F == IntPtr.Zero)
				id_transparency_F = JNIEnv.GetMethodID (class_ref, "transparency", "(F)Lcom/google/android/gms/maps/model/GroundOverlayOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.GroundOverlayOptions> (JNIEnv.CallObjectMethod  (Handle, id_transparency_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_visible_Z;
		[Register ("visible", "(Z)Lcom/google/android/gms/maps/model/GroundOverlayOptions;", "")]
		public global::Android.Gms.Maps.Model.GroundOverlayOptions Visible (bool p0)
		{
			if (id_visible_Z == IntPtr.Zero)
				id_visible_Z = JNIEnv.GetMethodID (class_ref, "visible", "(Z)Lcom/google/android/gms/maps/model/GroundOverlayOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.GroundOverlayOptions> (JNIEnv.CallObjectMethod  (Handle, id_visible_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public void WriteToParcel (global::Android.OS.Parcel p0, int p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_zIndex_F;
		[Register ("zIndex", "(F)Lcom/google/android/gms/maps/model/GroundOverlayOptions;", "")]
		public global::Android.Gms.Maps.Model.GroundOverlayOptions InvokeZIndex (float p0)
		{
			if (id_zIndex_F == IntPtr.Zero)
				id_zIndex_F = JNIEnv.GetMethodID (class_ref, "zIndex", "(F)Lcom/google/android/gms/maps/model/GroundOverlayOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.GroundOverlayOptions> (JNIEnv.CallObjectMethod  (Handle, id_zIndex_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
