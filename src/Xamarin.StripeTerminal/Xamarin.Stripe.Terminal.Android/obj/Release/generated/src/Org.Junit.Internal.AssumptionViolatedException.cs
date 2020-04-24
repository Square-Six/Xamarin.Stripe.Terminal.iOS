using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.internal']/class[@name='AssumptionViolatedException']"
	[global::Android.Runtime.Register ("org/junit/internal/AssumptionViolatedException", DoNotGenerateAcw=true)]
	public partial class AssumptionViolatedException : global::Java.Lang.RuntimeException {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/internal/AssumptionViolatedException", typeof (AssumptionViolatedException));
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

		protected AssumptionViolatedException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.internal']/class[@name='AssumptionViolatedException']/constructor[@name='AssumptionViolatedException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe AssumptionViolatedException (string assumption)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_assumption = JNIEnv.NewString (assumption);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_assumption);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_assumption);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.internal']/class[@name='AssumptionViolatedException']/constructor[@name='AssumptionViolatedException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe AssumptionViolatedException (string assumption, global::Java.Lang.Throwable e)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/Throwable;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_assumption = JNIEnv.NewString (assumption);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_assumption);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_assumption);
			}
		}

	}
}
