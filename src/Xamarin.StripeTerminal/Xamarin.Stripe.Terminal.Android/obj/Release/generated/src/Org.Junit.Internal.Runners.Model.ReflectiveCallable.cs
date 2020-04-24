using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Internal.Runners.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.internal.runners.model']/class[@name='ReflectiveCallable']"
	[global::Android.Runtime.Register ("org/junit/internal/runners/model/ReflectiveCallable", DoNotGenerateAcw=true)]
	public abstract partial class ReflectiveCallable : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/internal/runners/model/ReflectiveCallable", typeof (ReflectiveCallable));
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

		protected ReflectiveCallable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.internal.runners.model']/class[@name='ReflectiveCallable']/constructor[@name='ReflectiveCallable' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ReflectiveCallable ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static IntPtr n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.Runners.Model.ReflectiveCallable __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.Model.ReflectiveCallable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Run ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners.model']/class[@name='ReflectiveCallable']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()Ljava/lang/Object;", "GetRunHandler")]
		public virtual unsafe global::Java.Lang.Object Run ()
		{
			const string __id = "run.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_runReflectiveCall;
#pragma warning disable 0169
		static Delegate GetRunReflectiveCallHandler ()
		{
			if (cb_runReflectiveCall == null)
				cb_runReflectiveCall = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RunReflectiveCall);
			return cb_runReflectiveCall;
		}

		static IntPtr n_RunReflectiveCall (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.Runners.Model.ReflectiveCallable __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.Model.ReflectiveCallable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RunReflectiveCall ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners.model']/class[@name='ReflectiveCallable']/method[@name='runReflectiveCall' and count(parameter)=0]"
		[Register ("runReflectiveCall", "()Ljava/lang/Object;", "GetRunReflectiveCallHandler")]
		protected abstract global::Java.Lang.Object RunReflectiveCall ();

	}

	[global::Android.Runtime.Register ("org/junit/internal/runners/model/ReflectiveCallable", DoNotGenerateAcw=true)]
	internal partial class ReflectiveCallableInvoker : ReflectiveCallable {

		public ReflectiveCallableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/internal/runners/model/ReflectiveCallable", typeof (ReflectiveCallableInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners.model']/class[@name='ReflectiveCallable']/method[@name='runReflectiveCall' and count(parameter)=0]"
		[Register ("runReflectiveCall", "()Ljava/lang/Object;", "GetRunReflectiveCallHandler")]
		protected override unsafe global::Java.Lang.Object RunReflectiveCall ()
		{
			const string __id = "runReflectiveCall.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
