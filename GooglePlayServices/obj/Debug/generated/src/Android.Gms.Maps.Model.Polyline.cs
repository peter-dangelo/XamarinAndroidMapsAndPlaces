using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps.Model {

	[global::Android.Runtime.Register ("com/google/android/gms/maps/model/Polyline", DoNotGenerateAcw=true)]
	public sealed partial class Polyline : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/model/Polyline", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Polyline); }
		}

		internal Polyline (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getColor;
		static IntPtr id_setColor_I;
		public int Color {
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getColor);
			}
			[Register ("setColor", "(I)V", "GetSetColor_IHandler")]
			set {
				if (id_setColor_I == IntPtr.Zero)
					id_setColor_I = JNIEnv.GetMethodID (class_ref, "setColor", "(I)V");
				JNIEnv.CallVoidMethod  (Handle, id_setColor_I, new JValue (value));
			}
		}

		static IntPtr id_isGeodesic;
		static IntPtr id_setGeodesic_Z;
		public bool Geodesic {
			[Register ("isGeodesic", "()Z", "GetIsGeodesicHandler")]
			get {
				if (id_isGeodesic == IntPtr.Zero)
					id_isGeodesic = JNIEnv.GetMethodID (class_ref, "isGeodesic", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isGeodesic);
			}
			[Register ("setGeodesic", "(Z)V", "GetSetGeodesic_ZHandler")]
			set {
				if (id_setGeodesic_Z == IntPtr.Zero)
					id_setGeodesic_Z = JNIEnv.GetMethodID (class_ref, "setGeodesic", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setGeodesic_Z, new JValue (value));
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

		static IntPtr id_getPoints;
		static IntPtr id_setPoints_Ljava_util_List_;
		public global::System.Collections.Generic.IList<global::Android.Gms.Maps.Model.LatLng> Points {
			[Register ("getPoints", "()Ljava/util/List;", "GetGetPointsHandler")]
			get {
				if (id_getPoints == IntPtr.Zero)
					id_getPoints = JNIEnv.GetMethodID (class_ref, "getPoints", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Android.Gms.Maps.Model.LatLng>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPoints), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setPoints", "(Ljava/util/List;)V", "GetSetPoints_Ljava_util_List_Handler")]
			set {
				if (id_setPoints_Ljava_util_List_ == IntPtr.Zero)
					id_setPoints_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setPoints", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Android.Gms.Maps.Model.LatLng>.ToLocalJniHandle (value);
				JNIEnv.CallVoidMethod  (Handle, id_setPoints_Ljava_util_List_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
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

		static IntPtr id_getWidth;
		static IntPtr id_setWidth_F;
		public float Width {
			[Register ("getWidth", "()F", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getWidth);
			}
			[Register ("setWidth", "(F)V", "GetSetWidth_FHandler")]
			set {
				if (id_setWidth_F == IntPtr.Zero)
					id_setWidth_F = JNIEnv.GetMethodID (class_ref, "setWidth", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setWidth_F, new JValue (value));
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
