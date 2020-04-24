using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Experimental.Theories.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.experimental.theories.internal']/class[@name='Assignments']"
	[global::Android.Runtime.Register ("org/junit/experimental/theories/internal/Assignments", DoNotGenerateAcw=true)]
	public partial class Assignments : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/experimental/theories/internal/Assignments", typeof (Assignments));
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

		protected Assignments (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isComplete;
#pragma warning disable 0169
		static Delegate GetIsCompleteHandler ()
		{
			if (cb_isComplete == null)
				cb_isComplete = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsComplete);
			return cb_isComplete;
		}

		static bool n_IsComplete (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Experimental.Theories.Internal.Assignments __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.Internal.Assignments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsComplete;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsComplete {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories.internal']/class[@name='Assignments']/method[@name='isComplete' and count(parameter)=0]"
			[Register ("isComplete", "()Z", "GetIsCompleteHandler")]
			get {
				const string __id = "isComplete.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_assignNext_Lorg_junit_experimental_theories_PotentialAssignment_;
#pragma warning disable 0169
		static Delegate GetAssignNext_Lorg_junit_experimental_theories_PotentialAssignment_Handler ()
		{
			if (cb_assignNext_Lorg_junit_experimental_theories_PotentialAssignment_ == null)
				cb_assignNext_Lorg_junit_experimental_theories_PotentialAssignment_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AssignNext_Lorg_junit_experimental_theories_PotentialAssignment_);
			return cb_assignNext_Lorg_junit_experimental_theories_PotentialAssignment_;
		}

		static IntPtr n_AssignNext_Lorg_junit_experimental_theories_PotentialAssignment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			global::Org.Junit.Experimental.Theories.Internal.Assignments __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.Internal.Assignments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Junit.Experimental.Theories.PotentialAssignment source = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.PotentialAssignment> (native_source, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AssignNext (source));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories.internal']/class[@name='Assignments']/method[@name='assignNext' and count(parameter)=1 and parameter[1][@type='org.junit.experimental.theories.PotentialAssignment']]"
		[Register ("assignNext", "(Lorg/junit/experimental/theories/PotentialAssignment;)Lorg/junit/experimental/theories/internal/Assignments;", "GetAssignNext_Lorg_junit_experimental_theories_PotentialAssignment_Handler")]
		public virtual unsafe global::Org.Junit.Experimental.Theories.Internal.Assignments AssignNext (global::Org.Junit.Experimental.Theories.PotentialAssignment source)
		{
			const string __id = "assignNext.(Lorg/junit/experimental/theories/PotentialAssignment;)Lorg/junit/experimental/theories/internal/Assignments;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.Internal.Assignments> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getActualValues_II;
#pragma warning disable 0169
		static Delegate GetGetActualValues_IIHandler ()
		{
			if (cb_getActualValues_II == null)
				cb_getActualValues_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_GetActualValues_II);
			return cb_getActualValues_II;
		}

		static IntPtr n_GetActualValues_II (IntPtr jnienv, IntPtr native__this, int start, int stop)
		{
			global::Org.Junit.Experimental.Theories.Internal.Assignments __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.Internal.Assignments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetActualValues (start, stop));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories.internal']/class[@name='Assignments']/method[@name='getActualValues' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getActualValues", "(II)[Ljava/lang/Object;", "GetGetActualValues_IIHandler")]
		public virtual unsafe global::Java.Lang.Object[] GetActualValues (int start, int stop)
		{
			const string __id = "getActualValues.(II)[Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (start);
				__args [1] = new JniArgumentValue (stop);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
			}
		}

		static Delegate cb_getAllArguments;
#pragma warning disable 0169
		static Delegate GetGetAllArgumentsHandler ()
		{
			if (cb_getAllArguments == null)
				cb_getAllArguments = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllArguments);
			return cb_getAllArguments;
		}

		static IntPtr n_GetAllArguments (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Experimental.Theories.Internal.Assignments __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.Internal.Assignments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAllArguments ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories.internal']/class[@name='Assignments']/method[@name='getAllArguments' and count(parameter)=0]"
		[Register ("getAllArguments", "()[Ljava/lang/Object;", "GetGetAllArgumentsHandler")]
		public virtual unsafe global::Java.Lang.Object[] GetAllArguments ()
		{
			const string __id = "getAllArguments.()[Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
			}
		}

		static Delegate cb_getArgumentStrings_Z;
#pragma warning disable 0169
		static Delegate GetGetArgumentStrings_ZHandler ()
		{
			if (cb_getArgumentStrings_Z == null)
				cb_getArgumentStrings_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_GetArgumentStrings_Z);
			return cb_getArgumentStrings_Z;
		}

		static IntPtr n_GetArgumentStrings_Z (IntPtr jnienv, IntPtr native__this, bool nullsOk)
		{
			global::Org.Junit.Experimental.Theories.Internal.Assignments __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.Internal.Assignments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetArgumentStrings (nullsOk));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories.internal']/class[@name='Assignments']/method[@name='getArgumentStrings' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getArgumentStrings", "(Z)[Ljava/lang/Object;", "GetGetArgumentStrings_ZHandler")]
		public virtual unsafe global::Java.Lang.Object[] GetArgumentStrings (bool nullsOk)
		{
			const string __id = "getArgumentStrings.(Z)[Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nullsOk);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
			}
		}

		static Delegate cb_getConstructorArguments;
#pragma warning disable 0169
		static Delegate GetGetConstructorArgumentsHandler ()
		{
			if (cb_getConstructorArguments == null)
				cb_getConstructorArguments = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConstructorArguments);
			return cb_getConstructorArguments;
		}

		static IntPtr n_GetConstructorArguments (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Experimental.Theories.Internal.Assignments __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.Internal.Assignments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetConstructorArguments ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories.internal']/class[@name='Assignments']/method[@name='getConstructorArguments' and count(parameter)=0]"
		[Register ("getConstructorArguments", "()[Ljava/lang/Object;", "GetGetConstructorArgumentsHandler")]
		public virtual unsafe global::Java.Lang.Object[] GetConstructorArguments ()
		{
			const string __id = "getConstructorArguments.()[Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
			}
		}

		static Delegate cb_getMethodArguments;
#pragma warning disable 0169
		static Delegate GetGetMethodArgumentsHandler ()
		{
			if (cb_getMethodArguments == null)
				cb_getMethodArguments = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMethodArguments);
			return cb_getMethodArguments;
		}

		static IntPtr n_GetMethodArguments (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Experimental.Theories.Internal.Assignments __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.Internal.Assignments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetMethodArguments ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories.internal']/class[@name='Assignments']/method[@name='getMethodArguments' and count(parameter)=0]"
		[Register ("getMethodArguments", "()[Ljava/lang/Object;", "GetGetMethodArgumentsHandler")]
		public virtual unsafe global::Java.Lang.Object[] GetMethodArguments ()
		{
			const string __id = "getMethodArguments.()[Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
			}
		}

		static Delegate cb_nextUnassigned;
#pragma warning disable 0169
		static Delegate GetNextUnassignedHandler ()
		{
			if (cb_nextUnassigned == null)
				cb_nextUnassigned = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NextUnassigned);
			return cb_nextUnassigned;
		}

		static IntPtr n_NextUnassigned (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Experimental.Theories.Internal.Assignments __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.Internal.Assignments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NextUnassigned ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories.internal']/class[@name='Assignments']/method[@name='nextUnassigned' and count(parameter)=0]"
		[Register ("nextUnassigned", "()Lorg/junit/experimental/theories/ParameterSignature;", "GetNextUnassignedHandler")]
		public virtual unsafe global::Org.Junit.Experimental.Theories.ParameterSignature NextUnassigned ()
		{
			const string __id = "nextUnassigned.()Lorg/junit/experimental/theories/ParameterSignature;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.ParameterSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_potentialsForNextUnassigned;
#pragma warning disable 0169
		static Delegate GetPotentialsForNextUnassignedHandler ()
		{
			if (cb_potentialsForNextUnassigned == null)
				cb_potentialsForNextUnassigned = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PotentialsForNextUnassigned);
			return cb_potentialsForNextUnassigned;
		}

		static IntPtr n_PotentialsForNextUnassigned (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Experimental.Theories.Internal.Assignments __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.Internal.Assignments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Junit.Experimental.Theories.PotentialAssignment>.ToLocalJniHandle (__this.PotentialsForNextUnassigned ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories.internal']/class[@name='Assignments']/method[@name='potentialsForNextUnassigned' and count(parameter)=0]"
		[Register ("potentialsForNextUnassigned", "()Ljava/util/List;", "GetPotentialsForNextUnassignedHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Junit.Experimental.Theories.PotentialAssignment> PotentialsForNextUnassigned ()
		{
			const string __id = "potentialsForNextUnassigned.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Org.Junit.Experimental.Theories.PotentialAssignment>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
