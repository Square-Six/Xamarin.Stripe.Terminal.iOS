using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Junit.Framework {

	// Metadata.xml XPath class reference: path="/api/package[@name='junit.framework']/class[@name='TestResult']"
	[global::Android.Runtime.Register ("junit/framework/TestResult", DoNotGenerateAcw=true)]
	public partial class TestResult : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='junit.framework']/class[@name='TestResult']/field[@name='fErrors']"
		[Register ("fErrors")]
		protected global::System.Collections.IList FErrors {
			get {
				const string __id = "fErrors.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "fErrors.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='junit.framework']/class[@name='TestResult']/field[@name='fFailures']"
		[Register ("fFailures")]
		protected global::System.Collections.IList FFailures {
			get {
				const string __id = "fFailures.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "fFailures.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='junit.framework']/class[@name='TestResult']/field[@name='fListeners']"
		[Register ("fListeners")]
		protected global::System.Collections.IList FListeners {
			get {
				const string __id = "fListeners.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "fListeners.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='junit.framework']/class[@name='TestResult']/field[@name='fRunTests']"
		[Register ("fRunTests")]
		protected int FRunTests {
			get {
				const string __id = "fRunTests.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "fRunTests.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("junit/framework/TestResult", typeof (TestResult));
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

		protected TestResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.framework']/class[@name='TestResult']/constructor[@name='TestResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TestResult ()
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

		static Delegate cb_addError_Ljunit_framework_Test_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetAddError_Ljunit_framework_Test_Ljava_lang_Throwable_Handler ()
		{
			if (cb_addError_Ljunit_framework_Test_Ljava_lang_Throwable_ == null)
				cb_addError_Ljunit_framework_Test_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddError_Ljunit_framework_Test_Ljava_lang_Throwable_);
			return cb_addError_Ljunit_framework_Test_Ljava_lang_Throwable_;
		}

		static void n_AddError_Ljunit_framework_Test_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_test, IntPtr native_e)
		{
			global::Junit.Framework.TestResult __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITest test = (global::Junit.Framework.ITest)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (native_test, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable e = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.AddError (test, e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestResult']/method[@name='addError' and count(parameter)=2 and parameter[1][@type='junit.framework.Test'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("addError", "(Ljunit/framework/Test;Ljava/lang/Throwable;)V", "GetAddError_Ljunit_framework_Test_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void AddError (global::Junit.Framework.ITest test, global::Java.Lang.Throwable e)
		{
			const string __id = "addError.(Ljunit/framework/Test;Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((test == null) ? IntPtr.Zero : ((global::Java.Lang.Object) test).Handle);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_;
#pragma warning disable 0169
		static Delegate GetAddFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_Handler ()
		{
			if (cb_addFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_ == null)
				cb_addFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_);
			return cb_addFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_;
		}

		static void n_AddFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_test, IntPtr native_e)
		{
			global::Junit.Framework.TestResult __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITest test = (global::Junit.Framework.ITest)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (native_test, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.AssertionFailedError e = global::Java.Lang.Object.GetObject<global::Junit.Framework.AssertionFailedError> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.AddFailure (test, e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestResult']/method[@name='addFailure' and count(parameter)=2 and parameter[1][@type='junit.framework.Test'] and parameter[2][@type='junit.framework.AssertionFailedError']]"
		[Register ("addFailure", "(Ljunit/framework/Test;Ljunit/framework/AssertionFailedError;)V", "GetAddFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_Handler")]
		public virtual unsafe void AddFailure (global::Junit.Framework.ITest test, global::Junit.Framework.AssertionFailedError e)
		{
			const string __id = "addFailure.(Ljunit/framework/Test;Ljunit/framework/AssertionFailedError;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((test == null) ? IntPtr.Zero : ((global::Java.Lang.Object) test).Handle);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addListener_Ljunit_framework_TestListener_;
#pragma warning disable 0169
		static Delegate GetAddListener_Ljunit_framework_TestListener_Handler ()
		{
			if (cb_addListener_Ljunit_framework_TestListener_ == null)
				cb_addListener_Ljunit_framework_TestListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddListener_Ljunit_framework_TestListener_);
			return cb_addListener_Ljunit_framework_TestListener_;
		}

		static void n_AddListener_Ljunit_framework_TestListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Junit.Framework.TestResult __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITestListener listener = (global::Junit.Framework.ITestListener)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITestListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestResult']/method[@name='addListener' and count(parameter)=1 and parameter[1][@type='junit.framework.TestListener']]"
		[Register ("addListener", "(Ljunit/framework/TestListener;)V", "GetAddListener_Ljunit_framework_TestListener_Handler")]
		public virtual unsafe void AddListener (global::Junit.Framework.ITestListener listener)
		{
			const string __id = "addListener.(Ljunit/framework/TestListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_endTest_Ljunit_framework_Test_;
#pragma warning disable 0169
		static Delegate GetEndTest_Ljunit_framework_Test_Handler ()
		{
			if (cb_endTest_Ljunit_framework_Test_ == null)
				cb_endTest_Ljunit_framework_Test_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EndTest_Ljunit_framework_Test_);
			return cb_endTest_Ljunit_framework_Test_;
		}

		static void n_EndTest_Ljunit_framework_Test_ (IntPtr jnienv, IntPtr native__this, IntPtr native_test)
		{
			global::Junit.Framework.TestResult __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITest test = (global::Junit.Framework.ITest)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (native_test, JniHandleOwnership.DoNotTransfer);
			__this.EndTest (test);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestResult']/method[@name='endTest' and count(parameter)=1 and parameter[1][@type='junit.framework.Test']]"
		[Register ("endTest", "(Ljunit/framework/Test;)V", "GetEndTest_Ljunit_framework_Test_Handler")]
		public virtual unsafe void EndTest (global::Junit.Framework.ITest test)
		{
			const string __id = "endTest.(Ljunit/framework/Test;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((test == null) ? IntPtr.Zero : ((global::Java.Lang.Object) test).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_errorCount;
#pragma warning disable 0169
		static Delegate GetErrorCountHandler ()
		{
			if (cb_errorCount == null)
				cb_errorCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ErrorCount);
			return cb_errorCount;
		}

		static int n_ErrorCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestResult __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ErrorCount ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestResult']/method[@name='errorCount' and count(parameter)=0]"
		[Register ("errorCount", "()I", "GetErrorCountHandler")]
		public virtual unsafe int ErrorCount ()
		{
			const string __id = "errorCount.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_errors;
#pragma warning disable 0169
		static Delegate GetErrorsHandler ()
		{
			if (cb_errors == null)
				cb_errors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Errors);
			return cb_errors;
		}

		static IntPtr n_Errors (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestResult __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Errors ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestResult']/method[@name='errors' and count(parameter)=0]"
		[Register ("errors", "()Ljava/util/Enumeration;", "GetErrorsHandler")]
		public virtual unsafe global::Java.Util.IEnumeration Errors ()
		{
			const string __id = "errors.()Ljava/util/Enumeration;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IEnumeration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_failureCount;
#pragma warning disable 0169
		static Delegate GetFailureCountHandler ()
		{
			if (cb_failureCount == null)
				cb_failureCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_FailureCount);
			return cb_failureCount;
		}

		static int n_FailureCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestResult __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FailureCount ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestResult']/method[@name='failureCount' and count(parameter)=0]"
		[Register ("failureCount", "()I", "GetFailureCountHandler")]
		public virtual unsafe int FailureCount ()
		{
			const string __id = "failureCount.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_failures;
#pragma warning disable 0169
		static Delegate GetFailuresHandler ()
		{
			if (cb_failures == null)
				cb_failures = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Failures);
			return cb_failures;
		}

		static IntPtr n_Failures (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestResult __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Failures ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestResult']/method[@name='failures' and count(parameter)=0]"
		[Register ("failures", "()Ljava/util/Enumeration;", "GetFailuresHandler")]
		public virtual unsafe global::Java.Util.IEnumeration Failures ()
		{
			const string __id = "failures.()Ljava/util/Enumeration;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IEnumeration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeListener_Ljunit_framework_TestListener_;
#pragma warning disable 0169
		static Delegate GetRemoveListener_Ljunit_framework_TestListener_Handler ()
		{
			if (cb_removeListener_Ljunit_framework_TestListener_ == null)
				cb_removeListener_Ljunit_framework_TestListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveListener_Ljunit_framework_TestListener_);
			return cb_removeListener_Ljunit_framework_TestListener_;
		}

		static void n_RemoveListener_Ljunit_framework_TestListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Junit.Framework.TestResult __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITestListener listener = (global::Junit.Framework.ITestListener)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITestListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestResult']/method[@name='removeListener' and count(parameter)=1 and parameter[1][@type='junit.framework.TestListener']]"
		[Register ("removeListener", "(Ljunit/framework/TestListener;)V", "GetRemoveListener_Ljunit_framework_TestListener_Handler")]
		public virtual unsafe void RemoveListener (global::Junit.Framework.ITestListener listener)
		{
			const string __id = "removeListener.(Ljunit/framework/TestListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_run_Ljunit_framework_TestCase_;
#pragma warning disable 0169
		static Delegate GetRun_Ljunit_framework_TestCase_Handler ()
		{
			if (cb_run_Ljunit_framework_TestCase_ == null)
				cb_run_Ljunit_framework_TestCase_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Run_Ljunit_framework_TestCase_);
			return cb_run_Ljunit_framework_TestCase_;
		}

		static void n_Run_Ljunit_framework_TestCase_ (IntPtr jnienv, IntPtr native__this, IntPtr native_test)
		{
			global::Junit.Framework.TestResult __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.TestCase test = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestCase> (native_test, JniHandleOwnership.DoNotTransfer);
			__this.Run (test);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestResult']/method[@name='run' and count(parameter)=1 and parameter[1][@type='junit.framework.TestCase']]"
		[Register ("run", "(Ljunit/framework/TestCase;)V", "GetRun_Ljunit_framework_TestCase_Handler")]
		protected virtual unsafe void Run (global::Junit.Framework.TestCase test)
		{
			const string __id = "run.(Ljunit/framework/TestCase;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((test == null) ? IntPtr.Zero : ((global::Java.Lang.Object) test).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_runCount;
#pragma warning disable 0169
		static Delegate GetRunCountHandler ()
		{
			if (cb_runCount == null)
				cb_runCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_RunCount);
			return cb_runCount;
		}

		static int n_RunCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestResult __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RunCount ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestResult']/method[@name='runCount' and count(parameter)=0]"
		[Register ("runCount", "()I", "GetRunCountHandler")]
		public virtual unsafe int RunCount ()
		{
			const string __id = "runCount.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_runProtected_Ljunit_framework_Test_Ljunit_framework_Protectable_;
#pragma warning disable 0169
		static Delegate GetRunProtected_Ljunit_framework_Test_Ljunit_framework_Protectable_Handler ()
		{
			if (cb_runProtected_Ljunit_framework_Test_Ljunit_framework_Protectable_ == null)
				cb_runProtected_Ljunit_framework_Test_Ljunit_framework_Protectable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RunProtected_Ljunit_framework_Test_Ljunit_framework_Protectable_);
			return cb_runProtected_Ljunit_framework_Test_Ljunit_framework_Protectable_;
		}

		static void n_RunProtected_Ljunit_framework_Test_Ljunit_framework_Protectable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_test, IntPtr native_p)
		{
			global::Junit.Framework.TestResult __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITest test = (global::Junit.Framework.ITest)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (native_test, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.IProtectable p = (global::Junit.Framework.IProtectable)global::Java.Lang.Object.GetObject<global::Junit.Framework.IProtectable> (native_p, JniHandleOwnership.DoNotTransfer);
			__this.RunProtected (test, p);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestResult']/method[@name='runProtected' and count(parameter)=2 and parameter[1][@type='junit.framework.Test'] and parameter[2][@type='junit.framework.Protectable']]"
		[Register ("runProtected", "(Ljunit/framework/Test;Ljunit/framework/Protectable;)V", "GetRunProtected_Ljunit_framework_Test_Ljunit_framework_Protectable_Handler")]
		public virtual unsafe void RunProtected (global::Junit.Framework.ITest test, global::Junit.Framework.IProtectable p)
		{
			const string __id = "runProtected.(Ljunit/framework/Test;Ljunit/framework/Protectable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((test == null) ? IntPtr.Zero : ((global::Java.Lang.Object) test).Handle);
				__args [1] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_shouldStop;
#pragma warning disable 0169
		static Delegate GetShouldStopHandler ()
		{
			if (cb_shouldStop == null)
				cb_shouldStop = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldStop);
			return cb_shouldStop;
		}

		static bool n_ShouldStop (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestResult __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldStop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestResult']/method[@name='shouldStop' and count(parameter)=0]"
		[Register ("shouldStop", "()Z", "GetShouldStopHandler")]
		public virtual unsafe bool ShouldStop ()
		{
			const string __id = "shouldStop.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_startTest_Ljunit_framework_Test_;
#pragma warning disable 0169
		static Delegate GetStartTest_Ljunit_framework_Test_Handler ()
		{
			if (cb_startTest_Ljunit_framework_Test_ == null)
				cb_startTest_Ljunit_framework_Test_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartTest_Ljunit_framework_Test_);
			return cb_startTest_Ljunit_framework_Test_;
		}

		static void n_StartTest_Ljunit_framework_Test_ (IntPtr jnienv, IntPtr native__this, IntPtr native_test)
		{
			global::Junit.Framework.TestResult __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITest test = (global::Junit.Framework.ITest)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (native_test, JniHandleOwnership.DoNotTransfer);
			__this.StartTest (test);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestResult']/method[@name='startTest' and count(parameter)=1 and parameter[1][@type='junit.framework.Test']]"
		[Register ("startTest", "(Ljunit/framework/Test;)V", "GetStartTest_Ljunit_framework_Test_Handler")]
		public virtual unsafe void StartTest (global::Junit.Framework.ITest test)
		{
			const string __id = "startTest.(Ljunit/framework/Test;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((test == null) ? IntPtr.Zero : ((global::Java.Lang.Object) test).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestResult __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestResult']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_wasSuccessful;
#pragma warning disable 0169
		static Delegate GetWasSuccessfulHandler ()
		{
			if (cb_wasSuccessful == null)
				cb_wasSuccessful = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_WasSuccessful);
			return cb_wasSuccessful;
		}

		static bool n_WasSuccessful (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestResult __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WasSuccessful ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestResult']/method[@name='wasSuccessful' and count(parameter)=0]"
		[Register ("wasSuccessful", "()Z", "GetWasSuccessfulHandler")]
		public virtual unsafe bool WasSuccessful ()
		{
			const string __id = "wasSuccessful.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

#region "Event implementation for Junit.Framework.ITestListener"

		global::Junit.Framework.ITestListenerImplementor __CreateITestListenerImplementor ()
		{
			return new global::Junit.Framework.ITestListenerImplementor (this);
		}
#endregion
	}
}
