using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal.Model.External {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentStatus']"
	[global::Android.Runtime.Register ("com/stripe/stripeterminal/model/external/PaymentIntentStatus", DoNotGenerateAcw=true)]
	public sealed partial class PaymentIntentStatus : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentStatus']/field[@name='CANCELED']"
		[Register ("CANCELED")]
		public static global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentStatus Canceled {
			get {
				const string __id = "CANCELED.Lcom/stripe/stripeterminal/model/external/PaymentIntentStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentStatus']/field[@name='REQUIRES_CAPTURE']"
		[Register ("REQUIRES_CAPTURE")]
		public static global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentStatus RequiresCapture {
			get {
				const string __id = "REQUIRES_CAPTURE.Lcom/stripe/stripeterminal/model/external/PaymentIntentStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentStatus']/field[@name='REQUIRES_CONFIRMATION']"
		[Register ("REQUIRES_CONFIRMATION")]
		public static global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentStatus RequiresConfirmation {
			get {
				const string __id = "REQUIRES_CONFIRMATION.Lcom/stripe/stripeterminal/model/external/PaymentIntentStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentStatus']/field[@name='REQUIRES_PAYMENT_METHOD']"
		[Register ("REQUIRES_PAYMENT_METHOD")]
		public static global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentStatus RequiresPaymentMethod {
			get {
				const string __id = "REQUIRES_PAYMENT_METHOD.Lcom/stripe/stripeterminal/model/external/PaymentIntentStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/model/external/PaymentIntentStatus", typeof (PaymentIntentStatus));
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

		internal PaymentIntentStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/PaymentIntentStatus;", "")]
		public static unsafe global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentStatus ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/PaymentIntentStatus;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/stripe/stripeterminal/model/external/PaymentIntentStatus;", "")]
		public static unsafe global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentStatus[] Values ()
		{
			const string __id = "values.()[Lcom/stripe/stripeterminal/model/external/PaymentIntentStatus;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentStatus));
			} finally {
			}
		}

	}
}
