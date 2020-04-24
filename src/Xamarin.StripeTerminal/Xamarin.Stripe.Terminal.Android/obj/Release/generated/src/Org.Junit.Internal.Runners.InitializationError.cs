using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Internal.Runners {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='InitializationError']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/junit/internal/runners/InitializationError", DoNotGenerateAcw=true)]
	public partial class InitializationError : global::Java.Lang.Exception {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/internal/runners/InitializationError", typeof (InitializationError));
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

		protected InitializationError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='InitializationError']/constructor[@name='InitializationError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe InitializationError (string @string)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__string);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='InitializationError']/constructor[@name='InitializationError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable...']]"
		[Register (".ctor", "([Ljava/lang/Throwable;)V", "")]
		public unsafe InitializationError (params global::Java.Lang.Throwable[] errors)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Ljava/lang/Throwable;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_errors = JNIEnv.NewArray (errors);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_errors);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (errors != null) {
					JNIEnv.CopyArray (native_errors, errors);
					JNIEnv.DeleteLocalRef (native_errors);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='InitializationError']/constructor[@name='InitializationError' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Throwable&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe InitializationError (global::System.Collections.Generic.IList<global::Java.Lang.Throwable> errors)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_errors = global::Android.Runtime.JavaList<global::Java.Lang.Throwable>.ToLocalJniHandle (errors);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_errors);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_errors);
			}
		}

		static Delegate cb_getCauses;
#pragma warning disable 0169
		static Delegate GetGetCausesHandler ()
		{
			if (cb_getCauses == null)
				cb_getCauses = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCauses);
			return cb_getCauses;
		}

		static IntPtr n_GetCauses (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.Runners.InitializationError __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.InitializationError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.Throwable>.ToLocalJniHandle (__this.Causes);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Lang.Throwable> Causes {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='InitializationError']/method[@name='getCauses' and count(parameter)=0]"
			[Register ("getCauses", "()Ljava/util/List;", "GetGetCausesHandler")]
			get {
				const string __id = "getCauses.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Java.Lang.Throwable>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
