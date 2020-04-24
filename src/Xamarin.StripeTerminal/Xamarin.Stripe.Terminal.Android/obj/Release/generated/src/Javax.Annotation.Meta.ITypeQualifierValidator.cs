using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Javax.Annotation.Meta {

	// Metadata.xml XPath interface reference: path="/api/package[@name='javax.annotation.meta']/interface[@name='TypeQualifierValidator']"
	[Register ("javax/annotation/meta/TypeQualifierValidator", "", "Javax.Annotation.Meta.ITypeQualifierValidatorInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"A extends java.lang.annotation.Annotation"})]
	public partial interface ITypeQualifierValidator : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='javax.annotation.meta']/interface[@name='TypeQualifierValidator']/method[@name='forConstantValue' and count(parameter)=2 and parameter[1][@type='A'] and parameter[2][@type='java.lang.Object']]"
		[Register ("forConstantValue", "(Ljava/lang/annotation/Annotation;Ljava/lang/Object;)Ljavax/annotation/meta/When;", "GetForConstantValue_Ljava_lang_annotation_Annotation_Ljava_lang_Object_Handler:Javax.Annotation.Meta.ITypeQualifierValidatorInvoker, Xamarin.Stripe.Terminal.Android")]
		global::Javax.Annotation.Meta.When ForConstantValue (global::Java.Lang.Object p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("javax/annotation/meta/TypeQualifierValidator", DoNotGenerateAcw=true)]
	internal partial class ITypeQualifierValidatorInvoker : global::Java.Lang.Object, ITypeQualifierValidator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("javax/annotation/meta/TypeQualifierValidator", typeof (ITypeQualifierValidatorInvoker));

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

		public static ITypeQualifierValidator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITypeQualifierValidator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "javax.annotation.meta.TypeQualifierValidator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITypeQualifierValidatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_forConstantValue_Ljava_lang_annotation_Annotation_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetForConstantValue_Ljava_lang_annotation_Annotation_Ljava_lang_Object_Handler ()
		{
			if (cb_forConstantValue_Ljava_lang_annotation_Annotation_Ljava_lang_Object_ == null)
				cb_forConstantValue_Ljava_lang_annotation_Annotation_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ForConstantValue_Ljava_lang_annotation_Annotation_Ljava_lang_Object_);
			return cb_forConstantValue_Ljava_lang_annotation_Annotation_Ljava_lang_Object_;
		}

		static IntPtr n_ForConstantValue_Ljava_lang_annotation_Annotation_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Javax.Annotation.Meta.ITypeQualifierValidator __this = global::Java.Lang.Object.GetObject<global::Javax.Annotation.Meta.ITypeQualifierValidator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ForConstantValue (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_forConstantValue_Ljava_lang_annotation_Annotation_Ljava_lang_Object_;
		public unsafe global::Javax.Annotation.Meta.When ForConstantValue (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_forConstantValue_Ljava_lang_annotation_Annotation_Ljava_lang_Object_ == IntPtr.Zero)
				id_forConstantValue_Ljava_lang_annotation_Annotation_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "forConstantValue", "(Ljava/lang/annotation/Annotation;Ljava/lang/Object;)Ljavax/annotation/meta/When;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Javax.Annotation.Meta.When __ret = global::Java.Lang.Object.GetObject<global::Javax.Annotation.Meta.When> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_forConstantValue_Ljava_lang_annotation_Annotation_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
