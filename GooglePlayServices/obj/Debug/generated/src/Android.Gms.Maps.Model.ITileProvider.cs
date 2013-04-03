using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps.Model {

	[Register ("com/google/android/gms/maps/model/TileProvider")]
	public abstract class TileProvider {

		internal TileProvider ()
		{
		}

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

		static IntPtr class_ref = JNIEnv.FindClass ("com/google/android/gms/maps/model/TileProvider");
	}

	[System.Obsolete ("Use the 'TileProvider' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class TileProviderConsts : TileProvider {

		private TileProviderConsts ()
		{
		}
	}

	[Register ("com/google/android/gms/maps/model/TileProvider", "", "Android.Gms.Maps.Model.ITileProviderInvoker")]
	public partial interface ITileProvider : IJavaObject {

		[Register ("getTile", "(III)Lcom/google/android/gms/maps/model/Tile;", "GetGetTile_IIIHandler:Android.Gms.Maps.Model.ITileProviderInvoker, GooglePlayServices")]
		global::Android.Gms.Maps.Model.Tile GetTile (int p0, int p1, int p2);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/maps/model/TileProvider", DoNotGenerateAcw=true)]
	internal class ITileProviderInvoker : global::Java.Lang.Object, ITileProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/maps/model/TileProvider");
		IntPtr class_ref;

		public static ITileProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITileProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.maps.model.TileProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITileProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ITileProviderInvoker); }
		}

		static Delegate cb_getTile_III;
#pragma warning disable 0169
		static Delegate GetGetTile_IIIHandler ()
		{
			if (cb_getTile_III == null)
				cb_getTile_III = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr>) n_GetTile_III);
			return cb_getTile_III;
		}

		static IntPtr n_GetTile_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::Android.Gms.Maps.Model.ITileProvider __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.ITileProvider> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTile (p0, p1, p2));
		}
#pragma warning restore 0169

		IntPtr id_getTile_III;
		public global::Android.Gms.Maps.Model.Tile GetTile (int p0, int p1, int p2)
		{
			if (id_getTile_III == IntPtr.Zero)
				id_getTile_III = JNIEnv.GetMethodID (class_ref, "getTile", "(III)Lcom/google/android/gms/maps/model/Tile;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.Tile> (JNIEnv.CallObjectMethod (Handle, id_getTile_III, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
		}

	}

}
