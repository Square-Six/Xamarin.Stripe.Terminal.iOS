using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.internal']/class[@name='ArrayComparisonFailure']"
	[global::Android.Runtime.Register ("org/junit/internal/ArrayComparisonFailure", DoNotGenerateAcw=true)]
	public partial class ArrayComparisonFailure : global::Java.Lang.AssertionError {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/internal/ArrayComparisonFailure", typeof (ArrayComparisonFailure));
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

		protected ArrayComparisonFailure (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.internal']/class[@name='ArrayComparisonFailure']/constructor[@name='ArrayComparisonFailure' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.AssertionError'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/AssertionError;I)V", "")]
		public unsafe ArrayComparisonFailure (string message, global::Java.Lang.AssertionError cause, int index)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/AssertionError;I)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
				__args [2] = new JniArgumentValue (index);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_addDimension_I;
#pragma warning disable 0169
		static Delegate GetAddDimension_IHandler ()
		{
			if (cb_addDimension_I == null)
				cb_addDimension_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_AddDimension_I);
			return cb_addDimension_I;
		}

		static void n_AddDimension_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Org.Junit.Internal.ArrayComparisonFailure __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.ArrayComparisonFailure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddDimension (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal']/class[@name='ArrayComparisonFailure']/method[@name='addDimension' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("addDimension", "(I)V", "GetAddDimension_IHandler")]
		public virtual unsafe void AddDimension (int index)
		{
			const string __id = "addDimension.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.ArrayComparisonFailure __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.ArrayComparisonFailure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal']/class[@name='ArrayComparisonFailure']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "GetToStringHandler")]
		public override unsafe string ToString ()
		{
			const string __id = "toString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
