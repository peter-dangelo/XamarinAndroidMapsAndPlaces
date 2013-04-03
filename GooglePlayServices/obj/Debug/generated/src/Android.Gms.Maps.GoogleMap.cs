using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps {

	[global::Android.Runtime.Register ("com/google/android/gms/maps/GoogleMap", DoNotGenerateAcw=true)]
	public sealed partial class GoogleMap : global::Java.Lang.Object {


		[Register ("MAP_TYPE_HYBRID")]
		public const int MapTypeHybrid = (int) 4;

		[Register ("MAP_TYPE_NONE")]
		public const int MapTypeNone = (int) 0;

		[Register ("MAP_TYPE_NORMAL")]
		public const int MapTypeNormal = (int) 1;

		[Register ("MAP_TYPE_SATELLITE")]
		public const int MapTypeSatellite = (int) 2;

		[Register ("MAP_TYPE_TERRAIN")]
		public const int MapTypeTerrain = (int) 3;
		[Register ("com/google/android/gms/maps/GoogleMap$CancelableCallback", "", "Android.Gms.Maps.GoogleMap/ICancelableCallbackInvoker")]
		public partial interface ICancelableCallback : IJavaObject {

			[Register ("onCancel", "()V", "GetOnCancelHandler:Android.Gms.Maps.GoogleMap/ICancelableCallbackInvoker, GooglePlayServices")]
			void OnCancel ();

			[Register ("onFinish", "()V", "GetOnFinishHandler:Android.Gms.Maps.GoogleMap/ICancelableCallbackInvoker, GooglePlayServices")]
			void OnFinish ();

		}

		[global::Android.Runtime.Register ("com/google/android/gms/maps/GoogleMap$CancelableCallback", DoNotGenerateAcw=true)]
		internal class ICancelableCallbackInvoker : global::Java.Lang.Object, ICancelableCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/maps/GoogleMap$CancelableCallback");
			IntPtr class_ref;

			public static ICancelableCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICancelableCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.maps.GoogleMap.CancelableCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICancelableCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ICancelableCallbackInvoker); }
			}

			static Delegate cb_onCancel;
#pragma warning disable 0169
			static Delegate GetOnCancelHandler ()
			{
				if (cb_onCancel == null)
					cb_onCancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCancel);
				return cb_onCancel;
			}

			static void n_OnCancel (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Gms.Maps.GoogleMap.ICancelableCallback __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMap.ICancelableCallback> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCancel ();
			}
#pragma warning restore 0169

			IntPtr id_onCancel;
			public void OnCancel ()
			{
				if (id_onCancel == IntPtr.Zero)
					id_onCancel = JNIEnv.GetMethodID (class_ref, "onCancel", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onCancel);
			}

			static Delegate cb_onFinish;
#pragma warning disable 0169
			static Delegate GetOnFinishHandler ()
			{
				if (cb_onFinish == null)
					cb_onFinish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFinish);
				return cb_onFinish;
			}

			static void n_OnFinish (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Gms.Maps.GoogleMap.ICancelableCallback __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMap.ICancelableCallback> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnFinish ();
			}
#pragma warning restore 0169

			IntPtr id_onFinish;
			public void OnFinish ()
			{
				if (id_onFinish == IntPtr.Zero)
					id_onFinish = JNIEnv.GetMethodID (class_ref, "onFinish", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onFinish);
			}

		}


		[Register ("com/google/android/gms/maps/GoogleMap$InfoWindowAdapter", "", "Android.Gms.Maps.GoogleMap/IInfoWindowAdapterInvoker")]
		public partial interface IInfoWindowAdapter : IJavaObject {

			[Register ("getInfoContents", "(Lcom/google/android/gms/maps/model/Marker;)Landroid/view/View;", "GetGetInfoContents_Lcom_google_android_gms_maps_model_Marker_Handler:Android.Gms.Maps.GoogleMap/IInfoWindowAdapterInvoker, GooglePlayServices")]
			global::Android.Views.View GetInfoContents (global::Android.Gms.Maps.Model.Marker p0);

			[Register ("getInfoWindow", "(Lcom/google/android/gms/maps/model/Marker;)Landroid/view/View;", "GetGetInfoWindow_Lcom_google_android_gms_maps_model_Marker_Handler:Android.Gms.Maps.GoogleMap/IInfoWindowAdapterInvoker, GooglePlayServices")]
			global::Android.Views.View GetInfoWindow (global::Android.Gms.Maps.Model.Marker p0);

		}

		[global::Android.Runtime.Register ("com/google/android/gms/maps/GoogleMap$InfoWindowAdapter", DoNotGenerateAcw=true)]
		internal class IInfoWindowAdapterInvoker : global::Java.Lang.Object, IInfoWindowAdapter {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/maps/GoogleMap$InfoWindowAdapter");
			IntPtr class_ref;

			public static IInfoWindowAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IInfoWindowAdapter> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.maps.GoogleMap.InfoWindowAdapter"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IInfoWindowAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IInfoWindowAdapterInvoker); }
			}

			static Delegate cb_getInfoContents_Lcom_google_android_gms_maps_model_Marker_;
#pragma warning disable 0169
			static Delegate GetGetInfoContents_Lcom_google_android_gms_maps_model_Marker_Handler ()
			{
				if (cb_getInfoContents_Lcom_google_android_gms_maps_model_Marker_ == null)
					cb_getInfoContents_Lcom_google_android_gms_maps_model_Marker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetInfoContents_Lcom_google_android_gms_maps_model_Marker_);
				return cb_getInfoContents_Lcom_google_android_gms_maps_model_Marker_;
			}

			static IntPtr n_GetInfoContents_Lcom_google_android_gms_maps_model_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Maps.GoogleMap.IInfoWindowAdapter __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMap.IInfoWindowAdapter> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Gms.Maps.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetInfoContents (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_getInfoContents_Lcom_google_android_gms_maps_model_Marker_;
			public global::Android.Views.View GetInfoContents (global::Android.Gms.Maps.Model.Marker p0)
			{
				if (id_getInfoContents_Lcom_google_android_gms_maps_model_Marker_ == IntPtr.Zero)
					id_getInfoContents_Lcom_google_android_gms_maps_model_Marker_ = JNIEnv.GetMethodID (class_ref, "getInfoContents", "(Lcom/google/android/gms/maps/model/Marker;)Landroid/view/View;");
				global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (Handle, id_getInfoContents_Lcom_google_android_gms_maps_model_Marker_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_getInfoWindow_Lcom_google_android_gms_maps_model_Marker_;
#pragma warning disable 0169
			static Delegate GetGetInfoWindow_Lcom_google_android_gms_maps_model_Marker_Handler ()
			{
				if (cb_getInfoWindow_Lcom_google_android_gms_maps_model_Marker_ == null)
					cb_getInfoWindow_Lcom_google_android_gms_maps_model_Marker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetInfoWindow_Lcom_google_android_gms_maps_model_Marker_);
				return cb_getInfoWindow_Lcom_google_android_gms_maps_model_Marker_;
			}

			static IntPtr n_GetInfoWindow_Lcom_google_android_gms_maps_model_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Maps.GoogleMap.IInfoWindowAdapter __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMap.IInfoWindowAdapter> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Gms.Maps.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetInfoWindow (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_getInfoWindow_Lcom_google_android_gms_maps_model_Marker_;
			public global::Android.Views.View GetInfoWindow (global::Android.Gms.Maps.Model.Marker p0)
			{
				if (id_getInfoWindow_Lcom_google_android_gms_maps_model_Marker_ == IntPtr.Zero)
					id_getInfoWindow_Lcom_google_android_gms_maps_model_Marker_ = JNIEnv.GetMethodID (class_ref, "getInfoWindow", "(Lcom/google/android/gms/maps/model/Marker;)Landroid/view/View;");
				global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (Handle, id_getInfoWindow_Lcom_google_android_gms_maps_model_Marker_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		[Register ("com/google/android/gms/maps/GoogleMap$OnCameraChangeListener", "", "Android.Gms.Maps.GoogleMap/IOnCameraChangeListenerInvoker")]
		public partial interface IOnCameraChangeListener : IJavaObject {

			[Register ("onCameraChange", "(Lcom/google/android/gms/maps/model/CameraPosition;)V", "GetOnCameraChange_Lcom_google_android_gms_maps_model_CameraPosition_Handler:Android.Gms.Maps.GoogleMap/IOnCameraChangeListenerInvoker, GooglePlayServices")]
			void OnCameraChange (global::Android.Gms.Maps.Model.CameraPosition p0);

		}

		[global::Android.Runtime.Register ("com/google/android/gms/maps/GoogleMap$OnCameraChangeListener", DoNotGenerateAcw=true)]
		internal class IOnCameraChangeListenerInvoker : global::Java.Lang.Object, IOnCameraChangeListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/maps/GoogleMap$OnCameraChangeListener");
			IntPtr class_ref;

			public static IOnCameraChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCameraChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.maps.GoogleMap.OnCameraChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCameraChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnCameraChangeListenerInvoker); }
			}

			static Delegate cb_onCameraChange_Lcom_google_android_gms_maps_model_CameraPosition_;
#pragma warning disable 0169
			static Delegate GetOnCameraChange_Lcom_google_android_gms_maps_model_CameraPosition_Handler ()
			{
				if (cb_onCameraChange_Lcom_google_android_gms_maps_model_CameraPosition_ == null)
					cb_onCameraChange_Lcom_google_android_gms_maps_model_CameraPosition_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCameraChange_Lcom_google_android_gms_maps_model_CameraPosition_);
				return cb_onCameraChange_Lcom_google_android_gms_maps_model_CameraPosition_;
			}

			static void n_OnCameraChange_Lcom_google_android_gms_maps_model_CameraPosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Maps.GoogleMap.IOnCameraChangeListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMap.IOnCameraChangeListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Gms.Maps.Model.CameraPosition p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.CameraPosition> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraChange (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCameraChange_Lcom_google_android_gms_maps_model_CameraPosition_;
			public void OnCameraChange (global::Android.Gms.Maps.Model.CameraPosition p0)
			{
				if (id_onCameraChange_Lcom_google_android_gms_maps_model_CameraPosition_ == IntPtr.Zero)
					id_onCameraChange_Lcom_google_android_gms_maps_model_CameraPosition_ = JNIEnv.GetMethodID (class_ref, "onCameraChange", "(Lcom/google/android/gms/maps/model/CameraPosition;)V");
				JNIEnv.CallVoidMethod (Handle, id_onCameraChange_Lcom_google_android_gms_maps_model_CameraPosition_, new JValue (p0));
			}

		}

		public partial class CameraChangeEventArgs : global::System.EventArgs {

			public CameraChangeEventArgs (global::Android.Gms.Maps.Model.CameraPosition p0)
			{
				this.p0 = p0;
			}

			global::Android.Gms.Maps.Model.CameraPosition p0;
			public global::Android.Gms.Maps.Model.CameraPosition P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/google/android/gms/maps/GoogleMap_OnCameraChangeListenerImplementor")]
		internal sealed class IOnCameraChangeListenerImplementor : global::Java.Lang.Object, IOnCameraChangeListener {

			object sender;

			public IOnCameraChangeListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/maps/GoogleMap_OnCameraChangeListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CameraChangeEventArgs> Handler;
#pragma warning restore 0649

			public void OnCameraChange (global::Android.Gms.Maps.Model.CameraPosition p0)
			{
				if (Handler != null)
					Handler (sender, new CameraChangeEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnCameraChangeListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		[Register ("com/google/android/gms/maps/GoogleMap$OnInfoWindowClickListener", "", "Android.Gms.Maps.GoogleMap/IOnInfoWindowClickListenerInvoker")]
		public partial interface IOnInfoWindowClickListener : IJavaObject {

			[Register ("onInfoWindowClick", "(Lcom/google/android/gms/maps/model/Marker;)V", "GetOnInfoWindowClick_Lcom_google_android_gms_maps_model_Marker_Handler:Android.Gms.Maps.GoogleMap/IOnInfoWindowClickListenerInvoker, GooglePlayServices")]
			void OnInfoWindowClick (global::Android.Gms.Maps.Model.Marker p0);

		}

		[global::Android.Runtime.Register ("com/google/android/gms/maps/GoogleMap$OnInfoWindowClickListener", DoNotGenerateAcw=true)]
		internal class IOnInfoWindowClickListenerInvoker : global::Java.Lang.Object, IOnInfoWindowClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/maps/GoogleMap$OnInfoWindowClickListener");
			IntPtr class_ref;

			public static IOnInfoWindowClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnInfoWindowClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.maps.GoogleMap.OnInfoWindowClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnInfoWindowClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnInfoWindowClickListenerInvoker); }
			}

			static Delegate cb_onInfoWindowClick_Lcom_google_android_gms_maps_model_Marker_;
#pragma warning disable 0169
			static Delegate GetOnInfoWindowClick_Lcom_google_android_gms_maps_model_Marker_Handler ()
			{
				if (cb_onInfoWindowClick_Lcom_google_android_gms_maps_model_Marker_ == null)
					cb_onInfoWindowClick_Lcom_google_android_gms_maps_model_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInfoWindowClick_Lcom_google_android_gms_maps_model_Marker_);
				return cb_onInfoWindowClick_Lcom_google_android_gms_maps_model_Marker_;
			}

			static void n_OnInfoWindowClick_Lcom_google_android_gms_maps_model_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Maps.GoogleMap.IOnInfoWindowClickListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMap.IOnInfoWindowClickListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Gms.Maps.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnInfoWindowClick (p0);
			}
#pragma warning restore 0169

			IntPtr id_onInfoWindowClick_Lcom_google_android_gms_maps_model_Marker_;
			public void OnInfoWindowClick (global::Android.Gms.Maps.Model.Marker p0)
			{
				if (id_onInfoWindowClick_Lcom_google_android_gms_maps_model_Marker_ == IntPtr.Zero)
					id_onInfoWindowClick_Lcom_google_android_gms_maps_model_Marker_ = JNIEnv.GetMethodID (class_ref, "onInfoWindowClick", "(Lcom/google/android/gms/maps/model/Marker;)V");
				JNIEnv.CallVoidMethod (Handle, id_onInfoWindowClick_Lcom_google_android_gms_maps_model_Marker_, new JValue (p0));
			}

		}

		public partial class InfoWindowClickEventArgs : global::System.EventArgs {

			public InfoWindowClickEventArgs (global::Android.Gms.Maps.Model.Marker p0)
			{
				this.p0 = p0;
			}

			global::Android.Gms.Maps.Model.Marker p0;
			public global::Android.Gms.Maps.Model.Marker P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/google/android/gms/maps/GoogleMap_OnInfoWindowClickListenerImplementor")]
		internal sealed class IOnInfoWindowClickListenerImplementor : global::Java.Lang.Object, IOnInfoWindowClickListener {

			object sender;

			public IOnInfoWindowClickListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/maps/GoogleMap_OnInfoWindowClickListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<InfoWindowClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnInfoWindowClick (global::Android.Gms.Maps.Model.Marker p0)
			{
				if (Handler != null)
					Handler (sender, new InfoWindowClickEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnInfoWindowClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		[Register ("com/google/android/gms/maps/GoogleMap$OnMapClickListener", "", "Android.Gms.Maps.GoogleMap/IOnMapClickListenerInvoker")]
		public partial interface IOnMapClickListener : IJavaObject {

			[Register ("onMapClick", "(Lcom/google/android/gms/maps/model/LatLng;)V", "GetOnMapClick_Lcom_google_android_gms_maps_model_LatLng_Handler:Android.Gms.Maps.GoogleMap/IOnMapClickListenerInvoker, GooglePlayServices")]
			void OnMapClick (global::Android.Gms.Maps.Model.LatLng p0);

		}

		[global::Android.Runtime.Register ("com/google/android/gms/maps/GoogleMap$OnMapClickListener", DoNotGenerateAcw=true)]
		internal class IOnMapClickListenerInvoker : global::Java.Lang.Object, IOnMapClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/maps/GoogleMap$OnMapClickListener");
			IntPtr class_ref;

			public static IOnMapClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.maps.GoogleMap.OnMapClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnMapClickListenerInvoker); }
			}

			static Delegate cb_onMapClick_Lcom_google_android_gms_maps_model_LatLng_;
#pragma warning disable 0169
			static Delegate GetOnMapClick_Lcom_google_android_gms_maps_model_LatLng_Handler ()
			{
				if (cb_onMapClick_Lcom_google_android_gms_maps_model_LatLng_ == null)
					cb_onMapClick_Lcom_google_android_gms_maps_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapClick_Lcom_google_android_gms_maps_model_LatLng_);
				return cb_onMapClick_Lcom_google_android_gms_maps_model_LatLng_;
			}

			static void n_OnMapClick_Lcom_google_android_gms_maps_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Maps.GoogleMap.IOnMapClickListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMap.IOnMapClickListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Gms.Maps.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapClick (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapClick_Lcom_google_android_gms_maps_model_LatLng_;
			public void OnMapClick (global::Android.Gms.Maps.Model.LatLng p0)
			{
				if (id_onMapClick_Lcom_google_android_gms_maps_model_LatLng_ == IntPtr.Zero)
					id_onMapClick_Lcom_google_android_gms_maps_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "onMapClick", "(Lcom/google/android/gms/maps/model/LatLng;)V");
				JNIEnv.CallVoidMethod (Handle, id_onMapClick_Lcom_google_android_gms_maps_model_LatLng_, new JValue (p0));
			}

		}

		public partial class MapClickEventArgs : global::System.EventArgs {

			public MapClickEventArgs (global::Android.Gms.Maps.Model.LatLng p0)
			{
				this.p0 = p0;
			}

			global::Android.Gms.Maps.Model.LatLng p0;
			public global::Android.Gms.Maps.Model.LatLng P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/google/android/gms/maps/GoogleMap_OnMapClickListenerImplementor")]
		internal sealed class IOnMapClickListenerImplementor : global::Java.Lang.Object, IOnMapClickListener {

			object sender;

			public IOnMapClickListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/maps/GoogleMap_OnMapClickListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MapClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnMapClick (global::Android.Gms.Maps.Model.LatLng p0)
			{
				if (Handler != null)
					Handler (sender, new MapClickEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMapClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		[Register ("com/google/android/gms/maps/GoogleMap$OnMapLongClickListener", "", "Android.Gms.Maps.GoogleMap/IOnMapLongClickListenerInvoker")]
		public partial interface IOnMapLongClickListener : IJavaObject {

			[Register ("onMapLongClick", "(Lcom/google/android/gms/maps/model/LatLng;)V", "GetOnMapLongClick_Lcom_google_android_gms_maps_model_LatLng_Handler:Android.Gms.Maps.GoogleMap/IOnMapLongClickListenerInvoker, GooglePlayServices")]
			void OnMapLongClick (global::Android.Gms.Maps.Model.LatLng p0);

		}

		[global::Android.Runtime.Register ("com/google/android/gms/maps/GoogleMap$OnMapLongClickListener", DoNotGenerateAcw=true)]
		internal class IOnMapLongClickListenerInvoker : global::Java.Lang.Object, IOnMapLongClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/maps/GoogleMap$OnMapLongClickListener");
			IntPtr class_ref;

			public static IOnMapLongClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapLongClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.maps.GoogleMap.OnMapLongClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapLongClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnMapLongClickListenerInvoker); }
			}

			static Delegate cb_onMapLongClick_Lcom_google_android_gms_maps_model_LatLng_;
#pragma warning disable 0169
			static Delegate GetOnMapLongClick_Lcom_google_android_gms_maps_model_LatLng_Handler ()
			{
				if (cb_onMapLongClick_Lcom_google_android_gms_maps_model_LatLng_ == null)
					cb_onMapLongClick_Lcom_google_android_gms_maps_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapLongClick_Lcom_google_android_gms_maps_model_LatLng_);
				return cb_onMapLongClick_Lcom_google_android_gms_maps_model_LatLng_;
			}

			static void n_OnMapLongClick_Lcom_google_android_gms_maps_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Maps.GoogleMap.IOnMapLongClickListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMap.IOnMapLongClickListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Gms.Maps.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapLongClick (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapLongClick_Lcom_google_android_gms_maps_model_LatLng_;
			public void OnMapLongClick (global::Android.Gms.Maps.Model.LatLng p0)
			{
				if (id_onMapLongClick_Lcom_google_android_gms_maps_model_LatLng_ == IntPtr.Zero)
					id_onMapLongClick_Lcom_google_android_gms_maps_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "onMapLongClick", "(Lcom/google/android/gms/maps/model/LatLng;)V");
				JNIEnv.CallVoidMethod (Handle, id_onMapLongClick_Lcom_google_android_gms_maps_model_LatLng_, new JValue (p0));
			}

		}

		public partial class MapLongClickEventArgs : global::System.EventArgs {

			public MapLongClickEventArgs (global::Android.Gms.Maps.Model.LatLng p0)
			{
				this.p0 = p0;
			}

			global::Android.Gms.Maps.Model.LatLng p0;
			public global::Android.Gms.Maps.Model.LatLng P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/google/android/gms/maps/GoogleMap_OnMapLongClickListenerImplementor")]
		internal sealed class IOnMapLongClickListenerImplementor : global::Java.Lang.Object, IOnMapLongClickListener {

			object sender;

			public IOnMapLongClickListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/maps/GoogleMap_OnMapLongClickListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MapLongClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnMapLongClick (global::Android.Gms.Maps.Model.LatLng p0)
			{
				if (Handler != null)
					Handler (sender, new MapLongClickEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMapLongClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		[Register ("com/google/android/gms/maps/GoogleMap$OnMarkerClickListener", "", "Android.Gms.Maps.GoogleMap/IOnMarkerClickListenerInvoker")]
		public partial interface IOnMarkerClickListener : IJavaObject {

			[Register ("onMarkerClick", "(Lcom/google/android/gms/maps/model/Marker;)Z", "GetOnMarkerClick_Lcom_google_android_gms_maps_model_Marker_Handler:Android.Gms.Maps.GoogleMap/IOnMarkerClickListenerInvoker, GooglePlayServices")]
			bool OnMarkerClick (global::Android.Gms.Maps.Model.Marker p0);

		}

		[global::Android.Runtime.Register ("com/google/android/gms/maps/GoogleMap$OnMarkerClickListener", DoNotGenerateAcw=true)]
		internal class IOnMarkerClickListenerInvoker : global::Java.Lang.Object, IOnMarkerClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/maps/GoogleMap$OnMarkerClickListener");
			IntPtr class_ref;

			public static IOnMarkerClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMarkerClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.maps.GoogleMap.OnMarkerClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMarkerClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnMarkerClickListenerInvoker); }
			}

			static Delegate cb_onMarkerClick_Lcom_google_android_gms_maps_model_Marker_;
#pragma warning disable 0169
			static Delegate GetOnMarkerClick_Lcom_google_android_gms_maps_model_Marker_Handler ()
			{
				if (cb_onMarkerClick_Lcom_google_android_gms_maps_model_Marker_ == null)
					cb_onMarkerClick_Lcom_google_android_gms_maps_model_Marker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnMarkerClick_Lcom_google_android_gms_maps_model_Marker_);
				return cb_onMarkerClick_Lcom_google_android_gms_maps_model_Marker_;
			}

			static bool n_OnMarkerClick_Lcom_google_android_gms_maps_model_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Maps.GoogleMap.IOnMarkerClickListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMap.IOnMarkerClickListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Gms.Maps.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnMarkerClick (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onMarkerClick_Lcom_google_android_gms_maps_model_Marker_;
			public bool OnMarkerClick (global::Android.Gms.Maps.Model.Marker p0)
			{
				if (id_onMarkerClick_Lcom_google_android_gms_maps_model_Marker_ == IntPtr.Zero)
					id_onMarkerClick_Lcom_google_android_gms_maps_model_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerClick", "(Lcom/google/android/gms/maps/model/Marker;)Z");
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onMarkerClick_Lcom_google_android_gms_maps_model_Marker_, new JValue (p0));
				return __ret;
			}

		}

		public partial class MarkerClickEventArgs : global::System.EventArgs {

			public MarkerClickEventArgs (bool handled, global::Android.Gms.Maps.Model.Marker p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Android.Gms.Maps.Model.Marker p0;
			public global::Android.Gms.Maps.Model.Marker P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/google/android/gms/maps/GoogleMap_OnMarkerClickListenerImplementor")]
		internal sealed class IOnMarkerClickListenerImplementor : global::Java.Lang.Object, IOnMarkerClickListener {

			object sender;

			public IOnMarkerClickListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/maps/GoogleMap_OnMarkerClickListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MarkerClickEventArgs> Handler;
#pragma warning restore 0649

			public bool OnMarkerClick (global::Android.Gms.Maps.Model.Marker p0)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new MarkerClickEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnMarkerClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		[Register ("com/google/android/gms/maps/GoogleMap$OnMarkerDragListener", "", "Android.Gms.Maps.GoogleMap/IOnMarkerDragListenerInvoker")]
		public partial interface IOnMarkerDragListener : IJavaObject {

			[Register ("onMarkerDrag", "(Lcom/google/android/gms/maps/model/Marker;)V", "GetOnMarkerDrag_Lcom_google_android_gms_maps_model_Marker_Handler:Android.Gms.Maps.GoogleMap/IOnMarkerDragListenerInvoker, GooglePlayServices")]
			void OnMarkerDrag (global::Android.Gms.Maps.Model.Marker p0);

			[Register ("onMarkerDragEnd", "(Lcom/google/android/gms/maps/model/Marker;)V", "GetOnMarkerDragEnd_Lcom_google_android_gms_maps_model_Marker_Handler:Android.Gms.Maps.GoogleMap/IOnMarkerDragListenerInvoker, GooglePlayServices")]
			void OnMarkerDragEnd (global::Android.Gms.Maps.Model.Marker p0);

			[Register ("onMarkerDragStart", "(Lcom/google/android/gms/maps/model/Marker;)V", "GetOnMarkerDragStart_Lcom_google_android_gms_maps_model_Marker_Handler:Android.Gms.Maps.GoogleMap/IOnMarkerDragListenerInvoker, GooglePlayServices")]
			void OnMarkerDragStart (global::Android.Gms.Maps.Model.Marker p0);

		}

		[global::Android.Runtime.Register ("com/google/android/gms/maps/GoogleMap$OnMarkerDragListener", DoNotGenerateAcw=true)]
		internal class IOnMarkerDragListenerInvoker : global::Java.Lang.Object, IOnMarkerDragListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/maps/GoogleMap$OnMarkerDragListener");
			IntPtr class_ref;

			public static IOnMarkerDragListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMarkerDragListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.maps.GoogleMap.OnMarkerDragListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMarkerDragListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnMarkerDragListenerInvoker); }
			}

			static Delegate cb_onMarkerDrag_Lcom_google_android_gms_maps_model_Marker_;
#pragma warning disable 0169
			static Delegate GetOnMarkerDrag_Lcom_google_android_gms_maps_model_Marker_Handler ()
			{
				if (cb_onMarkerDrag_Lcom_google_android_gms_maps_model_Marker_ == null)
					cb_onMarkerDrag_Lcom_google_android_gms_maps_model_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMarkerDrag_Lcom_google_android_gms_maps_model_Marker_);
				return cb_onMarkerDrag_Lcom_google_android_gms_maps_model_Marker_;
			}

			static void n_OnMarkerDrag_Lcom_google_android_gms_maps_model_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Maps.GoogleMap.IOnMarkerDragListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMap.IOnMarkerDragListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Gms.Maps.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMarkerDrag (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMarkerDrag_Lcom_google_android_gms_maps_model_Marker_;
			public void OnMarkerDrag (global::Android.Gms.Maps.Model.Marker p0)
			{
				if (id_onMarkerDrag_Lcom_google_android_gms_maps_model_Marker_ == IntPtr.Zero)
					id_onMarkerDrag_Lcom_google_android_gms_maps_model_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerDrag", "(Lcom/google/android/gms/maps/model/Marker;)V");
				JNIEnv.CallVoidMethod (Handle, id_onMarkerDrag_Lcom_google_android_gms_maps_model_Marker_, new JValue (p0));
			}

			static Delegate cb_onMarkerDragEnd_Lcom_google_android_gms_maps_model_Marker_;
#pragma warning disable 0169
			static Delegate GetOnMarkerDragEnd_Lcom_google_android_gms_maps_model_Marker_Handler ()
			{
				if (cb_onMarkerDragEnd_Lcom_google_android_gms_maps_model_Marker_ == null)
					cb_onMarkerDragEnd_Lcom_google_android_gms_maps_model_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMarkerDragEnd_Lcom_google_android_gms_maps_model_Marker_);
				return cb_onMarkerDragEnd_Lcom_google_android_gms_maps_model_Marker_;
			}

			static void n_OnMarkerDragEnd_Lcom_google_android_gms_maps_model_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Maps.GoogleMap.IOnMarkerDragListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMap.IOnMarkerDragListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Gms.Maps.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMarkerDragEnd (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMarkerDragEnd_Lcom_google_android_gms_maps_model_Marker_;
			public void OnMarkerDragEnd (global::Android.Gms.Maps.Model.Marker p0)
			{
				if (id_onMarkerDragEnd_Lcom_google_android_gms_maps_model_Marker_ == IntPtr.Zero)
					id_onMarkerDragEnd_Lcom_google_android_gms_maps_model_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerDragEnd", "(Lcom/google/android/gms/maps/model/Marker;)V");
				JNIEnv.CallVoidMethod (Handle, id_onMarkerDragEnd_Lcom_google_android_gms_maps_model_Marker_, new JValue (p0));
			}

			static Delegate cb_onMarkerDragStart_Lcom_google_android_gms_maps_model_Marker_;
#pragma warning disable 0169
			static Delegate GetOnMarkerDragStart_Lcom_google_android_gms_maps_model_Marker_Handler ()
			{
				if (cb_onMarkerDragStart_Lcom_google_android_gms_maps_model_Marker_ == null)
					cb_onMarkerDragStart_Lcom_google_android_gms_maps_model_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMarkerDragStart_Lcom_google_android_gms_maps_model_Marker_);
				return cb_onMarkerDragStart_Lcom_google_android_gms_maps_model_Marker_;
			}

			static void n_OnMarkerDragStart_Lcom_google_android_gms_maps_model_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Maps.GoogleMap.IOnMarkerDragListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMap.IOnMarkerDragListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Gms.Maps.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMarkerDragStart (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMarkerDragStart_Lcom_google_android_gms_maps_model_Marker_;
			public void OnMarkerDragStart (global::Android.Gms.Maps.Model.Marker p0)
			{
				if (id_onMarkerDragStart_Lcom_google_android_gms_maps_model_Marker_ == IntPtr.Zero)
					id_onMarkerDragStart_Lcom_google_android_gms_maps_model_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerDragStart", "(Lcom/google/android/gms/maps/model/Marker;)V");
				JNIEnv.CallVoidMethod (Handle, id_onMarkerDragStart_Lcom_google_android_gms_maps_model_Marker_, new JValue (p0));
			}

		}

		public partial class MarkerDragEventArgs : global::System.EventArgs {

			public MarkerDragEventArgs (global::Android.Gms.Maps.Model.Marker p0)
			{
				this.p0 = p0;
			}

			global::Android.Gms.Maps.Model.Marker p0;
			public global::Android.Gms.Maps.Model.Marker P0 {
				get { return p0; }
			}
		}

		public partial class MarkerDragEndEventArgs : global::System.EventArgs {

			public MarkerDragEndEventArgs (global::Android.Gms.Maps.Model.Marker p0)
			{
				this.p0 = p0;
			}

			global::Android.Gms.Maps.Model.Marker p0;
			public global::Android.Gms.Maps.Model.Marker P0 {
				get { return p0; }
			}
		}

		public partial class MarkerDragStartEventArgs : global::System.EventArgs {

			public MarkerDragStartEventArgs (global::Android.Gms.Maps.Model.Marker p0)
			{
				this.p0 = p0;
			}

			global::Android.Gms.Maps.Model.Marker p0;
			public global::Android.Gms.Maps.Model.Marker P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/google/android/gms/maps/GoogleMap_OnMarkerDragListenerImplementor")]
		internal sealed class IOnMarkerDragListenerImplementor : global::Java.Lang.Object, IOnMarkerDragListener {

			object sender;

			public IOnMarkerDragListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/maps/GoogleMap_OnMarkerDragListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MarkerDragEventArgs> OnMarkerDragHandler;
#pragma warning restore 0649

			public void OnMarkerDrag (global::Android.Gms.Maps.Model.Marker p0)
			{
				if (OnMarkerDragHandler != null)
					OnMarkerDragHandler (sender, new MarkerDragEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<MarkerDragEndEventArgs> OnMarkerDragEndHandler;
#pragma warning restore 0649

			public void OnMarkerDragEnd (global::Android.Gms.Maps.Model.Marker p0)
			{
				if (OnMarkerDragEndHandler != null)
					OnMarkerDragEndHandler (sender, new MarkerDragEndEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<MarkerDragStartEventArgs> OnMarkerDragStartHandler;
#pragma warning restore 0649

			public void OnMarkerDragStart (global::Android.Gms.Maps.Model.Marker p0)
			{
				if (OnMarkerDragStartHandler != null)
					OnMarkerDragStartHandler (sender, new MarkerDragStartEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMarkerDragListenerImplementor value)
			{
				return value.OnMarkerDragHandler == null && value.OnMarkerDragEndHandler == null && value.OnMarkerDragStartHandler == null;
			}
		}


		[Register ("com/google/android/gms/maps/GoogleMap$OnMyLocationChangeListener", "", "Android.Gms.Maps.GoogleMap/IOnMyLocationChangeListenerInvoker")]
		public partial interface IOnMyLocationChangeListener : IJavaObject {

			[Register ("onMyLocationChange", "(Landroid/location/Location;)V", "GetOnMyLocationChange_Landroid_location_Location_Handler:Android.Gms.Maps.GoogleMap/IOnMyLocationChangeListenerInvoker, GooglePlayServices")]
			void OnMyLocationChange (global::Android.Locations.Location p0);

		}

		[global::Android.Runtime.Register ("com/google/android/gms/maps/GoogleMap$OnMyLocationChangeListener", DoNotGenerateAcw=true)]
		internal class IOnMyLocationChangeListenerInvoker : global::Java.Lang.Object, IOnMyLocationChangeListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/maps/GoogleMap$OnMyLocationChangeListener");
			IntPtr class_ref;

			public static IOnMyLocationChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMyLocationChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.maps.GoogleMap.OnMyLocationChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMyLocationChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnMyLocationChangeListenerInvoker); }
			}

			static Delegate cb_onMyLocationChange_Landroid_location_Location_;
#pragma warning disable 0169
			static Delegate GetOnMyLocationChange_Landroid_location_Location_Handler ()
			{
				if (cb_onMyLocationChange_Landroid_location_Location_ == null)
					cb_onMyLocationChange_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMyLocationChange_Landroid_location_Location_);
				return cb_onMyLocationChange_Landroid_location_Location_;
			}

			static void n_OnMyLocationChange_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Maps.GoogleMap.IOnMyLocationChangeListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMap.IOnMyLocationChangeListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Locations.Location p0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMyLocationChange (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMyLocationChange_Landroid_location_Location_;
			public void OnMyLocationChange (global::Android.Locations.Location p0)
			{
				if (id_onMyLocationChange_Landroid_location_Location_ == IntPtr.Zero)
					id_onMyLocationChange_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "onMyLocationChange", "(Landroid/location/Location;)V");
				JNIEnv.CallVoidMethod (Handle, id_onMyLocationChange_Landroid_location_Location_, new JValue (p0));
			}

		}

		public partial class MyLocationChangeEventArgs : global::System.EventArgs {

			public MyLocationChangeEventArgs (global::Android.Locations.Location p0)
			{
				this.p0 = p0;
			}

			global::Android.Locations.Location p0;
			public global::Android.Locations.Location P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/google/android/gms/maps/GoogleMap_OnMyLocationChangeListenerImplementor")]
		internal sealed class IOnMyLocationChangeListenerImplementor : global::Java.Lang.Object, IOnMyLocationChangeListener {

			object sender;

			public IOnMyLocationChangeListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/maps/GoogleMap_OnMyLocationChangeListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MyLocationChangeEventArgs> Handler;
#pragma warning restore 0649

			public void OnMyLocationChange (global::Android.Locations.Location p0)
			{
				if (Handler != null)
					Handler (sender, new MyLocationChangeEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMyLocationChangeListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/GoogleMap", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GoogleMap); }
		}

		internal GoogleMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getCameraPosition;
		public global::Android.Gms.Maps.Model.CameraPosition CameraPosition {
			[Register ("getCameraPosition", "()Lcom/google/android/gms/maps/model/CameraPosition;", "GetGetCameraPositionHandler")]
			get {
				if (id_getCameraPosition == IntPtr.Zero)
					id_getCameraPosition = JNIEnv.GetMethodID (class_ref, "getCameraPosition", "()Lcom/google/android/gms/maps/model/CameraPosition;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.CameraPosition> (JNIEnv.CallObjectMethod  (Handle, id_getCameraPosition), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isIndoorEnabled;
		public bool IsIndoorEnabled {
			[Register ("isIndoorEnabled", "()Z", "GetIsIndoorEnabledHandler")]
			get {
				if (id_isIndoorEnabled == IntPtr.Zero)
					id_isIndoorEnabled = JNIEnv.GetMethodID (class_ref, "isIndoorEnabled", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isIndoorEnabled);
			}
		}

		static IntPtr id_getMapType;
		static IntPtr id_setMapType_I;
		public int MapType {
			[Register ("getMapType", "()I", "GetGetMapTypeHandler")]
			get {
				if (id_getMapType == IntPtr.Zero)
					id_getMapType = JNIEnv.GetMethodID (class_ref, "getMapType", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getMapType);
			}
			[Register ("setMapType", "(I)V", "GetSetMapType_IHandler")]
			set {
				if (id_setMapType_I == IntPtr.Zero)
					id_setMapType_I = JNIEnv.GetMethodID (class_ref, "setMapType", "(I)V");
				JNIEnv.CallVoidMethod  (Handle, id_setMapType_I, new JValue (value));
			}
		}

		static IntPtr id_getMaxZoomLevel;
		public float MaxZoomLevel {
			[Register ("getMaxZoomLevel", "()F", "GetGetMaxZoomLevelHandler")]
			get {
				if (id_getMaxZoomLevel == IntPtr.Zero)
					id_getMaxZoomLevel = JNIEnv.GetMethodID (class_ref, "getMaxZoomLevel", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getMaxZoomLevel);
			}
		}

		static IntPtr id_getMinZoomLevel;
		public float MinZoomLevel {
			[Register ("getMinZoomLevel", "()F", "GetGetMinZoomLevelHandler")]
			get {
				if (id_getMinZoomLevel == IntPtr.Zero)
					id_getMinZoomLevel = JNIEnv.GetMethodID (class_ref, "getMinZoomLevel", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getMinZoomLevel);
			}
		}

		static IntPtr id_getMyLocation;
		public global::Android.Locations.Location MyLocation {
			[Register ("getMyLocation", "()Landroid/location/Location;", "GetGetMyLocationHandler")]
			get {
				if (id_getMyLocation == IntPtr.Zero)
					id_getMyLocation = JNIEnv.GetMethodID (class_ref, "getMyLocation", "()Landroid/location/Location;");
				return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallObjectMethod  (Handle, id_getMyLocation), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isMyLocationEnabled;
		static IntPtr id_setMyLocationEnabled_Z;
		public bool MyLocationEnabled {
			[Register ("isMyLocationEnabled", "()Z", "GetIsMyLocationEnabledHandler")]
			get {
				if (id_isMyLocationEnabled == IntPtr.Zero)
					id_isMyLocationEnabled = JNIEnv.GetMethodID (class_ref, "isMyLocationEnabled", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isMyLocationEnabled);
			}
			[Register ("setMyLocationEnabled", "(Z)V", "GetSetMyLocationEnabled_ZHandler")]
			set {
				if (id_setMyLocationEnabled_Z == IntPtr.Zero)
					id_setMyLocationEnabled_Z = JNIEnv.GetMethodID (class_ref, "setMyLocationEnabled", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setMyLocationEnabled_Z, new JValue (value));
			}
		}

		static IntPtr id_getProjection;
		public global::Android.Gms.Maps.Projection Projection {
			[Register ("getProjection", "()Lcom/google/android/gms/maps/Projection;", "GetGetProjectionHandler")]
			get {
				if (id_getProjection == IntPtr.Zero)
					id_getProjection = JNIEnv.GetMethodID (class_ref, "getProjection", "()Lcom/google/android/gms/maps/Projection;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Projection> (JNIEnv.CallObjectMethod  (Handle, id_getProjection), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isTrafficEnabled;
		static IntPtr id_setTrafficEnabled_Z;
		public bool TrafficEnabled {
			[Register ("isTrafficEnabled", "()Z", "GetIsTrafficEnabledHandler")]
			get {
				if (id_isTrafficEnabled == IntPtr.Zero)
					id_isTrafficEnabled = JNIEnv.GetMethodID (class_ref, "isTrafficEnabled", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isTrafficEnabled);
			}
			[Register ("setTrafficEnabled", "(Z)V", "GetSetTrafficEnabled_ZHandler")]
			set {
				if (id_setTrafficEnabled_Z == IntPtr.Zero)
					id_setTrafficEnabled_Z = JNIEnv.GetMethodID (class_ref, "setTrafficEnabled", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setTrafficEnabled_Z, new JValue (value));
			}
		}

		static IntPtr id_getUiSettings;
		public global::Android.Gms.Maps.UiSettings UiSettings {
			[Register ("getUiSettings", "()Lcom/google/android/gms/maps/UiSettings;", "GetGetUiSettingsHandler")]
			get {
				if (id_getUiSettings == IntPtr.Zero)
					id_getUiSettings = JNIEnv.GetMethodID (class_ref, "getUiSettings", "()Lcom/google/android/gms/maps/UiSettings;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.UiSettings> (JNIEnv.CallObjectMethod  (Handle, id_getUiSettings), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_addCircle_Lcom_google_android_gms_maps_model_CircleOptions_;
		[Register ("addCircle", "(Lcom/google/android/gms/maps/model/CircleOptions;)Lcom/google/android/gms/maps/model/Circle;", "")]
		public global::Android.Gms.Maps.Model.Circle AddCircle (global::Android.Gms.Maps.Model.CircleOptions p0)
		{
			if (id_addCircle_Lcom_google_android_gms_maps_model_CircleOptions_ == IntPtr.Zero)
				id_addCircle_Lcom_google_android_gms_maps_model_CircleOptions_ = JNIEnv.GetMethodID (class_ref, "addCircle", "(Lcom/google/android/gms/maps/model/CircleOptions;)Lcom/google/android/gms/maps/model/Circle;");
			global::Android.Gms.Maps.Model.Circle __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.Circle> (JNIEnv.CallObjectMethod  (Handle, id_addCircle_Lcom_google_android_gms_maps_model_CircleOptions_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_addGroundOverlay_Lcom_google_android_gms_maps_model_GroundOverlayOptions_;
		[Register ("addGroundOverlay", "(Lcom/google/android/gms/maps/model/GroundOverlayOptions;)Lcom/google/android/gms/maps/model/GroundOverlay;", "")]
		public global::Android.Gms.Maps.Model.GroundOverlay AddGroundOverlay (global::Android.Gms.Maps.Model.GroundOverlayOptions p0)
		{
			if (id_addGroundOverlay_Lcom_google_android_gms_maps_model_GroundOverlayOptions_ == IntPtr.Zero)
				id_addGroundOverlay_Lcom_google_android_gms_maps_model_GroundOverlayOptions_ = JNIEnv.GetMethodID (class_ref, "addGroundOverlay", "(Lcom/google/android/gms/maps/model/GroundOverlayOptions;)Lcom/google/android/gms/maps/model/GroundOverlay;");
			global::Android.Gms.Maps.Model.GroundOverlay __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.GroundOverlay> (JNIEnv.CallObjectMethod  (Handle, id_addGroundOverlay_Lcom_google_android_gms_maps_model_GroundOverlayOptions_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_addMarker_Lcom_google_android_gms_maps_model_MarkerOptions_;
		[Register ("addMarker", "(Lcom/google/android/gms/maps/model/MarkerOptions;)Lcom/google/android/gms/maps/model/Marker;", "")]
		public global::Android.Gms.Maps.Model.Marker AddMarker (global::Android.Gms.Maps.Model.MarkerOptions p0)
		{
			if (id_addMarker_Lcom_google_android_gms_maps_model_MarkerOptions_ == IntPtr.Zero)
				id_addMarker_Lcom_google_android_gms_maps_model_MarkerOptions_ = JNIEnv.GetMethodID (class_ref, "addMarker", "(Lcom/google/android/gms/maps/model/MarkerOptions;)Lcom/google/android/gms/maps/model/Marker;");
			global::Android.Gms.Maps.Model.Marker __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.Marker> (JNIEnv.CallObjectMethod  (Handle, id_addMarker_Lcom_google_android_gms_maps_model_MarkerOptions_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_addPolygon_Lcom_google_android_gms_maps_model_PolygonOptions_;
		[Register ("addPolygon", "(Lcom/google/android/gms/maps/model/PolygonOptions;)Lcom/google/android/gms/maps/model/Polygon;", "")]
		public global::Android.Gms.Maps.Model.Polygon AddPolygon (global::Android.Gms.Maps.Model.PolygonOptions p0)
		{
			if (id_addPolygon_Lcom_google_android_gms_maps_model_PolygonOptions_ == IntPtr.Zero)
				id_addPolygon_Lcom_google_android_gms_maps_model_PolygonOptions_ = JNIEnv.GetMethodID (class_ref, "addPolygon", "(Lcom/google/android/gms/maps/model/PolygonOptions;)Lcom/google/android/gms/maps/model/Polygon;");
			global::Android.Gms.Maps.Model.Polygon __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.Polygon> (JNIEnv.CallObjectMethod  (Handle, id_addPolygon_Lcom_google_android_gms_maps_model_PolygonOptions_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_addPolyline_Lcom_google_android_gms_maps_model_PolylineOptions_;
		[Register ("addPolyline", "(Lcom/google/android/gms/maps/model/PolylineOptions;)Lcom/google/android/gms/maps/model/Polyline;", "")]
		public global::Android.Gms.Maps.Model.Polyline AddPolyline (global::Android.Gms.Maps.Model.PolylineOptions p0)
		{
			if (id_addPolyline_Lcom_google_android_gms_maps_model_PolylineOptions_ == IntPtr.Zero)
				id_addPolyline_Lcom_google_android_gms_maps_model_PolylineOptions_ = JNIEnv.GetMethodID (class_ref, "addPolyline", "(Lcom/google/android/gms/maps/model/PolylineOptions;)Lcom/google/android/gms/maps/model/Polyline;");
			global::Android.Gms.Maps.Model.Polyline __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.Polyline> (JNIEnv.CallObjectMethod  (Handle, id_addPolyline_Lcom_google_android_gms_maps_model_PolylineOptions_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_addTileOverlay_Lcom_google_android_gms_maps_model_TileOverlayOptions_;
		[Register ("addTileOverlay", "(Lcom/google/android/gms/maps/model/TileOverlayOptions;)Lcom/google/android/gms/maps/model/TileOverlay;", "")]
		public global::Android.Gms.Maps.Model.TileOverlay AddTileOverlay (global::Android.Gms.Maps.Model.TileOverlayOptions p0)
		{
			if (id_addTileOverlay_Lcom_google_android_gms_maps_model_TileOverlayOptions_ == IntPtr.Zero)
				id_addTileOverlay_Lcom_google_android_gms_maps_model_TileOverlayOptions_ = JNIEnv.GetMethodID (class_ref, "addTileOverlay", "(Lcom/google/android/gms/maps/model/TileOverlayOptions;)Lcom/google/android/gms/maps/model/TileOverlay;");
			global::Android.Gms.Maps.Model.TileOverlay __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.TileOverlay> (JNIEnv.CallObjectMethod  (Handle, id_addTileOverlay_Lcom_google_android_gms_maps_model_TileOverlayOptions_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_animateCamera_Lcom_google_android_gms_maps_CameraUpdate_;
		[Register ("animateCamera", "(Lcom/google/android/gms/maps/CameraUpdate;)V", "")]
		public void AnimateCamera (global::Android.Gms.Maps.CameraUpdate p0)
		{
			if (id_animateCamera_Lcom_google_android_gms_maps_CameraUpdate_ == IntPtr.Zero)
				id_animateCamera_Lcom_google_android_gms_maps_CameraUpdate_ = JNIEnv.GetMethodID (class_ref, "animateCamera", "(Lcom/google/android/gms/maps/CameraUpdate;)V");
			JNIEnv.CallVoidMethod  (Handle, id_animateCamera_Lcom_google_android_gms_maps_CameraUpdate_, new JValue (p0));
		}

		static IntPtr id_animateCamera_Lcom_google_android_gms_maps_CameraUpdate_Lcom_google_android_gms_maps_GoogleMap_CancelableCallback_;
		[Register ("animateCamera", "(Lcom/google/android/gms/maps/CameraUpdate;Lcom/google/android/gms/maps/GoogleMap$CancelableCallback;)V", "")]
		public void AnimateCamera (global::Android.Gms.Maps.CameraUpdate p0, global::Android.Gms.Maps.GoogleMap.ICancelableCallback p1)
		{
			if (id_animateCamera_Lcom_google_android_gms_maps_CameraUpdate_Lcom_google_android_gms_maps_GoogleMap_CancelableCallback_ == IntPtr.Zero)
				id_animateCamera_Lcom_google_android_gms_maps_CameraUpdate_Lcom_google_android_gms_maps_GoogleMap_CancelableCallback_ = JNIEnv.GetMethodID (class_ref, "animateCamera", "(Lcom/google/android/gms/maps/CameraUpdate;Lcom/google/android/gms/maps/GoogleMap$CancelableCallback;)V");
			JNIEnv.CallVoidMethod  (Handle, id_animateCamera_Lcom_google_android_gms_maps_CameraUpdate_Lcom_google_android_gms_maps_GoogleMap_CancelableCallback_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_animateCamera_Lcom_google_android_gms_maps_CameraUpdate_ILcom_google_android_gms_maps_GoogleMap_CancelableCallback_;
		[Register ("animateCamera", "(Lcom/google/android/gms/maps/CameraUpdate;ILcom/google/android/gms/maps/GoogleMap$CancelableCallback;)V", "")]
		public void AnimateCamera (global::Android.Gms.Maps.CameraUpdate p0, int p1, global::Android.Gms.Maps.GoogleMap.ICancelableCallback p2)
		{
			if (id_animateCamera_Lcom_google_android_gms_maps_CameraUpdate_ILcom_google_android_gms_maps_GoogleMap_CancelableCallback_ == IntPtr.Zero)
				id_animateCamera_Lcom_google_android_gms_maps_CameraUpdate_ILcom_google_android_gms_maps_GoogleMap_CancelableCallback_ = JNIEnv.GetMethodID (class_ref, "animateCamera", "(Lcom/google/android/gms/maps/CameraUpdate;ILcom/google/android/gms/maps/GoogleMap$CancelableCallback;)V");
			JNIEnv.CallVoidMethod  (Handle, id_animateCamera_Lcom_google_android_gms_maps_CameraUpdate_ILcom_google_android_gms_maps_GoogleMap_CancelableCallback_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_clear;
		[Register ("clear", "()V", "")]
		public void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_clear);
		}

		static IntPtr id_moveCamera_Lcom_google_android_gms_maps_CameraUpdate_;
		[Register ("moveCamera", "(Lcom/google/android/gms/maps/CameraUpdate;)V", "")]
		public void MoveCamera (global::Android.Gms.Maps.CameraUpdate p0)
		{
			if (id_moveCamera_Lcom_google_android_gms_maps_CameraUpdate_ == IntPtr.Zero)
				id_moveCamera_Lcom_google_android_gms_maps_CameraUpdate_ = JNIEnv.GetMethodID (class_ref, "moveCamera", "(Lcom/google/android/gms/maps/CameraUpdate;)V");
			JNIEnv.CallVoidMethod  (Handle, id_moveCamera_Lcom_google_android_gms_maps_CameraUpdate_, new JValue (p0));
		}

		static IntPtr id_setIndoorEnabled_Z;
		[Register ("setIndoorEnabled", "(Z)Z", "")]
		public bool SetIndoorEnabled (bool p0)
		{
			if (id_setIndoorEnabled_Z == IntPtr.Zero)
				id_setIndoorEnabled_Z = JNIEnv.GetMethodID (class_ref, "setIndoorEnabled", "(Z)Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_setIndoorEnabled_Z, new JValue (p0));
		}

		static IntPtr id_setInfoWindowAdapter_Lcom_google_android_gms_maps_GoogleMap_InfoWindowAdapter_;
		[Register ("setInfoWindowAdapter", "(Lcom/google/android/gms/maps/GoogleMap$InfoWindowAdapter;)V", "")]
		public void SetInfoWindowAdapter (global::Android.Gms.Maps.GoogleMap.IInfoWindowAdapter p0)
		{
			if (id_setInfoWindowAdapter_Lcom_google_android_gms_maps_GoogleMap_InfoWindowAdapter_ == IntPtr.Zero)
				id_setInfoWindowAdapter_Lcom_google_android_gms_maps_GoogleMap_InfoWindowAdapter_ = JNIEnv.GetMethodID (class_ref, "setInfoWindowAdapter", "(Lcom/google/android/gms/maps/GoogleMap$InfoWindowAdapter;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setInfoWindowAdapter_Lcom_google_android_gms_maps_GoogleMap_InfoWindowAdapter_, new JValue (p0));
		}

		static IntPtr id_setLocationSource_Lcom_google_android_gms_maps_LocationSource_;
		[Register ("setLocationSource", "(Lcom/google/android/gms/maps/LocationSource;)V", "")]
		public void SetLocationSource (global::Android.Gms.Maps.ILocationSource p0)
		{
			if (id_setLocationSource_Lcom_google_android_gms_maps_LocationSource_ == IntPtr.Zero)
				id_setLocationSource_Lcom_google_android_gms_maps_LocationSource_ = JNIEnv.GetMethodID (class_ref, "setLocationSource", "(Lcom/google/android/gms/maps/LocationSource;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setLocationSource_Lcom_google_android_gms_maps_LocationSource_, new JValue (p0));
		}

		static IntPtr id_setOnCameraChangeListener_Lcom_google_android_gms_maps_GoogleMap_OnCameraChangeListener_;
		[Register ("setOnCameraChangeListener", "(Lcom/google/android/gms/maps/GoogleMap$OnCameraChangeListener;)V", "")]
		public void SetOnCameraChangeListener (global::Android.Gms.Maps.GoogleMap.IOnCameraChangeListener p0)
		{
			if (id_setOnCameraChangeListener_Lcom_google_android_gms_maps_GoogleMap_OnCameraChangeListener_ == IntPtr.Zero)
				id_setOnCameraChangeListener_Lcom_google_android_gms_maps_GoogleMap_OnCameraChangeListener_ = JNIEnv.GetMethodID (class_ref, "setOnCameraChangeListener", "(Lcom/google/android/gms/maps/GoogleMap$OnCameraChangeListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setOnCameraChangeListener_Lcom_google_android_gms_maps_GoogleMap_OnCameraChangeListener_, new JValue (p0));
		}

		static IntPtr id_setOnInfoWindowClickListener_Lcom_google_android_gms_maps_GoogleMap_OnInfoWindowClickListener_;
		[Register ("setOnInfoWindowClickListener", "(Lcom/google/android/gms/maps/GoogleMap$OnInfoWindowClickListener;)V", "")]
		public void SetOnInfoWindowClickListener (global::Android.Gms.Maps.GoogleMap.IOnInfoWindowClickListener p0)
		{
			if (id_setOnInfoWindowClickListener_Lcom_google_android_gms_maps_GoogleMap_OnInfoWindowClickListener_ == IntPtr.Zero)
				id_setOnInfoWindowClickListener_Lcom_google_android_gms_maps_GoogleMap_OnInfoWindowClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnInfoWindowClickListener", "(Lcom/google/android/gms/maps/GoogleMap$OnInfoWindowClickListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setOnInfoWindowClickListener_Lcom_google_android_gms_maps_GoogleMap_OnInfoWindowClickListener_, new JValue (p0));
		}

		static IntPtr id_setOnMapClickListener_Lcom_google_android_gms_maps_GoogleMap_OnMapClickListener_;
		[Register ("setOnMapClickListener", "(Lcom/google/android/gms/maps/GoogleMap$OnMapClickListener;)V", "")]
		public void SetOnMapClickListener (global::Android.Gms.Maps.GoogleMap.IOnMapClickListener p0)
		{
			if (id_setOnMapClickListener_Lcom_google_android_gms_maps_GoogleMap_OnMapClickListener_ == IntPtr.Zero)
				id_setOnMapClickListener_Lcom_google_android_gms_maps_GoogleMap_OnMapClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnMapClickListener", "(Lcom/google/android/gms/maps/GoogleMap$OnMapClickListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setOnMapClickListener_Lcom_google_android_gms_maps_GoogleMap_OnMapClickListener_, new JValue (p0));
		}

		static IntPtr id_setOnMapLongClickListener_Lcom_google_android_gms_maps_GoogleMap_OnMapLongClickListener_;
		[Register ("setOnMapLongClickListener", "(Lcom/google/android/gms/maps/GoogleMap$OnMapLongClickListener;)V", "")]
		public void SetOnMapLongClickListener (global::Android.Gms.Maps.GoogleMap.IOnMapLongClickListener p0)
		{
			if (id_setOnMapLongClickListener_Lcom_google_android_gms_maps_GoogleMap_OnMapLongClickListener_ == IntPtr.Zero)
				id_setOnMapLongClickListener_Lcom_google_android_gms_maps_GoogleMap_OnMapLongClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnMapLongClickListener", "(Lcom/google/android/gms/maps/GoogleMap$OnMapLongClickListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setOnMapLongClickListener_Lcom_google_android_gms_maps_GoogleMap_OnMapLongClickListener_, new JValue (p0));
		}

		static IntPtr id_setOnMarkerClickListener_Lcom_google_android_gms_maps_GoogleMap_OnMarkerClickListener_;
		[Register ("setOnMarkerClickListener", "(Lcom/google/android/gms/maps/GoogleMap$OnMarkerClickListener;)V", "")]
		public void SetOnMarkerClickListener (global::Android.Gms.Maps.GoogleMap.IOnMarkerClickListener p0)
		{
			if (id_setOnMarkerClickListener_Lcom_google_android_gms_maps_GoogleMap_OnMarkerClickListener_ == IntPtr.Zero)
				id_setOnMarkerClickListener_Lcom_google_android_gms_maps_GoogleMap_OnMarkerClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnMarkerClickListener", "(Lcom/google/android/gms/maps/GoogleMap$OnMarkerClickListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setOnMarkerClickListener_Lcom_google_android_gms_maps_GoogleMap_OnMarkerClickListener_, new JValue (p0));
		}

		static IntPtr id_setOnMarkerDragListener_Lcom_google_android_gms_maps_GoogleMap_OnMarkerDragListener_;
		[Register ("setOnMarkerDragListener", "(Lcom/google/android/gms/maps/GoogleMap$OnMarkerDragListener;)V", "")]
		public void SetOnMarkerDragListener (global::Android.Gms.Maps.GoogleMap.IOnMarkerDragListener p0)
		{
			if (id_setOnMarkerDragListener_Lcom_google_android_gms_maps_GoogleMap_OnMarkerDragListener_ == IntPtr.Zero)
				id_setOnMarkerDragListener_Lcom_google_android_gms_maps_GoogleMap_OnMarkerDragListener_ = JNIEnv.GetMethodID (class_ref, "setOnMarkerDragListener", "(Lcom/google/android/gms/maps/GoogleMap$OnMarkerDragListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setOnMarkerDragListener_Lcom_google_android_gms_maps_GoogleMap_OnMarkerDragListener_, new JValue (p0));
		}

		static IntPtr id_setOnMyLocationChangeListener_Lcom_google_android_gms_maps_GoogleMap_OnMyLocationChangeListener_;
		[Register ("setOnMyLocationChangeListener", "(Lcom/google/android/gms/maps/GoogleMap$OnMyLocationChangeListener;)V", "")]
		public void SetOnMyLocationChangeListener (global::Android.Gms.Maps.GoogleMap.IOnMyLocationChangeListener p0)
		{
			if (id_setOnMyLocationChangeListener_Lcom_google_android_gms_maps_GoogleMap_OnMyLocationChangeListener_ == IntPtr.Zero)
				id_setOnMyLocationChangeListener_Lcom_google_android_gms_maps_GoogleMap_OnMyLocationChangeListener_ = JNIEnv.GetMethodID (class_ref, "setOnMyLocationChangeListener", "(Lcom/google/android/gms/maps/GoogleMap$OnMyLocationChangeListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setOnMyLocationChangeListener_Lcom_google_android_gms_maps_GoogleMap_OnMyLocationChangeListener_, new JValue (p0));
		}

		static IntPtr id_stopAnimation;
		[Register ("stopAnimation", "()V", "")]
		public void StopAnimation ()
		{
			if (id_stopAnimation == IntPtr.Zero)
				id_stopAnimation = JNIEnv.GetMethodID (class_ref, "stopAnimation", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_stopAnimation);
		}

#region "Event implementation for Android.Gms.Maps.GoogleMap.IOnCameraChangeListener"
		public event EventHandler<global::Android.Gms.Maps.GoogleMap.CameraChangeEventArgs> CameraChange {
			add {
				global::Java.Interop.AndroidEventHelper.AddEventHandler<global::Android.Gms.Maps.GoogleMap.IOnCameraChangeListener, global::Android.Gms.Maps.GoogleMap.IOnCameraChangeListenerImplementor>(
						ref weak_implementor_SetOnCameraChangeListener,
						__CreateIOnCameraChangeListenerImplementor,
						SetOnCameraChangeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.AndroidEventHelper.RemoveEventHandler<global::Android.Gms.Maps.GoogleMap.IOnCameraChangeListener, global::Android.Gms.Maps.GoogleMap.IOnCameraChangeListenerImplementor>(
						ref weak_implementor_SetOnCameraChangeListener,
						global::Android.Gms.Maps.GoogleMap.IOnCameraChangeListenerImplementor.__IsEmpty,
						SetOnCameraChangeListener,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnCameraChangeListener;

		global::Android.Gms.Maps.GoogleMap.IOnCameraChangeListenerImplementor __CreateIOnCameraChangeListenerImplementor ()
		{
			return new global::Android.Gms.Maps.GoogleMap.IOnCameraChangeListenerImplementor (this);
		}
#endregion
#region "Event implementation for Android.Gms.Maps.GoogleMap.IOnInfoWindowClickListener"
		public event EventHandler<global::Android.Gms.Maps.GoogleMap.InfoWindowClickEventArgs> InfoWindowClick {
			add {
				global::Java.Interop.AndroidEventHelper.AddEventHandler<global::Android.Gms.Maps.GoogleMap.IOnInfoWindowClickListener, global::Android.Gms.Maps.GoogleMap.IOnInfoWindowClickListenerImplementor>(
						ref weak_implementor_SetOnInfoWindowClickListener,
						__CreateIOnInfoWindowClickListenerImplementor,
						SetOnInfoWindowClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.AndroidEventHelper.RemoveEventHandler<global::Android.Gms.Maps.GoogleMap.IOnInfoWindowClickListener, global::Android.Gms.Maps.GoogleMap.IOnInfoWindowClickListenerImplementor>(
						ref weak_implementor_SetOnInfoWindowClickListener,
						global::Android.Gms.Maps.GoogleMap.IOnInfoWindowClickListenerImplementor.__IsEmpty,
						SetOnInfoWindowClickListener,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnInfoWindowClickListener;

		global::Android.Gms.Maps.GoogleMap.IOnInfoWindowClickListenerImplementor __CreateIOnInfoWindowClickListenerImplementor ()
		{
			return new global::Android.Gms.Maps.GoogleMap.IOnInfoWindowClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Android.Gms.Maps.GoogleMap.IOnMapClickListener"
		public event EventHandler<global::Android.Gms.Maps.GoogleMap.MapClickEventArgs> MapClick {
			add {
				global::Java.Interop.AndroidEventHelper.AddEventHandler<global::Android.Gms.Maps.GoogleMap.IOnMapClickListener, global::Android.Gms.Maps.GoogleMap.IOnMapClickListenerImplementor>(
						ref weak_implementor_SetOnMapClickListener,
						__CreateIOnMapClickListenerImplementor,
						SetOnMapClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.AndroidEventHelper.RemoveEventHandler<global::Android.Gms.Maps.GoogleMap.IOnMapClickListener, global::Android.Gms.Maps.GoogleMap.IOnMapClickListenerImplementor>(
						ref weak_implementor_SetOnMapClickListener,
						global::Android.Gms.Maps.GoogleMap.IOnMapClickListenerImplementor.__IsEmpty,
						SetOnMapClickListener,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapClickListener;

		global::Android.Gms.Maps.GoogleMap.IOnMapClickListenerImplementor __CreateIOnMapClickListenerImplementor ()
		{
			return new global::Android.Gms.Maps.GoogleMap.IOnMapClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Android.Gms.Maps.GoogleMap.IOnMapLongClickListener"
		public event EventHandler<global::Android.Gms.Maps.GoogleMap.MapLongClickEventArgs> MapLongClick {
			add {
				global::Java.Interop.AndroidEventHelper.AddEventHandler<global::Android.Gms.Maps.GoogleMap.IOnMapLongClickListener, global::Android.Gms.Maps.GoogleMap.IOnMapLongClickListenerImplementor>(
						ref weak_implementor_SetOnMapLongClickListener,
						__CreateIOnMapLongClickListenerImplementor,
						SetOnMapLongClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.AndroidEventHelper.RemoveEventHandler<global::Android.Gms.Maps.GoogleMap.IOnMapLongClickListener, global::Android.Gms.Maps.GoogleMap.IOnMapLongClickListenerImplementor>(
						ref weak_implementor_SetOnMapLongClickListener,
						global::Android.Gms.Maps.GoogleMap.IOnMapLongClickListenerImplementor.__IsEmpty,
						SetOnMapLongClickListener,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapLongClickListener;

		global::Android.Gms.Maps.GoogleMap.IOnMapLongClickListenerImplementor __CreateIOnMapLongClickListenerImplementor ()
		{
			return new global::Android.Gms.Maps.GoogleMap.IOnMapLongClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Android.Gms.Maps.GoogleMap.IOnMarkerClickListener"
		public event EventHandler<global::Android.Gms.Maps.GoogleMap.MarkerClickEventArgs> MarkerClick {
			add {
				global::Java.Interop.AndroidEventHelper.AddEventHandler<global::Android.Gms.Maps.GoogleMap.IOnMarkerClickListener, global::Android.Gms.Maps.GoogleMap.IOnMarkerClickListenerImplementor>(
						ref weak_implementor_SetOnMarkerClickListener,
						__CreateIOnMarkerClickListenerImplementor,
						SetOnMarkerClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.AndroidEventHelper.RemoveEventHandler<global::Android.Gms.Maps.GoogleMap.IOnMarkerClickListener, global::Android.Gms.Maps.GoogleMap.IOnMarkerClickListenerImplementor>(
						ref weak_implementor_SetOnMarkerClickListener,
						global::Android.Gms.Maps.GoogleMap.IOnMarkerClickListenerImplementor.__IsEmpty,
						SetOnMarkerClickListener,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMarkerClickListener;

		global::Android.Gms.Maps.GoogleMap.IOnMarkerClickListenerImplementor __CreateIOnMarkerClickListenerImplementor ()
		{
			return new global::Android.Gms.Maps.GoogleMap.IOnMarkerClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Android.Gms.Maps.GoogleMap.IOnMarkerDragListener"
		public event EventHandler<global::Android.Gms.Maps.GoogleMap.MarkerDragEventArgs> MarkerDrag {
			add {
				global::Java.Interop.AndroidEventHelper.AddEventHandler<global::Android.Gms.Maps.GoogleMap.IOnMarkerDragListener, global::Android.Gms.Maps.GoogleMap.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						__CreateIOnMarkerDragListenerImplementor,
						SetOnMarkerDragListener,
						__h => __h.OnMarkerDragHandler += value);
			}
			remove {
				global::Java.Interop.AndroidEventHelper.RemoveEventHandler<global::Android.Gms.Maps.GoogleMap.IOnMarkerDragListener, global::Android.Gms.Maps.GoogleMap.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						global::Android.Gms.Maps.GoogleMap.IOnMarkerDragListenerImplementor.__IsEmpty,
						SetOnMarkerDragListener,
						__h => __h.OnMarkerDragHandler -= value);
			}
		}

		public event EventHandler<global::Android.Gms.Maps.GoogleMap.MarkerDragEndEventArgs> MarkerDragEnd {
			add {
				global::Java.Interop.AndroidEventHelper.AddEventHandler<global::Android.Gms.Maps.GoogleMap.IOnMarkerDragListener, global::Android.Gms.Maps.GoogleMap.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						__CreateIOnMarkerDragListenerImplementor,
						SetOnMarkerDragListener,
						__h => __h.OnMarkerDragEndHandler += value);
			}
			remove {
				global::Java.Interop.AndroidEventHelper.RemoveEventHandler<global::Android.Gms.Maps.GoogleMap.IOnMarkerDragListener, global::Android.Gms.Maps.GoogleMap.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						global::Android.Gms.Maps.GoogleMap.IOnMarkerDragListenerImplementor.__IsEmpty,
						SetOnMarkerDragListener,
						__h => __h.OnMarkerDragEndHandler -= value);
			}
		}

		public event EventHandler<global::Android.Gms.Maps.GoogleMap.MarkerDragStartEventArgs> MarkerDragStart {
			add {
				global::Java.Interop.AndroidEventHelper.AddEventHandler<global::Android.Gms.Maps.GoogleMap.IOnMarkerDragListener, global::Android.Gms.Maps.GoogleMap.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						__CreateIOnMarkerDragListenerImplementor,
						SetOnMarkerDragListener,
						__h => __h.OnMarkerDragStartHandler += value);
			}
			remove {
				global::Java.Interop.AndroidEventHelper.RemoveEventHandler<global::Android.Gms.Maps.GoogleMap.IOnMarkerDragListener, global::Android.Gms.Maps.GoogleMap.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						global::Android.Gms.Maps.GoogleMap.IOnMarkerDragListenerImplementor.__IsEmpty,
						SetOnMarkerDragListener,
						__h => __h.OnMarkerDragStartHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMarkerDragListener;

		global::Android.Gms.Maps.GoogleMap.IOnMarkerDragListenerImplementor __CreateIOnMarkerDragListenerImplementor ()
		{
			return new global::Android.Gms.Maps.GoogleMap.IOnMarkerDragListenerImplementor (this);
		}
#endregion
#region "Event implementation for Android.Gms.Maps.GoogleMap.IOnMyLocationChangeListener"
		public event EventHandler<global::Android.Gms.Maps.GoogleMap.MyLocationChangeEventArgs> MyLocationChange {
			add {
				global::Java.Interop.AndroidEventHelper.AddEventHandler<global::Android.Gms.Maps.GoogleMap.IOnMyLocationChangeListener, global::Android.Gms.Maps.GoogleMap.IOnMyLocationChangeListenerImplementor>(
						ref weak_implementor_SetOnMyLocationChangeListener,
						__CreateIOnMyLocationChangeListenerImplementor,
						SetOnMyLocationChangeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.AndroidEventHelper.RemoveEventHandler<global::Android.Gms.Maps.GoogleMap.IOnMyLocationChangeListener, global::Android.Gms.Maps.GoogleMap.IOnMyLocationChangeListenerImplementor>(
						ref weak_implementor_SetOnMyLocationChangeListener,
						global::Android.Gms.Maps.GoogleMap.IOnMyLocationChangeListenerImplementor.__IsEmpty,
						SetOnMyLocationChangeListener,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMyLocationChangeListener;

		global::Android.Gms.Maps.GoogleMap.IOnMyLocationChangeListenerImplementor __CreateIOnMyLocationChangeListenerImplementor ()
		{
			return new global::Android.Gms.Maps.GoogleMap.IOnMyLocationChangeListenerImplementor (this);
		}
#endregion
	}
}
