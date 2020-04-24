using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Rules {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.rules']/class[@name='DisableOnDebug']"
	[global::Android.Runtime.Register ("org/junit/rules/DisableOnDebug", DoNotGenerateAcw=true)]
	public partial class DisableOnDebug : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/rules/DisableOnDebug", typeof (DisableOnDebug));
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

		protected DisableOnDebug (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isDebugging;
#pragma warning disable 0169
		static Delegate GetIsDebuggingHandler ()
		{
			if (cb_isDebugging == null)
				cb_isDebugging = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDebugging);
			return cb_isDebugging;
		}

		static bool n_IsDebugging (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Rules.DisableOnDebug __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.DisableOnDebug> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDebugging;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDebugging {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='DisableOnDebug']/method[@name='isDebugging' and count(parameter)=0]"
			[Register ("isDebugging", "()Z", "GetIsDebuggingHandler")]
			get {
				const string __id = "isDebugging.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
