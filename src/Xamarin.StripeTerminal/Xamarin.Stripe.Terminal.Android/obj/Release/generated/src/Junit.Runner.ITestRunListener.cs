using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Junit.Runner {

	[Register ("junit/runner/TestRunListener", DoNotGenerateAcw=true)]
	public abstract class TestRunListener : Java.Lang.Object {

		internal TestRunListener ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='junit.runner']/interface[@name='TestRunListener']/field[@name='STATUS_ERROR']"
		[Register ("STATUS_ERROR")]
		public const int StatusError = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='junit.runner']/interface[@name='TestRunListener']/field[@name='STATUS_FAILURE']"
		[Register ("STATUS_FAILURE")]
		public const int StatusFailure = (int) 2;
	}

	[Register ("junit/runner/TestRunListener", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'TestRunListener' type. This type will be removed in a future release.", error: true)]
	public abstract class TestRunListenerConsts : TestRunListener {

		private TestRunListenerConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='junit.runner']/interface[@name='TestRunListener']"
	[Register ("junit/runner/TestRunListener", "", "Junit.Runner.ITestRunListenerInvoker")]
	public partial interface ITestRunListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/interface[@name='TestRunListener']/method[@name='testEnded' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("testEnded", "(Ljava/lang/String;)V", "GetTestEnded_Ljava_lang_String_Handler:Junit.Runner.ITestRunListenerInvoker, Xamarin.Stripe.Terminal.Android")]
		void TestEnded (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/interface[@name='TestRunListener']/method[@name='testFailed' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("testFailed", "(ILjava/lang/String;Ljava/lang/String;)V", "GetTestFailed_ILjava_lang_String_Ljava_lang_String_Handler:Junit.Runner.ITestRunListenerInvoker, Xamarin.Stripe.Terminal.Android")]
		void TestFailed (int p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/interface[@name='TestRunListener']/method[@name='testRunEnded' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("testRunEnded", "(J)V", "GetTestRunEnded_JHandler:Junit.Runner.ITestRunListenerInvoker, Xamarin.Stripe.Terminal.Android")]
		void TestRunEnded (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/interface[@name='TestRunListener']/method[@name='testRunStarted' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("testRunStarted", "(Ljava/lang/String;I)V", "GetTestRunStarted_Ljava_lang_String_IHandler:Junit.Runner.ITestRunListenerInvoker, Xamarin.Stripe.Terminal.Android")]
		void TestRunStarted (string p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/interface[@name='TestRunListener']/method[@name='testRunStopped' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("testRunStopped", "(J)V", "GetTestRunStopped_JHandler:Junit.Runner.ITestRunListenerInvoker, Xamarin.Stripe.Terminal.Android")]
		void TestRunStopped (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/interface[@name='TestRunListener']/method[@name='testStarted' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("testStarted", "(Ljava/lang/String;)V", "GetTestStarted_Ljava_lang_String_Handler:Junit.Runner.ITestRunListenerInvoker, Xamarin.Stripe.Terminal.Android")]
		void TestStarted (string p0);

	}

	[global::Android.Runtime.Register ("junit/runner/TestRunListener", DoNotGenerateAcw=true)]
	internal partial class ITestRunListenerInvoker : global::Java.Lang.Object, ITestRunListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("junit/runner/TestRunListener", typeof (ITestRunListenerInvoker));

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

		public static ITestRunListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITestRunListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "junit.runner.TestRunListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITestRunListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Junit.Runner.ITestRunListener __this = global::Java.Lang.Object.GetObject<global::Junit.Runner.ITestRunListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TestEnded (p0);
		}
#pragma warning restore 0169

		IntPtr id_testEnded_Ljava_lang_String_;
		public unsafe void TestEnded (string p0)
		{
			if (id_testEnded_Ljava_lang_String_ == IntPtr.Zero)
				id_testEnded_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "testEnded", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_testEnded_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_testFailed_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTestFailed_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_testFailed_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_testFailed_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_TestFailed_ILjava_lang_String_Ljava_lang_String_);
			return cb_testFailed_ILjava_lang_String_Ljava_lang_String_;
		}

		static void n_TestFailed_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Junit.Runner.ITestRunListener __this = global::Java.Lang.Object.GetObject<global::Junit.Runner.ITestRunListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.TestFailed (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_testFailed_ILjava_lang_String_Ljava_lang_String_;
		public unsafe void TestFailed (int p0, string p1, string p2)
		{
			if (id_testFailed_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_testFailed_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "testFailed", "(ILjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_testFailed_ILjava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_testRunEnded_J;
#pragma warning disable 0169
		static Delegate GetTestRunEnded_JHandler ()
		{
			if (cb_testRunEnded_J == null)
				cb_testRunEnded_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_TestRunEnded_J);
			return cb_testRunEnded_J;
		}

		static void n_TestRunEnded_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Junit.Runner.ITestRunListener __this = global::Java.Lang.Object.GetObject<global::Junit.Runner.ITestRunListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TestRunEnded (p0);
		}
#pragma warning restore 0169

		IntPtr id_testRunEnded_J;
		public unsafe void TestRunEnded (long p0)
		{
			if (id_testRunEnded_J == IntPtr.Zero)
				id_testRunEnded_J = JNIEnv.GetMethodID (class_ref, "testRunEnded", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_testRunEnded_J, __args);
		}

		static Delegate cb_testRunStarted_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetTestRunStarted_Ljava_lang_String_IHandler ()
		{
			if (cb_testRunStarted_Ljava_lang_String_I == null)
				cb_testRunStarted_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_TestRunStarted_Ljava_lang_String_I);
			return cb_testRunStarted_Ljava_lang_String_I;
		}

		static void n_TestRunStarted_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Junit.Runner.ITestRunListener __this = global::Java.Lang.Object.GetObject<global::Junit.Runner.ITestRunListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TestRunStarted (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_testRunStarted_Ljava_lang_String_I;
		public unsafe void TestRunStarted (string p0, int p1)
		{
			if (id_testRunStarted_Ljava_lang_String_I == IntPtr.Zero)
				id_testRunStarted_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "testRunStarted", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_testRunStarted_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_testRunStopped_J;
#pragma warning disable 0169
		static Delegate GetTestRunStopped_JHandler ()
		{
			if (cb_testRunStopped_J == null)
				cb_testRunStopped_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_TestRunStopped_J);
			return cb_testRunStopped_J;
		}

		static void n_TestRunStopped_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Junit.Runner.ITestRunListener __this = global::Java.Lang.Object.GetObject<global::Junit.Runner.ITestRunListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TestRunStopped (p0);
		}
#pragma warning restore 0169

		IntPtr id_testRunStopped_J;
		public unsafe void TestRunStopped (long p0)
		{
			if (id_testRunStopped_J == IntPtr.Zero)
				id_testRunStopped_J = JNIEnv.GetMethodID (class_ref, "testRunStopped", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_testRunStopped_J, __args);
		}

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
			global::Junit.Runner.ITestRunListener __this = global::Java.Lang.Object.GetObject<global::Junit.Runner.ITestRunListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TestStarted (p0);
		}
#pragma warning restore 0169

		IntPtr id_testStarted_Ljava_lang_String_;
		public unsafe void TestStarted (string p0)
		{
			if (id_testStarted_Ljava_lang_String_ == IntPtr.Zero)
				id_testStarted_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "testStarted", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_testStarted_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for junit.runner.TestRunListener.testEnded
	public partial class TestEndedEventArgs : global::System.EventArgs {

		public TestEndedEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	// event args for junit.runner.TestRunListener.testFailed
	public partial class TestFailedEventArgs : global::System.EventArgs {

		public TestFailedEventArgs (int p0, string p1, string p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}

		string p2;
		public string P2 {
			get { return p2; }
		}
	}

	// event args for junit.runner.TestRunListener.testRunEnded
	public partial class TestRunEndedEventArgs : global::System.EventArgs {

		public TestRunEndedEventArgs (long p0)
		{
			this.p0 = p0;
		}

		long p0;
		public long P0 {
			get { return p0; }
		}
	}

	// event args for junit.runner.TestRunListener.testRunStarted
	public partial class TestRunStartedEventArgs : global::System.EventArgs {

		public TestRunStartedEventArgs (string p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	// event args for junit.runner.TestRunListener.testRunStopped
	public partial class TestRunStoppedEventArgs : global::System.EventArgs {

		public TestRunStoppedEventArgs (long p0)
		{
			this.p0 = p0;
		}

		long p0;
		public long P0 {
			get { return p0; }
		}
	}

	// event args for junit.runner.TestRunListener.testStarted
	public partial class TestStartedEventArgs : global::System.EventArgs {

		public TestStartedEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/junit/runner/TestRunListenerImplementor")]
	internal sealed partial class ITestRunListenerImplementor : global::Java.Lang.Object, ITestRunListener {

		object sender;

		public ITestRunListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/junit/runner/TestRunListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<TestEndedEventArgs> TestEndedHandler;
#pragma warning restore 0649

		public void TestEnded (string p0)
		{
			var __h = TestEndedHandler;
			if (__h != null)
				__h (sender, new TestEndedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<TestFailedEventArgs> TestFailedHandler;
#pragma warning restore 0649

		public void TestFailed (int p0, string p1, string p2)
		{
			var __h = TestFailedHandler;
			if (__h != null)
				__h (sender, new TestFailedEventArgs (p0, p1, p2));
		}
#pragma warning disable 0649
		public EventHandler<TestRunEndedEventArgs> TestRunEndedHandler;
#pragma warning restore 0649

		public void TestRunEnded (long p0)
		{
			var __h = TestRunEndedHandler;
			if (__h != null)
				__h (sender, new TestRunEndedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<TestRunStartedEventArgs> TestRunStartedHandler;
#pragma warning restore 0649

		public void TestRunStarted (string p0, int p1)
		{
			var __h = TestRunStartedHandler;
			if (__h != null)
				__h (sender, new TestRunStartedEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<TestRunStoppedEventArgs> TestRunStoppedHandler;
#pragma warning restore 0649

		public void TestRunStopped (long p0)
		{
			var __h = TestRunStoppedHandler;
			if (__h != null)
				__h (sender, new TestRunStoppedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<TestStartedEventArgs> TestStartedHandler;
#pragma warning restore 0649

		public void TestStarted (string p0)
		{
			var __h = TestStartedHandler;
			if (__h != null)
				__h (sender, new TestStartedEventArgs (p0));
		}

		internal static bool __IsEmpty (ITestRunListenerImplementor value)
		{
			return value.TestEndedHandler == null && value.TestFailedHandler == null && value.TestRunEndedHandler == null && value.TestRunStartedHandler == null && value.TestRunStoppedHandler == null && value.TestStartedHandler == null;
		}
	}

}
