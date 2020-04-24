using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.internal']/class[@name='InexactComparisonCriteria']"
	[global::Android.Runtime.Register ("org/junit/internal/InexactComparisonCriteria", DoNotGenerateAcw=true)]
	public partial class InexactComparisonCriteria : global::Org.Junit.Internal.ComparisonCriteria {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.junit.internal']/class[@name='InexactComparisonCriteria']/field[@name='fDelta']"
		[Register ("fDelta")]
		public global::Java.Lang.Object FDelta {
			get {
				const string __id = "fDelta.Ljava/lang/Object;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "fDelta.Ljava/lang/Object;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/internal/InexactComparisonCriteria", typeof (InexactComparisonCriteria));
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

		protected InexactComparisonCriteria (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.internal']/class[@name='InexactComparisonCriteria']/constructor[@name='InexactComparisonCriteria' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register (".ctor", "(D)V", "")]
		public unsafe InexactComparisonCriteria (double delta)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(D)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (delta);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.internal']/class[@name='InexactComparisonCriteria']/constructor[@name='InexactComparisonCriteria' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register (".ctor", "(F)V", "")]
		public unsafe InexactComparisonCriteria (float delta)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(F)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (delta);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
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
			global::Org.Junit.Internal.InexactComparisonCriteria __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.InexactComparisonCriteria> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object expected = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_expected, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object actual = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_actual, JniHandleOwnership.DoNotTransfer);
			__this.AssertElementsEqual (expected, actual);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal']/class[@name='InexactComparisonCriteria']/method[@name='assertElementsEqual' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
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
