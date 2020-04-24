using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal.Model.External {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentStatus']"
	[global::Android.Runtime.Register ("com/stripe/stripeterminal/model/external/PaymentStatus", DoNotGenerateAcw=true)]
	public sealed partial class PaymentStatus : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentStatus']/field[@name='NOT_READY']"
		[Register ("NOT_READY")]
		public static global::Com.Stripe.Stripeterminal.Model.External.PaymentStatus NotReady {
			get {
				const string __id = "NOT_READY.Lcom/stripe/stripeterminal/model/external/PaymentStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentStatus']/field[@name='PROCESSING']"
		[Register ("PROCESSING")]
		public static global::Com.Stripe.Stripeterminal.Model.External.PaymentStatus Processing {
			get {
				const string __id = "PROCESSING.Lcom/stripe/stripeterminal/model/external/PaymentStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentStatus']/field[@name='READY']"
		[Register ("READY")]
		public static global::Com.Stripe.Stripeterminal.Model.External.PaymentStatus Ready {
			get {
				const string __id = "READY.Lcom/stripe/stripeterminal/model/external/PaymentStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentStatus']/field[@name='WAITING_FOR_INPUT']"
		[Register ("WAITING_FOR_INPUT")]
		public static global::Com.Stripe.Stripeterminal.Model.External.PaymentStatus WaitingForInput {
			get {
				const string __id = "WAITING_FOR_INPUT.Lcom/stripe/stripeterminal/model/external/PaymentStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/model/external/PaymentStatus", typeof (PaymentStatus));
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

		internal PaymentStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/PaymentStatus;", "")]
		public static unsafe global::Com.Stripe.Stripeterminal.Model.External.PaymentStatus ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/PaymentStatus;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/stripe/stripeterminal/model/external/PaymentStatus;", "")]
		public static unsafe global::Com.Stripe.Stripeterminal.Model.External.PaymentStatus[] Values ()
		{
			const string __id = "values.()[Lcom/stripe/stripeterminal/model/external/PaymentStatus;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Stripe.Stripeterminal.Model.External.PaymentStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Stripe.Stripeterminal.Model.External.PaymentStatus));
			} finally {
			}
		}

	}
}
