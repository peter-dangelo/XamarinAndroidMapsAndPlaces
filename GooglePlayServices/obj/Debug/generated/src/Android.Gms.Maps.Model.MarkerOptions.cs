using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps.Model {

	[global::Android.Runtime.Register ("com/google/android/gms/maps/model/MarkerOptions", DoNotGenerateAcw=true)]
	public sealed partial class MarkerOptions : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/model/MarkerOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MarkerOptions); }
		}

		internal MarkerOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public MarkerOptions () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MarkerOptions)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getAnchorU;
		public float AnchorU {
			[Register ("getAnchorU", "()F", "GetGetAnchorUHandler")]
			get {
				if (id_getAnchorU == IntPtr.Zero)
					id_getAnchorU = JNIEnv.GetMethodID (class_ref, "getAnchorU", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getAnchorU);
			}
		}

		static IntPtr id_getAnchorV;
		public float AnchorV {
			[Register ("getAnchorV", "()F", "GetGetAnchorVHandler")]
			get {
				if (id_getAnchorV == IntPtr.Zero)
					id_getAnchorV = JNIEnv.GetMethodID (class_ref, "getAnchorV", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getAnchorV);
			}
		}

		static IntPtr id_getIcon;
		public global::Android.Gms.Maps.Model.BitmapDescriptor Icon {
			[Register ("getIcon", "()Lcom/google/android/gms/maps/model/BitmapDescriptor;", "GetGetIconHandler")]
			get {
				if (id_getIcon == IntPtr.Zero)
					id_getIcon = JNIEnv.GetMethodID (class_ref, "getIcon", "()Lcom/google/android/gms/maps/model/BitmapDescriptor;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.BitmapDescriptor> (JNIEnv.CallObjectMethod  (Handle, id_getIcon), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isDraggable;
		public bool IsDraggable {
			[Register ("isDraggable", "()Z", "GetIsDraggableHandler")]
			get {
				if (id_isDraggable == IntPtr.Zero)
					id_isDraggable = JNIEnv.GetMethodID (class_ref, "isDraggable", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isDraggable);
			}
		}

		static IntPtr id_isVisible;
		public bool IsVisible {
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isVisible);
			}
		}

		static IntPtr id_getPosition;
		public global::Android.Gms.Maps.Model.LatLng Position {
			[Register ("getPosition", "()Lcom/google/android/gms/maps/model/LatLng;", "GetGetPositionHandler")]
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()Lcom/google/android/gms/maps/model/LatLng;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getPosition), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getSnippet;
		public string Snippet {
			[Register ("getSnippet", "()Ljava/lang/String;", "GetGetSnippetHandler")]
			get {
				if (id_getSnippet == IntPtr.Zero)
					id_getSnippet = JNIEnv.GetMethodID (class_ref, "getSnippet", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSnippet), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getTitle;
		public string Title {
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_anchor_FF;
		[Register ("anchor", "(FF)Lcom/google/android/gms/maps/model/MarkerOptions;", "")]
		public global::Android.Gms.Maps.Model.MarkerOptions Anchor (float p0, float p1)
		{
			if (id_anchor_FF == IntPtr.Zero)
				id_anchor_FF = JNIEnv.GetMethodID (class_ref, "anchor", "(FF)Lcom/google/android/gms/maps/model/MarkerOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.MarkerOptions> (JNIEnv.CallObjectMethod  (Handle, id_anchor_FF, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_describeContents;
		[Register ("describeContents", "()I", "")]
		public int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_describeContents);
		}

		static IntPtr id_draggable_Z;
		[Register ("draggable", "(Z)Lcom/google/android/gms/maps/model/MarkerOptions;", "")]
		public global::Android.Gms.Maps.Model.MarkerOptions Draggable (bool p0)
		{
			if (id_draggable_Z == IntPtr.Zero)
				id_draggable_Z = JNIEnv.GetMethodID (class_ref, "draggable", "(Z)Lcom/google/android/gms/maps/model/MarkerOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.MarkerOptions> (JNIEnv.CallObjectMethod  (Handle, id_draggable_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_icon_Lcom_google_android_gms_maps_model_BitmapDescriptor_;
		[Register ("icon", "(Lcom/google/android/gms/maps/model/BitmapDescriptor;)Lcom/google/android/gms/maps/model/MarkerOptions;", "")]
		public global::Android.Gms.Maps.Model.MarkerOptions InvokeIcon (global::Android.Gms.Maps.Model.BitmapDescriptor p0)
		{
			if (id_icon_Lcom_google_android_gms_maps_model_BitmapDescriptor_ == IntPtr.Zero)
				id_icon_Lcom_google_android_gms_maps_model_BitmapDescriptor_ = JNIEnv.GetMethodID (class_ref, "icon", "(Lcom/google/android/gms/maps/model/BitmapDescriptor;)Lcom/google/android/gms/maps/model/MarkerOptions;");
			global::Android.Gms.Maps.Model.MarkerOptions __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.MarkerOptions> (JNIEnv.CallObjectMethod  (Handle, id_icon_Lcom_google_android_gms_maps_model_BitmapDescriptor_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_position_Lcom_google_android_gms_maps_model_LatLng_;
		[Register ("position", "(Lcom/google/android/gms/maps/model/LatLng;)Lcom/google/android/gms/maps/model/MarkerOptions;", "")]
		public global::Android.Gms.Maps.Model.MarkerOptions SetPosition (global::Android.Gms.Maps.Model.LatLng p0)
		{
			if (id_position_Lcom_google_android_gms_maps_model_LatLng_ == IntPtr.Zero)
				id_position_Lcom_google_android_gms_maps_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "position", "(Lcom/google/android/gms/maps/model/LatLng;)Lcom/google/android/gms/maps/model/MarkerOptions;");
			global::Android.Gms.Maps.Model.MarkerOptions __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.MarkerOptions> (JNIEnv.CallObjectMethod  (Handle, id_position_Lcom_google_android_gms_maps_model_LatLng_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_snippet_Ljava_lang_String_;
		[Register ("snippet", "(Ljava/lang/String;)Lcom/google/android/gms/maps/model/MarkerOptions;", "")]
		public global::Android.Gms.Maps.Model.MarkerOptions SetSnippet (string p0)
		{
			if (id_snippet_Ljava_lang_String_ == IntPtr.Zero)
				id_snippet_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "snippet", "(Ljava/lang/String;)Lcom/google/android/gms/maps/model/MarkerOptions;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Android.Gms.Maps.Model.MarkerOptions __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.MarkerOptions> (JNIEnv.CallObjectMethod  (Handle, id_snippet_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_title_Ljava_lang_String_;
		[Register ("title", "(Ljava/lang/String;)Lcom/google/android/gms/maps/model/MarkerOptions;", "")]
		public global::Android.Gms.Maps.Model.MarkerOptions SetTitle (string p0)
		{
			if (id_title_Ljava_lang_String_ == IntPtr.Zero)
				id_title_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "title", "(Ljava/lang/String;)Lcom/google/android/gms/maps/model/MarkerOptions;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Android.Gms.Maps.Model.MarkerOptions __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.MarkerOptions> (JNIEnv.CallObjectMethod  (Handle, id_title_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_visible_Z;
		[Register ("visible", "(Z)Lcom/google/android/gms/maps/model/MarkerOptions;", "")]
		public global::Android.Gms.Maps.Model.MarkerOptions Visible (bool p0)
		{
			if (id_visible_Z == IntPtr.Zero)
				id_visible_Z = JNIEnv.GetMethodID (class_ref, "visible", "(Z)Lcom/google/android/gms/maps/model/MarkerOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.MarkerOptions> (JNIEnv.CallObjectMethod  (Handle, id_visible_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
