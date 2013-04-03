using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps.Model {

	[global::Android.Runtime.Register ("com/google/android/gms/maps/model/Tile", DoNotGenerateAcw=true)]
	public sealed partial class Tile : global::Java.Lang.Object {


		static IntPtr dq_jfieldId;

		[Register ("dq")]
		public IList<byte> Dq {
			get {
				if (dq_jfieldId == IntPtr.Zero)
					dq_jfieldId = JNIEnv.GetFieldID (class_ref, "dq", "[B");
				return new JavaArray<byte> (JNIEnv.GetObjectField (Handle, dq_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}


		static IntPtr height_jfieldId;

		[Register ("height")]
		public int Height {
			get {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
				return JNIEnv.GetIntField (Handle, height_jfieldId);
			}
			set {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
				JNIEnv.SetField (Handle, height_jfieldId, value);
			}
		}

		static IntPtr width_jfieldId;

		[Register ("width")]
		public int Width {
			get {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
				return JNIEnv.GetIntField (Handle, width_jfieldId);
			}
			set {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
				JNIEnv.SetField (Handle, width_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/model/Tile", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Tile); }
		}

		internal Tile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIarrayB;
		[Register (".ctor", "(II[B)V", "")]
		public Tile (int p0, int p1, byte[] p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewArray (p2);;
			if (GetType () != typeof (Tile)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(II[B)V", new JValue (p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				return;
			}

			if (id_ctor_IIarrayB == IntPtr.Zero)
				id_ctor_IIarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(II[B)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_IIarrayB, new JValue (p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
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
