using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps.Model {

	[global::Android.Runtime.Register ("com/google/android/gms/maps/model/CameraPosition", DoNotGenerateAcw=true)]
	public sealed partial class CameraPosition : global::Java.Lang.Object {


		static IntPtr bearing_jfieldId;

		[Register ("bearing")]
		public float Bearing {
			get {
				if (bearing_jfieldId == IntPtr.Zero)
					bearing_jfieldId = JNIEnv.GetFieldID (class_ref, "bearing", "F");
				return JNIEnv.GetFloatField (Handle, bearing_jfieldId);
			}
			set {
				if (bearing_jfieldId == IntPtr.Zero)
					bearing_jfieldId = JNIEnv.GetFieldID (class_ref, "bearing", "F");
				JNIEnv.SetField (Handle, bearing_jfieldId, value);
			}
		}

		static IntPtr target_jfieldId;

		[Register ("target")]
		public global::Android.Gms.Maps.Model.LatLng Target {
			get {
				if (target_jfieldId == IntPtr.Zero)
					target_jfieldId = JNIEnv.GetFieldID (class_ref, "target", "Lcom/google/android/gms/maps/model/LatLng;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, target_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLng> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (target_jfieldId == IntPtr.Zero)
					target_jfieldId = JNIEnv.GetFieldID (class_ref, "target", "Lcom/google/android/gms/maps/model/LatLng;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, target_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr tilt_jfieldId;

		[Register ("tilt")]
		public float Tilt {
			get {
				if (tilt_jfieldId == IntPtr.Zero)
					tilt_jfieldId = JNIEnv.GetFieldID (class_ref, "tilt", "F");
				return JNIEnv.GetFloatField (Handle, tilt_jfieldId);
			}
			set {
				if (tilt_jfieldId == IntPtr.Zero)
					tilt_jfieldId = JNIEnv.GetFieldID (class_ref, "tilt", "F");
				JNIEnv.SetField (Handle, tilt_jfieldId, value);
			}
		}

		static IntPtr zoom_jfieldId;

		[Register ("zoom")]
		public float Zoom {
			get {
				if (zoom_jfieldId == IntPtr.Zero)
					zoom_jfieldId = JNIEnv.GetFieldID (class_ref, "zoom", "F");
				return JNIEnv.GetFloatField (Handle, zoom_jfieldId);
			}
			set {
				if (zoom_jfieldId == IntPtr.Zero)
					zoom_jfieldId = JNIEnv.GetFieldID (class_ref, "zoom", "F");
				JNIEnv.SetField (Handle, zoom_jfieldId, value);
			}
		}
		[global::Android.Runtime.Register ("com/google/android/gms/maps/model/CameraPosition$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/gms/maps/model/CameraPosition$Builder", ref java_class_handle);
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

			static IntPtr id_ctor_Lcom_google_android_gms_maps_model_CameraPosition_;
			[Register (".ctor", "(Lcom/google/android/gms/maps/model/CameraPosition;)V", "")]
			public Builder (global::Android.Gms.Maps.Model.CameraPosition p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Builder)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/google/android/gms/maps/model/CameraPosition;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_Lcom_google_android_gms_maps_model_CameraPosition_ == IntPtr.Zero)
					id_ctor_Lcom_google_android_gms_maps_model_CameraPosition_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/android/gms/maps/model/CameraPosition;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_google_android_gms_maps_model_CameraPosition_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_bearing_F;
			[Register ("bearing", "(F)Lcom/google/android/gms/maps/model/CameraPosition$Builder;", "")]
			public global::Android.Gms.Maps.Model.CameraPosition.Builder Bearing (float p0)
			{
				if (id_bearing_F == IntPtr.Zero)
					id_bearing_F = JNIEnv.GetMethodID (class_ref, "bearing", "(F)Lcom/google/android/gms/maps/model/CameraPosition$Builder;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.CameraPosition.Builder> (JNIEnv.CallObjectMethod  (Handle, id_bearing_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_build;
			[Register ("build", "()Lcom/google/android/gms/maps/model/CameraPosition;", "")]
			public global::Android.Gms.Maps.Model.CameraPosition Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/google/android/gms/maps/model/CameraPosition;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.CameraPosition> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_target_Lcom_google_android_gms_maps_model_LatLng_;
			[Register ("target", "(Lcom/google/android/gms/maps/model/LatLng;)Lcom/google/android/gms/maps/model/CameraPosition$Builder;", "")]
			public global::Android.Gms.Maps.Model.CameraPosition.Builder Target (global::Android.Gms.Maps.Model.LatLng p0)
			{
				if (id_target_Lcom_google_android_gms_maps_model_LatLng_ == IntPtr.Zero)
					id_target_Lcom_google_android_gms_maps_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "target", "(Lcom/google/android/gms/maps/model/LatLng;)Lcom/google/android/gms/maps/model/CameraPosition$Builder;");
				global::Android.Gms.Maps.Model.CameraPosition.Builder __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.CameraPosition.Builder> (JNIEnv.CallObjectMethod  (Handle, id_target_Lcom_google_android_gms_maps_model_LatLng_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_tilt_F;
			[Register ("tilt", "(F)Lcom/google/android/gms/maps/model/CameraPosition$Builder;", "")]
			public global::Android.Gms.Maps.Model.CameraPosition.Builder Tilt (float p0)
			{
				if (id_tilt_F == IntPtr.Zero)
					id_tilt_F = JNIEnv.GetMethodID (class_ref, "tilt", "(F)Lcom/google/android/gms/maps/model/CameraPosition$Builder;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.CameraPosition.Builder> (JNIEnv.CallObjectMethod  (Handle, id_tilt_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_zoom_F;
			[Register ("zoom", "(F)Lcom/google/android/gms/maps/model/CameraPosition$Builder;", "")]
			public global::Android.Gms.Maps.Model.CameraPosition.Builder Zoom (float p0)
			{
				if (id_zoom_F == IntPtr.Zero)
					id_zoom_F = JNIEnv.GetMethodID (class_ref, "zoom", "(F)Lcom/google/android/gms/maps/model/CameraPosition$Builder;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.CameraPosition.Builder> (JNIEnv.CallObjectMethod  (Handle, id_zoom_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/model/CameraPosition", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CameraPosition); }
		}

		internal CameraPosition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_android_gms_maps_model_LatLng_FFF;
		[Register (".ctor", "(Lcom/google/android/gms/maps/model/LatLng;FFF)V", "")]
		public CameraPosition (global::Android.Gms.Maps.Model.LatLng p0, float p1, float p2, float p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CameraPosition)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/google/android/gms/maps/model/LatLng;FFF)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lcom_google_android_gms_maps_model_LatLng_FFF == IntPtr.Zero)
				id_ctor_Lcom_google_android_gms_maps_model_LatLng_FFF = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/android/gms/maps/model/LatLng;FFF)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_google_android_gms_maps_model_LatLng_FFF, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_builder;
		[Register ("builder", "()Lcom/google/android/gms/maps/model/CameraPosition$Builder;", "")]
		public static global::Android.Gms.Maps.Model.CameraPosition.Builder InvokeBuilder ()
		{
			if (id_builder == IntPtr.Zero)
				id_builder = JNIEnv.GetStaticMethodID (class_ref, "builder", "()Lcom/google/android/gms/maps/model/CameraPosition$Builder;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.CameraPosition.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_builder), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_builder_Lcom_google_android_gms_maps_model_CameraPosition_;
		[Register ("builder", "(Lcom/google/android/gms/maps/model/CameraPosition;)Lcom/google/android/gms/maps/model/CameraPosition$Builder;", "")]
		public static global::Android.Gms.Maps.Model.CameraPosition.Builder InvokeBuilder (global::Android.Gms.Maps.Model.CameraPosition p0)
		{
			if (id_builder_Lcom_google_android_gms_maps_model_CameraPosition_ == IntPtr.Zero)
				id_builder_Lcom_google_android_gms_maps_model_CameraPosition_ = JNIEnv.GetStaticMethodID (class_ref, "builder", "(Lcom/google/android/gms/maps/model/CameraPosition;)Lcom/google/android/gms/maps/model/CameraPosition$Builder;");
			global::Android.Gms.Maps.Model.CameraPosition.Builder __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.CameraPosition.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_builder_Lcom_google_android_gms_maps_model_CameraPosition_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_createFromAttributes_Landroid_content_Context_Landroid_util_AttributeSet_;
		[Register ("createFromAttributes", "(Landroid/content/Context;Landroid/util/AttributeSet;)Lcom/google/android/gms/maps/model/CameraPosition;", "")]
		public static global::Android.Gms.Maps.Model.CameraPosition CreateFromAttributes (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
		{
			if (id_createFromAttributes_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_createFromAttributes_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetStaticMethodID (class_ref, "createFromAttributes", "(Landroid/content/Context;Landroid/util/AttributeSet;)Lcom/google/android/gms/maps/model/CameraPosition;");
			global::Android.Gms.Maps.Model.CameraPosition __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.CameraPosition> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromAttributes_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr id_fromLatLngZoom_Lcom_google_android_gms_maps_model_LatLng_F;
		[Register ("fromLatLngZoom", "(Lcom/google/android/gms/maps/model/LatLng;F)Lcom/google/android/gms/maps/model/CameraPosition;", "")]
		public static global::Android.Gms.Maps.Model.CameraPosition FromLatLngZoom (global::Android.Gms.Maps.Model.LatLng p0, float p1)
		{
			if (id_fromLatLngZoom_Lcom_google_android_gms_maps_model_LatLng_F == IntPtr.Zero)
				id_fromLatLngZoom_Lcom_google_android_gms_maps_model_LatLng_F = JNIEnv.GetStaticMethodID (class_ref, "fromLatLngZoom", "(Lcom/google/android/gms/maps/model/LatLng;F)Lcom/google/android/gms/maps/model/CameraPosition;");
			global::Android.Gms.Maps.Model.CameraPosition __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.CameraPosition> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromLatLngZoom_Lcom_google_android_gms_maps_model_LatLng_F, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
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
