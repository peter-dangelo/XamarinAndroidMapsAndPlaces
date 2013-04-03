using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps.Model {

	[global::Android.Runtime.Register ("com/google/android/gms/maps/model/Circle", DoNotGenerateAcw=true)]
	public sealed partial class Circle : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/model/Circle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Circle); }
		}

		internal Circle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getCenter;
		static IntPtr id_setCenter_Lcom_google_android_gms_maps_model_LatLng_;
		public global::Android.Gms.Maps.Model.LatLng Center {
			[Register ("getCenter", "()Lcom/google/android/gms/maps/model/LatLng;", "GetGetCenterHandler")]
			get {
				if (id_getCenter == IntPtr.Zero)
					id_getCenter = JNIEnv.GetMethodID (class_ref, "getCenter", "()Lcom/google/android/gms/maps/model/LatLng;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getCenter), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setCenter", "(Lcom/google/android/gms/maps/model/LatLng;)V", "GetSetCenter_Lcom_google_android_gms_maps_model_LatLng_Handler")]
			set {
				if (id_setCenter_Lcom_google_android_gms_maps_model_LatLng_ == IntPtr.Zero)
					id_setCenter_Lcom_google_android_gms_maps_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "setCenter", "(Lcom/google/android/gms/maps/model/LatLng;)V");
				JNIEnv.CallVoidMethod  (Handle, id_setCenter_Lcom_google_android_gms_maps_model_LatLng_, new JValue (value));
			}
		}

		static IntPtr id_getFillColor;
		static IntPtr id_setFillColor_I;
		public int FillColor {
			[Register ("getFillColor", "()I", "GetGetFillColorHandler")]
			get {
				if (id_getFillColor == IntPtr.Zero)
					id_getFillColor = JNIEnv.GetMethodID (class_ref, "getFillColor", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getFillColor);
			}
			[Register ("setFillColor", "(I)V", "GetSetFillColor_IHandler")]
			set {
				if (id_setFillColor_I == IntPtr.Zero)
					id_setFillColor_I = JNIEnv.GetMethodID (class_ref, "setFillColor", "(I)V");
				JNIEnv.CallVoidMethod  (Handle, id_setFillColor_I, new JValue (value));
			}
		}

		static IntPtr id_getId;
		public string Id {
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getRadius;
		static IntPtr id_setRadius_D;
		public double Radius {
			[Register ("getRadius", "()D", "GetGetRadiusHandler")]
			get {
				if (id_getRadius == IntPtr.Zero)
					id_getRadius = JNIEnv.GetMethodID (class_ref, "getRadius", "()D");
				return JNIEnv.CallDoubleMethod  (Handle, id_getRadius);
			}
			[Register ("setRadius", "(D)V", "GetSetRadius_DHandler")]
			set {
				if (id_setRadius_D == IntPtr.Zero)
					id_setRadius_D = JNIEnv.GetMethodID (class_ref, "setRadius", "(D)V");
				JNIEnv.CallVoidMethod  (Handle, id_setRadius_D, new JValue (value));
			}
		}

		static IntPtr id_getStrokeColor;
		static IntPtr id_setStrokeColor_I;
		public int StrokeColor {
			[Register ("getStrokeColor", "()I", "GetGetStrokeColorHandler")]
			get {
				if (id_getStrokeColor == IntPtr.Zero)
					id_getStrokeColor = JNIEnv.GetMethodID (class_ref, "getStrokeColor", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getStrokeColor);
			}
			[Register ("setStrokeColor", "(I)V", "GetSetStrokeColor_IHandler")]
			set {
				if (id_setStrokeColor_I == IntPtr.Zero)
					id_setStrokeColor_I = JNIEnv.GetMethodID (class_ref, "setStrokeColor", "(I)V");
				JNIEnv.CallVoidMethod  (Handle, id_setStrokeColor_I, new JValue (value));
			}
		}

		static IntPtr id_getStrokeWidth;
		static IntPtr id_setStrokeWidth_F;
		public float StrokeWidth {
			[Register ("getStrokeWidth", "()F", "GetGetStrokeWidthHandler")]
			get {
				if (id_getStrokeWidth == IntPtr.Zero)
					id_getStrokeWidth = JNIEnv.GetMethodID (class_ref, "getStrokeWidth", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getStrokeWidth);
			}
			[Register ("setStrokeWidth", "(F)V", "GetSetStrokeWidth_FHandler")]
			set {
				if (id_setStrokeWidth_F == IntPtr.Zero)
					id_setStrokeWidth_F = JNIEnv.GetMethodID (class_ref, "setStrokeWidth", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setStrokeWidth_F, new JValue (value));
			}
		}

		static IntPtr id_isVisible;
		static IntPtr id_setVisible_Z;
		public bool Visible {
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isVisible);
			}
			[Register ("setVisible", "(Z)V", "GetSetVisible_ZHandler")]
			set {
				if (id_setVisible_Z == IntPtr.Zero)
					id_setVisible_Z = JNIEnv.GetMethodID (class_ref, "setVisible", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setVisible_Z, new JValue (value));
			}
		}

		static IntPtr id_getZIndex;
		static IntPtr id_setZIndex_F;
		public float ZIndex {
			[Register ("getZIndex", "()F", "GetGetZIndexHandler")]
			get {
				if (id_getZIndex == IntPtr.Zero)
					id_getZIndex = JNIEnv.GetMethodID (class_ref, "getZIndex", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getZIndex);
			}
			[Register ("setZIndex", "(F)V", "GetSetZIndex_FHandler")]
			set {
				if (id_setZIndex_F == IntPtr.Zero)
					id_setZIndex_F = JNIEnv.GetMethodID (class_ref, "setZIndex", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setZIndex_F, new JValue (value));
			}
		}

		static IntPtr id_remove;
		[Register ("remove", "()V", "")]
		public void Remove ()
		{
			if (id_remove == IntPtr.Zero)
				id_remove = JNIEnv.GetMethodID (class_ref, "remove", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_remove);
		}

	}
}
