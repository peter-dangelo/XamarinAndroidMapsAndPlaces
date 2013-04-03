using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps {

	[global::Android.Runtime.Register ("com/google/android/gms/maps/MapsInitializer", DoNotGenerateAcw=true)]
	public sealed partial class MapsInitializer : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/MapsInitializer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapsInitializer); }
		}

		internal MapsInitializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_initialize_Landroid_content_Context_;
		[Register ("initialize", "(Landroid/content/Context;)V", "")]
		public static void Initialize (global::Android.Content.Context p0)
		{
			if (id_initialize_Landroid_content_Context_ == IntPtr.Zero)
				id_initialize_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_initialize_Landroid_content_Context_, new JValue (p0));
		}

	}
}
