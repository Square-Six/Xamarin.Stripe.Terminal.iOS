using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Junit.Framework {

	// Metadata.xml XPath class reference: path="/api/package[@name='junit.framework']/class[@name='TestFailure']"
	[global::Android.Runtime.Register ("junit/framework/TestFailure", DoNotGenerateAcw=true)]
	public partial class TestFailure : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='junit.framework']/class[@name='TestFailure']/field[@name='fFailedTest']"
		[Register ("fFailedTest")]
		protected global::Junit.Framework.ITest FFailedTest {
			get {
				const string __id = "fFailedTest.Ljunit/framework/Test;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "fFailedTest.Ljunit/framework/Test;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='junit.framework']/class[@name='TestFailure']/field[@name='fThrownException']"
		[Register ("fThrownException")]
		protected global::Java.Lang.Throwable FThrownException {
			get {
				const string __id = "fThrownException.Ljava/lang/Throwable;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "fThrownException.Ljava/lang/Throwable;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("junit/framework/TestFailure", typeof (TestFailure));
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

		protected TestFailure (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.framework']/class[@name='TestFailure']/constructor[@name='TestFailure' and count(parameter)=2 and parameter[1][@type='junit.framework.Test'] and parameter[2][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljunit/framework/Test;Ljava/lang/Throwable;)V", "")]
		public unsafe TestFailure (global::Junit.Framework.ITest failedTest, global::Java.Lang.Throwable thrownException)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljunit/framework/Test;Ljava/lang/Throwable;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((failedTest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) failedTest).Handle);
				__args [1] = new JniArgumentValue ((thrownException == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) thrownException).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isFailure;
#pragma warning disable 0169
		static Delegate GetIsFailureHandler ()
		{
			if (cb_isFailure == null)
				cb_isFailure = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFailure);
			return cb_isFailure;
		}

		static bool n_IsFailure (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestFailure __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestFailure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFailure;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsFailure {
			// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestFailure']/method[@name='isFailure' and count(parameter)=0]"
			[Register ("isFailure", "()Z", "GetIsFailureHandler")]
			get {
				const string __id = "isFailure.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_exceptionMessage;
#pragma warning disable 0169
		static Delegate GetExceptionMessageHandler ()
		{
			if (cb_exceptionMessage == null)
				cb_exceptionMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ExceptionMessage);
			return cb_exceptionMessage;
		}

		static IntPtr n_ExceptionMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestFailure __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestFailure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExceptionMessage ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestFailure']/method[@name='exceptionMessage' and count(parameter)=0]"
		[Register ("exceptionMessage", "()Ljava/lang/String;", "GetExceptionMessageHandler")]
		public virtual unsafe string ExceptionMessage ()
		{
			const string __id = "exceptionMessage.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_failedTest;
#pragma warning disable 0169
		static Delegate GetFailedTestHandler ()
		{
			if (cb_failedTest == null)
				cb_failedTest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FailedTest);
			return cb_failedTest;
		}

		static IntPtr n_FailedTest (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestFailure __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestFailure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FailedTest ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestFailure']/method[@name='failedTest' and count(parameter)=0]"
		[Register ("failedTest", "()Ljunit/framework/Test;", "GetFailedTestHandler")]
		public virtual unsafe global::Junit.Framework.ITest FailedTest ()
		{
			const string __id = "failedTest.()Ljunit/framework/Test;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_thrownException;
#pragma warning disable 0169
		static Delegate GetThrownExceptionHandler ()
		{
			if (cb_thrownException == null)
				cb_thrownException = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ThrownException);
			return cb_thrownException;
		}

		static IntPtr n_ThrownException (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestFailure __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestFailure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThrownException ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestFailure']/method[@name='thrownException' and count(parameter)=0]"
		[Register ("thrownException", "()Ljava/lang/Throwable;", "GetThrownExceptionHandler")]
		public virtual unsafe global::Java.Lang.Throwable ThrownException ()
		{
			const string __id = "thrownException.()Ljava/lang/Throwable;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_trace;
#pragma warning disable 0169
		static Delegate GetTraceHandler ()
		{
			if (cb_trace == null)
				cb_trace = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Trace);
			return cb_trace;
		}

		static IntPtr n_Trace (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestFailure __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestFailure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Trace ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestFailure']/method[@name='trace' and count(parameter)=0]"
		[Register ("trace", "()Ljava/lang/String;", "GetTraceHandler")]
		public virtual unsafe string Trace ()
		{
			const string __id = "trace.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
