using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Rules {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.rules']/class[@name='ErrorCollector']"
	[global::Android.Runtime.Register ("org/junit/rules/ErrorCollector", DoNotGenerateAcw=true)]
	public partial class ErrorCollector : global::Org.Junit.Rules.Verifier {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/rules/ErrorCollector", typeof (ErrorCollector));
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

		protected ErrorCollector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.rules']/class[@name='ErrorCollector']/constructor[@name='ErrorCollector' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ErrorCollector ()
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

		static Delegate cb_addError_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetAddError_Ljava_lang_Throwable_Handler ()
		{
			if (cb_addError_Ljava_lang_Throwable_ == null)
				cb_addError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddError_Ljava_lang_Throwable_);
			return cb_addError_Ljava_lang_Throwable_;
		}

		static void n_AddError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_error)
		{
			global::Org.Junit.Rules.ErrorCollector __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.ErrorCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable error = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.AddError (error);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='ErrorCollector']/method[@name='addError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("addError", "(Ljava/lang/Throwable;)V", "GetAddError_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void AddError (global::Java.Lang.Throwable error)
		{
			const string __id = "addError.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) error).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_checkSucceeds_Ljava_util_concurrent_Callable_;
#pragma warning disable 0169
		static Delegate GetCheckSucceeds_Ljava_util_concurrent_Callable_Handler ()
		{
			if (cb_checkSucceeds_Ljava_util_concurrent_Callable_ == null)
				cb_checkSucceeds_Ljava_util_concurrent_Callable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckSucceeds_Ljava_util_concurrent_Callable_);
			return cb_checkSucceeds_Ljava_util_concurrent_Callable_;
		}

		static IntPtr n_CheckSucceeds_Ljava_util_concurrent_Callable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_callable)
		{
			global::Org.Junit.Rules.ErrorCollector __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.ErrorCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.ICallable callable = (global::Java.Util.Concurrent.ICallable)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ICallable> (native_callable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CheckSucceeds (callable));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='ErrorCollector']/method[@name='checkSucceeds' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;T&gt;']]"
		[Register ("checkSucceeds", "(Ljava/util/concurrent/Callable;)Ljava/lang/Object;", "GetCheckSucceeds_Ljava_util_concurrent_Callable_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Java.Lang.Object CheckSucceeds (global::Java.Util.Concurrent.ICallable callable)
		{
			const string __id = "checkSucceeds.(Ljava/util/concurrent/Callable;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((callable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callable).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
