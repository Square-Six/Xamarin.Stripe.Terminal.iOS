using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Androidx.Lifecycle {

	// Metadata.xml XPath class reference: path="/api/package[@name='androidx.lifecycle']/class[@name='ComputableLiveData']"
	[global::Android.Runtime.Register ("androidx/lifecycle/ComputableLiveData", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class ComputableLiveData : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("androidx/lifecycle/ComputableLiveData", typeof (ComputableLiveData));
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

		protected ComputableLiveData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='androidx.lifecycle']/class[@name='ComputableLiveData']/constructor[@name='ComputableLiveData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ComputableLiveData ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='androidx.lifecycle']/class[@name='ComputableLiveData']/constructor[@name='ComputableLiveData' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Executor']]"
		[Register (".ctor", "(Ljava/util/concurrent/Executor;)V", "")]
		public unsafe ComputableLiveData (global::Java.Util.Concurrent.IExecutor executor)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/concurrent/Executor;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((executor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executor).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_compute;
#pragma warning disable 0169
		static Delegate GetComputeHandler ()
		{
			if (cb_compute == null)
				cb_compute = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Compute);
			return cb_compute;
		}

		static IntPtr n_Compute (IntPtr jnienv, IntPtr native__this)
		{
			global::Androidx.Lifecycle.ComputableLiveData __this = global::Java.Lang.Object.GetObject<global::Androidx.Lifecycle.ComputableLiveData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Compute ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='androidx.lifecycle']/class[@name='ComputableLiveData']/method[@name='compute' and count(parameter)=0]"
		[Register ("compute", "()Ljava/lang/Object;", "GetComputeHandler")]
		protected abstract global::Java.Lang.Object Compute ();

		static Delegate cb_invalidate;
#pragma warning disable 0169
		static Delegate GetInvalidateHandler ()
		{
			if (cb_invalidate == null)
				cb_invalidate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Invalidate);
			return cb_invalidate;
		}

		static void n_Invalidate (IntPtr jnienv, IntPtr native__this)
		{
			global::Androidx.Lifecycle.ComputableLiveData __this = global::Java.Lang.Object.GetObject<global::Androidx.Lifecycle.ComputableLiveData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Invalidate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='androidx.lifecycle']/class[@name='ComputableLiveData']/method[@name='invalidate' and count(parameter)=0]"
		[Register ("invalidate", "()V", "GetInvalidateHandler")]
		public virtual unsafe void Invalidate ()
		{
			const string __id = "invalidate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("androidx/lifecycle/ComputableLiveData", DoNotGenerateAcw=true)]
	internal partial class ComputableLiveDataInvoker : ComputableLiveData {

		public ComputableLiveDataInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("androidx/lifecycle/ComputableLiveData", typeof (ComputableLiveDataInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='androidx.lifecycle']/class[@name='ComputableLiveData']/method[@name='compute' and count(parameter)=0]"
		[Register ("compute", "()Ljava/lang/Object;", "GetComputeHandler")]
		protected override unsafe global::Java.Lang.Object Compute ()
		{
			const string __id = "compute.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
