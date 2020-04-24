using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Junit.Framework {

	// Metadata.xml XPath class reference: path="/api/package[@name='junit.framework']/class[@name='JUnit4TestAdapter']"
	[global::Android.Runtime.Register ("junit/framework/JUnit4TestAdapter", DoNotGenerateAcw=true)]
	public partial class JUnit4TestAdapter : global::Java.Lang.Object, global::Junit.Framework.ITest {

		static readonly JniPeerMembers _members = new XAPeerMembers ("junit/framework/JUnit4TestAdapter", typeof (JUnit4TestAdapter));
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

		protected JUnit4TestAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.framework']/class[@name='JUnit4TestAdapter']/constructor[@name='JUnit4TestAdapter' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register (".ctor", "(Ljava/lang/Class;)V", "")]
		public unsafe JUnit4TestAdapter (global::Java.Lang.Class newTestClass)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Class;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((newTestClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newTestClass).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.framework']/class[@name='JUnit4TestAdapter']/constructor[@name='JUnit4TestAdapter' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='junit.framework.JUnit4TestAdapterCache']]"
		[Register (".ctor", "(Ljava/lang/Class;Ljunit/framework/JUnit4TestAdapterCache;)V", "")]
		public unsafe JUnit4TestAdapter (global::Java.Lang.Class newTestClass, global::Junit.Framework.JUnit4TestAdapterCache cache)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Class;Ljunit/framework/JUnit4TestAdapterCache;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((newTestClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newTestClass).Handle);
				__args [1] = new JniArgumentValue ((cache == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cache).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getTestClass;
#pragma warning disable 0169
		static Delegate GetGetTestClassHandler ()
		{
			if (cb_getTestClass == null)
				cb_getTestClass = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTestClass);
			return cb_getTestClass;
		}

		static IntPtr n_GetTestClass (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.JUnit4TestAdapter __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.JUnit4TestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TestClass);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Class TestClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='JUnit4TestAdapter']/method[@name='getTestClass' and count(parameter)=0]"
			[Register ("getTestClass", "()Ljava/lang/Class;", "GetGetTestClassHandler")]
			get {
				const string __id = "getTestClass.()Ljava/lang/Class;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTests;
#pragma warning disable 0169
		static Delegate GetGetTestsHandler ()
		{
			if (cb_getTests == null)
				cb_getTests = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTests);
			return cb_getTests;
		}

		static IntPtr n_GetTests (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.JUnit4TestAdapter __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.JUnit4TestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Junit.Framework.ITest>.ToLocalJniHandle (__this.Tests);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Junit.Framework.ITest> Tests {
			// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='JUnit4TestAdapter']/method[@name='getTests' and count(parameter)=0]"
			[Register ("getTests", "()Ljava/util/List;", "GetGetTestsHandler")]
			get {
				const string __id = "getTests.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Junit.Framework.ITest>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Junit.Framework.JUnit4TestAdapter __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.JUnit4TestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CountTestCases ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='JUnit4TestAdapter']/method[@name='countTestCases' and count(parameter)=0]"
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
			global::Junit.Framework.JUnit4TestAdapter __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.JUnit4TestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.TestResult result = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (native_result, JniHandleOwnership.DoNotTransfer);
			__this.Run (result);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='JUnit4TestAdapter']/method[@name='run' and count(parameter)=1 and parameter[1][@type='junit.framework.TestResult']]"
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
