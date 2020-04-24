using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Checkerframework.Common.Reflection.Qual {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.checkerframework.common.reflection.qual']/interface[@name='MethodVal']"
	[Register ("org/checkerframework/common/reflection/qual/MethodVal", "", "Org.Checkerframework.Common.Reflection.Qual.IMethodValInvoker")]
	public partial interface IMethodVal : global::Java.Lang.Annotation.IAnnotation {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.common.reflection.qual']/interface[@name='MethodVal']/method[@name='className' and count(parameter)=0]"
		[Register ("className", "()[Ljava/lang/String;", "GetClassNameHandler:Org.Checkerframework.Common.Reflection.Qual.IMethodValInvoker, Xamarin.Stripe.Terminal.Android")]
		string[] ClassName ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.common.reflection.qual']/interface[@name='MethodVal']/method[@name='methodName' and count(parameter)=0]"
		[Register ("methodName", "()[Ljava/lang/String;", "GetMethodNameHandler:Org.Checkerframework.Common.Reflection.Qual.IMethodValInvoker, Xamarin.Stripe.Terminal.Android")]
		string[] MethodName ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.common.reflection.qual']/interface[@name='MethodVal']/method[@name='params' and count(parameter)=0]"
		[Register ("params", "()[I", "GetParamsHandler:Org.Checkerframework.Common.Reflection.Qual.IMethodValInvoker, Xamarin.Stripe.Terminal.Android")]
		int[] Params ();

	}

	[global::Android.Runtime.Register ("org/checkerframework/common/reflection/qual/MethodVal", DoNotGenerateAcw=true)]
	internal partial class IMethodValInvoker : global::Java.Lang.Object, IMethodVal {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/checkerframework/common/reflection/qual/MethodVal", typeof (IMethodValInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IMethodVal GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMethodVal> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.checkerframework.common.reflection.qual.MethodVal"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMethodValInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_className;
#pragma warning disable 0169
		static Delegate GetClassNameHandler ()
		{
			if (cb_className == null)
				cb_className = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ClassName);
			return cb_className;
		}

		static IntPtr n_ClassName (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Checkerframework.Common.Reflection.Qual.IMethodVal __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Common.Reflection.Qual.IMethodVal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ClassName ());
		}
#pragma warning restore 0169

		IntPtr id_className;
		public unsafe string[] ClassName ()
		{
			if (id_className == IntPtr.Zero)
				id_className = JNIEnv.GetMethodID (class_ref, "className", "()[Ljava/lang/String;");
			return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_className), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static Delegate cb_methodName;
#pragma warning disable 0169
		static Delegate GetMethodNameHandler ()
		{
			if (cb_methodName == null)
				cb_methodName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_MethodName);
			return cb_methodName;
		}

		static IntPtr n_MethodName (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Checkerframework.Common.Reflection.Qual.IMethodVal __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Common.Reflection.Qual.IMethodVal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.MethodName ());
		}
#pragma warning restore 0169

		IntPtr id_methodName;
		public unsafe string[] MethodName ()
		{
			if (id_methodName == IntPtr.Zero)
				id_methodName = JNIEnv.GetMethodID (class_ref, "methodName", "()[Ljava/lang/String;");
			return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_methodName), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static Delegate cb_params;
#pragma warning disable 0169
		static Delegate GetParamsHandler ()
		{
			if (cb_params == null)
				cb_params = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Params);
			return cb_params;
		}

		static IntPtr n_Params (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Checkerframework.Common.Reflection.Qual.IMethodVal __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Common.Reflection.Qual.IMethodVal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Params ());
		}
#pragma warning restore 0169

		IntPtr id_params;
		public unsafe int[] Params ()
		{
			if (id_params == IntPtr.Zero)
				id_params = JNIEnv.GetMethodID (class_ref, "params", "()[I");
			return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_params), JniHandleOwnership.TransferLocalRef, typeof (int));
		}

		static Delegate cb_annotationType;
#pragma warning disable 0169
		static Delegate GetAnnotationTypeHandler ()
		{
			if (cb_annotationType == null)
				cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
			return cb_annotationType;
		}

		static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Checkerframework.Common.Reflection.Qual.IMethodVal __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Common.Reflection.Qual.IMethodVal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
		}
#pragma warning restore 0169

		IntPtr id_annotationType;
		public unsafe global::Java.Lang.Class AnnotationType ()
		{
			if (id_annotationType == IntPtr.Zero)
				id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Checkerframework.Common.Reflection.Qual.IMethodVal __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Common.Reflection.Qual.IMethodVal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (obj);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
			return __ret;
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
			global::Org.Checkerframework.Common.Reflection.Qual.IMethodVal __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Common.Reflection.Qual.IMethodVal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public unsafe global::System.Int32 GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Checkerframework.Common.Reflection.Qual.IMethodVal __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Common.Reflection.Qual.IMethodVal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public unsafe global::System.String ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}

}
