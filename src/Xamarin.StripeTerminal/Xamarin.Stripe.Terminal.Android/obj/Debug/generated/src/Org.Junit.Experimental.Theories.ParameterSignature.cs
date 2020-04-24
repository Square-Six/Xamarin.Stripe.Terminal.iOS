using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Experimental.Theories {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='ParameterSignature']"
	[global::Android.Runtime.Register ("org/junit/experimental/theories/ParameterSignature", DoNotGenerateAcw=true)]
	public partial class ParameterSignature : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/experimental/theories/ParameterSignature", typeof (ParameterSignature));
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

		protected ParameterSignature (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAnnotations;
#pragma warning disable 0169
		static Delegate GetGetAnnotationsHandler ()
		{
			if (cb_getAnnotations == null)
				cb_getAnnotations = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAnnotations);
			return cb_getAnnotations;
		}

		static IntPtr n_GetAnnotations (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Experimental.Theories.ParameterSignature __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.ParameterSignature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.Annotation.IAnnotation>.ToLocalJniHandle (__this.Annotations);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Lang.Annotation.IAnnotation> Annotations {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='ParameterSignature']/method[@name='getAnnotations' and count(parameter)=0]"
			[Register ("getAnnotations", "()Ljava/util/List;", "GetGetAnnotationsHandler")]
			get {
				const string __id = "getAnnotations.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Java.Lang.Annotation.IAnnotation>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Experimental.Theories.ParameterSignature __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.ParameterSignature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Class Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='ParameterSignature']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/Class;", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()Ljava/lang/Class;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_canAcceptType_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetCanAcceptType_Ljava_lang_Class_Handler ()
		{
			if (cb_canAcceptType_Ljava_lang_Class_ == null)
				cb_canAcceptType_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_CanAcceptType_Ljava_lang_Class_);
			return cb_canAcceptType_Ljava_lang_Class_;
		}

		static bool n_CanAcceptType_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_candidate)
		{
			global::Org.Junit.Experimental.Theories.ParameterSignature __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.ParameterSignature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class candidate = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_candidate, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanAcceptType (candidate);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='ParameterSignature']/method[@name='canAcceptType' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("canAcceptType", "(Ljava/lang/Class;)Z", "GetCanAcceptType_Ljava_lang_Class_Handler")]
		public virtual unsafe bool CanAcceptType (global::Java.Lang.Class candidate)
		{
			const string __id = "canAcceptType.(Ljava/lang/Class;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((candidate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) candidate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_canAcceptValue_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCanAcceptValue_Ljava_lang_Object_Handler ()
		{
			if (cb_canAcceptValue_Ljava_lang_Object_ == null)
				cb_canAcceptValue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_CanAcceptValue_Ljava_lang_Object_);
			return cb_canAcceptValue_Ljava_lang_Object_;
		}

		static bool n_CanAcceptValue_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_candidate)
		{
			global::Org.Junit.Experimental.Theories.ParameterSignature __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.ParameterSignature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object candidate = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_candidate, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanAcceptValue (candidate);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='ParameterSignature']/method[@name='canAcceptValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("canAcceptValue", "(Ljava/lang/Object;)Z", "GetCanAcceptValue_Ljava_lang_Object_Handler")]
		public virtual unsafe bool CanAcceptValue (global::Java.Lang.Object candidate)
		{
			const string __id = "canAcceptValue.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((candidate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) candidate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_canPotentiallyAcceptType_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetCanPotentiallyAcceptType_Ljava_lang_Class_Handler ()
		{
			if (cb_canPotentiallyAcceptType_Ljava_lang_Class_ == null)
				cb_canPotentiallyAcceptType_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_CanPotentiallyAcceptType_Ljava_lang_Class_);
			return cb_canPotentiallyAcceptType_Ljava_lang_Class_;
		}

		static bool n_CanPotentiallyAcceptType_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_candidate)
		{
			global::Org.Junit.Experimental.Theories.ParameterSignature __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.ParameterSignature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class candidate = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_candidate, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanPotentiallyAcceptType (candidate);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='ParameterSignature']/method[@name='canPotentiallyAcceptType' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("canPotentiallyAcceptType", "(Ljava/lang/Class;)Z", "GetCanPotentiallyAcceptType_Ljava_lang_Class_Handler")]
		public virtual unsafe bool CanPotentiallyAcceptType (global::Java.Lang.Class candidate)
		{
			const string __id = "canPotentiallyAcceptType.(Ljava/lang/Class;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((candidate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) candidate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_findDeepAnnotation_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetFindDeepAnnotation_Ljava_lang_Class_Handler ()
		{
			if (cb_findDeepAnnotation_Ljava_lang_Class_ == null)
				cb_findDeepAnnotation_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FindDeepAnnotation_Ljava_lang_Class_);
			return cb_findDeepAnnotation_Ljava_lang_Class_;
		}

		static IntPtr n_FindDeepAnnotation_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_annotationType)
		{
			global::Org.Junit.Experimental.Theories.ParameterSignature __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.ParameterSignature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class annotationType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_annotationType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FindDeepAnnotation (annotationType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='ParameterSignature']/method[@name='findDeepAnnotation' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("findDeepAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", "GetFindDeepAnnotation_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.annotation.Annotation"})]
		public virtual unsafe global::Java.Lang.Object FindDeepAnnotation (global::Java.Lang.Class annotationType)
		{
			const string __id = "findDeepAnnotation.(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((annotationType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) annotationType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getAnnotation_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGetAnnotation_Ljava_lang_Class_Handler ()
		{
			if (cb_getAnnotation_Ljava_lang_Class_ == null)
				cb_getAnnotation_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAnnotation_Ljava_lang_Class_);
			return cb_getAnnotation_Ljava_lang_Class_;
		}

		static IntPtr n_GetAnnotation_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_annotationType)
		{
			global::Org.Junit.Experimental.Theories.ParameterSignature __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.ParameterSignature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class annotationType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_annotationType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAnnotation (annotationType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='ParameterSignature']/method[@name='getAnnotation' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", "GetGetAnnotation_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.annotation.Annotation"})]
		public virtual unsafe global::Java.Lang.Object GetAnnotation (global::Java.Lang.Class annotationType)
		{
			const string __id = "getAnnotation.(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((annotationType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) annotationType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hasAnnotation_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetHasAnnotation_Ljava_lang_Class_Handler ()
		{
			if (cb_hasAnnotation_Ljava_lang_Class_ == null)
				cb_hasAnnotation_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HasAnnotation_Ljava_lang_Class_);
			return cb_hasAnnotation_Ljava_lang_Class_;
		}

		static bool n_HasAnnotation_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			global::Org.Junit.Experimental.Theories.ParameterSignature __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.ParameterSignature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class type = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_type, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasAnnotation (type);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='ParameterSignature']/method[@name='hasAnnotation' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends java.lang.annotation.Annotation&gt;']]"
		[Register ("hasAnnotation", "(Ljava/lang/Class;)Z", "GetHasAnnotation_Ljava_lang_Class_Handler")]
		public virtual unsafe bool HasAnnotation (global::Java.Lang.Class type)
		{
			const string __id = "hasAnnotation.(Ljava/lang/Class;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='ParameterSignature']/method[@name='signatures' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Constructor&lt;?&gt;']]"
		[Register ("signatures", "(Ljava/lang/reflect/Constructor;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Org.Junit.Experimental.Theories.ParameterSignature> Signatures (global::Java.Lang.Reflect.Constructor constructor)
		{
			const string __id = "signatures.(Ljava/lang/reflect/Constructor;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((constructor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) constructor).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Org.Junit.Experimental.Theories.ParameterSignature>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='ParameterSignature']/method[@name='signatures' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Method']]"
		[Register ("signatures", "(Ljava/lang/reflect/Method;)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Org.Junit.Experimental.Theories.ParameterSignature> Signatures (global::Java.Lang.Reflect.Method method)
		{
			const string __id = "signatures.(Ljava/lang/reflect/Method;)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((method == null) ? IntPtr.Zero : ((global::Java.Lang.Object) method).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Org.Junit.Experimental.Theories.ParameterSignature>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
