using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Experimental.Theories {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='ParameterSupplier']"
	[global::Android.Runtime.Register ("org/junit/experimental/theories/ParameterSupplier", DoNotGenerateAcw=true)]
	public abstract partial class ParameterSupplier : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/experimental/theories/ParameterSupplier", typeof (ParameterSupplier));
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

		protected ParameterSupplier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='ParameterSupplier']/constructor[@name='ParameterSupplier' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ParameterSupplier ()
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

		static IntPtr n_GetValueSources_Lorg_junit_experimental_theories_ParameterSignature_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Junit.Experimental.Theories.ParameterSupplier __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.ParameterSupplier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Junit.Experimental.Theories.ParameterSignature p0 = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.ParameterSignature> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Junit.Experimental.Theories.PotentialAssignment>.ToLocalJniHandle (__this.GetValueSources (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='ParameterSupplier']/method[@name='getValueSources' and count(parameter)=1 and parameter[1][@type='org.junit.experimental.theories.ParameterSignature']]"
		[Register ("getValueSources", "(Lorg/junit/experimental/theories/ParameterSignature;)Ljava/util/List;", "GetGetValueSources_Lorg_junit_experimental_theories_ParameterSignature_Handler")]
		public abstract global::System.Collections.Generic.IList<global::Org.Junit.Experimental.Theories.PotentialAssignment> GetValueSources (global::Org.Junit.Experimental.Theories.ParameterSignature p0);

	}

	[global::Android.Runtime.Register ("org/junit/experimental/theories/ParameterSupplier", DoNotGenerateAcw=true)]
	internal partial class ParameterSupplierInvoker : ParameterSupplier {

		public ParameterSupplierInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/experimental/theories/ParameterSupplier", typeof (ParameterSupplierInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='ParameterSupplier']/method[@name='getValueSources' and count(parameter)=1 and parameter[1][@type='org.junit.experimental.theories.ParameterSignature']]"
		[Register ("getValueSources", "(Lorg/junit/experimental/theories/ParameterSignature;)Ljava/util/List;", "GetGetValueSources_Lorg_junit_experimental_theories_ParameterSignature_Handler")]
		public override unsafe global::System.Collections.Generic.IList<global::Org.Junit.Experimental.Theories.PotentialAssignment> GetValueSources (global::Org.Junit.Experimental.Theories.ParameterSignature p0)
		{
			const string __id = "getValueSources.(Lorg/junit/experimental/theories/ParameterSignature;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Org.Junit.Experimental.Theories.PotentialAssignment>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
