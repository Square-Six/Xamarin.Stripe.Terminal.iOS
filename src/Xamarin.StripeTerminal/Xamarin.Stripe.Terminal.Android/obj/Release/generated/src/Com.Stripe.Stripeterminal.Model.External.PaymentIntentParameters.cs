using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal.Model.External {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentParameters']"
	[global::Android.Runtime.Register ("com/stripe/stripeterminal/model/external/PaymentIntentParameters", DoNotGenerateAcw=true)]
	public sealed partial class PaymentIntentParameters : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentParameters.Builder']"
		[global::Android.Runtime.Register ("com/stripe/stripeterminal/model/external/PaymentIntentParameters$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/model/external/PaymentIntentParameters$Builder", typeof (Builder));
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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentParameters.Builder']/constructor[@name='PaymentIntentParameters.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentParameters.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/stripe/stripeterminal/model/external/PaymentIntentParameters;", "")]
			public unsafe global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentParameters Build ()
			{
				const string __id = "build.()Lcom/stripe/stripeterminal/model/external/PaymentIntentParameters;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentParameters.Builder']/method[@name='setCurrency' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCurrency", "(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/PaymentIntentParameters$Builder;", "")]
			public unsafe global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentParameters.Builder SetCurrency (string currency)
			{
				const string __id = "setCurrency.(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/PaymentIntentParameters$Builder;";
				IntPtr native_currency = JNIEnv.NewString (currency);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_currency);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_currency);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentParameters.Builder']/method[@name='setCustomer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCustomer", "(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/PaymentIntentParameters$Builder;", "")]
			public unsafe global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentParameters.Builder SetCustomer (string customer)
			{
				const string __id = "setCustomer.(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/PaymentIntentParameters$Builder;";
				IntPtr native_customer = JNIEnv.NewString (customer);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_customer);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_customer);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentParameters.Builder']/method[@name='setDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDescription", "(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/PaymentIntentParameters$Builder;", "")]
			public unsafe global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentParameters.Builder SetDescription (string description)
			{
				const string __id = "setDescription.(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/PaymentIntentParameters$Builder;";
				IntPtr native_description = JNIEnv.NewString (description);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_description);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_description);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentParameters.Builder']/method[@name='setMetadata' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setMetadata", "(Ljava/util/Map;)Lcom/stripe/stripeterminal/model/external/PaymentIntentParameters$Builder;", "")]
			public unsafe global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentParameters.Builder SetMetadata (global::System.Collections.Generic.IDictionary<string, string> metadata)
			{
				const string __id = "setMetadata.(Ljava/util/Map;)Lcom/stripe/stripeterminal/model/external/PaymentIntentParameters$Builder;";
				IntPtr native_metadata = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (metadata);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_metadata);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_metadata);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentParameters.Builder']/method[@name='setOnBehalfOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setOnBehalfOf", "(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/PaymentIntentParameters$Builder;", "")]
			public unsafe global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentParameters.Builder SetOnBehalfOf (string onBehalfOf)
			{
				const string __id = "setOnBehalfOf.(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/PaymentIntentParameters$Builder;";
				IntPtr native_onBehalfOf = JNIEnv.NewString (onBehalfOf);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_onBehalfOf);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_onBehalfOf);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentParameters.Builder']/method[@name='setReceiptEmail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setReceiptEmail", "(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/PaymentIntentParameters$Builder;", "")]
			public unsafe global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentParameters.Builder SetReceiptEmail (string receiptEmail)
			{
				const string __id = "setReceiptEmail.(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/PaymentIntentParameters$Builder;";
				IntPtr native_receiptEmail = JNIEnv.NewString (receiptEmail);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_receiptEmail);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_receiptEmail);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentParameters.Builder']/method[@name='setStatementDescriptor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStatementDescriptor", "(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/PaymentIntentParameters$Builder;", "")]
			public unsafe global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentParameters.Builder SetStatementDescriptor (string statementDescriptor)
			{
				const string __id = "setStatementDescriptor.(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/PaymentIntentParameters$Builder;";
				IntPtr native_statementDescriptor = JNIEnv.NewString (statementDescriptor);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_statementDescriptor);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_statementDescriptor);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentParameters.Builder']/method[@name='setTransferDataDestination' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTransferDataDestination", "(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/PaymentIntentParameters$Builder;", "")]
			public unsafe global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentParameters.Builder SetTransferDataDestination (string transferDataDestination)
			{
				const string __id = "setTransferDataDestination.(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/PaymentIntentParameters$Builder;";
				IntPtr native_transferDataDestination = JNIEnv.NewString (transferDataDestination);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_transferDataDestination);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_transferDataDestination);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentParameters.Builder']/method[@name='setTransferGroup' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTransferGroup", "(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/PaymentIntentParameters$Builder;", "")]
			public unsafe global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentParameters.Builder SetTransferGroup (string transferGroup)
			{
				const string __id = "setTransferGroup.(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/PaymentIntentParameters$Builder;";
				IntPtr native_transferGroup = JNIEnv.NewString (transferGroup);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_transferGroup);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_transferGroup);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/model/external/PaymentIntentParameters", typeof (PaymentIntentParameters));
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

		internal PaymentIntentParameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe global::Java.Lang.Integer Amount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentParameters']/method[@name='getAmount' and count(parameter)=0]"
			[Register ("getAmount", "()Ljava/lang/Integer;", "")]
			get {
				const string __id = "getAmount.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Integer ApplicationFeeAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentParameters']/method[@name='getApplicationFeeAmount' and count(parameter)=0]"
			[Register ("getApplicationFeeAmount", "()Ljava/lang/Integer;", "")]
			get {
				const string __id = "getApplicationFeeAmount.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Currency {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentParameters']/method[@name='getCurrency' and count(parameter)=0]"
			[Register ("getCurrency", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getCurrency.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Customer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentParameters']/method[@name='getCustomer' and count(parameter)=0]"
			[Register ("getCustomer", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getCustomer.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentParameters']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDescription.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IDictionary<string, string> Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentParameters']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Ljava/util/Map;", "")]
			get {
				const string __id = "getMetadata.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string OnBehalfOf {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentParameters']/method[@name='getOnBehalfOf' and count(parameter)=0]"
			[Register ("getOnBehalfOf", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getOnBehalfOf.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string ReceiptEmail {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentParameters']/method[@name='getReceiptEmail' and count(parameter)=0]"
			[Register ("getReceiptEmail", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getReceiptEmail.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string StatementDescriptor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentParameters']/method[@name='getStatementDescriptor' and count(parameter)=0]"
			[Register ("getStatementDescriptor", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getStatementDescriptor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string TransferDataDestination {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentParameters']/method[@name='getTransferDataDestination' and count(parameter)=0]"
			[Register ("getTransferDataDestination", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getTransferDataDestination.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string TransferGroup {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentIntentParameters']/method[@name='getTransferGroup' and count(parameter)=0]"
			[Register ("getTransferGroup", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getTransferGroup.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
