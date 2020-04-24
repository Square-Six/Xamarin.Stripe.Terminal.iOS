using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Junit.Framework {

	// Metadata.xml XPath interface reference: path="/api/package[@name='junit.framework']/interface[@name='Test']"
	[Register ("junit/framework/Test", "", "Junit.Framework.ITestInvoker")]
	public partial interface ITest : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/interface[@name='Test']/method[@name='countTestCases' and count(parameter)=0]"
		[Register ("countTestCases", "()I", "GetCountTestCasesHandler:Junit.Framework.ITestInvoker, Xamarin.Stripe.Terminal.Android")]
		int CountTestCases ();

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/interface[@name='Test']/method[@name='run' and count(parameter)=1 and parameter[1][@type='junit.framework.TestResult']]"
		[Register ("run", "(Ljunit/framework/TestResult;)V", "GetRun_Ljunit_framework_TestResult_Handler:Junit.Framework.ITestInvoker, Xamarin.Stripe.Terminal.Android")]
		void Run (global::Junit.Framework.TestResult p0);

	}

	[global::Android.Runtime.Register ("junit/framework/Test", DoNotGenerateAcw=true)]
	internal partial class ITestInvoker : global::Java.Lang.Object, ITest {

		static readonly JniPeerMembers _members = new XAPeerMembers ("junit/framework/Test", typeof (ITestInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ITest GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITest> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "junit.framework.Test"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Junit.Framework.ITest __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CountTestCases ();
		}
#pragma warning restore 0169

		IntPtr id_countTestCases;
		public unsafe int CountTestCases ()
		{
			if (id_countTestCases == IntPtr.Zero)
				id_countTestCases = JNIEnv.GetMethodID (class_ref, "countTestCases", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_countTestCases);
		}

		static Delegate cb_run_Ljunit_framework_TestResult_;
#pragma warning disable 0169
		static Delegate GetRun_Ljunit_framework_TestResult_Handler ()
		{
			if (cb_run_Ljunit_framework_TestResult_ == null)
				cb_run_Ljunit_framework_TestResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Run_Ljunit_framework_TestResult_);
			return cb_run_Ljunit_framework_TestResult_;
		}

		static void n_Run_Ljunit_framework_TestResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Junit.Framework.ITest __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.TestResult p0 = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Run (p0);
		}
#pragma warning restore 0169

		IntPtr id_run_Ljunit_framework_TestResult_;
		public unsafe void Run (global::Junit.Framework.TestResult p0)
		{
			if (id_run_Ljunit_framework_TestResult_ == IntPtr.Zero)
				id_run_Ljunit_framework_TestResult_ = JNIEnv.GetMethodID (class_ref, "run", "(Ljunit/framework/TestResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run_Ljunit_framework_TestResult_, __args);
		}

	}

}
