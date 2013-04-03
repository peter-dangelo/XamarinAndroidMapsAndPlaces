using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps.Model {

	[global::Android.Runtime.Register ("com/google/android/gms/maps/model/LatLng", DoNotGenerateAcw=true)]
	public sealed partial class LatLng : global::Java.Lang.Object {


		static IntPtr latitude_jfieldId;

		[Register ("latitude")]
		public double Latitude {
			get {
				if (latitude_jfieldId == IntPtr.Zero)
					latitude_jfieldId = JNIEnv.GetFieldID (class_ref, "latitude", "D");
				return JNIEnv.GetDoubleField (Handle, latitude_jfieldId);
			}
			set {
				if (latitude_jfieldId == IntPtr.Zero)
					latitude_jfieldId = JNIEnv.GetFieldID (class_ref, "latitude", "D");
				JNIEnv.SetField (Handle, latitude_jfieldId, value);
			}
		}

		static IntPtr longitude_jfieldId;

		[Register ("longitude")]
		public double Longitude {
			get {
				if (longitude_jfieldId == IntPtr.Zero)
					longitude_jfieldId = JNIEnv.GetFieldID (class_ref, "longitude", "D");
				return JNIEnv.GetDoubleField (Handle, longitude_jfieldId);
			}
			set {
				if (longitude_jfieldId == IntPtr.Zero)
					longitude_jfieldId = JNIEnv.GetFieldID (class_ref, "longitude", "D");
				JNIEnv.SetField (Handle, longitude_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/model/LatLng", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LatLng); }
		}

		internal LatLng (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_DD;
		[Register (".ctor", "(DD)V", "")]
		public LatLng (double p0, double p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LatLng)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(DD)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_DD == IntPtr.Zero)
				id_ctor_DD = JNIEnv.GetMethodID (class_ref, "<init>", "(DD)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_DD, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_describeContents;
		[Register ("describeContents", "()I", "")]
		public int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_describeContents);
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
