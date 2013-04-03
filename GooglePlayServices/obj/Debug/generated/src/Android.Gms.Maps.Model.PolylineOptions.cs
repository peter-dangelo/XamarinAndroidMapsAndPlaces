using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps.Model {

	[global::Android.Runtime.Register ("com/google/android/gms/maps/model/PolylineOptions", DoNotGenerateAcw=true)]
	public sealed partial class PolylineOptions : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/model/PolylineOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PolylineOptions); }
		}

		internal PolylineOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public PolylineOptions () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PolylineOptions)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getColor;
		public int Color {
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getColor);
			}
		}

		static IntPtr id_isGeodesic;
		public bool IsGeodesic {
			[Register ("isGeodesic", "()Z", "GetIsGeodesicHandler")]
			get {
				if (id_isGeodesic == IntPtr.Zero)
					id_isGeodesic = JNIEnv.GetMethodID (class_ref, "isGeodesic", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isGeodesic);
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

		static IntPtr id_getPoints;
		public global::System.Collections.Generic.IList<global::Android.Gms.Maps.Model.LatLng> Points {
			[Register ("getPoints", "()Ljava/util/List;", "GetGetPointsHandler")]
			get {
				if (id_getPoints == IntPtr.Zero)
					id_getPoints = JNIEnv.GetMethodID (class_ref, "getPoints", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Android.Gms.Maps.Model.LatLng>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPoints), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr id_add_Lcom_google_android_gms_maps_model_LatLng_;
		[Register ("add", "(Lcom/google/android/gms/maps/model/LatLng;)Lcom/google/android/gms/maps/model/PolylineOptions;", "")]
		public global::Android.Gms.Maps.Model.PolylineOptions Add (global::Android.Gms.Maps.Model.LatLng p0)
		{
			if (id_add_Lcom_google_android_gms_maps_model_LatLng_ == IntPtr.Zero)
				id_add_Lcom_google_android_gms_maps_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/google/android/gms/maps/model/LatLng;)Lcom/google/android/gms/maps/model/PolylineOptions;");
			global::Android.Gms.Maps.Model.PolylineOptions __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.PolylineOptions> (JNIEnv.CallObjectMethod  (Handle, id_add_Lcom_google_android_gms_maps_model_LatLng_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_add_arrayLcom_google_android_gms_maps_model_LatLng_;
		[Register ("add", "([Lcom/google/android/gms/maps/model/LatLng;)Lcom/google/android/gms/maps/model/PolylineOptions;", "")]
		public global::Android.Gms.Maps.Model.PolylineOptions Add (params global:: Android.Gms.Maps.Model.LatLng[] p0)
		{
			if (id_add_arrayLcom_google_android_gms_maps_model_LatLng_ == IntPtr.Zero)
				id_add_arrayLcom_google_android_gms_maps_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "add", "([Lcom/google/android/gms/maps/model/LatLng;)Lcom/google/android/gms/maps/model/PolylineOptions;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Android.Gms.Maps.Model.PolylineOptions __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.PolylineOptions> (JNIEnv.CallObjectMethod  (Handle, id_add_arrayLcom_google_android_gms_maps_model_LatLng_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_addAll_Ljava_lang_Iterable_;
		[Register ("addAll", "(Ljava/lang/Iterable;)Lcom/google/android/gms/maps/model/PolylineOptions;", "")]
		public global::Android.Gms.Maps.Model.PolylineOptions AddAll (global::Java.Lang.IIterable p0)
		{
			if (id_addAll_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_addAll_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "addAll", "(Ljava/lang/Iterable;)Lcom/google/android/gms/maps/model/PolylineOptions;");
			global::Android.Gms.Maps.Model.PolylineOptions __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.PolylineOptions> (JNIEnv.CallObjectMethod  (Handle, id_addAll_Ljava_lang_Iterable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_color_I;
		[Register ("color", "(I)Lcom/google/android/gms/maps/model/PolylineOptions;", "")]
		public global::Android.Gms.Maps.Model.PolylineOptions InvokeColor (int p0)
		{
			if (id_color_I == IntPtr.Zero)
				id_color_I = JNIEnv.GetMethodID (class_ref, "color", "(I)Lcom/google/android/gms/maps/model/PolylineOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.PolylineOptions> (JNIEnv.CallObjectMethod  (Handle, id_color_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_describeContents;
		[Register ("describeContents", "()I", "")]
		public int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_describeContents);
		}

		static IntPtr id_geodesic_Z;
		[Register ("geodesic", "(Z)Lcom/google/android/gms/maps/model/PolylineOptions;", "")]
		public global::Android.Gms.Maps.Model.PolylineOptions Geodesic (bool p0)
		{
			if (id_geodesic_Z == IntPtr.Zero)
				id_geodesic_Z = JNIEnv.GetMethodID (class_ref, "geodesic", "(Z)Lcom/google/android/gms/maps/model/PolylineOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.PolylineOptions> (JNIEnv.CallObjectMethod  (Handle, id_geodesic_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_visible_Z;
		[Register ("visible", "(Z)Lcom/google/android/gms/maps/model/PolylineOptions;", "")]
		public global::Android.Gms.Maps.Model.PolylineOptions Visible (bool p0)
		{
			if (id_visible_Z == IntPtr.Zero)
				id_visible_Z = JNIEnv.GetMethodID (class_ref, "visible", "(Z)Lcom/google/android/gms/maps/model/PolylineOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.PolylineOptions> (JNIEnv.CallObjectMethod  (Handle, id_visible_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_width_F;
		[Register ("width", "(F)Lcom/google/android/gms/maps/model/PolylineOptions;", "")]
		public global::Android.Gms.Maps.Model.PolylineOptions InvokeWidth (float p0)
		{
			if (id_width_F == IntPtr.Zero)
				id_width_F = JNIEnv.GetMethodID (class_ref, "width", "(F)Lcom/google/android/gms/maps/model/PolylineOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.PolylineOptions> (JNIEnv.CallObjectMethod  (Handle, id_width_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
		[Register ("zIndex", "(F)Lcom/google/android/gms/maps/model/PolylineOptions;", "")]
		public global::Android.Gms.Maps.Model.PolylineOptions InvokeZIndex (float p0)
		{
			if (id_zIndex_F == IntPtr.Zero)
				id_zIndex_F = JNIEnv.GetMethodID (class_ref, "zIndex", "(F)Lcom/google/android/gms/maps/model/PolylineOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.PolylineOptions> (JNIEnv.CallObjectMethod  (Handle, id_zIndex_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
