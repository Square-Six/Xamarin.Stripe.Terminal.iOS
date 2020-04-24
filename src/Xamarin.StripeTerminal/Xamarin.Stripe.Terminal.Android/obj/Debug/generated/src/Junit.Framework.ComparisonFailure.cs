using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Junit.Framework {

	// Metadata.xml XPath class reference: path="/api/package[@name='junit.framework']/class[@name='ComparisonFailure']"
	[global::Android.Runtime.Register ("junit/framework/ComparisonFailure", DoNotGenerateAcw=true)]
	public partial class ComparisonFailure : global::Junit.Framework.AssertionFailedError {

		static readonly JniPeerMembers _members = new XAPeerMembers ("junit/framework/ComparisonFailure", typeof (ComparisonFailure));
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

		protected ComparisonFailure (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.framework']/class[@name='ComparisonFailure']/constructor[@name='ComparisonFailure' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe ComparisonFailure (string message, string expected, string actual)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_expected = JNIEnv.NewString (expected);
			IntPtr native_actual = JNIEnv.NewString (actual);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (native_expected);
				__args [2] = new JniArgumentValue (native_actual);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				JNIEnv.DeleteLocalRef (native_expected);
				JNIEnv.DeleteLocalRef (native_actual);
			}
		}

		static Delegate cb_getActual;
#pragma warning disable 0169
		static Delegate GetGetActualHandler ()
		{
			if (cb_getActual == null)
				cb_getActual = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActual);
			return cb_getActual;
		}

		static IntPtr n_GetActual (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.ComparisonFailure __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.ComparisonFailure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Actual);
		}
#pragma warning restore 0169

		public virtual unsafe string Actual {
			// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='ComparisonFailure']/method[@name='getActual' and count(parameter)=0]"
			[Register ("getActual", "()Ljava/lang/String;", "GetGetActualHandler")]
			get {
				const string __id = "getActual.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExpected;
#pragma warning disable 0169
		static Delegate GetGetExpectedHandler ()
		{
			if (cb_getExpected == null)
				cb_getExpected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExpected);
			return cb_getExpected;
		}

		static IntPtr n_GetExpected (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.ComparisonFailure __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.ComparisonFailure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Expected);
		}
#pragma warning restore 0169

		public virtual unsafe string Expected {
			// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='ComparisonFailure']/method[@name='getExpected' and count(parameter)=0]"
			[Register ("getExpected", "()Ljava/lang/String;", "GetGetExpectedHandler")]
			get {
				const string __id = "getExpected.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
