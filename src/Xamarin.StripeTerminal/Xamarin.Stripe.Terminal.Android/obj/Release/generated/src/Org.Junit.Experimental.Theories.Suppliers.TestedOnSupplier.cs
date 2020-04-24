using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Experimental.Theories.Suppliers {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.experimental.theories.suppliers']/class[@name='TestedOnSupplier']"
	[global::Android.Runtime.Register ("org/junit/experimental/theories/suppliers/TestedOnSupplier", DoNotGenerateAcw=true)]
	public partial class TestedOnSupplier : global::Org.Junit.Experimental.Theories.ParameterSupplier {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/experimental/theories/suppliers/TestedOnSupplier", typeof (TestedOnSupplier));
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

		protected TestedOnSupplier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.experimental.theories.suppliers']/class[@name='TestedOnSupplier']/constructor[@name='TestedOnSupplier' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TestedOnSupplier ()
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

		static Delegate cb_getValueSources_Lorg_junit_experimental_theories_ParameterSignature_;
#pragma warning disable 0169
		static Delegate GetGetValueSources_Lorg_junit_experimental_theories_ParameterSignature_Handler ()
		{
			if (cb_getValueSources_Lorg_junit_experimental_theories_ParameterSignature_ == null)
				cb_getValueSources_Lorg_junit_experimental_theories_ParameterSignature_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetValueSources_Lorg_junit_experimental_theories_ParameterSignature_);
			return cb_getValueSources_Lorg_junit_experimental_theories_ParameterSignature_;
		}

		static IntPtr n_GetValueSources_Lorg_junit_experimental_theories_ParameterSignature_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sig)
		{
			global::Org.Junit.Experimental.Theories.Suppliers.TestedOnSupplier __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.Suppliers.TestedOnSupplier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Junit.Experimental.Theories.ParameterSignature sig = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.ParameterSignature> (native_sig, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Junit.Experimental.Theories.PotentialAssignment>.ToLocalJniHandle (__this.GetValueSources (sig));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories.suppliers']/class[@name='TestedOnSupplier']/method[@name='getValueSources' and count(parameter)=1 and parameter[1][@type='org.junit.experimental.theories.ParameterSignature']]"
		[Register ("getValueSources", "(Lorg/junit/experimental/theories/ParameterSignature;)Ljava/util/List;", "GetGetValueSources_Lorg_junit_experimental_theories_ParameterSignature_Handler")]
		public override unsafe global::System.Collections.Generic.IList<global::Org.Junit.Experimental.Theories.PotentialAssignment> GetValueSources (global::Org.Junit.Experimental.Theories.ParameterSignature sig)
		{
			const string __id = "getValueSources.(Lorg/junit/experimental/theories/ParameterSignature;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sig).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Org.Junit.Experimental.Theories.PotentialAssignment>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
