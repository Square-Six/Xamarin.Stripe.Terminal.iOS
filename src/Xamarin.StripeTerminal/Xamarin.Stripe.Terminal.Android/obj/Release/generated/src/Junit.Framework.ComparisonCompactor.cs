using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Junit.Framework {

	// Metadata.xml XPath class reference: path="/api/package[@name='junit.framework']/class[@name='ComparisonCompactor']"
	[global::Android.Runtime.Register ("junit/framework/ComparisonCompactor", DoNotGenerateAcw=true)]
	public partial class ComparisonCompactor : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("junit/framework/ComparisonCompactor", typeof (ComparisonCompactor));
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

		protected ComparisonCompactor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.framework']/class[@name='ComparisonCompactor']/constructor[@name='ComparisonCompactor' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe ComparisonCompactor (int contextLength, string expected, string actual)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_expected = JNIEnv.NewString (expected);
			IntPtr native_actual = JNIEnv.NewString (actual);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (contextLength);
				__args [1] = new JniArgumentValue (native_expected);
				__args [2] = new JniArgumentValue (native_actual);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_expected);
				JNIEnv.DeleteLocalRef (native_actual);
			}
		}

		static Delegate cb_compact_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCompact_Ljava_lang_String_Handler ()
		{
			if (cb_compact_Ljava_lang_String_ == null)
				cb_compact_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Compact_Ljava_lang_String_);
			return cb_compact_Ljava_lang_String_;
		}

		static IntPtr n_Compact_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			global::Junit.Framework.ComparisonCompactor __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.ComparisonCompactor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Compact (message));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='ComparisonCompactor']/method[@name='compact' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("compact", "(Ljava/lang/String;)Ljava/lang/String;", "GetCompact_Ljava_lang_String_Handler")]
		public virtual unsafe string Compact (string message)
		{
			const string __id = "compact.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

	}
}
