using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal.Model.External {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='Reader']"
	[global::Android.Runtime.Register ("com/stripe/stripeterminal/model/external/Reader", DoNotGenerateAcw=true)]
	public partial class Reader : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/model/external/Reader", typeof (Reader));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected Reader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe global::Java.Lang.Float BatteryLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='Reader']/method[@name='getBatteryLevel' and count(parameter)=0]"
			[Register ("getBatteryLevel", "()Ljava/lang/Float;", "")]
			get {
				const string __id = "getBatteryLevel.()Ljava/lang/Float;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Stripe.Stripeterminal.Model.External.DeviceType DeviceType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='Reader']/method[@name='getDeviceType' and count(parameter)=0]"
			[Register ("getDeviceType", "()Lcom/stripe/stripeterminal/model/external/DeviceType;", "")]
			get {
				const string __id = "getDeviceType.()Lcom/stripe/stripeterminal/model/external/DeviceType;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.DeviceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsSimulated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='Reader']/method[@name='isSimulated' and count(parameter)=0]"
			[Register ("isSimulated", "()Z", "")]
			get {
				const string __id = "isSimulated.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSerialNumber;
#pragma warning disable 0169
		static Delegate GetGetSerialNumberHandler ()
		{
			if (cb_getSerialNumber == null)
				cb_getSerialNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSerialNumber);
			return cb_getSerialNumber;
		}

		static IntPtr n_GetSerialNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Stripe.Stripeterminal.Model.External.Reader __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.Reader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SerialNumber);
		}
#pragma warning restore 0169

		public virtual unsafe string SerialNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='Reader']/method[@name='getSerialNumber' and count(parameter)=0]"
			[Register ("getSerialNumber", "()Ljava/lang/String;", "GetGetSerialNumberHandler")]
			get {
				const string __id = "getSerialNumber.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string SoftwareVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='Reader']/method[@name='getSoftwareVersion' and count(parameter)=0]"
			[Register ("getSoftwareVersion", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getSoftwareVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
