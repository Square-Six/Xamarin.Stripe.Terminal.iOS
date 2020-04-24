using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Junit.Extensions {

	// Metadata.xml XPath class reference: path="/api/package[@name='junit.extensions']/class[@name='ActiveTestSuite']"
	[global::Android.Runtime.Register ("junit/extensions/ActiveTestSuite", DoNotGenerateAcw=true)]
	public partial class ActiveTestSuite : global::Junit.Framework.TestSuite {

		static readonly JniPeerMembers _members = new XAPeerMembers ("junit/extensions/ActiveTestSuite", typeof (ActiveTestSuite));
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

		protected ActiveTestSuite (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.extensions']/class[@name='ActiveTestSuite']/constructor[@name='ActiveTestSuite' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ActiveTestSuite ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.extensions']/class[@name='ActiveTestSuite']/constructor[@name='ActiveTestSuite' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends junit.framework.TestCase&gt;']]"
		[Register (".ctor", "(Ljava/lang/Class;)V", "")]
		public unsafe ActiveTestSuite (global::Java.Lang.Class theClass)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Class;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((theClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) theClass).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.extensions']/class[@name='ActiveTestSuite']/constructor[@name='ActiveTestSuite' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;? extends junit.framework.TestCase&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/Class;Ljava/lang/String;)V", "")]
		public unsafe ActiveTestSuite (global::Java.Lang.Class theClass, string name)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Class;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((theClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) theClass).Handle);
				__args [1] = new JniArgumentValue (native_name);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.extensions']/class[@name='ActiveTestSuite']/constructor[@name='ActiveTestSuite' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe ActiveTestSuite (string name)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_runFinished;
#pragma warning disable 0169
		static Delegate GetRunFinishedHandler ()
		{
			if (cb_runFinished == null)
				cb_runFinished = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RunFinished);
			return cb_runFinished;
		}

		static void n_RunFinished (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Extensions.ActiveTestSuite __this = global::Java.Lang.Object.GetObject<global::Junit.Extensions.ActiveTestSuite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RunFinished ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.extensions']/class[@name='ActiveTestSuite']/method[@name='runFinished' and count(parameter)=0]"
		[Register ("runFinished", "()V", "GetRunFinishedHandler")]
		public virtual unsafe void RunFinished ()
		{
			const string __id = "runFinished.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
