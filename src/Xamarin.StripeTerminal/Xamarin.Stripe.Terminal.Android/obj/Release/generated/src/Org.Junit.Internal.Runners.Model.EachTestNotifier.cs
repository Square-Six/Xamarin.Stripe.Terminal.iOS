using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Internal.Runners.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.internal.runners.model']/class[@name='EachTestNotifier']"
	[global::Android.Runtime.Register ("org/junit/internal/runners/model/EachTestNotifier", DoNotGenerateAcw=true)]
	public partial class EachTestNotifier : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/internal/runners/model/EachTestNotifier", typeof (EachTestNotifier));
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

		protected EachTestNotifier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_addFailedAssumption_Lorg_junit_internal_AssumptionViolatedException_;
#pragma warning disable 0169
		static Delegate GetAddFailedAssumption_Lorg_junit_internal_AssumptionViolatedException_Handler ()
		{
			if (cb_addFailedAssumption_Lorg_junit_internal_AssumptionViolatedException_ == null)
				cb_addFailedAssumption_Lorg_junit_internal_AssumptionViolatedException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddFailedAssumption_Lorg_junit_internal_AssumptionViolatedException_);
			return cb_addFailedAssumption_Lorg_junit_internal_AssumptionViolatedException_;
		}

		static void n_AddFailedAssumption_Lorg_junit_internal_AssumptionViolatedException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Org.Junit.Internal.Runners.Model.EachTestNotifier __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.Model.EachTestNotifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Junit.Internal.AssumptionViolatedException e = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.AssumptionViolatedException> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.AddFailedAssumption (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners.model']/class[@name='EachTestNotifier']/method[@name='addFailedAssumption' and count(parameter)=1 and parameter[1][@type='org.junit.internal.AssumptionViolatedException']]"
		[Register ("addFailedAssumption", "(Lorg/junit/internal/AssumptionViolatedException;)V", "GetAddFailedAssumption_Lorg_junit_internal_AssumptionViolatedException_Handler")]
		public virtual unsafe void AddFailedAssumption (global::Org.Junit.Internal.AssumptionViolatedException e)
		{
			const string __id = "addFailedAssumption.(Lorg/junit/internal/AssumptionViolatedException;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addFailure_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetAddFailure_Ljava_lang_Throwable_Handler ()
		{
			if (cb_addFailure_Ljava_lang_Throwable_ == null)
				cb_addFailure_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddFailure_Ljava_lang_Throwable_);
			return cb_addFailure_Ljava_lang_Throwable_;
		}

		static void n_AddFailure_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_targetException)
		{
			global::Org.Junit.Internal.Runners.Model.EachTestNotifier __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.Model.EachTestNotifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable targetException = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_targetException, JniHandleOwnership.DoNotTransfer);
			__this.AddFailure (targetException);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners.model']/class[@name='EachTestNotifier']/method[@name='addFailure' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("addFailure", "(Ljava/lang/Throwable;)V", "GetAddFailure_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void AddFailure (global::Java.Lang.Throwable targetException)
		{
			const string __id = "addFailure.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((targetException == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) targetException).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_fireTestFinished;
#pragma warning disable 0169
		static Delegate GetFireTestFinishedHandler ()
		{
			if (cb_fireTestFinished == null)
				cb_fireTestFinished = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FireTestFinished);
			return cb_fireTestFinished;
		}

		static void n_FireTestFinished (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.Runners.Model.EachTestNotifier __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.Model.EachTestNotifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FireTestFinished ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners.model']/class[@name='EachTestNotifier']/method[@name='fireTestFinished' and count(parameter)=0]"
		[Register ("fireTestFinished", "()V", "GetFireTestFinishedHandler")]
		public virtual unsafe void FireTestFinished ()
		{
			const string __id = "fireTestFinished.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_fireTestIgnored;
#pragma warning disable 0169
		static Delegate GetFireTestIgnoredHandler ()
		{
			if (cb_fireTestIgnored == null)
				cb_fireTestIgnored = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FireTestIgnored);
			return cb_fireTestIgnored;
		}

		static void n_FireTestIgnored (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.Runners.Model.EachTestNotifier __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.Model.EachTestNotifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FireTestIgnored ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners.model']/class[@name='EachTestNotifier']/method[@name='fireTestIgnored' and count(parameter)=0]"
		[Register ("fireTestIgnored", "()V", "GetFireTestIgnoredHandler")]
		public virtual unsafe void FireTestIgnored ()
		{
			const string __id = "fireTestIgnored.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_fireTestStarted;
#pragma warning disable 0169
		static Delegate GetFireTestStartedHandler ()
		{
			if (cb_fireTestStarted == null)
				cb_fireTestStarted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FireTestStarted);
			return cb_fireTestStarted;
		}

		static void n_FireTestStarted (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.Runners.Model.EachTestNotifier __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.Model.EachTestNotifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FireTestStarted ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners.model']/class[@name='EachTestNotifier']/method[@name='fireTestStarted' and count(parameter)=0]"
		[Register ("fireTestStarted", "()V", "GetFireTestStartedHandler")]
		public virtual unsafe void FireTestStarted ()
		{
			const string __id = "fireTestStarted.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
