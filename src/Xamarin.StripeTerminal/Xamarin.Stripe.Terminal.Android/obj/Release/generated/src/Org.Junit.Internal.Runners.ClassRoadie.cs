using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Internal.Runners {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='ClassRoadie']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/junit/internal/runners/ClassRoadie", DoNotGenerateAcw=true)]
	public partial class ClassRoadie : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/internal/runners/ClassRoadie", typeof (ClassRoadie));
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

		protected ClassRoadie (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Org.Junit.Internal.Runners.ClassRoadie __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.ClassRoadie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable targetException = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_targetException, JniHandleOwnership.DoNotTransfer);
			__this.AddFailure (targetException);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='ClassRoadie']/method[@name='addFailure' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("addFailure", "(Ljava/lang/Throwable;)V", "GetAddFailure_Ljava_lang_Throwable_Handler")]
		protected virtual unsafe void AddFailure (global::Java.Lang.Throwable targetException)
		{
			const string __id = "addFailure.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((targetException == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) targetException).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_runProtected;
#pragma warning disable 0169
		static Delegate GetRunProtectedHandler ()
		{
			if (cb_runProtected == null)
				cb_runProtected = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RunProtected);
			return cb_runProtected;
		}

		static void n_RunProtected (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.Runners.ClassRoadie __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.ClassRoadie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RunProtected ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='ClassRoadie']/method[@name='runProtected' and count(parameter)=0]"
		[Register ("runProtected", "()V", "GetRunProtectedHandler")]
		public virtual unsafe void RunProtected ()
		{
			const string __id = "runProtected.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_runUnprotected;
#pragma warning disable 0169
		static Delegate GetRunUnprotectedHandler ()
		{
			if (cb_runUnprotected == null)
				cb_runUnprotected = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RunUnprotected);
			return cb_runUnprotected;
		}

		static void n_RunUnprotected (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.Runners.ClassRoadie __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.ClassRoadie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RunUnprotected ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='ClassRoadie']/method[@name='runUnprotected' and count(parameter)=0]"
		[Register ("runUnprotected", "()V", "GetRunUnprotectedHandler")]
		protected virtual unsafe void RunUnprotected ()
		{
			const string __id = "runUnprotected.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
