using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps.Model {

	[global::Android.Runtime.Register ("com/google/android/gms/maps/model/TileOverlayOptions", DoNotGenerateAcw=true)]
	public sealed partial class TileOverlayOptions : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/model/TileOverlayOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TileOverlayOptions); }
		}

		internal TileOverlayOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public TileOverlayOptions () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (TileOverlayOptions)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr id_getTileProvider;
		public global::Android.Gms.Maps.Model.ITileProvider TileProvider {
			[Register ("getTileProvider", "()Lcom/google/android/gms/maps/model/TileProvider;", "GetGetTileProviderHandler")]
			get {
				if (id_getTileProvider == IntPtr.Zero)
					id_getTileProvider = JNIEnv.GetMethodID (class_ref, "getTileProvider", "()Lcom/google/android/gms/maps/model/TileProvider;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.ITileProvider> (JNIEnv.CallObjectMethod  (Handle, id_getTileProvider), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr id_describeContents;
		[Register ("describeContents", "()I", "")]
		public int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_describeContents);
		}

		static IntPtr id_tileProvider_Lcom_google_android_gms_maps_model_TileProvider_;
		[Register ("tileProvider", "(Lcom/google/android/gms/maps/model/TileProvider;)Lcom/google/android/gms/maps/model/TileOverlayOptions;", "")]
		public global::Android.Gms.Maps.Model.TileOverlayOptions InvokeTileProvider (global::Android.Gms.Maps.Model.ITileProvider p0)
		{
			if (id_tileProvider_Lcom_google_android_gms_maps_model_TileProvider_ == IntPtr.Zero)
				id_tileProvider_Lcom_google_android_gms_maps_model_TileProvider_ = JNIEnv.GetMethodID (class_ref, "tileProvider", "(Lcom/google/android/gms/maps/model/TileProvider;)Lcom/google/android/gms/maps/model/TileOverlayOptions;");
			global::Android.Gms.Maps.Model.TileOverlayOptions __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.TileOverlayOptions> (JNIEnv.CallObjectMethod  (Handle, id_tileProvider_Lcom_google_android_gms_maps_model_TileProvider_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_visible_Z;
		[Register ("visible", "(Z)Lcom/google/android/gms/maps/model/TileOverlayOptions;", "")]
		public global::Android.Gms.Maps.Model.TileOverlayOptions Visible (bool p0)
		{
			if (id_visible_Z == IntPtr.Zero)
				id_visible_Z = JNIEnv.GetMethodID (class_ref, "visible", "(Z)Lcom/google/android/gms/maps/model/TileOverlayOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.TileOverlayOptions> (JNIEnv.CallObjectMethod  (Handle, id_visible_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
		[Register ("zIndex", "(F)Lcom/google/android/gms/maps/model/TileOverlayOptions;", "")]
		public global::Android.Gms.Maps.Model.TileOverlayOptions InvokeZIndex (float p0)
		{
			if (id_zIndex_F == IntPtr.Zero)
				id_zIndex_F = JNIEnv.GetMethodID (class_ref, "zIndex", "(F)Lcom/google/android/gms/maps/model/TileOverlayOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.TileOverlayOptions> (JNIEnv.CallObjectMethod  (Handle, id_zIndex_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
