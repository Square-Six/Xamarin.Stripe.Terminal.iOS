using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Junit.Runner {

	// Metadata.xml XPath class reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']"
	[global::Android.Runtime.Register ("junit/runner/BaseTestRunner", DoNotGenerateAcw=true)]
	public abstract partial class BaseTestRunner : global::Java.Lang.Object, global::Junit.Framework.ITestListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/field[@name='SUITE_METHODNAME']"
		[Register ("SUITE_METHODNAME")]
		public const string SuiteMethodname = (string) "suite";
		static readonly JniPeerMembers _members = new XAPeerMembers ("junit/runner/BaseTestRunner", typeof (BaseTestRunner));
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

		protected BaseTestRunner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/constructor[@name='BaseTestRunner' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseTestRunner ()
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

		protected static unsafe global::Java.Util.Properties Preferences {
			// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='getPreferences' and count(parameter)=0]"
			[Register ("getPreferences", "()Ljava/util/Properties;", "")]
			get {
				const string __id = "getPreferences.()Ljava/util/Properties;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Properties> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='setPreferences' and count(parameter)=1 and parameter[1][@type='java.util.Properties']]"
			[Register ("setPreferences", "(Ljava/util/Properties;)V", "")]
			set {
				const string __id = "setPreferences.(Ljava/util/Properties;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
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
			global::Junit.Runner.BaseTestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Runner.BaseTestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITest test = (global::Junit.Framework.ITest)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (native_test, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable e = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.AddError (test, e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='addError' and count(parameter)=2 and parameter[1][@type='junit.framework.Test'] and parameter[2][@type='java.lang.Throwable']]"
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
			global::Junit.Runner.BaseTestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Runner.BaseTestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITest test = (global::Junit.Framework.ITest)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (native_test, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.AssertionFailedError e = global::Java.Lang.Object.GetObject<global::Junit.Framework.AssertionFailedError> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.AddFailure (test, e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='addFailure' and count(parameter)=2 and parameter[1][@type='junit.framework.Test'] and parameter[2][@type='junit.framework.AssertionFailedError']]"
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

		static Delegate cb_clearStatus;
#pragma warning disable 0169
		static Delegate GetClearStatusHandler ()
		{
			if (cb_clearStatus == null)
				cb_clearStatus = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearStatus);
			return cb_clearStatus;
		}

		static void n_ClearStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Runner.BaseTestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Runner.BaseTestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearStatus ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='clearStatus' and count(parameter)=0]"
		[Register ("clearStatus", "()V", "GetClearStatusHandler")]
		protected virtual unsafe void ClearStatus ()
		{
			const string __id = "clearStatus.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_elapsedTimeAsString_J;
#pragma warning disable 0169
		static Delegate GetElapsedTimeAsString_JHandler ()
		{
			if (cb_elapsedTimeAsString_J == null)
				cb_elapsedTimeAsString_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_ElapsedTimeAsString_J);
			return cb_elapsedTimeAsString_J;
		}

		static IntPtr n_ElapsedTimeAsString_J (IntPtr jnienv, IntPtr native__this, long runTime)
		{
			global::Junit.Runner.BaseTestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Runner.BaseTestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ElapsedTimeAsString (runTime));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='elapsedTimeAsString' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("elapsedTimeAsString", "(J)Ljava/lang/String;", "GetElapsedTimeAsString_JHandler")]
		public virtual unsafe string ElapsedTimeAsString (long runTime)
		{
			const string __id = "elapsedTimeAsString.(J)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (runTime);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Junit.Runner.BaseTestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Runner.BaseTestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITest test = (global::Junit.Framework.ITest)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (native_test, JniHandleOwnership.DoNotTransfer);
			__this.EndTest (test);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='endTest' and count(parameter)=1 and parameter[1][@type='junit.framework.Test']]"
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

		static Delegate cb_extractClassName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetExtractClassName_Ljava_lang_String_Handler ()
		{
			if (cb_extractClassName_Ljava_lang_String_ == null)
				cb_extractClassName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ExtractClassName_Ljava_lang_String_);
			return cb_extractClassName_Ljava_lang_String_;
		}

		static IntPtr n_ExtractClassName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_className)
		{
			global::Junit.Runner.BaseTestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Runner.BaseTestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string className = JNIEnv.GetString (native_className, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ExtractClassName (className));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='extractClassName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("extractClassName", "(Ljava/lang/String;)Ljava/lang/String;", "GetExtractClassName_Ljava_lang_String_Handler")]
		public virtual unsafe string ExtractClassName (string className)
		{
			const string __id = "extractClassName.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_className = JNIEnv.NewString (className);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_className);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='getFilteredTrace' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFilteredTrace", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetFilteredTrace (string stack)
		{
			const string __id = "getFilteredTrace.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_stack = JNIEnv.NewString (stack);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_stack);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_stack);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='getFilteredTrace' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("getFilteredTrace", "(Ljava/lang/Throwable;)Ljava/lang/String;", "")]
		public static unsafe string GetFilteredTrace (global::Java.Lang.Throwable e)
		{
			const string __id = "getFilteredTrace.(Ljava/lang/Throwable;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='getPreference' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPreference", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetPreference (string key)
		{
			const string __id = "getPreference.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='getPreference' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getPreference", "(Ljava/lang/String;I)I", "")]
		public static unsafe int GetPreference (string key, int dflt)
		{
			const string __id = "getPreference.(Ljava/lang/String;I)I";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (dflt);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_getTest_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTest_Ljava_lang_String_Handler ()
		{
			if (cb_getTest_Ljava_lang_String_ == null)
				cb_getTest_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTest_Ljava_lang_String_);
			return cb_getTest_Ljava_lang_String_;
		}

		static IntPtr n_GetTest_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_suiteClassName)
		{
			global::Junit.Runner.BaseTestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Runner.BaseTestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string suiteClassName = JNIEnv.GetString (native_suiteClassName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTest (suiteClassName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='getTest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTest", "(Ljava/lang/String;)Ljunit/framework/Test;", "GetGetTest_Ljava_lang_String_Handler")]
		public virtual unsafe global::Junit.Framework.ITest GetTest (string suiteClassName)
		{
			const string __id = "getTest.(Ljava/lang/String;)Ljunit/framework/Test;";
			IntPtr native_suiteClassName = JNIEnv.NewString (suiteClassName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_suiteClassName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_suiteClassName);
			}
		}

		static Delegate cb_loadSuiteClass_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadSuiteClass_Ljava_lang_String_Handler ()
		{
			if (cb_loadSuiteClass_Ljava_lang_String_ == null)
				cb_loadSuiteClass_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadSuiteClass_Ljava_lang_String_);
			return cb_loadSuiteClass_Ljava_lang_String_;
		}

		static IntPtr n_LoadSuiteClass_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_suiteClassName)
		{
			global::Junit.Runner.BaseTestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Runner.BaseTestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string suiteClassName = JNIEnv.GetString (native_suiteClassName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadSuiteClass (suiteClassName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='loadSuiteClass' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadSuiteClass", "(Ljava/lang/String;)Ljava/lang/Class;", "GetLoadSuiteClass_Ljava_lang_String_Handler")]
		protected virtual unsafe global::Java.Lang.Class LoadSuiteClass (string suiteClassName)
		{
			const string __id = "loadSuiteClass.(Ljava/lang/String;)Ljava/lang/Class;";
			IntPtr native_suiteClassName = JNIEnv.NewString (suiteClassName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_suiteClassName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_suiteClassName);
			}
		}

		static Delegate cb_processArguments_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetProcessArguments_arrayLjava_lang_String_Handler ()
		{
			if (cb_processArguments_arrayLjava_lang_String_ == null)
				cb_processArguments_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ProcessArguments_arrayLjava_lang_String_);
			return cb_processArguments_arrayLjava_lang_String_;
		}

		static IntPtr n_ProcessArguments_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			global::Junit.Runner.BaseTestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Runner.BaseTestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] args = (string[]) JNIEnv.GetArray (native_args, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.NewString (__this.ProcessArguments (args));
			if (args != null)
				JNIEnv.CopyArray (args, native_args);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='processArguments' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("processArguments", "([Ljava/lang/String;)Ljava/lang/String;", "GetProcessArguments_arrayLjava_lang_String_Handler")]
		protected virtual unsafe string ProcessArguments (string[] args)
		{
			const string __id = "processArguments.([Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_args);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
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

		static void n_RunFailed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Junit.Runner.BaseTestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Runner.BaseTestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RunFailed (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='runFailed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("runFailed", "(Ljava/lang/String;)V", "GetRunFailed_Ljava_lang_String_Handler")]
		protected abstract void RunFailed (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='savePreferences' and count(parameter)=0]"
		[Register ("savePreferences", "()V", "")]
		public static unsafe void SavePreferences ()
		{
			const string __id = "savePreferences.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		static Delegate cb_setLoading_Z;
#pragma warning disable 0169
		static Delegate GetSetLoading_ZHandler ()
		{
			if (cb_setLoading_Z == null)
				cb_setLoading_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetLoading_Z);
			return cb_setLoading_Z;
		}

		static void n_SetLoading_Z (IntPtr jnienv, IntPtr native__this, bool enable)
		{
			global::Junit.Runner.BaseTestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Runner.BaseTestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLoading (enable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='setLoading' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setLoading", "(Z)V", "GetSetLoading_ZHandler")]
		public virtual unsafe void SetLoading (bool enable)
		{
			const string __id = "setLoading.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='setPreference' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setPreference", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetPreference (string key, string value)
		{
			const string __id = "setPreference.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='showStackRaw' and count(parameter)=0]"
		[Register ("showStackRaw", "()Z", "")]
		protected static unsafe bool ShowStackRaw ()
		{
			const string __id = "showStackRaw.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
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
			global::Junit.Runner.BaseTestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Runner.BaseTestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITest test = (global::Junit.Framework.ITest)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (native_test, JniHandleOwnership.DoNotTransfer);
			__this.StartTest (test);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='startTest' and count(parameter)=1 and parameter[1][@type='junit.framework.Test']]"
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

		static Delegate cb_testEnded_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTestEnded_Ljava_lang_String_Handler ()
		{
			if (cb_testEnded_Ljava_lang_String_ == null)
				cb_testEnded_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TestEnded_Ljava_lang_String_);
			return cb_testEnded_Ljava_lang_String_;
		}

		static void n_TestEnded_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Junit.Runner.BaseTestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Runner.BaseTestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TestEnded (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='testEnded' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("testEnded", "(Ljava/lang/String;)V", "GetTestEnded_Ljava_lang_String_Handler")]
		public abstract void TestEnded (string p0);

		static Delegate cb_testFailed_ILjunit_framework_Test_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetTestFailed_ILjunit_framework_Test_Ljava_lang_Throwable_Handler ()
		{
			if (cb_testFailed_ILjunit_framework_Test_Ljava_lang_Throwable_ == null)
				cb_testFailed_ILjunit_framework_Test_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_TestFailed_ILjunit_framework_Test_Ljava_lang_Throwable_);
			return cb_testFailed_ILjunit_framework_Test_Ljava_lang_Throwable_;
		}

		static void n_TestFailed_ILjunit_framework_Test_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Junit.Runner.BaseTestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Runner.BaseTestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITest p1 = (global::Junit.Framework.ITest)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.TestFailed (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='testFailed' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='junit.framework.Test'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("testFailed", "(ILjunit/framework/Test;Ljava/lang/Throwable;)V", "GetTestFailed_ILjunit_framework_Test_Ljava_lang_Throwable_Handler")]
		public abstract void TestFailed (int p0, global::Junit.Framework.ITest p1, global::Java.Lang.Throwable p2);

		static Delegate cb_testStarted_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTestStarted_Ljava_lang_String_Handler ()
		{
			if (cb_testStarted_Ljava_lang_String_ == null)
				cb_testStarted_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TestStarted_Ljava_lang_String_);
			return cb_testStarted_Ljava_lang_String_;
		}

		static void n_TestStarted_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Junit.Runner.BaseTestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Runner.BaseTestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TestStarted (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='testStarted' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("testStarted", "(Ljava/lang/String;)V", "GetTestStarted_Ljava_lang_String_Handler")]
		public abstract void TestStarted (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='truncate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("truncate", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Truncate (string s)
		{
			const string __id = "truncate.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		static Delegate cb_useReloadingTestSuiteLoader;
#pragma warning disable 0169
		static Delegate GetUseReloadingTestSuiteLoaderHandler ()
		{
			if (cb_useReloadingTestSuiteLoader == null)
				cb_useReloadingTestSuiteLoader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UseReloadingTestSuiteLoader);
			return cb_useReloadingTestSuiteLoader;
		}

		static bool n_UseReloadingTestSuiteLoader (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Runner.BaseTestRunner __this = global::Java.Lang.Object.GetObject<global::Junit.Runner.BaseTestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseReloadingTestSuiteLoader ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='useReloadingTestSuiteLoader' and count(parameter)=0]"
		[Register ("useReloadingTestSuiteLoader", "()Z", "GetUseReloadingTestSuiteLoaderHandler")]
		protected virtual unsafe bool UseReloadingTestSuiteLoader ()
		{
			const string __id = "useReloadingTestSuiteLoader.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("junit/runner/BaseTestRunner", DoNotGenerateAcw=true)]
	internal partial class BaseTestRunnerInvoker : BaseTestRunner {

		public BaseTestRunnerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("junit/runner/BaseTestRunner", typeof (BaseTestRunnerInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='runFailed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("runFailed", "(Ljava/lang/String;)V", "GetRunFailed_Ljava_lang_String_Handler")]
		protected override unsafe void RunFailed (string p0)
		{
			const string __id = "runFailed.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='testEnded' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("testEnded", "(Ljava/lang/String;)V", "GetTestEnded_Ljava_lang_String_Handler")]
		public override unsafe void TestEnded (string p0)
		{
			const string __id = "testEnded.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='testFailed' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='junit.framework.Test'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("testFailed", "(ILjunit/framework/Test;Ljava/lang/Throwable;)V", "GetTestFailed_ILjunit_framework_Test_Ljava_lang_Throwable_Handler")]
		public override unsafe void TestFailed (int p0, global::Junit.Framework.ITest p1, global::Java.Lang.Throwable p2)
		{
			const string __id = "testFailed.(ILjunit/framework/Test;Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='BaseTestRunner']/method[@name='testStarted' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("testStarted", "(Ljava/lang/String;)V", "GetTestStarted_Ljava_lang_String_Handler")]
		public override unsafe void TestStarted (string p0)
		{
			const string __id = "testStarted.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
