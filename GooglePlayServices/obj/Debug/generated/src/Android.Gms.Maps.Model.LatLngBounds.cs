using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps.Model {

	[global::Android.Runtime.Register ("com/google/android/gms/maps/model/LatLngBounds", DoNotGenerateAcw=true)]
	public sealed partial class LatLngBounds : global::Java.Lang.Object {


		static IntPtr northeast_jfieldId;

		[Register ("northeast")]
		public global::Android.Gms.Maps.Model.LatLng Northeast {
			get {
				if (northeast_jfieldId == IntPtr.Zero)
					northeast_jfieldId = JNIEnv.GetFieldID (class_ref, "northeast", "Lcom/google/android/gms/maps/model/LatLng;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, northeast_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLng> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (northeast_jfieldId == IntPtr.Zero)
					northeast_jfieldId = JNIEnv.GetFieldID (class_ref, "northeast", "Lcom/google/android/gms/maps/model/LatLng;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, northeast_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr southwest_jfieldId;

		[Register ("southwest")]
		public global::Android.Gms.Maps.Model.LatLng Southwest {
			get {
				if (southwest_jfieldId == IntPtr.Zero)
					southwest_jfieldId = JNIEnv.GetFieldID (class_ref, "southwest", "Lcom/google/android/gms/maps/model/LatLng;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, southwest_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLng> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (southwest_jfieldId == IntPtr.Zero)
					southwest_jfieldId = JNIEnv.GetFieldID (class_ref, "southwest", "Lcom/google/android/gms/maps/model/LatLng;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, southwest_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		[global::Android.Runtime.Register ("com/google/android/gms/maps/model/LatLngBounds$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/gms/maps/model/LatLngBounds$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			[Register (".ctor", "()V", "")]
			public Builder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Builder)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_build;
			[Register ("build", "()Lcom/google/android/gms/maps/model/LatLngBounds;", "")]
			public global::Android.Gms.Maps.Model.LatLngBounds Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/google/android/gms/maps/model/LatLngBounds;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLngBounds> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_include_Lcom_google_android_gms_maps_model_LatLng_;
			[Register ("include", "(Lcom/google/android/gms/maps/model/LatLng;)Lcom/google/android/gms/maps/model/LatLngBounds$Builder;", "")]
			public global::Android.Gms.Maps.Model.LatLngBounds.Builder Include (global::Android.Gms.Maps.Model.LatLng p0)
			{
				if (id_include_Lcom_google_android_gms_maps_model_LatLng_ == IntPtr.Zero)
					id_include_Lcom_google_android_gms_maps_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "include", "(Lcom/google/android/gms/maps/model/LatLng;)Lcom/google/android/gms/maps/model/LatLngBounds$Builder;");
				global::Android.Gms.Maps.Model.LatLngBounds.Builder __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLngBounds.Builder> (JNIEnv.CallObjectMethod  (Handle, id_include_Lcom_google_android_gms_maps_model_LatLng_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/model/LatLngBounds", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LatLngBounds); }
		}

		internal LatLngBounds (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_android_gms_maps_model_LatLng_Lcom_google_android_gms_maps_model_LatLng_;
		[Register (".ctor", "(Lcom/google/android/gms/maps/model/LatLng;Lcom/google/android/gms/maps/model/LatLng;)V", "")]
		public LatLngBounds (global::Android.Gms.Maps.Model.LatLng p0, global::Android.Gms.Maps.Model.LatLng p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LatLngBounds)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/google/android/gms/maps/model/LatLng;Lcom/google/android/gms/maps/model/LatLng;)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lcom_google_android_gms_maps_model_LatLng_Lcom_google_android_gms_maps_model_LatLng_ == IntPtr.Zero)
				id_ctor_Lcom_google_android_gms_maps_model_LatLng_Lcom_google_android_gms_maps_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/android/gms/maps/model/LatLng;Lcom/google/android/gms/maps/model/LatLng;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_google_android_gms_maps_model_LatLng_Lcom_google_android_gms_maps_model_LatLng_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_builder;
		[Register ("builder", "()Lcom/google/android/gms/maps/model/LatLngBounds$Builder;", "")]
		public static global::Android.Gms.Maps.Model.LatLngBounds.Builder InvokeBuilder ()
		{
			if (id_builder == IntPtr.Zero)
				id_builder = JNIEnv.GetStaticMethodID (class_ref, "builder", "()Lcom/google/android/gms/maps/model/LatLngBounds$Builder;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLngBounds.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_builder), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_contains_Lcom_google_android_gms_maps_model_LatLng_;
		[Register ("contains", "(Lcom/google/android/gms/maps/model/LatLng;)Z", "")]
		public bool Contains (global::Android.Gms.Maps.Model.LatLng p0)
		{
			if (id_contains_Lcom_google_android_gms_maps_model_LatLng_ == IntPtr.Zero)
				id_contains_Lcom_google_android_gms_maps_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "contains", "(Lcom/google/android/gms/maps/model/LatLng;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_contains_Lcom_google_android_gms_maps_model_LatLng_, new JValue (p0));
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

		static IntPtr id_including_Lcom_google_android_gms_maps_model_LatLng_;
		[Register ("including", "(Lcom/google/android/gms/maps/model/LatLng;)Lcom/google/android/gms/maps/model/LatLngBounds;", "")]
		public global::Android.Gms.Maps.Model.LatLngBounds Including (global::Android.Gms.Maps.Model.LatLng p0)
		{
			if (id_including_Lcom_google_android_gms_maps_model_LatLng_ == IntPtr.Zero)
				id_including_Lcom_google_android_gms_maps_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "including", "(Lcom/google/android/gms/maps/model/LatLng;)Lcom/google/android/gms/maps/model/LatLngBounds;");
			global::Android.Gms.Maps.Model.LatLngBounds __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLngBounds> (JNIEnv.CallObjectMethod  (Handle, id_including_Lcom_google_android_gms_maps_model_LatLng_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public void WriteToParcel (global::Android.OS.Parcel p0, int p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue (p1));
		}

	}
}
