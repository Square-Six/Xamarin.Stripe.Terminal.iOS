using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal.Model.External {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderDisplayMessage']"
	[global::Android.Runtime.Register ("com/stripe/stripeterminal/model/external/ReaderDisplayMessage", DoNotGenerateAcw=true)]
	public sealed partial class ReaderDisplayMessage : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderDisplayMessage']/field[@name='INSERT_CARD']"
		[Register ("INSERT_CARD")]
		public static global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage InsertCard {
			get {
				const string __id = "INSERT_CARD.Lcom/stripe/stripeterminal/model/external/ReaderDisplayMessage;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderDisplayMessage']/field[@name='INSERT_OR_SWIPE_CARD']"
		[Register ("INSERT_OR_SWIPE_CARD")]
		public static global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage InsertOrSwipeCard {
			get {
				const string __id = "INSERT_OR_SWIPE_CARD.Lcom/stripe/stripeterminal/model/external/ReaderDisplayMessage;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderDisplayMessage']/field[@name='MULTIPLE_CONTACTLESS_CARDS_DETECTED']"
		[Register ("MULTIPLE_CONTACTLESS_CARDS_DETECTED")]
		public static global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage MultipleContactlessCardsDetected {
			get {
				const string __id = "MULTIPLE_CONTACTLESS_CARDS_DETECTED.Lcom/stripe/stripeterminal/model/external/ReaderDisplayMessage;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderDisplayMessage']/field[@name='REMOVE_CARD']"
		[Register ("REMOVE_CARD")]
		public static global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage RemoveCard {
			get {
				const string __id = "REMOVE_CARD.Lcom/stripe/stripeterminal/model/external/ReaderDisplayMessage;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderDisplayMessage']/field[@name='RETRY_CARD']"
		[Register ("RETRY_CARD")]
		public static global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage RetryCard {
			get {
				const string __id = "RETRY_CARD.Lcom/stripe/stripeterminal/model/external/ReaderDisplayMessage;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderDisplayMessage']/field[@name='SWIPE_CARD']"
		[Register ("SWIPE_CARD")]
		public static global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage SwipeCard {
			get {
				const string __id = "SWIPE_CARD.Lcom/stripe/stripeterminal/model/external/ReaderDisplayMessage;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderDisplayMessage']/field[@name='TRY_ANOTHER_CARD']"
		[Register ("TRY_ANOTHER_CARD")]
		public static global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage TryAnotherCard {
			get {
				const string __id = "TRY_ANOTHER_CARD.Lcom/stripe/stripeterminal/model/external/ReaderDisplayMessage;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderDisplayMessage']/field[@name='TRY_ANOTHER_READ_METHOD']"
		[Register ("TRY_ANOTHER_READ_METHOD")]
		public static global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage TryAnotherReadMethod {
			get {
				const string __id = "TRY_ANOTHER_READ_METHOD.Lcom/stripe/stripeterminal/model/external/ReaderDisplayMessage;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/model/external/ReaderDisplayMessage", typeof (ReaderDisplayMessage));
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

		internal ReaderDisplayMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderDisplayMessage']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/ReaderDisplayMessage;", "")]
		public static unsafe global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/ReaderDisplayMessage;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderDisplayMessage']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/stripe/stripeterminal/model/external/ReaderDisplayMessage;", "")]
		public static unsafe global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage[] Values ()
		{
			const string __id = "values.()[Lcom/stripe/stripeterminal/model/external/ReaderDisplayMessage;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage));
			} finally {
			}
		}

	}
}
