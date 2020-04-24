using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.internal']/class[@name='ComparisonCriteria']"
	[global::Android.Runtime.Register ("org/junit/internal/ComparisonCriteria", DoNotGenerateAcw=true)]
	public abstract partial class ComparisonCriteria : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/internal/ComparisonCriteria", typeof (ComparisonCriteria));
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

		protected ComparisonCriteria (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.internal']/class[@name='ComparisonCriteria']/constructor[@name='ComparisonCriteria' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ComparisonCriteria ()
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

		static Delegate cb_arrayEquals_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetArrayEquals_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_arrayEquals_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_arrayEquals_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ArrayEquals_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_arrayEquals_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_ArrayEquals_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message, IntPtr native_expecteds, IntPtr native_actuals)
		{
			global::Org.Junit.Internal.ComparisonCriteria __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.ComparisonCriteria> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object expecteds = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_expecteds, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object actuals = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_actuals, JniHandleOwnership.DoNotTransfer);
			__this.ArrayEquals (message, expecteds, actuals);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal']/class[@name='ComparisonCriteria']/method[@name='arrayEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("arrayEquals", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "GetArrayEquals_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe void ArrayEquals (string message, global::Java.Lang.Object expecteds, global::Java.Lang.Object actuals)
		{
			const string __id = "arrayEquals.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((expecteds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expecteds).Handle);
				__args [2] = new JniArgumentValue ((actuals == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actuals).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_assertElementsEqual_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAssertElementsEqual_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_assertElementsEqual_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_assertElementsEqual_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AssertElementsEqual_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_assertElementsEqual_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_AssertElementsEqual_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Junit.Internal.ComparisonCriteria __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.ComparisonCriteria> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AssertElementsEqual (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal']/class[@name='ComparisonCriteria']/method[@name='assertElementsEqual' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("assertElementsEqual", "(Ljava/lang/Object;Ljava/lang/Object;)V", "GetAssertElementsEqual_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		protected abstract void AssertElementsEqual (global::Java.Lang.Object p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("org/junit/internal/ComparisonCriteria", DoNotGenerateAcw=true)]
	internal partial class ComparisonCriteriaInvoker : ComparisonCriteria {

		public ComparisonCriteriaInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/internal/ComparisonCriteria", typeof (ComparisonCriteriaInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal']/class[@name='ComparisonCriteria']/method[@name='assertElementsEqual' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("assertElementsEqual", "(Ljava/lang/Object;Ljava/lang/Object;)V", "GetAssertElementsEqual_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		protected override unsafe void AssertElementsEqual (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			const string __id = "assertElementsEqual.(Ljava/lang/Object;Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
