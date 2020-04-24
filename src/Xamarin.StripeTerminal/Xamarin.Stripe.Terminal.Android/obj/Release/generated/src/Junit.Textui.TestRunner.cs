using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Junit.Textui {

	// Metadata.xml XPath class reference: path="/api/package[@name='junit.textui']/class[@name='TestRunner']"
	[global::Android.Runtime.Register ("junit/textui/TestRunner", DoNotGenerateAcw=true)]
	public partial class TestRunner : global::Junit.Runner.BaseTestRunner {


		// Metadata.xml XPath field reference: path="/api/package[@name='junit.textui']/class[@name='TestRunner']/field[@name='EXCEPTION_EXIT']"
		[Register ("EXCEPTION_EXIT")]
		public const int ExceptionExit = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='junit.textui']/class[@name='TestRunner']/field[@name='FAILURE_EXIT']"
		[Register ("FAILURE_EXIT")]
		public const int FailureExit = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='junit.textui']/class[@name='TestRunner']/field[@name='SUCCESS_EXIT']"
		[Register ("SUCCESS_EXIT")]
		public const int SuccessExit = (int) 0;
		static readonly JniPeerMembers _members = new XAPeerMembers ("junit/textui/TestRunner", typeof (TestRunner));
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

		protected TestRunner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.textui']/class[@name='TestRunner']/constructor[@name='TestRunner' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TestRunner ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.textui']/class[@name='TestRunner']/constructor[@name='TestRunner' and count(parameter)=1 and parameter[1][@type='java.io.PrintStream']]"
		[Register (".ctor", "(Ljava/io/PrintStream;)V", "")]
		public unsafe TestRunner (global::Java.IO.PrintStream writer)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/PrintStream;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((writer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) writer).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.textui']/class[@name='TestRunner']/constructor[@name='TestRunner' and count(parameter)=1 and parameter[1][@type='junit.textui.ResultPrinter']]"
		[Register (".ctor", "(Ljunit/textui/ResultPrinter;)V", "")]
		public unsafe TestRunner (global::Junit.Textui.ResultPrinter printer)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljunit/textui/ResultPrinter;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((printer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) printer).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_createTestResult;
#pragma warning disable 0169
		static Delegate GetCreateTestResultHandler ()
		{
			if (cb_createTestResult == null)
				cb_createTestResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateTestResult);
			return cb_createTestResult;
		}

		static IntPtr n_CreateTestResult (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Textui.TestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.TestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateTestResult ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='TestRunner']/method[@name='createTestResult' and count(parameter)=0]"
		[Register ("createTestResult", "()Ljunit/framework/TestResult;", "GetCreateTestResultHandler")]
		protected virtual unsafe global::Junit.Framework.TestResult CreateTestResult ()
		{
			const string __id = "createTestResult.()Ljunit/framework/TestResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_doRun_Ljunit_framework_Test_;
#pragma warning disable 0169
		static Delegate GetDoRun_Ljunit_framework_Test_Handler ()
		{
			if (cb_doRun_Ljunit_framework_Test_ == null)
				cb_doRun_Ljunit_framework_Test_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoRun_Ljunit_framework_Test_);
			return cb_doRun_Ljunit_framework_Test_;
		}

		static IntPtr n_DoRun_Ljunit_framework_Test_ (IntPtr jnienv, IntPtr native__this, IntPtr native_test)
		{
			global::Junit.Textui.TestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.TestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITest test = (global::Junit.Framework.ITest)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (native_test, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoRun (test));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='TestRunner']/method[@name='doRun' and count(parameter)=1 and parameter[1][@type='junit.framework.Test']]"
		[Register ("doRun", "(Ljunit/framework/Test;)Ljunit/framework/TestResult;", "GetDoRun_Ljunit_framework_Test_Handler")]
		public virtual unsafe global::Junit.Framework.TestResult DoRun (global::Junit.Framework.ITest test)
		{
			const string __id = "doRun.(Ljunit/framework/Test;)Ljunit/framework/TestResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((test == null) ? IntPtr.Zero : ((global::Java.Lang.Object) test).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_doRun_Ljunit_framework_Test_Z;
#pragma warning disable 0169
		static Delegate GetDoRun_Ljunit_framework_Test_ZHandler ()
		{
			if (cb_doRun_Ljunit_framework_Test_Z == null)
				cb_doRun_Ljunit_framework_Test_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_DoRun_Ljunit_framework_Test_Z);
			return cb_doRun_Ljunit_framework_Test_Z;
		}

		static IntPtr n_DoRun_Ljunit_framework_Test_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_suite, bool wait)
		{
			global::Junit.Textui.TestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.TestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITest suite = (global::Junit.Framework.ITest)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (native_suite, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoRun (suite, wait));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='TestRunner']/method[@name='doRun' and count(parameter)=2 and parameter[1][@type='junit.framework.Test'] and parameter[2][@type='boolean']]"
		[Register ("doRun", "(Ljunit/framework/Test;Z)Ljunit/framework/TestResult;", "GetDoRun_Ljunit_framework_Test_ZHandler")]
		public virtual unsafe global::Junit.Framework.TestResult DoRun (global::Junit.Framework.ITest suite, bool wait)
		{
			const string __id = "doRun.(Ljunit/framework/Test;Z)Ljunit/framework/TestResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((suite == null) ? IntPtr.Zero : ((global::Java.Lang.Object) suite).Handle);
				__args [1] = new JniArgumentValue (wait);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='TestRunner']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] args)
		{
			const string __id = "main.([Ljava/lang/String;)V";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_args);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static Delegate cb_pause_Z;
#pragma warning disable 0169
		static Delegate GetPause_ZHandler ()
		{
			if (cb_pause_Z == null)
				cb_pause_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_Pause_Z);
			return cb_pause_Z;
		}

		static void n_Pause_Z (IntPtr jnienv, IntPtr native__this, bool wait)
		{
			global::Junit.Textui.TestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.TestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause (wait);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='TestRunner']/method[@name='pause' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("pause", "(Z)V", "GetPause_ZHandler")]
		protected virtual unsafe void Pause (bool wait)
		{
			const string __id = "pause.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (wait);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='TestRunner']/method[@name='run' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends junit.framework.TestCase&gt;']]"
		[Register ("run", "(Ljava/lang/Class;)V", "")]
		public static unsafe void Run (global::Java.Lang.Class testClass)
		{
			const string __id = "run.(Ljava/lang/Class;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((testClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) testClass).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='TestRunner']/method[@name='run' and count(parameter)=1 and parameter[1][@type='junit.framework.Test']]"
		[Register ("run", "(Ljunit/framework/Test;)Ljunit/framework/TestResult;", "")]
		public static unsafe global::Junit.Framework.TestResult Run (global::Junit.Framework.ITest test)
		{
			const string __id = "run.(Ljunit/framework/Test;)Ljunit/framework/TestResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((test == null) ? IntPtr.Zero : ((global::Java.Lang.Object) test).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='TestRunner']/method[@name='runAndWait' and count(parameter)=1 and parameter[1][@type='junit.framework.Test']]"
		[Register ("runAndWait", "(Ljunit/framework/Test;)V", "")]
		public static unsafe void RunAndWait (global::Junit.Framework.ITest suite)
		{
			const string __id = "runAndWait.(Ljunit/framework/Test;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((suite == null) ? IntPtr.Zero : ((global::Java.Lang.Object) suite).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		static Delegate cb_runFailed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRunFailed_Ljava_lang_String_Handler ()
		{
			if (cb_runFailed_Ljava_lang_String_ == null)
				cb_runFailed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RunFailed_Ljava_lang_String_);
			return cb_runFailed_Ljava_lang_String_;
		}

		static void n_RunFailed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			global::Junit.Textui.TestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.TestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.RunFailed (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='TestRunner']/method[@name='runFailed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("runFailed", "(Ljava/lang/String;)V", "GetRunFailed_Ljava_lang_String_Handler")]
		protected override unsafe void RunFailed (string message)
		{
			const string __id = "runFailed.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_runSingleMethod_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetRunSingleMethod_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_runSingleMethod_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_runSingleMethod_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_RunSingleMethod_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_runSingleMethod_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static IntPtr n_RunSingleMethod_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_testCase, IntPtr native_method, bool wait)
		{
			global::Junit.Textui.TestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.TestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string testCase = JNIEnv.GetString (native_testCase, JniHandleOwnership.DoNotTransfer);
			string method = JNIEnv.GetString (native_method, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RunSingleMethod (testCase, method, wait));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='TestRunner']/method[@name='runSingleMethod' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("runSingleMethod", "(Ljava/lang/String;Ljava/lang/String;Z)Ljunit/framework/TestResult;", "GetRunSingleMethod_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		protected virtual unsafe global::Junit.Framework.TestResult RunSingleMethod (string testCase, string method, bool wait)
		{
			const string __id = "runSingleMethod.(Ljava/lang/String;Ljava/lang/String;Z)Ljunit/framework/TestResult;";
			IntPtr native_testCase = JNIEnv.NewString (testCase);
			IntPtr native_method = JNIEnv.NewString (method);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_testCase);
				__args [1] = new JniArgumentValue (native_method);
				__args [2] = new JniArgumentValue (wait);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_testCase);
				JNIEnv.DeleteLocalRef (native_method);
			}
		}

		static Delegate cb_setPrinter_Ljunit_textui_ResultPrinter_;
#pragma warning disable 0169
		static Delegate GetSetPrinter_Ljunit_textui_ResultPrinter_Handler ()
		{
			if (cb_setPrinter_Ljunit_textui_ResultPrinter_ == null)
				cb_setPrinter_Ljunit_textui_ResultPrinter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPrinter_Ljunit_textui_ResultPrinter_);
			return cb_setPrinter_Ljunit_textui_ResultPrinter_;
		}

		static void n_SetPrinter_Ljunit_textui_ResultPrinter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_printer)
		{
			global::Junit.Textui.TestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.TestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Textui.ResultPrinter printer = global::Java.Lang.Object.GetObject<global::Junit.Textui.ResultPrinter> (native_printer, JniHandleOwnership.DoNotTransfer);
			__this.SetPrinter (printer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='TestRunner']/method[@name='setPrinter' and count(parameter)=1 and parameter[1][@type='junit.textui.ResultPrinter']]"
		[Register ("setPrinter", "(Ljunit/textui/ResultPrinter;)V", "GetSetPrinter_Ljunit_textui_ResultPrinter_Handler")]
		public virtual unsafe void SetPrinter (global::Junit.Textui.ResultPrinter printer)
		{
			const string __id = "setPrinter.(Ljunit/textui/ResultPrinter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((printer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) printer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_start_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStart_arrayLjava_lang_String_Handler ()
		{
			if (cb_start_arrayLjava_lang_String_ == null)
				cb_start_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Start_arrayLjava_lang_String_);
			return cb_start_arrayLjava_lang_String_;
		}

		static IntPtr n_Start_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			global::Junit.Textui.TestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.TestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] args = (string[]) JNIEnv.GetArray (native_args, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Start (args));
			if (args != null)
				JNIEnv.CopyArray (args, native_args);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='TestRunner']/method[@name='start' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("start", "([Ljava/lang/String;)Ljunit/framework/TestResult;", "GetStart_arrayLjava_lang_String_Handler")]
		public virtual unsafe global::Junit.Framework.TestResult Start (string[] args)
		{
			const string __id = "start.([Ljava/lang/String;)Ljunit/framework/TestResult;";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_args);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static Delegate cb_testEnded_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTestEnded_Ljava_lang_String_Handler ()
		{
			if (cb_testEnded_Ljava_lang_String_ == null)
				cb_testEnded_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TestEnded_Ljava_lang_String_);
			return cb_testEnded_Ljava_lang_String_;
		}

		static void n_TestEnded_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_testName)
		{
			global::Junit.Textui.TestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.TestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string testName = JNIEnv.GetString (native_testName, JniHandleOwnership.DoNotTransfer);
			__this.TestEnded (testName);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='TestRunner']/method[@name='testEnded' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("testEnded", "(Ljava/lang/String;)V", "GetTestEnded_Ljava_lang_String_Handler")]
		public override unsafe void TestEnded (string testName)
		{
			const string __id = "testEnded.(Ljava/lang/String;)V";
			IntPtr native_testName = JNIEnv.NewString (testName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_testName);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_testName);
			}
		}

		static Delegate cb_testFailed_ILjunit_framework_Test_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetTestFailed_ILjunit_framework_Test_Ljava_lang_Throwable_Handler ()
		{
			if (cb_testFailed_ILjunit_framework_Test_Ljava_lang_Throwable_ == null)
				cb_testFailed_ILjunit_framework_Test_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_TestFailed_ILjunit_framework_Test_Ljava_lang_Throwable_);
			return cb_testFailed_ILjunit_framework_Test_Ljava_lang_Throwable_;
		}

		static void n_TestFailed_ILjunit_framework_Test_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, int status, IntPtr native_test, IntPtr native_e)
		{
			global::Junit.Textui.TestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.TestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITest test = (global::Junit.Framework.ITest)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (native_test, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable e = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.TestFailed (status, test, e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='TestRunner']/method[@name='testFailed' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='junit.framework.Test'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("testFailed", "(ILjunit/framework/Test;Ljava/lang/Throwable;)V", "GetTestFailed_ILjunit_framework_Test_Ljava_lang_Throwable_Handler")]
		public override unsafe void TestFailed (int status, global::Junit.Framework.ITest test, global::Java.Lang.Throwable e)
		{
			const string __id = "testFailed.(ILjunit/framework/Test;Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (status);
				__args [1] = new JniArgumentValue ((test == null) ? IntPtr.Zero : ((global::Java.Lang.Object) test).Handle);
				__args [2] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_testStarted_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTestStarted_Ljava_lang_String_Handler ()
		{
			if (cb_testStarted_Ljava_lang_String_ == null)
				cb_testStarted_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TestStarted_Ljava_lang_String_);
			return cb_testStarted_Ljava_lang_String_;
		}

		static void n_TestStarted_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_testName)
		{
			global::Junit.Textui.TestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.TestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string testName = JNIEnv.GetString (native_testName, JniHandleOwnership.DoNotTransfer);
			__this.TestStarted (testName);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='TestRunner']/method[@name='testStarted' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("testStarted", "(Ljava/lang/String;)V", "GetTestStarted_Ljava_lang_String_Handler")]
		public override unsafe void TestStarted (string testName)
		{
			const string __id = "testStarted.(Ljava/lang/String;)V";
			IntPtr native_testName = JNIEnv.NewString (testName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_testName);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_testName);
			}
		}

	}
}
