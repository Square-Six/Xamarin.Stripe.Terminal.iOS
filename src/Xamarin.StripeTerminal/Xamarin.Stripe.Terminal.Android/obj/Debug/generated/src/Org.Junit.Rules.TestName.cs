using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Rules {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.rules']/class[@name='TestName']"
	[global::Android.Runtime.Register ("org/junit/rules/TestName", DoNotGenerateAcw=true)]
	public partial class TestName : global::Org.Junit.Rules.TestWatcher {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/rules/TestName", typeof (TestName));
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

		protected TestName (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.rules']/class[@name='TestName']/constructor[@name='TestName' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TestName ()
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

		static Delegate cb_getMethodName;
#pragma warning disable 0169
		static Delegate GetGetMethodNameHandler ()
		{
			if (cb_getMethodName == null)
				cb_getMethodName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMethodName);
			return cb_getMethodName;
		}

		static IntPtr n_GetMethodName (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Rules.TestName __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.TestName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MethodName);
		}
#pragma warning restore 0169

		public virtual unsafe string MethodName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='TestName']/method[@name='getMethodName' and count(parameter)=0]"
			[Register ("getMethodName", "()Ljava/lang/String;", "GetGetMethodNameHandler")]
			get {
				const string __id = "getMethodName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
