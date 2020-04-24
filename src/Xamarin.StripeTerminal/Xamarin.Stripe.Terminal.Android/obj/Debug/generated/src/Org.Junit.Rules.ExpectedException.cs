using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Rules {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.rules']/class[@name='ExpectedException']"
	[global::Android.Runtime.Register ("org/junit/rules/ExpectedException", DoNotGenerateAcw=true)]
	public partial class ExpectedException : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/rules/ExpectedException", typeof (ExpectedException));
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

		protected ExpectedException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_expect_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetExpect_Ljava_lang_Class_Handler ()
		{
			if (cb_expect_Ljava_lang_Class_ == null)
				cb_expect_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Expect_Ljava_lang_Class_);
			return cb_expect_Ljava_lang_Class_;
		}

		static void n_Expect_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			global::Org.Junit.Rules.ExpectedException __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.ExpectedException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class type = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_type, JniHandleOwnership.DoNotTransfer);
			__this.Expect (type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='ExpectedException']/method[@name='expect' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends java.lang.Throwable&gt;']]"
		[Register ("expect", "(Ljava/lang/Class;)V", "GetExpect_Ljava_lang_Class_Handler")]
		public virtual unsafe void Expect (global::Java.Lang.Class type)
		{
			const string __id = "expect.(Ljava/lang/Class;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_expectMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetExpectMessage_Ljava_lang_String_Handler ()
		{
			if (cb_expectMessage_Ljava_lang_String_ == null)
				cb_expectMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ExpectMessage_Ljava_lang_String_);
			return cb_expectMessage_Ljava_lang_String_;
		}

		static void n_ExpectMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_substring)
		{
			global::Org.Junit.Rules.ExpectedException __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.ExpectedException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string substring = JNIEnv.GetString (native_substring, JniHandleOwnership.DoNotTransfer);
			__this.ExpectMessage (substring);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='ExpectedException']/method[@name='expectMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("expectMessage", "(Ljava/lang/String;)V", "GetExpectMessage_Ljava_lang_String_Handler")]
		public virtual unsafe void ExpectMessage (string substring)
		{
			const string __id = "expectMessage.(Ljava/lang/String;)V";
			IntPtr native_substring = JNIEnv.NewString (substring);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_substring);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_substring);
			}
		}

		static Delegate cb_handleAssertionErrors;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetHandleAssertionErrorsHandler ()
		{
			if (cb_handleAssertionErrors == null)
				cb_handleAssertionErrors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_HandleAssertionErrors);
			return cb_handleAssertionErrors;
		}

		[Obsolete]
		static IntPtr n_HandleAssertionErrors (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Rules.ExpectedException __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.ExpectedException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HandleAssertionErrors ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='ExpectedException']/method[@name='handleAssertionErrors' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("handleAssertionErrors", "()Lorg/junit/rules/ExpectedException;", "GetHandleAssertionErrorsHandler")]
		public virtual unsafe global::Org.Junit.Rules.ExpectedException HandleAssertionErrors ()
		{
			const string __id = "handleAssertionErrors.()Lorg/junit/rules/ExpectedException;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.ExpectedException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_handleAssumptionViolatedExceptions;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetHandleAssumptionViolatedExceptionsHandler ()
		{
			if (cb_handleAssumptionViolatedExceptions == null)
				cb_handleAssumptionViolatedExceptions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_HandleAssumptionViolatedExceptions);
			return cb_handleAssumptionViolatedExceptions;
		}

		[Obsolete]
		static IntPtr n_HandleAssumptionViolatedExceptions (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Rules.ExpectedException __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.ExpectedException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HandleAssumptionViolatedExceptions ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='ExpectedException']/method[@name='handleAssumptionViolatedExceptions' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("handleAssumptionViolatedExceptions", "()Lorg/junit/rules/ExpectedException;", "GetHandleAssumptionViolatedExceptionsHandler")]
		public virtual unsafe global::Org.Junit.Rules.ExpectedException HandleAssumptionViolatedExceptions ()
		{
			const string __id = "handleAssumptionViolatedExceptions.()Lorg/junit/rules/ExpectedException;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.ExpectedException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='ExpectedException']/method[@name='none' and count(parameter)=0]"
		[Register ("none", "()Lorg/junit/rules/ExpectedException;", "")]
		public static unsafe global::Org.Junit.Rules.ExpectedException None ()
		{
			const string __id = "none.()Lorg/junit/rules/ExpectedException;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.ExpectedException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_reportMissingExceptionWithMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReportMissingExceptionWithMessage_Ljava_lang_String_Handler ()
		{
			if (cb_reportMissingExceptionWithMessage_Ljava_lang_String_ == null)
				cb_reportMissingExceptionWithMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReportMissingExceptionWithMessage_Ljava_lang_String_);
			return cb_reportMissingExceptionWithMessage_Ljava_lang_String_;
		}

		static IntPtr n_ReportMissingExceptionWithMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			global::Org.Junit.Rules.ExpectedException __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.ExpectedException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReportMissingExceptionWithMessage (message));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='ExpectedException']/method[@name='reportMissingExceptionWithMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("reportMissingExceptionWithMessage", "(Ljava/lang/String;)Lorg/junit/rules/ExpectedException;", "GetReportMissingExceptionWithMessage_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Junit.Rules.ExpectedException ReportMissingExceptionWithMessage (string message)
		{
			const string __id = "reportMissingExceptionWithMessage.(Ljava/lang/String;)Lorg/junit/rules/ExpectedException;";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.ExpectedException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

	}
}
