using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal.Model.External {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ConnectionStatus']"
	[global::Android.Runtime.Register ("com/stripe/stripeterminal/model/external/ConnectionStatus", DoNotGenerateAcw=true)]
	public sealed partial class ConnectionStatus : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ConnectionStatus']/field[@name='CONNECTED']"
		[Register ("CONNECTED")]
		public static global::Com.Stripe.Stripeterminal.Model.External.ConnectionStatus Connected {
			get {
				const string __id = "CONNECTED.Lcom/stripe/stripeterminal/model/external/ConnectionStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ConnectionStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ConnectionStatus']/field[@name='CONNECTING']"
		[Register ("CONNECTING")]
		public static global::Com.Stripe.Stripeterminal.Model.External.ConnectionStatus Connecting {
			get {
				const string __id = "CONNECTING.Lcom/stripe/stripeterminal/model/external/ConnectionStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ConnectionStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ConnectionStatus']/field[@name='NOT_CONNECTED']"
		[Register ("NOT_CONNECTED")]
		public static global::Com.Stripe.Stripeterminal.Model.External.ConnectionStatus NotConnected {
			get {
				const string __id = "NOT_CONNECTED.Lcom/stripe/stripeterminal/model/external/ConnectionStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ConnectionStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/model/external/ConnectionStatus", typeof (ConnectionStatus));
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

		internal ConnectionStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ConnectionStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/ConnectionStatus;", "")]
		public static unsafe global::Com.Stripe.Stripeterminal.Model.External.ConnectionStatus ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/ConnectionStatus;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ConnectionStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ConnectionStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/stripe/stripeterminal/model/external/ConnectionStatus;", "")]
		public static unsafe global::Com.Stripe.Stripeterminal.Model.External.ConnectionStatus[] Values ()
		{
			const string __id = "values.()[Lcom/stripe/stripeterminal/model/external/ConnectionStatus;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Stripe.Stripeterminal.Model.External.ConnectionStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Stripe.Stripeterminal.Model.External.ConnectionStatus));
			} finally {
			}
		}

	}
}
