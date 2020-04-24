using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Experimental.Theories.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.experimental.theories.internal']/class[@name='AllMembersSupplier']"
	[global::Android.Runtime.Register ("org/junit/experimental/theories/internal/AllMembersSupplier", DoNotGenerateAcw=true)]
	public partial class AllMembersSupplier : global::Org.Junit.Experimental.Theories.ParameterSupplier {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.experimental.theories.internal']/class[@name='AllMembersSupplier.MethodParameterValue']"
		[global::Android.Runtime.Register ("org/junit/experimental/theories/internal/AllMembersSupplier$MethodParameterValue", DoNotGenerateAcw=true)]
		public partial class MethodParameterValue : global::Org.Junit.Experimental.Theories.PotentialAssignment {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/experimental/theories/internal/AllMembersSupplier$MethodParameterValue", typeof (MethodParameterValue));
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

			protected MethodParameterValue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getDescription;
#pragma warning disable 0169
			static Delegate GetGetDescriptionHandler ()
			{
				if (cb_getDescription == null)
					cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
				return cb_getDescription;
			}

			static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Junit.Experimental.Theories.Internal.AllMembersSupplier.MethodParameterValue __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.Internal.AllMembersSupplier.MethodParameterValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Description);
			}
#pragma warning restore 0169

			public override unsafe string Description {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories.internal']/class[@name='AllMembersSupplier.MethodParameterValue']/method[@name='getDescription' and count(parameter)=0]"
				[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
				get {
					const string __id = "getDescription.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getValue;
#pragma warning disable 0169
			static Delegate GetGetValueHandler ()
			{
				if (cb_getValue == null)
					cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
				return cb_getValue;
			}

			static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Junit.Experimental.Theories.Internal.AllMembersSupplier.MethodParameterValue __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.Internal.AllMembersSupplier.MethodParameterValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Value);
			}
#pragma warning restore 0169

			public override unsafe global::Java.Lang.Object Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories.internal']/class[@name='AllMembersSupplier.MethodParameterValue']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Ljava/lang/Object;", "GetGetValueHandler")]
				get {
					const string __id = "getValue.()Ljava/lang/Object;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/experimental/theories/internal/AllMembersSupplier", typeof (AllMembersSupplier));
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

		protected AllMembersSupplier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getDataPointsFields_Lorg_junit_experimental_theories_ParameterSignature_;
#pragma warning disable 0169
		static Delegate GetGetDataPointsFields_Lorg_junit_experimental_theories_ParameterSignature_Handler ()
		{
			if (cb_getDataPointsFields_Lorg_junit_experimental_theories_ParameterSignature_ == null)
				cb_getDataPointsFields_Lorg_junit_experimental_theories_ParameterSignature_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDataPointsFields_Lorg_junit_experimental_theories_ParameterSignature_);
			return cb_getDataPointsFields_Lorg_junit_experimental_theories_ParameterSignature_;
		}

		static IntPtr n_GetDataPointsFields_Lorg_junit_experimental_theories_ParameterSignature_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sig)
		{
			global::Org.Junit.Experimental.Theories.Internal.AllMembersSupplier __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.Internal.AllMembersSupplier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Junit.Experimental.Theories.ParameterSignature sig = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.ParameterSignature> (native_sig, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaCollection<global::Java.Lang.Reflect.Field>.ToLocalJniHandle (__this.GetDataPointsFields (sig));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories.internal']/class[@name='AllMembersSupplier']/method[@name='getDataPointsFields' and count(parameter)=1 and parameter[1][@type='org.junit.experimental.theories.ParameterSignature']]"
		[Register ("getDataPointsFields", "(Lorg/junit/experimental/theories/ParameterSignature;)Ljava/util/Collection;", "GetGetDataPointsFields_Lorg_junit_experimental_theories_ParameterSignature_Handler")]
		protected virtual unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.Reflect.Field> GetDataPointsFields (global::Org.Junit.Experimental.Theories.ParameterSignature sig)
		{
			const string __id = "getDataPointsFields.(Lorg/junit/experimental/theories/ParameterSignature;)Ljava/util/Collection;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sig).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaCollection<global::Java.Lang.Reflect.Field>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getSingleDataPointFields_Lorg_junit_experimental_theories_ParameterSignature_;
#pragma warning disable 0169
		static Delegate GetGetSingleDataPointFields_Lorg_junit_experimental_theories_ParameterSignature_Handler ()
		{
			if (cb_getSingleDataPointFields_Lorg_junit_experimental_theories_ParameterSignature_ == null)
				cb_getSingleDataPointFields_Lorg_junit_experimental_theories_ParameterSignature_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSingleDataPointFields_Lorg_junit_experimental_theories_ParameterSignature_);
			return cb_getSingleDataPointFields_Lorg_junit_experimental_theories_ParameterSignature_;
		}

		static IntPtr n_GetSingleDataPointFields_Lorg_junit_experimental_theories_ParameterSignature_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sig)
		{
			global::Org.Junit.Experimental.Theories.Internal.AllMembersSupplier __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.Internal.AllMembersSupplier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Junit.Experimental.Theories.ParameterSignature sig = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.ParameterSignature> (native_sig, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaCollection<global::Java.Lang.Reflect.Field>.ToLocalJniHandle (__this.GetSingleDataPointFields (sig));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories.internal']/class[@name='AllMembersSupplier']/method[@name='getSingleDataPointFields' and count(parameter)=1 and parameter[1][@type='org.junit.experimental.theories.ParameterSignature']]"
		[Register ("getSingleDataPointFields", "(Lorg/junit/experimental/theories/ParameterSignature;)Ljava/util/Collection;", "GetGetSingleDataPointFields_Lorg_junit_experimental_theories_ParameterSignature_Handler")]
		protected virtual unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.Reflect.Field> GetSingleDataPointFields (global::Org.Junit.Experimental.Theories.ParameterSignature sig)
		{
			const string __id = "getSingleDataPointFields.(Lorg/junit/experimental/theories/ParameterSignature;)Ljava/util/Collection;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sig).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaCollection<global::Java.Lang.Reflect.Field>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Org.Junit.Experimental.Theories.Internal.AllMembersSupplier __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.Internal.AllMembersSupplier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Junit.Experimental.Theories.ParameterSignature sig = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.ParameterSignature> (native_sig, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Junit.Experimental.Theories.PotentialAssignment>.ToLocalJniHandle (__this.GetValueSources (sig));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories.internal']/class[@name='AllMembersSupplier']/method[@name='getValueSources' and count(parameter)=1 and parameter[1][@type='org.junit.experimental.theories.ParameterSignature']]"
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
