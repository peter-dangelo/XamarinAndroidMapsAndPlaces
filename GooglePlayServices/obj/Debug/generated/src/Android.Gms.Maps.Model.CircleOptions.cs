using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps.Model {

	[global::Android.Runtime.Register ("com/google/android/gms/maps/model/CircleOptions", DoNotGenerateAcw=true)]
	public sealed partial class CircleOptions : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/model/CircleOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CircleOptions); }
		}

		internal CircleOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public CircleOptions () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CircleOptions)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getCenter;
		public global::Android.Gms.Maps.Model.LatLng Center {
			[Register ("getCenter", "()Lcom/google/android/gms/maps/model/LatLng;", "GetGetCenterHandler")]
			get {
				if (id_getCenter == IntPtr.Zero)
					id_getCenter = JNIEnv.GetMethodID (class_ref, "getCenter", "()Lcom/google/android/gms/maps/model/LatLng;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getCenter), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getFillColor;
		public int FillColor {
			[Register ("getFillColor", "()I", "GetGetFillColorHandler")]
			get {
				if (id_getFillColor == IntPtr.Zero)
					id_getFillColor = JNIEnv.GetMethodID (class_ref, "getFillColor", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getFillColor);
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

		static IntPtr id_getRadius;
		public double Radius {
			[Register ("getRadius", "()D", "GetGetRadiusHandler")]
			get {
				if (id_getRadius == IntPtr.Zero)
					id_getRadius = JNIEnv.GetMethodID (class_ref, "getRadius", "()D");
				return JNIEnv.CallDoubleMethod  (Handle, id_getRadius);
			}
		}

		static IntPtr id_getStrokeColor;
		public int StrokeColor {
			[Register ("getStrokeColor", "()I", "GetGetStrokeColorHandler")]
			get {
				if (id_getStrokeColor == IntPtr.Zero)
					id_getStrokeColor = JNIEnv.GetMethodID (class_ref, "getStrokeColor", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getStrokeColor);
			}
		}

		static IntPtr id_getStrokeWidth;
		public float StrokeWidth {
			[Register ("getStrokeWidth", "()F", "GetGetStrokeWidthHandler")]
			get {
				if (id_getStrokeWidth == IntPtr.Zero)
					id_getStrokeWidth = JNIEnv.GetMethodID (class_ref, "getStrokeWidth", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getStrokeWidth);
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

		static IntPtr id_center_Lcom_google_android_gms_maps_model_LatLng_;
		[Register ("center", "(Lcom/google/android/gms/maps/model/LatLng;)Lcom/google/android/gms/maps/model/CircleOptions;", "")]
		public global::Android.Gms.Maps.Model.CircleOptions InvokeCenter (global::Android.Gms.Maps.Model.LatLng p0)
		{
			if (id_center_Lcom_google_android_gms_maps_model_LatLng_ == IntPtr.Zero)
				id_center_Lcom_google_android_gms_maps_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "center", "(Lcom/google/android/gms/maps/model/LatLng;)Lcom/google/android/gms/maps/model/CircleOptions;");
			global::Android.Gms.Maps.Model.CircleOptions __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.CircleOptions> (JNIEnv.CallObjectMethod  (Handle, id_center_Lcom_google_android_gms_maps_model_LatLng_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_describeContents;
		[Register ("describeContents", "()I", "")]
		public int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_describeContents);
		}

		static IntPtr id_fillColor_I;
		[Register ("fillColor", "(I)Lcom/google/android/gms/maps/model/CircleOptions;", "")]
		public global::Android.Gms.Maps.Model.CircleOptions InvokeFillColor (int p0)
		{
			if (id_fillColor_I == IntPtr.Zero)
				id_fillColor_I = JNIEnv.GetMethodID (class_ref, "fillColor", "(I)Lcom/google/android/gms/maps/model/CircleOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.CircleOptions> (JNIEnv.CallObjectMethod  (Handle, id_fillColor_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_radius_D;
		[Register ("radius", "(D)Lcom/google/android/gms/maps/model/CircleOptions;", "")]
		public global::Android.Gms.Maps.Model.CircleOptions InvokeRadius (double p0)
		{
			if (id_radius_D == IntPtr.Zero)
				id_radius_D = JNIEnv.GetMethodID (class_ref, "radius", "(D)Lcom/google/android/gms/maps/model/CircleOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.CircleOptions> (JNIEnv.CallObjectMethod  (Handle, id_radius_D, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_strokeColor_I;
		[Register ("strokeColor", "(I)Lcom/google/android/gms/maps/model/CircleOptions;", "")]
		public global::Android.Gms.Maps.Model.CircleOptions InvokeStrokeColor (int p0)
		{
			if (id_strokeColor_I == IntPtr.Zero)
				id_strokeColor_I = JNIEnv.GetMethodID (class_ref, "strokeColor", "(I)Lcom/google/android/gms/maps/model/CircleOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.CircleOptions> (JNIEnv.CallObjectMethod  (Handle, id_strokeColor_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_strokeWidth_F;
		[Register ("strokeWidth", "(F)Lcom/google/android/gms/maps/model/CircleOptions;", "")]
		public global::Android.Gms.Maps.Model.CircleOptions InvokeStrokeWidth (float p0)
		{
			if (id_strokeWidth_F == IntPtr.Zero)
				id_strokeWidth_F = JNIEnv.GetMethodID (class_ref, "strokeWidth", "(F)Lcom/google/android/gms/maps/model/CircleOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.CircleOptions> (JNIEnv.CallObjectMethod  (Handle, id_strokeWidth_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_visible_Z;
		[Register ("visible", "(Z)Lcom/google/android/gms/maps/model/CircleOptions;", "")]
		public global::Android.Gms.Maps.Model.CircleOptions Visible (bool p0)
		{
			if (id_visible_Z == IntPtr.Zero)
				id_visible_Z = JNIEnv.GetMethodID (class_ref, "visible", "(Z)Lcom/google/android/gms/maps/model/CircleOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.CircleOptions> (JNIEnv.CallObjectMethod  (Handle, id_visible_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
		[Register ("zIndex", "(F)Lcom/google/android/gms/maps/model/CircleOptions;", "")]
		public global::Android.Gms.Maps.Model.CircleOptions InvokeZIndex (float p0)
		{
			if (id_zIndex_F == IntPtr.Zero)
				id_zIndex_F = JNIEnv.GetMethodID (class_ref, "zIndex", "(F)Lcom/google/android/gms/maps/model/CircleOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.CircleOptions> (JNIEnv.CallObjectMethod  (Handle, id_zIndex_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
