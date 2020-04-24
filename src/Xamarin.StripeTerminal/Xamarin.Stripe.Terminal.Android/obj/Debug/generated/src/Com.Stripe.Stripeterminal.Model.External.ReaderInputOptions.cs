using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal.Model.External {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderInputOptions']"
	[global::Android.Runtime.Register ("com/stripe/stripeterminal/model/external/ReaderInputOptions", DoNotGenerateAcw=true)]
	public sealed partial class ReaderInputOptions : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderInputOptions.ReaderInputOption']"
		[global::Android.Runtime.Register ("com/stripe/stripeterminal/model/external/ReaderInputOptions$ReaderInputOption", DoNotGenerateAcw=true)]
		public sealed partial class ReaderInputOption : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderInputOptions.ReaderInputOption']/field[@name='INSERT']"
			[Register ("INSERT")]
			public static global::Com.Stripe.Stripeterminal.Model.External.ReaderInputOptions.ReaderInputOption Insert {
				get {
					const string __id = "INSERT.Lcom/stripe/stripeterminal/model/external/ReaderInputOptions$ReaderInputOption;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReaderInputOptions.ReaderInputOption> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderInputOptions.ReaderInputOption']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Com.Stripe.Stripeterminal.Model.External.ReaderInputOptions.ReaderInputOption None {
				get {
					const string __id = "NONE.Lcom/stripe/stripeterminal/model/external/ReaderInputOptions$ReaderInputOption;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReaderInputOptions.ReaderInputOption> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderInputOptions.ReaderInputOption']/field[@name='SWIPE']"
			[Register ("SWIPE")]
			public static global::Com.Stripe.Stripeterminal.Model.External.ReaderInputOptions.ReaderInputOption Swipe {
				get {
					const string __id = "SWIPE.Lcom/stripe/stripeterminal/model/external/ReaderInputOptions$ReaderInputOption;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReaderInputOptions.ReaderInputOption> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderInputOptions.ReaderInputOption']/field[@name='TAP']"
			[Register ("TAP")]
			public static global::Com.Stripe.Stripeterminal.Model.External.ReaderInputOptions.ReaderInputOption Tap {
				get {
					const string __id = "TAP.Lcom/stripe/stripeterminal/model/external/ReaderInputOptions$ReaderInputOption;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReaderInputOptions.ReaderInputOption> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/model/external/ReaderInputOptions$ReaderInputOption", typeof (ReaderInputOption));
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

			internal ReaderInputOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderInputOptions.ReaderInputOption']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/ReaderInputOptions$ReaderInputOption;", "")]
			public static unsafe global::Com.Stripe.Stripeterminal.Model.External.ReaderInputOptions.ReaderInputOption ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/ReaderInputOptions$ReaderInputOption;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReaderInputOptions.ReaderInputOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderInputOptions.ReaderInputOption']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/stripe/stripeterminal/model/external/ReaderInputOptions$ReaderInputOption;", "")]
			public static unsafe global::Com.Stripe.Stripeterminal.Model.External.ReaderInputOptions.ReaderInputOption[] Values ()
			{
				const string __id = "values.()[Lcom/stripe/stripeterminal/model/external/ReaderInputOptions$ReaderInputOption;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Stripe.Stripeterminal.Model.External.ReaderInputOptions.ReaderInputOption[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Stripe.Stripeterminal.Model.External.ReaderInputOptions.ReaderInputOption));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/model/external/ReaderInputOptions", typeof (ReaderInputOptions));
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

		internal ReaderInputOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
