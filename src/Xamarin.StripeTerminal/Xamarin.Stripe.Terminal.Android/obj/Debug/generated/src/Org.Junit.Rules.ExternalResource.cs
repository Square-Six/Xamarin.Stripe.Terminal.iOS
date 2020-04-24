using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Rules {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.rules']/class[@name='ExternalResource']"
	[global::Android.Runtime.Register ("org/junit/rules/ExternalResource", DoNotGenerateAcw=true)]
	public abstract partial class ExternalResource : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/rules/ExternalResource", typeof (ExternalResource));
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

		protected ExternalResource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.rules']/class[@name='ExternalResource']/constructor[@name='ExternalResource' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ExternalResource ()
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

		static Delegate cb_after;
#pragma warning disable 0169
		static Delegate GetAfterHandler ()
		{
			if (cb_after == null)
				cb_after = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_After);
			return cb_after;
		}

		static void n_After (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Rules.ExternalResource __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.ExternalResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.After ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='ExternalResource']/method[@name='after' and count(parameter)=0]"
		[Register ("after", "()V", "GetAfterHandler")]
		protected virtual unsafe void After ()
		{
			const string __id = "after.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_before;
#pragma warning disable 0169
		static Delegate GetBeforeHandler ()
		{
			if (cb_before == null)
				cb_before = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Before);
			return cb_before;
		}

		static void n_Before (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Rules.ExternalResource __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.ExternalResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Before ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='ExternalResource']/method[@name='before' and count(parameter)=0]"
		[Register ("before", "()V", "GetBeforeHandler")]
		protected virtual unsafe void Before ()
		{
			const string __id = "before.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/junit/rules/ExternalResource", DoNotGenerateAcw=true)]
	internal partial class ExternalResourceInvoker : ExternalResource {

		public ExternalResourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/rules/ExternalResource", typeof (ExternalResourceInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
