using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Junit.Extensions {

	// Metadata.xml XPath class reference: path="/api/package[@name='junit.extensions']/class[@name='TestDecorator']"
	[global::Android.Runtime.Register ("junit/extensions/TestDecorator", DoNotGenerateAcw=true)]
	public partial class TestDecorator : global::Junit.Framework.Assert, global::Junit.Framework.ITest {



		// Metadata.xml XPath field reference: path="/api/package[@name='junit.extensions']/class[@name='TestDecorator']/field[@name='fTest']"
		[Register ("fTest")]
		protected global::Junit.Framework.ITest FTest {
			get {
				const string __id = "fTest.Ljunit/framework/Test;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "fTest.Ljunit/framework/Test;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("junit/extensions/TestDecorator", typeof (TestDecorator));
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

		protected TestDecorator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.extensions']/class[@name='TestDecorator']/constructor[@name='TestDecorator' and count(parameter)=1 and parameter[1][@type='junit.framework.Test']]"
		[Register (".ctor", "(Ljunit/framework/Test;)V", "")]
		public unsafe TestDecorator (global::Junit.Framework.ITest test)
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

		static Delegate cb_getTest;
#pragma warning disable 0169
		static Delegate GetGetTestHandler ()
		{
			if (cb_getTest == null)
				cb_getTest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTest);
			return cb_getTest;
		}

		static IntPtr n_GetTest (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Extensions.TestDecorator __this = global::Java.Lang.Object.GetObject<global::Junit.Extensions.TestDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Test);
		}
#pragma warning restore 0169

		public virtual unsafe global::Junit.Framework.ITest Test {
			// Metadata.xml XPath method reference: path="/api/package[@name='junit.extensions']/class[@name='TestDecorator']/method[@name='getTest' and count(parameter)=0]"
			[Register ("getTest", "()Ljunit/framework/Test;", "GetGetTestHandler")]
			get {
				const string __id = "getTest.()Ljunit/framework/Test;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_basicRun_Ljunit_framework_TestResult_;
#pragma warning disable 0169
		static Delegate GetBasicRun_Ljunit_framework_TestResult_Handler ()
		{
			if (cb_basicRun_Ljunit_framework_TestResult_ == null)
				cb_basicRun_Ljunit_framework_TestResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_BasicRun_Ljunit_framework_TestResult_);
			return cb_basicRun_Ljunit_framework_TestResult_;
		}

		static void n_BasicRun_Ljunit_framework_TestResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			global::Junit.Extensions.TestDecorator __this = global::Java.Lang.Object.GetObject<global::Junit.Extensions.TestDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.TestResult result = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (native_result, JniHandleOwnership.DoNotTransfer);
			__this.BasicRun (result);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.extensions']/class[@name='TestDecorator']/method[@name='basicRun' and count(parameter)=1 and parameter[1][@type='junit.framework.TestResult']]"
		[Register ("basicRun", "(Ljunit/framework/TestResult;)V", "GetBasicRun_Ljunit_framework_TestResult_Handler")]
		public virtual unsafe void BasicRun (global::Junit.Framework.TestResult result)
		{
			const string __id = "basicRun.(Ljunit/framework/TestResult;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
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
			global::Junit.Extensions.TestDecorator __this = global::Java.Lang.Object.GetObject<global::Junit.Extensions.TestDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CountTestCases ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.extensions']/class[@name='TestDecorator']/method[@name='countTestCases' and count(parameter)=0]"
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
			global::Junit.Extensions.TestDecorator __this = global::Java.Lang.Object.GetObject<global::Junit.Extensions.TestDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.TestResult result = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (native_result, JniHandleOwnership.DoNotTransfer);
			__this.Run (result);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.extensions']/class[@name='TestDecorator']/method[@name='run' and count(parameter)=1 and parameter[1][@type='junit.framework.TestResult']]"
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

	}
}
