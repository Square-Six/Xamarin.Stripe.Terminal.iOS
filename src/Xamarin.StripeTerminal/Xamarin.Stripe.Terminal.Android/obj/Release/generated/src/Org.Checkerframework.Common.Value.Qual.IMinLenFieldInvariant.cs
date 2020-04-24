using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Checkerframework.Common.Value.Qual {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.checkerframework.common.value.qual']/interface[@name='MinLenFieldInvariant']"
	[Register ("org/checkerframework/common/value/qual/MinLenFieldInvariant", "", "Org.Checkerframework.Common.Value.Qual.IMinLenFieldInvariantInvoker")]
	public partial interface IMinLenFieldInvariant : global::Java.Lang.Annotation.IAnnotation {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.common.value.qual']/interface[@name='MinLenFieldInvariant']/method[@name='field' and count(parameter)=0]"
		[Register ("field", "()[Ljava/lang/String;", "GetFieldHandler:Org.Checkerframework.Common.Value.Qual.IMinLenFieldInvariantInvoker, Xamarin.Stripe.Terminal.Android")]
		string[] Field ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.common.value.qual']/interface[@name='MinLenFieldInvariant']/method[@name='minLen' and count(parameter)=0]"
		[Register ("minLen", "()[I", "GetMinLenHandler:Org.Checkerframework.Common.Value.Qual.IMinLenFieldInvariantInvoker, Xamarin.Stripe.Terminal.Android")]
		int[] MinLen ();

	}

	[global::Android.Runtime.Register ("org/checkerframework/common/value/qual/MinLenFieldInvariant", DoNotGenerateAcw=true)]
	internal partial class IMinLenFieldInvariantInvoker : global::Java.Lang.Object, IMinLenFieldInvariant {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/checkerframework/common/value/qual/MinLenFieldInvariant", typeof (IMinLenFieldInvariantInvoker));

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

		public static IMinLenFieldInvariant GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMinLenFieldInvariant> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.checkerframework.common.value.qual.MinLenFieldInvariant"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMinLenFieldInvariantInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_field;
#pragma warning disable 0169
		static Delegate GetFieldHandler ()
		{
			if (cb_field == null)
				cb_field = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Field);
			return cb_field;
		}

		static IntPtr n_Field (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Checkerframework.Common.Value.Qual.IMinLenFieldInvariant __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Common.Value.Qual.IMinLenFieldInvariant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Field ());
		}
#pragma warning restore 0169

		IntPtr id_field;
		public unsafe string[] Field ()
		{
			if (id_field == IntPtr.Zero)
				id_field = JNIEnv.GetMethodID (class_ref, "field", "()[Ljava/lang/String;");
			return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_field), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static Delegate cb_minLen;
#pragma warning disable 0169
		static Delegate GetMinLenHandler ()
		{
			if (cb_minLen == null)
				cb_minLen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_MinLen);
			return cb_minLen;
		}

		static IntPtr n_MinLen (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Checkerframework.Common.Value.Qual.IMinLenFieldInvariant __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Common.Value.Qual.IMinLenFieldInvariant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.MinLen ());
		}
#pragma warning restore 0169

		IntPtr id_minLen;
		public unsafe int[] MinLen ()
		{
			if (id_minLen == IntPtr.Zero)
				id_minLen = JNIEnv.GetMethodID (class_ref, "minLen", "()[I");
			return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_minLen), JniHandleOwnership.TransferLocalRef, typeof (int));
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
			global::Org.Checkerframework.Common.Value.Qual.IMinLenFieldInvariant __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Common.Value.Qual.IMinLenFieldInvariant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Checkerframework.Common.Value.Qual.IMinLenFieldInvariant __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Common.Value.Qual.IMinLenFieldInvariant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Checkerframework.Common.Value.Qual.IMinLenFieldInvariant __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Common.Value.Qual.IMinLenFieldInvariant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Checkerframework.Common.Value.Qual.IMinLenFieldInvariant __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Common.Value.Qual.IMinLenFieldInvariant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
