using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Junit.Framework {

	// Metadata.xml XPath interface reference: path="/api/package[@name='junit.framework']/interface[@name='TestListener']"
	[Register ("junit/framework/TestListener", "", "Junit.Framework.ITestListenerInvoker")]
	public partial interface ITestListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/interface[@name='TestListener']/method[@name='addError' and count(parameter)=2 and parameter[1][@type='junit.framework.Test'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("addError", "(Ljunit/framework/Test;Ljava/lang/Throwable;)V", "GetAddError_Ljunit_framework_Test_Ljava_lang_Throwable_Handler:Junit.Framework.ITestListenerInvoker, Xamarin.Stripe.Terminal.Android")]
		void AddError (global::Junit.Framework.ITest p0, global::Java.Lang.Throwable p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/interface[@name='TestListener']/method[@name='addFailure' and count(parameter)=2 and parameter[1][@type='junit.framework.Test'] and parameter[2][@type='junit.framework.AssertionFailedError']]"
		[Register ("addFailure", "(Ljunit/framework/Test;Ljunit/framework/AssertionFailedError;)V", "GetAddFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_Handler:Junit.Framework.ITestListenerInvoker, Xamarin.Stripe.Terminal.Android")]
		void AddFailure (global::Junit.Framework.ITest p0, global::Junit.Framework.AssertionFailedError p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/interface[@name='TestListener']/method[@name='endTest' and count(parameter)=1 and parameter[1][@type='junit.framework.Test']]"
		[Register ("endTest", "(Ljunit/framework/Test;)V", "GetEndTest_Ljunit_framework_Test_Handler:Junit.Framework.ITestListenerInvoker, Xamarin.Stripe.Terminal.Android")]
		void EndTest (global::Junit.Framework.ITest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/interface[@name='TestListener']/method[@name='startTest' and count(parameter)=1 and parameter[1][@type='junit.framework.Test']]"
		[Register ("startTest", "(Ljunit/framework/Test;)V", "GetStartTest_Ljunit_framework_Test_Handler:Junit.Framework.ITestListenerInvoker, Xamarin.Stripe.Terminal.Android")]
		void StartTest (global::Junit.Framework.ITest p0);

	}

	[global::Android.Runtime.Register ("junit/framework/TestListener", DoNotGenerateAcw=true)]
	internal partial class ITestListenerInvoker : global::Java.Lang.Object, ITestListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("junit/framework/TestListener", typeof (ITestListenerInvoker));

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

		public static ITestListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITestListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "junit.framework.TestListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITestListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_addError_Ljunit_framework_Test_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetAddError_Ljunit_framework_Test_Ljava_lang_Throwable_Handler ()
		{
			if (cb_addError_Ljunit_framework_Test_Ljava_lang_Throwable_ == null)
				cb_addError_Ljunit_framework_Test_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddError_Ljunit_framework_Test_Ljava_lang_Throwable_);
			return cb_addError_Ljunit_framework_Test_Ljava_lang_Throwable_;
		}

		static void n_AddError_Ljunit_framework_Test_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Junit.Framework.ITestListener __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.ITestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITest p0 = (global::Junit.Framework.ITest)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_addError_Ljunit_framework_Test_Ljava_lang_Throwable_;
		public unsafe void AddError (global::Junit.Framework.ITest p0, global::Java.Lang.Throwable p1)
		{
			if (id_addError_Ljunit_framework_Test_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_addError_Ljunit_framework_Test_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "addError", "(Ljunit/framework/Test;Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addError_Ljunit_framework_Test_Ljava_lang_Throwable_, __args);
		}

		static Delegate cb_addFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_;
#pragma warning disable 0169
		static Delegate GetAddFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_Handler ()
		{
			if (cb_addFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_ == null)
				cb_addFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_);
			return cb_addFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_;
		}

		static void n_AddFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Junit.Framework.ITestListener __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.ITestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITest p0 = (global::Junit.Framework.ITest)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.AssertionFailedError p1 = global::Java.Lang.Object.GetObject<global::Junit.Framework.AssertionFailedError> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddFailure (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_addFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_;
		public unsafe void AddFailure (global::Junit.Framework.ITest p0, global::Junit.Framework.AssertionFailedError p1)
		{
			if (id_addFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_ == IntPtr.Zero)
				id_addFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_ = JNIEnv.GetMethodID (class_ref, "addFailure", "(Ljunit/framework/Test;Ljunit/framework/AssertionFailedError;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_, __args);
		}

		static Delegate cb_endTest_Ljunit_framework_Test_;
#pragma warning disable 0169
		static Delegate GetEndTest_Ljunit_framework_Test_Handler ()
		{
			if (cb_endTest_Ljunit_framework_Test_ == null)
				cb_endTest_Ljunit_framework_Test_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EndTest_Ljunit_framework_Test_);
			return cb_endTest_Ljunit_framework_Test_;
		}

		static void n_EndTest_Ljunit_framework_Test_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Junit.Framework.ITestListener __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.ITestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITest p0 = (global::Junit.Framework.ITest)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EndTest (p0);
		}
#pragma warning restore 0169

		IntPtr id_endTest_Ljunit_framework_Test_;
		public unsafe void EndTest (global::Junit.Framework.ITest p0)
		{
			if (id_endTest_Ljunit_framework_Test_ == IntPtr.Zero)
				id_endTest_Ljunit_framework_Test_ = JNIEnv.GetMethodID (class_ref, "endTest", "(Ljunit/framework/Test;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_endTest_Ljunit_framework_Test_, __args);
		}

		static Delegate cb_startTest_Ljunit_framework_Test_;
#pragma warning disable 0169
		static Delegate GetStartTest_Ljunit_framework_Test_Handler ()
		{
			if (cb_startTest_Ljunit_framework_Test_ == null)
				cb_startTest_Ljunit_framework_Test_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartTest_Ljunit_framework_Test_);
			return cb_startTest_Ljunit_framework_Test_;
		}

		static void n_StartTest_Ljunit_framework_Test_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Junit.Framework.ITestListener __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.ITestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITest p0 = (global::Junit.Framework.ITest)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartTest (p0);
		}
#pragma warning restore 0169

		IntPtr id_startTest_Ljunit_framework_Test_;
		public unsafe void StartTest (global::Junit.Framework.ITest p0)
		{
			if (id_startTest_Ljunit_framework_Test_ == IntPtr.Zero)
				id_startTest_Ljunit_framework_Test_ = JNIEnv.GetMethodID (class_ref, "startTest", "(Ljunit/framework/Test;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startTest_Ljunit_framework_Test_, __args);
		}

	}

	// event args for junit.framework.TestListener.addError
	public partial class AddErrorEventArgs : global::System.EventArgs {

		public AddErrorEventArgs (global::Junit.Framework.ITest p0, global::Java.Lang.Throwable p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Junit.Framework.ITest p0;
		public global::Junit.Framework.ITest P0 {
			get { return p0; }
		}

		global::Java.Lang.Throwable p1;
		public global::Java.Lang.Throwable P1 {
			get { return p1; }
		}
	}

	// event args for junit.framework.TestListener.addFailure
	public partial class AddFailureEventArgs : global::System.EventArgs {

		public AddFailureEventArgs (global::Junit.Framework.ITest p0, global::Junit.Framework.AssertionFailedError p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Junit.Framework.ITest p0;
		public global::Junit.Framework.ITest P0 {
			get { return p0; }
		}

		global::Junit.Framework.AssertionFailedError p1;
		public global::Junit.Framework.AssertionFailedError P1 {
			get { return p1; }
		}
	}

	// event args for junit.framework.TestListener.endTest
	public partial class EndTestEventArgs : global::System.EventArgs {

		public EndTestEventArgs (global::Junit.Framework.ITest p0)
		{
			this.p0 = p0;
		}

		global::Junit.Framework.ITest p0;
		public global::Junit.Framework.ITest P0 {
			get { return p0; }
		}
	}

	// event args for junit.framework.TestListener.startTest
	public partial class StartTestEventArgs : global::System.EventArgs {

		public StartTestEventArgs (global::Junit.Framework.ITest p0)
		{
			this.p0 = p0;
		}

		global::Junit.Framework.ITest p0;
		public global::Junit.Framework.ITest P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/junit/framework/TestListenerImplementor")]
	internal sealed partial class ITestListenerImplementor : global::Java.Lang.Object, ITestListener {

		object sender;

		public ITestListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/junit/framework/TestListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AddErrorEventArgs> AddErrorHandler;
#pragma warning restore 0649

		public void AddError (global::Junit.Framework.ITest p0, global::Java.Lang.Throwable p1)
		{
			var __h = AddErrorHandler;
			if (__h != null)
				__h (sender, new AddErrorEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<AddFailureEventArgs> AddFailureHandler;
#pragma warning restore 0649

		public void AddFailure (global::Junit.Framework.ITest p0, global::Junit.Framework.AssertionFailedError p1)
		{
			var __h = AddFailureHandler;
			if (__h != null)
				__h (sender, new AddFailureEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<EndTestEventArgs> EndTestHandler;
#pragma warning restore 0649

		public void EndTest (global::Junit.Framework.ITest p0)
		{
			var __h = EndTestHandler;
			if (__h != null)
				__h (sender, new EndTestEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<StartTestEventArgs> StartTestHandler;
#pragma warning restore 0649

		public void StartTest (global::Junit.Framework.ITest p0)
		{
			var __h = StartTestHandler;
			if (__h != null)
				__h (sender, new StartTestEventArgs (p0));
		}

		internal static bool __IsEmpty (ITestListenerImplementor value)
		{
			return value.AddErrorHandler == null && value.AddFailureHandler == null && value.EndTestHandler == null && value.StartTestHandler == null;
		}
	}

}
