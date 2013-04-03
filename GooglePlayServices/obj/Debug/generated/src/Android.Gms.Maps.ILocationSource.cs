using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps {

	[Register ("com/google/android/gms/maps/LocationSource$OnLocationChangedListener", "", "Android.Gms.Maps.ILocationSourceOnLocationChangedListenerInvoker")]
	public partial interface ILocationSourceOnLocationChangedListener : IJavaObject {

		[Register ("onLocationChanged", "(Landroid/location/Location;)V", "GetOnLocationChanged_Landroid_location_Location_Handler:Android.Gms.Maps.ILocationSourceOnLocationChangedListenerInvoker, GooglePlayServices")]
		void OnLocationChanged (global::Android.Locations.Location p0);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/maps/LocationSource$OnLocationChangedListener", DoNotGenerateAcw=true)]
	internal class ILocationSourceOnLocationChangedListenerInvoker : global::Java.Lang.Object, ILocationSourceOnLocationChangedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/maps/LocationSource$OnLocationChangedListener");
		IntPtr class_ref;

		public static ILocationSourceOnLocationChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILocationSourceOnLocationChangedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.maps.LocationSource.OnLocationChangedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILocationSourceOnLocationChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILocationSourceOnLocationChangedListenerInvoker); }
		}

		static Delegate cb_onLocationChanged_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetOnLocationChanged_Landroid_location_Location_Handler ()
		{
			if (cb_onLocationChanged_Landroid_location_Location_ == null)
				cb_onLocationChanged_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocationChanged_Landroid_location_Location_);
			return cb_onLocationChanged_Landroid_location_Location_;
		}

		static void n_OnLocationChanged_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Maps.ILocationSourceOnLocationChangedListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.ILocationSourceOnLocationChangedListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location p0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocationChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onLocationChanged_Landroid_location_Location_;
		public void OnLocationChanged (global::Android.Locations.Location p0)
		{
			if (id_onLocationChanged_Landroid_location_Location_ == IntPtr.Zero)
				id_onLocationChanged_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "onLocationChanged", "(Landroid/location/Location;)V");
			JNIEnv.CallVoidMethod (Handle, id_onLocationChanged_Landroid_location_Location_, new JValue (p0));
		}

	}

	public partial class LocationSourceOnLocationChangedEventArgs : global::System.EventArgs {

		public LocationSourceOnLocationChangedEventArgs (global::Android.Locations.Location p0)
		{
			this.p0 = p0;
		}

		global::Android.Locations.Location p0;
		public global::Android.Locations.Location P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/gms/maps/LocationSource_OnLocationChangedListenerImplementor")]
	internal sealed class ILocationSourceOnLocationChangedListenerImplementor : global::Java.Lang.Object, ILocationSourceOnLocationChangedListener {

		object sender;

		public ILocationSourceOnLocationChangedListenerImplementor (object sender)
			: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/maps/LocationSource_OnLocationChangedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<LocationSourceOnLocationChangedEventArgs> Handler;
#pragma warning restore 0649

		public void OnLocationChanged (global::Android.Locations.Location p0)
		{
			if (Handler != null)
				Handler (sender, new LocationSourceOnLocationChangedEventArgs (p0));
		}

		internal static bool __IsEmpty (ILocationSourceOnLocationChangedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	[Register ("com/google/android/gms/maps/LocationSource", "", "Android.Gms.Maps.ILocationSourceInvoker")]
	public partial interface ILocationSource : IJavaObject {

		[Register ("activate", "(Lcom/google/android/gms/maps/LocationSource$OnLocationChangedListener;)V", "GetActivate_Lcom_google_android_gms_maps_LocationSource_OnLocationChangedListener_Handler:Android.Gms.Maps.ILocationSourceInvoker, GooglePlayServices")]
		void Activate (global::Android.Gms.Maps.ILocationSourceOnLocationChangedListener p0);

		[Register ("deactivate", "()V", "GetDeactivateHandler:Android.Gms.Maps.ILocationSourceInvoker, GooglePlayServices")]
		void Deactivate ();

	}

	[global::Android.Runtime.Register ("com/google/android/gms/maps/LocationSource", DoNotGenerateAcw=true)]
	internal class ILocationSourceInvoker : global::Java.Lang.Object, ILocationSource {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/maps/LocationSource");
		IntPtr class_ref;

		public static ILocationSource GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILocationSource> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.maps.LocationSource"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILocationSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILocationSourceInvoker); }
		}

		static Delegate cb_activate_Lcom_google_android_gms_maps_LocationSource_OnLocationChangedListener_;
#pragma warning disable 0169
		static Delegate GetActivate_Lcom_google_android_gms_maps_LocationSource_OnLocationChangedListener_Handler ()
		{
			if (cb_activate_Lcom_google_android_gms_maps_LocationSource_OnLocationChangedListener_ == null)
				cb_activate_Lcom_google_android_gms_maps_LocationSource_OnLocationChangedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Activate_Lcom_google_android_gms_maps_LocationSource_OnLocationChangedListener_);
			return cb_activate_Lcom_google_android_gms_maps_LocationSource_OnLocationChangedListener_;
		}

		static void n_Activate_Lcom_google_android_gms_maps_LocationSource_OnLocationChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Maps.ILocationSource __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.ILocationSource> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Maps.ILocationSourceOnLocationChangedListener p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.ILocationSourceOnLocationChangedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Activate (p0);
		}
#pragma warning restore 0169

		IntPtr id_activate_Lcom_google_android_gms_maps_LocationSource_OnLocationChangedListener_;
		public void Activate (global::Android.Gms.Maps.ILocationSourceOnLocationChangedListener p0)
		{
			if (id_activate_Lcom_google_android_gms_maps_LocationSource_OnLocationChangedListener_ == IntPtr.Zero)
				id_activate_Lcom_google_android_gms_maps_LocationSource_OnLocationChangedListener_ = JNIEnv.GetMethodID (class_ref, "activate", "(Lcom/google/android/gms/maps/LocationSource$OnLocationChangedListener;)V");
			JNIEnv.CallVoidMethod (Handle, id_activate_Lcom_google_android_gms_maps_LocationSource_OnLocationChangedListener_, new JValue (p0));
		}

		static Delegate cb_deactivate;
#pragma warning disable 0169
		static Delegate GetDeactivateHandler ()
		{
			if (cb_deactivate == null)
				cb_deactivate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Deactivate);
			return cb_deactivate;
		}

		static void n_Deactivate (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Maps.ILocationSource __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.ILocationSource> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Deactivate ();
		}
#pragma warning restore 0169

		IntPtr id_deactivate;
		public void Deactivate ()
		{
			if (id_deactivate == IntPtr.Zero)
				id_deactivate = JNIEnv.GetMethodID (class_ref, "deactivate", "()V");
			JNIEnv.CallVoidMethod (Handle, id_deactivate);
		}

	}

}
