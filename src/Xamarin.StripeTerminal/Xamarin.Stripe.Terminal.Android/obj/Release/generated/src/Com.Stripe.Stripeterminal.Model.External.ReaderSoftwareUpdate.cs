using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal.Model.External {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderSoftwareUpdate']"
	[global::Android.Runtime.Register ("com/stripe/stripeterminal/model/external/ReaderSoftwareUpdate", DoNotGenerateAcw=true)]
	public sealed partial class ReaderSoftwareUpdate : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderSoftwareUpdate.UpdateTimeEstimate']"
		[global::Android.Runtime.Register ("com/stripe/stripeterminal/model/external/ReaderSoftwareUpdate$UpdateTimeEstimate", DoNotGenerateAcw=true)]
		public sealed partial class UpdateTimeEstimate : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderSoftwareUpdate.UpdateTimeEstimate']/field[@name='FIVE_TO_FIFTEEN_MINUTES']"
			[Register ("FIVE_TO_FIFTEEN_MINUTES")]
			public static global::Com.Stripe.Stripeterminal.Model.External.ReaderSoftwareUpdate.UpdateTimeEstimate FiveToFifteenMinutes {
				get {
					const string __id = "FIVE_TO_FIFTEEN_MINUTES.Lcom/stripe/stripeterminal/model/external/ReaderSoftwareUpdate$UpdateTimeEstimate;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReaderSoftwareUpdate.UpdateTimeEstimate> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderSoftwareUpdate.UpdateTimeEstimate']/field[@name='LESS_THAN_ONE_MINUTE']"
			[Register ("LESS_THAN_ONE_MINUTE")]
			public static global::Com.Stripe.Stripeterminal.Model.External.ReaderSoftwareUpdate.UpdateTimeEstimate LessThanOneMinute {
				get {
					const string __id = "LESS_THAN_ONE_MINUTE.Lcom/stripe/stripeterminal/model/external/ReaderSoftwareUpdate$UpdateTimeEstimate;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReaderSoftwareUpdate.UpdateTimeEstimate> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderSoftwareUpdate.UpdateTimeEstimate']/field[@name='ONE_TO_TWO_MINUTES']"
			[Register ("ONE_TO_TWO_MINUTES")]
			public static global::Com.Stripe.Stripeterminal.Model.External.ReaderSoftwareUpdate.UpdateTimeEstimate OneToTwoMinutes {
				get {
					const string __id = "ONE_TO_TWO_MINUTES.Lcom/stripe/stripeterminal/model/external/ReaderSoftwareUpdate$UpdateTimeEstimate;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReaderSoftwareUpdate.UpdateTimeEstimate> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderSoftwareUpdate.UpdateTimeEstimate']/field[@name='TWO_TO_FIVE_MINUTES']"
			[Register ("TWO_TO_FIVE_MINUTES")]
			public static global::Com.Stripe.Stripeterminal.Model.External.ReaderSoftwareUpdate.UpdateTimeEstimate TwoToFiveMinutes {
				get {
					const string __id = "TWO_TO_FIVE_MINUTES.Lcom/stripe/stripeterminal/model/external/ReaderSoftwareUpdate$UpdateTimeEstimate;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReaderSoftwareUpdate.UpdateTimeEstimate> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/model/external/ReaderSoftwareUpdate$UpdateTimeEstimate", typeof (UpdateTimeEstimate));
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

			internal UpdateTimeEstimate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe string Description {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderSoftwareUpdate.UpdateTimeEstimate']/method[@name='getDescription' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderSoftwareUpdate.UpdateTimeEstimate']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/ReaderSoftwareUpdate$UpdateTimeEstimate;", "")]
			public static unsafe global::Com.Stripe.Stripeterminal.Model.External.ReaderSoftwareUpdate.UpdateTimeEstimate ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/ReaderSoftwareUpdate$UpdateTimeEstimate;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReaderSoftwareUpdate.UpdateTimeEstimate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderSoftwareUpdate.UpdateTimeEstimate']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/stripe/stripeterminal/model/external/ReaderSoftwareUpdate$UpdateTimeEstimate;", "")]
			public static unsafe global::Com.Stripe.Stripeterminal.Model.External.ReaderSoftwareUpdate.UpdateTimeEstimate[] Values ()
			{
				const string __id = "values.()[Lcom/stripe/stripeterminal/model/external/ReaderSoftwareUpdate$UpdateTimeEstimate;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Stripe.Stripeterminal.Model.External.ReaderSoftwareUpdate.UpdateTimeEstimate[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Stripe.Stripeterminal.Model.External.ReaderSoftwareUpdate.UpdateTimeEstimate));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/model/external/ReaderSoftwareUpdate", typeof (ReaderSoftwareUpdate));
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

		internal ReaderSoftwareUpdate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe bool HasConfigUpdate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderSoftwareUpdate']/method[@name='hasConfigUpdate' and count(parameter)=0]"
			[Register ("hasConfigUpdate", "()Z", "")]
			get {
				const string __id = "hasConfigUpdate.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool HasFirmwareUpdate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderSoftwareUpdate']/method[@name='hasFirmwareUpdate' and count(parameter)=0]"
			[Register ("hasFirmwareUpdate", "()Z", "")]
			get {
				const string __id = "hasFirmwareUpdate.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool HasKeyUpdate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderSoftwareUpdate']/method[@name='hasKeyUpdate' and count(parameter)=0]"
			[Register ("hasKeyUpdate", "()Z", "")]
			get {
				const string __id = "hasKeyUpdate.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Stripe.Stripeterminal.Model.External.ReaderSoftwareUpdate.UpdateTimeEstimate TimeEstimate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderSoftwareUpdate']/method[@name='getTimeEstimate' and count(parameter)=0]"
			[Register ("getTimeEstimate", "()Lcom/stripe/stripeterminal/model/external/ReaderSoftwareUpdate$UpdateTimeEstimate;", "")]
			get {
				const string __id = "getTimeEstimate.()Lcom/stripe/stripeterminal/model/external/ReaderSoftwareUpdate$UpdateTimeEstimate;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReaderSoftwareUpdate.UpdateTimeEstimate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='ReaderSoftwareUpdate']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
