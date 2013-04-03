using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps.Model {

	[global::Android.Runtime.Register ("com/google/android/gms/maps/model/RuntimeRemoteException", DoNotGenerateAcw=true)]
	public sealed partial class RuntimeRemoteException : global::Java.Lang.RuntimeException {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/model/RuntimeRemoteException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RuntimeRemoteException); }
		}

		internal RuntimeRemoteException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_RemoteException_;
		[Register (".ctor", "(Landroid/os/RemoteException;)V", "")]
		public RuntimeRemoteException (global::Android.OS.RemoteException p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RuntimeRemoteException)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/os/RemoteException;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_os_RemoteException_ == IntPtr.Zero)
				id_ctor_Landroid_os_RemoteException_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/RemoteException;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_os_RemoteException_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
