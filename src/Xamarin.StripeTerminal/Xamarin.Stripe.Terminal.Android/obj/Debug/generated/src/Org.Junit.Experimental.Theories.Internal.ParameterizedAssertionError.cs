using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Experimental.Theories.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.experimental.theories.internal']/class[@name='ParameterizedAssertionError']"
	[global::Android.Runtime.Register ("org/junit/experimental/theories/internal/ParameterizedAssertionError", DoNotGenerateAcw=true)]
	public partial class ParameterizedAssertionError : global::Java.Lang.AssertionError {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/experimental/theories/internal/ParameterizedAssertionError", typeof (ParameterizedAssertionError));
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

		protected ParameterizedAssertionError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.experimental.theories.internal']/class[@name='ParameterizedAssertionError']/constructor[@name='ParameterizedAssertionError' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register (".ctor", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public unsafe ParameterizedAssertionError (global::Java.Lang.Throwable targetException, string methodName, params global::Java.Lang.Object[] @params)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native__params = JNIEnv.NewArray (@params);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((targetException == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) targetException).Handle);
				__args [1] = new JniArgumentValue (native_methodName);
				__args [2] = new JniArgumentValue (native__params);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (@params != null) {
					JNIEnv.CopyArray (native__params, @params);
					JNIEnv.DeleteLocalRef (native__params);
				}
			}
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			global::Org.Junit.Experimental.Theories.Internal.ParameterizedAssertionError __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.Internal.ParameterizedAssertionError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (obj);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories.internal']/class[@name='ParameterizedAssertionError']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "GetEquals_Ljava_lang_Object_Handler")]
		public new virtual unsafe bool Equals (global::Java.Lang.Object obj)
		{
			const string __id = "equals.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Experimental.Theories.Internal.ParameterizedAssertionError __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.Internal.ParameterizedAssertionError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories.internal']/class[@name='ParameterizedAssertionError']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "GetGetHashCodeHandler")]
		public override unsafe int GetHashCode ()
		{
			const string __id = "hashCode.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories.internal']/class[@name='ParameterizedAssertionError']/method[@name='join' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("join", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string Join (string delimiter, params global::Java.Lang.Object[] @params)
		{
			const string __id = "join.(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;";
			IntPtr native_delimiter = JNIEnv.NewString (delimiter);
			IntPtr native__params = JNIEnv.NewArray (@params);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_delimiter);
				__args [1] = new JniArgumentValue (native__params);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_delimiter);
				if (@params != null) {
					JNIEnv.CopyArray (native__params, @params);
					JNIEnv.DeleteLocalRef (native__params);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories.internal']/class[@name='ParameterizedAssertionError']/method[@name='join' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Collection&lt;java.lang.Object&gt;']]"
		[Register ("join", "(Ljava/lang/String;Ljava/util/Collection;)Ljava/lang/String;", "")]
		public static unsafe string Join (string delimiter, global::System.Collections.Generic.ICollection<global::Java.Lang.Object> values)
		{
			const string __id = "join.(Ljava/lang/String;Ljava/util/Collection;)Ljava/lang/String;";
			IntPtr native_delimiter = JNIEnv.NewString (delimiter);
			IntPtr native_values = global::Android.Runtime.JavaCollection<global::Java.Lang.Object>.ToLocalJniHandle (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_delimiter);
				__args [1] = new JniArgumentValue (native_values);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_delimiter);
				JNIEnv.DeleteLocalRef (native_values);
			}
		}

	}
}
