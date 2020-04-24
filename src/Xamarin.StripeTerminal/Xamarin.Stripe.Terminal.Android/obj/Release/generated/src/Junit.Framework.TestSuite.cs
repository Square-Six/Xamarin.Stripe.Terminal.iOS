using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Junit.Framework {

	// Metadata.xml XPath class reference: path="/api/package[@name='junit.framework']/class[@name='TestSuite']"
	[global::Android.Runtime.Register ("junit/framework/TestSuite", DoNotGenerateAcw=true)]
	public partial class TestSuite : global::Java.Lang.Object, global::Junit.Framework.ITest {

		static readonly JniPeerMembers _members = new XAPeerMembers ("junit/framework/TestSuite", typeof (TestSuite));
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

		protected TestSuite (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.framework']/class[@name='TestSuite']/constructor[@name='TestSuite' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TestSuite ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.framework']/class[@name='TestSuite']/constructor[@name='TestSuite' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;? extends junit.framework.TestCase&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/Class;Ljava/lang/String;)V", "")]
		public unsafe TestSuite (global::Java.Lang.Class theClass, string name)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.framework']/class[@name='TestSuite']/constructor[@name='TestSuite' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;? extends junit.framework.TestCase&gt;[]'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "([Ljava/lang/Class;Ljava/lang/String;)V", "")]
		public unsafe TestSuite (global::Java.Lang.Class[] classes, string name)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Ljava/lang/Class;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_classes = JNIEnv.NewArray (classes);
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_classes);
				__args [1] = new JniArgumentValue (native_name);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (classes != null) {
					JNIEnv.CopyArray (native_classes, classes);
					JNIEnv.DeleteLocalRef (native_classes);
				}
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.framework']/class[@name='TestSuite']/constructor[@name='TestSuite' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register (".ctor", "(Ljava/lang/Class;)V", "")]
		public unsafe TestSuite (global::Java.Lang.Class theClass)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.framework']/class[@name='TestSuite']/constructor[@name='TestSuite' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;...']]"
		[Register (".ctor", "([Ljava/lang/Class;)V", "")]
		public unsafe TestSuite (params global::Java.Lang.Class[] classes)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Ljava/lang/Class;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_classes = JNIEnv.NewArray (classes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_classes);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (classes != null) {
					JNIEnv.CopyArray (native_classes, classes);
					JNIEnv.DeleteLocalRef (native_classes);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.framework']/class[@name='TestSuite']/constructor[@name='TestSuite' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe TestSuite (string name)
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

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestSuite __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestSuite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Junit.Framework.TestSuite __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestSuite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.Name = name;
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestSuite']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestSuite']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_addTest_Ljunit_framework_Test_;
#pragma warning disable 0169
		static Delegate GetAddTest_Ljunit_framework_Test_Handler ()
		{
			if (cb_addTest_Ljunit_framework_Test_ == null)
				cb_addTest_Ljunit_framework_Test_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddTest_Ljunit_framework_Test_);
			return cb_addTest_Ljunit_framework_Test_;
		}

		static void n_AddTest_Ljunit_framework_Test_ (IntPtr jnienv, IntPtr native__this, IntPtr native_test)
		{
			global::Junit.Framework.TestSuite __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestSuite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITest test = (global::Junit.Framework.ITest)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (native_test, JniHandleOwnership.DoNotTransfer);
			__this.AddTest (test);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestSuite']/method[@name='addTest' and count(parameter)=1 and parameter[1][@type='junit.framework.Test']]"
		[Register ("addTest", "(Ljunit/framework/Test;)V", "GetAddTest_Ljunit_framework_Test_Handler")]
		public virtual unsafe void AddTest (global::Junit.Framework.ITest test)
		{
			const string __id = "addTest.(Ljunit/framework/Test;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((test == null) ? IntPtr.Zero : ((global::Java.Lang.Object) test).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addTestSuite_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetAddTestSuite_Ljava_lang_Class_Handler ()
		{
			if (cb_addTestSuite_Ljava_lang_Class_ == null)
				cb_addTestSuite_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddTestSuite_Ljava_lang_Class_);
			return cb_addTestSuite_Ljava_lang_Class_;
		}

		static void n_AddTestSuite_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_testClass)
		{
			global::Junit.Framework.TestSuite __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestSuite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class testClass = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_testClass, JniHandleOwnership.DoNotTransfer);
			__this.AddTestSuite (testClass);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestSuite']/method[@name='addTestSuite' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends junit.framework.TestCase&gt;']]"
		[Register ("addTestSuite", "(Ljava/lang/Class;)V", "GetAddTestSuite_Ljava_lang_Class_Handler")]
		public virtual unsafe void AddTestSuite (global::Java.Lang.Class testClass)
		{
			const string __id = "addTestSuite.(Ljava/lang/Class;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((testClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) testClass).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_countTestCases;
#pragma warning disable 0169
		static Delegate GetCountTestCasesHandler ()
		{
			if (cb_countTestCases == null)
				cb_countTestCases = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_CountTestCases);
			return cb_countTestCases;
		}

		static int n_CountTestCases (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestSuite __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestSuite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CountTestCases ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestSuite']/method[@name='countTestCases' and count(parameter)=0]"
		[Register ("countTestCases", "()I", "GetCountTestCasesHandler")]
		public virtual unsafe int CountTestCases ()
		{
			const string __id = "countTestCases.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestSuite']/method[@name='createTest' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("createTest", "(Ljava/lang/Class;Ljava/lang/String;)Ljunit/framework/Test;", "")]
		public static unsafe global::Junit.Framework.ITest CreateTest (global::Java.Lang.Class theClass, string name)
		{
			const string __id = "createTest.(Ljava/lang/Class;Ljava/lang/String;)Ljunit/framework/Test;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((theClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) theClass).Handle);
				__args [1] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestSuite']/method[@name='getTestConstructor' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getTestConstructor", "(Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", "")]
		public static unsafe global::Java.Lang.Reflect.Constructor GetTestConstructor (global::Java.Lang.Class theClass)
		{
			const string __id = "getTestConstructor.(Ljava/lang/Class;)Ljava/lang/reflect/Constructor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((theClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) theClass).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Constructor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_run_Ljunit_framework_TestResult_;
#pragma warning disable 0169
		static Delegate GetRun_Ljunit_framework_TestResult_Handler ()
		{
			if (cb_run_Ljunit_framework_TestResult_ == null)
				cb_run_Ljunit_framework_TestResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Run_Ljunit_framework_TestResult_);
			return cb_run_Ljunit_framework_TestResult_;
		}

		static void n_Run_Ljunit_framework_TestResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			global::Junit.Framework.TestSuite __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestSuite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.TestResult result = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (native_result, JniHandleOwnership.DoNotTransfer);
			__this.Run (result);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestSuite']/method[@name='run' and count(parameter)=1 and parameter[1][@type='junit.framework.TestResult']]"
		[Register ("run", "(Ljunit/framework/TestResult;)V", "GetRun_Ljunit_framework_TestResult_Handler")]
		public virtual unsafe void Run (global::Junit.Framework.TestResult result)
		{
			const string __id = "run.(Ljunit/framework/TestResult;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_runTest_Ljunit_framework_Test_Ljunit_framework_TestResult_;
#pragma warning disable 0169
		static Delegate GetRunTest_Ljunit_framework_Test_Ljunit_framework_TestResult_Handler ()
		{
			if (cb_runTest_Ljunit_framework_Test_Ljunit_framework_TestResult_ == null)
				cb_runTest_Ljunit_framework_Test_Ljunit_framework_TestResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RunTest_Ljunit_framework_Test_Ljunit_framework_TestResult_);
			return cb_runTest_Ljunit_framework_Test_Ljunit_framework_TestResult_;
		}

		static void n_RunTest_Ljunit_framework_Test_Ljunit_framework_TestResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_test, IntPtr native_result)
		{
			global::Junit.Framework.TestSuite __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestSuite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITest test = (global::Junit.Framework.ITest)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (native_test, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.TestResult result = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (native_result, JniHandleOwnership.DoNotTransfer);
			__this.RunTest (test, result);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestSuite']/method[@name='runTest' and count(parameter)=2 and parameter[1][@type='junit.framework.Test'] and parameter[2][@type='junit.framework.TestResult']]"
		[Register ("runTest", "(Ljunit/framework/Test;Ljunit/framework/TestResult;)V", "GetRunTest_Ljunit_framework_Test_Ljunit_framework_TestResult_Handler")]
		public virtual unsafe void RunTest (global::Junit.Framework.ITest test, global::Junit.Framework.TestResult result)
		{
			const string __id = "runTest.(Ljunit/framework/Test;Ljunit/framework/TestResult;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((test == null) ? IntPtr.Zero : ((global::Java.Lang.Object) test).Handle);
				__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_testAt_I;
#pragma warning disable 0169
		static Delegate GetTestAt_IHandler ()
		{
			if (cb_testAt_I == null)
				cb_testAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_TestAt_I);
			return cb_testAt_I;
		}

		static IntPtr n_TestAt_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Junit.Framework.TestSuite __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestSuite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TestAt (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestSuite']/method[@name='testAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("testAt", "(I)Ljunit/framework/Test;", "GetTestAt_IHandler")]
		public virtual unsafe global::Junit.Framework.ITest TestAt (int index)
		{
			const string __id = "testAt.(I)Ljunit/framework/Test;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_testCount;
#pragma warning disable 0169
		static Delegate GetTestCountHandler ()
		{
			if (cb_testCount == null)
				cb_testCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_TestCount);
			return cb_testCount;
		}

		static int n_TestCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestSuite __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestSuite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TestCount ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestSuite']/method[@name='testCount' and count(parameter)=0]"
		[Register ("testCount", "()I", "GetTestCountHandler")]
		public virtual unsafe int TestCount ()
		{
			const string __id = "testCount.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_tests;
#pragma warning disable 0169
		static Delegate GetTestsHandler ()
		{
			if (cb_tests == null)
				cb_tests = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Tests);
			return cb_tests;
		}

		static IntPtr n_Tests (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestSuite __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestSuite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Tests ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestSuite']/method[@name='tests' and count(parameter)=0]"
		[Register ("tests", "()Ljava/util/Enumeration;", "GetTestsHandler")]
		public virtual unsafe global::Java.Util.IEnumeration Tests ()
		{
			const string __id = "tests.()Ljava/util/Enumeration;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IEnumeration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestSuite']/method[@name='warning' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("warning", "(Ljava/lang/String;)Ljunit/framework/Test;", "")]
		public static unsafe global::Junit.Framework.ITest Warning (string message)
		{
			const string __id = "warning.(Ljava/lang/String;)Ljunit/framework/Test;";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

	}
}
