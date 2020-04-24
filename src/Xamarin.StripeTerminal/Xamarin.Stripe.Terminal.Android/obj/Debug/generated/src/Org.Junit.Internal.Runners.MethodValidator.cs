using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Internal.Runners {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='MethodValidator']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/junit/internal/runners/MethodValidator", DoNotGenerateAcw=true)]
	public partial class MethodValidator : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/internal/runners/MethodValidator", typeof (MethodValidator));
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

		protected MethodValidator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='MethodValidator']/constructor[@name='MethodValidator' and count(parameter)=1 and parameter[1][@type='org.junit.internal.runners.TestClass']]"
		[Register (".ctor", "(Lorg/junit/internal/runners/TestClass;)V", "")]
		public unsafe MethodValidator (global::Org.Junit.Internal.Runners.TestClass testClass)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/junit/internal/runners/TestClass;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((testClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) testClass).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_assertValid;
#pragma warning disable 0169
		static Delegate GetAssertValidHandler ()
		{
			if (cb_assertValid == null)
				cb_assertValid = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AssertValid);
			return cb_assertValid;
		}

		static void n_AssertValid (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.Runners.MethodValidator __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.MethodValidator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AssertValid ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='MethodValidator']/method[@name='assertValid' and count(parameter)=0]"
		[Register ("assertValid", "()V", "GetAssertValidHandler")]
		public virtual unsafe void AssertValid ()
		{
			const string __id = "assertValid.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_validateInstanceMethods;
#pragma warning disable 0169
		static Delegate GetValidateInstanceMethodsHandler ()
		{
			if (cb_validateInstanceMethods == null)
				cb_validateInstanceMethods = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ValidateInstanceMethods);
			return cb_validateInstanceMethods;
		}

		static void n_ValidateInstanceMethods (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.Runners.MethodValidator __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.MethodValidator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ValidateInstanceMethods ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='MethodValidator']/method[@name='validateInstanceMethods' and count(parameter)=0]"
		[Register ("validateInstanceMethods", "()V", "GetValidateInstanceMethodsHandler")]
		public virtual unsafe void ValidateInstanceMethods ()
		{
			const string __id = "validateInstanceMethods.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_validateMethodsForDefaultRunner;
#pragma warning disable 0169
		static Delegate GetValidateMethodsForDefaultRunnerHandler ()
		{
			if (cb_validateMethodsForDefaultRunner == null)
				cb_validateMethodsForDefaultRunner = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ValidateMethodsForDefaultRunner);
			return cb_validateMethodsForDefaultRunner;
		}

		static IntPtr n_ValidateMethodsForDefaultRunner (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.Runners.MethodValidator __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.MethodValidator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.Throwable>.ToLocalJniHandle (__this.ValidateMethodsForDefaultRunner ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='MethodValidator']/method[@name='validateMethodsForDefaultRunner' and count(parameter)=0]"
		[Register ("validateMethodsForDefaultRunner", "()Ljava/util/List;", "GetValidateMethodsForDefaultRunnerHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Lang.Throwable> ValidateMethodsForDefaultRunner ()
		{
			const string __id = "validateMethodsForDefaultRunner.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Java.Lang.Throwable>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_validateNoArgConstructor;
#pragma warning disable 0169
		static Delegate GetValidateNoArgConstructorHandler ()
		{
			if (cb_validateNoArgConstructor == null)
				cb_validateNoArgConstructor = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ValidateNoArgConstructor);
			return cb_validateNoArgConstructor;
		}

		static void n_ValidateNoArgConstructor (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.Runners.MethodValidator __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.MethodValidator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ValidateNoArgConstructor ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='MethodValidator']/method[@name='validateNoArgConstructor' and count(parameter)=0]"
		[Register ("validateNoArgConstructor", "()V", "GetValidateNoArgConstructorHandler")]
		public virtual unsafe void ValidateNoArgConstructor ()
		{
			const string __id = "validateNoArgConstructor.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_validateStaticMethods;
#pragma warning disable 0169
		static Delegate GetValidateStaticMethodsHandler ()
		{
			if (cb_validateStaticMethods == null)
				cb_validateStaticMethods = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ValidateStaticMethods);
			return cb_validateStaticMethods;
		}

		static void n_ValidateStaticMethods (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.Runners.MethodValidator __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.MethodValidator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ValidateStaticMethods ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='MethodValidator']/method[@name='validateStaticMethods' and count(parameter)=0]"
		[Register ("validateStaticMethods", "()V", "GetValidateStaticMethodsHandler")]
		public virtual unsafe void ValidateStaticMethods ()
		{
			const string __id = "validateStaticMethods.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
