using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Junit.Framework {

	// Metadata.xml XPath class reference: path="/api/package[@name='junit.framework']/class[@name='JUnit4TestCaseFacade']"
	[global::Android.Runtime.Register ("junit/framework/JUnit4TestCaseFacade", DoNotGenerateAcw=true)]
	public partial class JUnit4TestCaseFacade : global::Java.Lang.Object, global::Junit.Framework.ITest {

		static readonly JniPeerMembers _members = new XAPeerMembers ("junit/framework/JUnit4TestCaseFacade", typeof (JUnit4TestCaseFacade));
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

		protected JUnit4TestCaseFacade (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Junit.Framework.JUnit4TestCaseFacade __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.JUnit4TestCaseFacade> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CountTestCases ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='JUnit4TestCaseFacade']/method[@name='countTestCases' and count(parameter)=0]"
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
			global::Junit.Framework.JUnit4TestCaseFacade __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.JUnit4TestCaseFacade> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.TestResult result = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (native_result, JniHandleOwnership.DoNotTransfer);
			__this.Run (result);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='JUnit4TestCaseFacade']/method[@name='run' and count(parameter)=1 and parameter[1][@type='junit.framework.TestResult']]"
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
