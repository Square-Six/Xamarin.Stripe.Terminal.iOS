using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Junit.Extensions {

	// Metadata.xml XPath class reference: path="/api/package[@name='junit.extensions']/class[@name='TestSetup']"
	[global::Android.Runtime.Register ("junit/extensions/TestSetup", DoNotGenerateAcw=true)]
	public partial class TestSetup : global::Junit.Extensions.TestDecorator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("junit/extensions/TestSetup", typeof (TestSetup));
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

		protected TestSetup (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.extensions']/class[@name='TestSetup']/constructor[@name='TestSetup' and count(parameter)=1 and parameter[1][@type='junit.framework.Test']]"
		[Register (".ctor", "(Ljunit/framework/Test;)V", "")]
		public unsafe TestSetup (global::Junit.Framework.ITest test)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljunit/framework/Test;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((test == null) ? IntPtr.Zero : ((global::Java.Lang.Object) test).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setUp;
#pragma warning disable 0169
		static Delegate GetSetUpHandler ()
		{
			if (cb_setUp == null)
				cb_setUp = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetUp);
			return cb_setUp;
		}

		static void n_SetUp (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Extensions.TestSetup __this = global::Java.Lang.Object.GetObject<global::Junit.Extensions.TestSetup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUp ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.extensions']/class[@name='TestSetup']/method[@name='setUp' and count(parameter)=0]"
		[Register ("setUp", "()V", "GetSetUpHandler")]
		protected virtual unsafe void SetUp ()
		{
			const string __id = "setUp.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_tearDown;
#pragma warning disable 0169
		static Delegate GetTearDownHandler ()
		{
			if (cb_tearDown == null)
				cb_tearDown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TearDown);
			return cb_tearDown;
		}

		static void n_TearDown (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Extensions.TestSetup __this = global::Java.Lang.Object.GetObject<global::Junit.Extensions.TestSetup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TearDown ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.extensions']/class[@name='TestSetup']/method[@name='tearDown' and count(parameter)=0]"
		[Register ("tearDown", "()V", "GetTearDownHandler")]
		protected virtual unsafe void TearDown ()
		{
			const string __id = "tearDown.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
