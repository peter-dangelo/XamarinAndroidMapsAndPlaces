using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps.Model {

	[global::Android.Runtime.Register ("com/google/android/gms/maps/model/UrlTileProvider", DoNotGenerateAcw=true)]
	public abstract partial class UrlTileProvider : global::Java.Lang.Object, global::Android.Gms.Maps.Model.ITileProvider {


		public static class InterfaceConsts {

			// The following are fields from: com.google.android.gms.maps.model.TileProvider

			static IntPtr NO_TILE_jfieldId;

			[Register ("NO_TILE")]
			public static global::Android.Gms.Maps.Model.Tile NoTile {
				get {
					if (NO_TILE_jfieldId == IntPtr.Zero)
						NO_TILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_TILE", "Lcom/google/android/gms/maps/model/Tile;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_TILE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.Tile> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NO_TILE_jfieldId == IntPtr.Zero)
						NO_TILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_TILE", "Lcom/google/android/gms/maps/model/Tile;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NO_TILE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/model/UrlTileProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UrlTileProvider); }
		}

		protected UrlTileProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		[Register (".ctor", "(II)V", "")]
		public UrlTileProvider (int p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UrlTileProvider)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(II)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_II == IntPtr.Zero)
				id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_II, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getTile_III;
		[Register ("getTile", "(III)Lcom/google/android/gms/maps/model/Tile;", "")]
		public global::Android.Gms.Maps.Model.Tile GetTile (int p0, int p1, int p2)
		{
			if (id_getTile_III == IntPtr.Zero)
				id_getTile_III = JNIEnv.GetMethodID (class_ref, "getTile", "(III)Lcom/google/android/gms/maps/model/Tile;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.Tile> (JNIEnv.CallObjectMethod  (Handle, id_getTile_III, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getTileUrl_III;
#pragma warning disable 0169
		static Delegate GetGetTileUrl_IIIHandler ()
		{
			if (cb_getTileUrl_III == null)
				cb_getTileUrl_III = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr>) n_GetTileUrl_III);
			return cb_getTileUrl_III;
		}

		static IntPtr n_GetTileUrl_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::Android.Gms.Maps.Model.UrlTileProvider __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.UrlTileProvider> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTileUrl (p0, p1, p2));
		}
#pragma warning restore 0169

		[Register ("getTileUrl", "(III)Ljava/net/URL;", "GetGetTileUrl_IIIHandler")]
		public abstract global::Java.Net.URL GetTileUrl (int p0, int p1, int p2);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/maps/model/UrlTileProvider", DoNotGenerateAcw=true)]
	internal partial class UrlTileProviderInvoker : UrlTileProvider {

		public UrlTileProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (UrlTileProviderInvoker); }
		}

		static IntPtr id_getTileUrl_III;
		[Register ("getTileUrl", "(III)Ljava/net/URL;", "GetGetTileUrl_IIIHandler")]
		public override global::Java.Net.URL GetTileUrl (int p0, int p1, int p2)
		{
			if (id_getTileUrl_III == IntPtr.Zero)
				id_getTileUrl_III = JNIEnv.GetMethodID (class_ref, "getTileUrl", "(III)Ljava/net/URL;");
			return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (JNIEnv.CallObjectMethod  (Handle, id_getTileUrl_III, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
		}

	}

}
