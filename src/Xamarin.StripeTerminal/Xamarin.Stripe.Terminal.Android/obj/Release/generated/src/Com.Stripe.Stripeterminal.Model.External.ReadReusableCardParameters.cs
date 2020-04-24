using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal.Model.External {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReadReusableCardParameters']"
	[global::Android.Runtime.Register ("com/stripe/stripeterminal/model/external/ReadReusableCardParameters", DoNotGenerateAcw=true)]
	public sealed partial class ReadReusableCardParameters : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReadReusableCardParameters.Builder']"
		[global::Android.Runtime.Register ("com/stripe/stripeterminal/model/external/ReadReusableCardParameters$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/model/external/ReadReusableCardParameters$Builder", typeof (Builder));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReadReusableCardParameters.Builder']/constructor[@name='ReadReusableCardParameters.Builder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReadReusableCardParameters.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/stripe/stripeterminal/model/external/ReadReusableCardParameters;", "")]
			public unsafe global::Com.Stripe.Stripeterminal.Model.External.ReadReusableCardParameters Build ()
			{
				const string __id = "build.()Lcom/stripe/stripeterminal/model/external/ReadReusableCardParameters;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReadReusableCardParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReadReusableCardParameters.Builder']/method[@name='putAllMetadata' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("putAllMetadata", "(Ljava/util/Map;)Lcom/stripe/stripeterminal/model/external/ReadReusableCardParameters$Builder;", "")]
			public unsafe global::Com.Stripe.Stripeterminal.Model.External.ReadReusableCardParameters.Builder PutAllMetadata (global::System.Collections.Generic.IDictionary<string, string> data)
			{
				const string __id = "putAllMetadata.(Ljava/util/Map;)Lcom/stripe/stripeterminal/model/external/ReadReusableCardParameters$Builder;";
				IntPtr native_data = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_data);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReadReusableCardParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_data);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReadReusableCardParameters.Builder']/method[@name='putMetadata' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("putMetadata", "(Ljava/lang/String;Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/ReadReusableCardParameters$Builder;", "")]
			public unsafe global::Com.Stripe.Stripeterminal.Model.External.ReadReusableCardParameters.Builder PutMetadata (string key, string value)
			{
				const string __id = "putMetadata.(Ljava/lang/String;Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/ReadReusableCardParameters$Builder;";
				IntPtr native_key = JNIEnv.NewString (key);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_key);
					__args [1] = new JniArgumentValue (native_value);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReadReusableCardParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_key);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReadReusableCardParameters.Companion']"
		[global::Android.Runtime.Register ("com/stripe/stripeterminal/model/external/ReadReusableCardParameters$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/model/external/ReadReusableCardParameters$Companion", typeof (Companion));
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

			internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe global::Com.Stripe.Stripeterminal.Model.External.ReadReusableCardParameters NULL {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReadReusableCardParameters.Companion']/method[@name='getNULL' and count(parameter)=0]"
				[Register ("getNULL", "()Lcom/stripe/stripeterminal/model/external/ReadReusableCardParameters;", "")]
				get {
					const string __id = "getNULL.()Lcom/stripe/stripeterminal/model/external/ReadReusableCardParameters;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReadReusableCardParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/model/external/ReadReusableCardParameters", typeof (ReadReusableCardParameters));
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

		internal ReadReusableCardParameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Stripe.Stripeterminal.Model.External.ReadReusableCardParameters NULL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReadReusableCardParameters']/method[@name='getNULL' and count(parameter)=0]"
			[Register ("getNULL", "()Lcom/stripe/stripeterminal/model/external/ReadReusableCardParameters;", "")]
			get {
				const string __id = "getNULL.()Lcom/stripe/stripeterminal/model/external/ReadReusableCardParameters;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReadReusableCardParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
