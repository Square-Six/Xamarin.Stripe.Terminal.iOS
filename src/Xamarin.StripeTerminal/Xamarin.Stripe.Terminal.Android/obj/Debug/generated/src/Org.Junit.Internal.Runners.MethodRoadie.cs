using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Internal.Runners {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='MethodRoadie']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/junit/internal/runners/MethodRoadie", DoNotGenerateAcw=true)]
	public partial class MethodRoadie : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/internal/runners/MethodRoadie", typeof (MethodRoadie));
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

		protected MethodRoadie (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_addFailure_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetAddFailure_Ljava_lang_Throwable_Handler ()
		{
			if (cb_addFailure_Ljava_lang_Throwable_ == null)
				cb_addFailure_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddFailure_Ljava_lang_Throwable_);
			return cb_addFailure_Ljava_lang_Throwable_;
		}

		static void n_AddFailure_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Org.Junit.Internal.Runners.MethodRoadie __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.MethodRoadie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable e = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.AddFailure (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='MethodRoadie']/method[@name='addFailure' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("addFailure", "(Ljava/lang/Throwable;)V", "GetAddFailure_Ljava_lang_Throwable_Handler")]
		protected virtual unsafe void AddFailure (global::Java.Lang.Throwable e)
		{
			const string __id = "addFailure.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.Runners.MethodRoadie __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.MethodRoadie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='MethodRoadie']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_runBeforesThenTestThenAfters_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetRunBeforesThenTestThenAfters_Ljava_lang_Runnable_Handler ()
		{
			if (cb_runBeforesThenTestThenAfters_Ljava_lang_Runnable_ == null)
				cb_runBeforesThenTestThenAfters_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RunBeforesThenTestThenAfters_Ljava_lang_Runnable_);
			return cb_runBeforesThenTestThenAfters_Ljava_lang_Runnable_;
		}

		static void n_RunBeforesThenTestThenAfters_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_test)
		{
			global::Org.Junit.Internal.Runners.MethodRoadie __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.MethodRoadie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable test = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_test, JniHandleOwnership.DoNotTransfer);
			__this.RunBeforesThenTestThenAfters (test);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='MethodRoadie']/method[@name='runBeforesThenTestThenAfters' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("runBeforesThenTestThenAfters", "(Ljava/lang/Runnable;)V", "GetRunBeforesThenTestThenAfters_Ljava_lang_Runnable_Handler")]
		public virtual unsafe void RunBeforesThenTestThenAfters (global::Java.Lang.IRunnable test)
		{
			const string __id = "runBeforesThenTestThenAfters.(Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((test == null) ? IntPtr.Zero : ((global::Java.Lang.Object) test).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_runTest;
#pragma warning disable 0169
		static Delegate GetRunTestHandler ()
		{
			if (cb_runTest == null)
				cb_runTest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RunTest);
			return cb_runTest;
		}

		static void n_RunTest (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.Runners.MethodRoadie __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.MethodRoadie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RunTest ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='MethodRoadie']/method[@name='runTest' and count(parameter)=0]"
		[Register ("runTest", "()V", "GetRunTestHandler")]
		public virtual unsafe void RunTest ()
		{
			const string __id = "runTest.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_runTestMethod;
#pragma warning disable 0169
		static Delegate GetRunTestMethodHandler ()
		{
			if (cb_runTestMethod == null)
				cb_runTestMethod = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RunTestMethod);
			return cb_runTestMethod;
		}

		static void n_RunTestMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.Runners.MethodRoadie __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.MethodRoadie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RunTestMethod ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='MethodRoadie']/method[@name='runTestMethod' and count(parameter)=0]"
		[Register ("runTestMethod", "()V", "GetRunTestMethodHandler")]
		protected virtual unsafe void RunTestMethod ()
		{
			const string __id = "runTestMethod.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
