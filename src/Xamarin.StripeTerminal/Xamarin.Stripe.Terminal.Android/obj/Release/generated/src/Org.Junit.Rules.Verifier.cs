using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Rules {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.rules']/class[@name='Verifier']"
	[global::Android.Runtime.Register ("org/junit/rules/Verifier", DoNotGenerateAcw=true)]
	public abstract partial class Verifier : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/rules/Verifier", typeof (Verifier));
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

		protected Verifier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.rules']/class[@name='Verifier']/constructor[@name='Verifier' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Verifier ()
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

		static Delegate cb_verify;
#pragma warning disable 0169
		static Delegate GetVerifyHandler ()
		{
			if (cb_verify == null)
				cb_verify = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Verify);
			return cb_verify;
		}

		static void n_Verify (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Rules.Verifier __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.Verifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Verify ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='Verifier']/method[@name='verify' and count(parameter)=0]"
		[Register ("verify", "()V", "GetVerifyHandler")]
		protected virtual unsafe void Verify ()
		{
			const string __id = "verify.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/junit/rules/Verifier", DoNotGenerateAcw=true)]
	internal partial class VerifierInvoker : Verifier {

		public VerifierInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/rules/Verifier", typeof (VerifierInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
