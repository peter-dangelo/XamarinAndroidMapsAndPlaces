using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps {

	[global::Android.Runtime.Register ("com/google/android/gms/maps/MapView", DoNotGenerateAcw=true)]
	public partial class MapView : global::Android.Widget.FrameLayout {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/MapView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapView); }
		}

		protected MapView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public MapView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapView)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public MapView (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapView)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public MapView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapView)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_google_android_gms_maps_GoogleMapOptions_;
		[Register (".ctor", "(Landroid/content/Context;Lcom/google/android/gms/maps/GoogleMapOptions;)V", "")]
		public MapView (global::Android.Content.Context p0, global::Android.Gms.Maps.GoogleMapOptions p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapView)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;Lcom/google/android/gms/maps/GoogleMapOptions;)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_Lcom_google_android_gms_maps_GoogleMapOptions_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lcom_google_android_gms_maps_GoogleMapOptions_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/google/android/gms/maps/GoogleMapOptions;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_Lcom_google_android_gms_maps_GoogleMapOptions_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getMap;
		public global::Android.Gms.Maps.GoogleMap Map {
			[Register ("getMap", "()Lcom/google/android/gms/maps/GoogleMap;", "GetGetMapHandler")]
			get {
				if (id_getMap == IntPtr.Zero)
					id_getMap = JNIEnv.GetMethodID (class_ref, "getMap", "()Lcom/google/android/gms/maps/GoogleMap;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMap> (JNIEnv.CallObjectMethod  (Handle, id_getMap), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_onCreate_Landroid_os_Bundle_;
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "")]
		public void OnCreate (global::Android.OS.Bundle p0)
		{
			if (id_onCreate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreate_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/os/Bundle;)V");
			JNIEnv.CallVoidMethod  (Handle, id_onCreate_Landroid_os_Bundle_, new JValue (p0));
		}

		static IntPtr id_onDestroy;
		[Register ("onDestroy", "()V", "")]
		public void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_onDestroy);
		}

		static IntPtr id_onLowMemory;
		[Register ("onLowMemory", "()V", "")]
		public void OnLowMemory ()
		{
			if (id_onLowMemory == IntPtr.Zero)
				id_onLowMemory = JNIEnv.GetMethodID (class_ref, "onLowMemory", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_onLowMemory);
		}

		static IntPtr id_onPause;
		[Register ("onPause", "()V", "")]
		public void OnPause ()
		{
			if (id_onPause == IntPtr.Zero)
				id_onPause = JNIEnv.GetMethodID (class_ref, "onPause", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_onPause);
		}

		static IntPtr id_onResume;
		[Register ("onResume", "()V", "")]
		public void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_onResume);
		}

		static IntPtr id_onSaveInstanceState_Landroid_os_Bundle_;
		[Register ("onSaveInstanceState", "(Landroid/os/Bundle;)V", "")]
		public void OnSaveInstanceState (global::Android.OS.Bundle p0)
		{
			if (id_onSaveInstanceState_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onSaveInstanceState_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onSaveInstanceState", "(Landroid/os/Bundle;)V");
			JNIEnv.CallVoidMethod  (Handle, id_onSaveInstanceState_Landroid_os_Bundle_, new JValue (p0));
		}

	}
}
