using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Internal.Runners {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='TestMethod']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/junit/internal/runners/TestMethod", DoNotGenerateAcw=true)]
	public partial class TestMethod : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/internal/runners/TestMethod", typeof (TestMethod));
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

		protected TestMethod (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='TestMethod']/constructor[@name='TestMethod' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Method'] and parameter[2][@type='org.junit.internal.runners.TestClass']]"
		[Register (".ctor", "(Ljava/lang/reflect/Method;Lorg/junit/internal/runners/TestClass;)V", "")]
		public unsafe TestMethod (global::Java.Lang.Reflect.Method method, global::Org.Junit.Internal.Runners.TestClass testClass)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/reflect/Method;Lorg/junit/internal/runners/TestClass;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((method == null) ? IntPtr.Zero : ((global::Java.Lang.Object) method).Handle);
				__args [1] = new JniArgumentValue ((testClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) testClass).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getExpectedException;
#pragma warning disable 0169
		static Delegate GetGetExpectedExceptionHandler ()
		{
			if (cb_getExpectedException == null)
				cb_getExpectedException = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExpectedException);
			return cb_getExpectedException;
		}

		static IntPtr n_GetExpectedException (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.Runners.TestMethod __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.TestMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExpectedException);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Java.Lang.Class ExpectedException {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='TestMethod']/method[@name='getExpectedException' and count(parameter)=0]"
			[Register ("getExpectedException", "()Ljava/lang/Class;", "GetGetExpectedExceptionHandler")]
			get {
				const string __id = "getExpectedException.()Ljava/lang/Class;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isIgnored;
#pragma warning disable 0169
		static Delegate GetIsIgnoredHandler ()
		{
			if (cb_isIgnored == null)
				cb_isIgnored = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsIgnored);
			return cb_isIgnored;
		}

		static bool n_IsIgnored (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.Runners.TestMethod __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.TestMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIgnored;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsIgnored {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='TestMethod']/method[@name='isIgnored' and count(parameter)=0]"
			[Register ("isIgnored", "()Z", "GetIsIgnoredHandler")]
			get {
				const string __id = "isIgnored.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTimeout;
#pragma warning disable 0169
		static Delegate GetGetTimeoutHandler ()
		{
			if (cb_getTimeout == null)
				cb_getTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimeout);
			return cb_getTimeout;
		}

		static long n_GetTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.Runners.TestMethod __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.TestMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timeout;
		}
#pragma warning restore 0169

		public virtual unsafe long Timeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='TestMethod']/method[@name='getTimeout' and count(parameter)=0]"
			[Register ("getTimeout", "()J", "GetGetTimeoutHandler")]
			get {
				const string __id = "getTimeout.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_invoke_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInvoke_Ljava_lang_Object_Handler ()
		{
			if (cb_invoke_Ljava_lang_Object_ == null)
				cb_invoke_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Invoke_Ljava_lang_Object_);
			return cb_invoke_Ljava_lang_Object_;
		}

		static void n_Invoke_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_test)
		{
			global::Org.Junit.Internal.Runners.TestMethod __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.TestMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object test = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_test, JniHandleOwnership.DoNotTransfer);
			__this.Invoke (test);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='TestMethod']/method[@name='invoke' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("invoke", "(Ljava/lang/Object;)V", "GetInvoke_Ljava_lang_Object_Handler")]
		public virtual unsafe void Invoke (global::Java.Lang.Object test)
		{
			const string __id = "invoke.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((test == null) ? IntPtr.Zero : ((global::Java.Lang.Object) test).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
