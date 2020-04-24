using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.internal']/class[@name='ExactComparisonCriteria']"
	[global::Android.Runtime.Register ("org/junit/internal/ExactComparisonCriteria", DoNotGenerateAcw=true)]
	public partial class ExactComparisonCriteria : global::Org.Junit.Internal.ComparisonCriteria {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/internal/ExactComparisonCriteria", typeof (ExactComparisonCriteria));
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

		protected ExactComparisonCriteria (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.internal']/class[@name='ExactComparisonCriteria']/constructor[@name='ExactComparisonCriteria' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ExactComparisonCriteria ()
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

		static Delegate cb_assertElementsEqual_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAssertElementsEqual_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_assertElementsEqual_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_assertElementsEqual_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AssertElementsEqual_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_assertElementsEqual_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_AssertElementsEqual_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_expected, IntPtr native_actual)
		{
			global::Org.Junit.Internal.ExactComparisonCriteria __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.ExactComparisonCriteria> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object expected = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_expected, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object actual = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_actual, JniHandleOwnership.DoNotTransfer);
			__this.AssertElementsEqual (expected, actual);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal']/class[@name='ExactComparisonCriteria']/method[@name='assertElementsEqual' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("assertElementsEqual", "(Ljava/lang/Object;Ljava/lang/Object;)V", "GetAssertElementsEqual_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		protected override unsafe void AssertElementsEqual (global::Java.Lang.Object expected, global::Java.Lang.Object actual)
		{
			const string __id = "assertElementsEqual.(Ljava/lang/Object;Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((expected == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expected).Handle);
				__args [1] = new JniArgumentValue ((actual == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actual).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
