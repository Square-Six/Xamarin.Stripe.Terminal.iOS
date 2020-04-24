using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Intellij.Lang.Annotations {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.stripe.intellij.lang.annotations']/interface[@name='MagicConstant']"
	[Register ("com/stripe/intellij/lang/annotations/MagicConstant", "", "Com.Stripe.Intellij.Lang.Annotations.IMagicConstantInvoker")]
	public partial interface IMagicConstant : global::Java.Lang.Annotation.IAnnotation {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.intellij.lang.annotations']/interface[@name='MagicConstant']/method[@name='flags' and count(parameter)=0]"
		[Register ("flags", "()[J", "GetFlagsHandler:Com.Stripe.Intellij.Lang.Annotations.IMagicConstantInvoker, Xamarin.Stripe.Terminal.Android")]
		long[] Flags ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.intellij.lang.annotations']/interface[@name='MagicConstant']/method[@name='flagsFromClass' and count(parameter)=0]"
		[Register ("flagsFromClass", "()Ljava/lang/Class;", "GetFlagsFromClassHandler:Com.Stripe.Intellij.Lang.Annotations.IMagicConstantInvoker, Xamarin.Stripe.Terminal.Android")]
		global::Java.Lang.Class FlagsFromClass ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.intellij.lang.annotations']/interface[@name='MagicConstant']/method[@name='intValues' and count(parameter)=0]"
		[Register ("intValues", "()[J", "GetIntValuesHandler:Com.Stripe.Intellij.Lang.Annotations.IMagicConstantInvoker, Xamarin.Stripe.Terminal.Android")]
		long[] IntValues ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.intellij.lang.annotations']/interface[@name='MagicConstant']/method[@name='stringValues' and count(parameter)=0]"
		[Register ("stringValues", "()[Ljava/lang/String;", "GetStringValuesHandler:Com.Stripe.Intellij.Lang.Annotations.IMagicConstantInvoker, Xamarin.Stripe.Terminal.Android")]
		string[] StringValues ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.intellij.lang.annotations']/interface[@name='MagicConstant']/method[@name='valuesFromClass' and count(parameter)=0]"
		[Register ("valuesFromClass", "()Ljava/lang/Class;", "GetValuesFromClassHandler:Com.Stripe.Intellij.Lang.Annotations.IMagicConstantInvoker, Xamarin.Stripe.Terminal.Android")]
		global::Java.Lang.Class ValuesFromClass ();

	}

	[global::Android.Runtime.Register ("com/stripe/intellij/lang/annotations/MagicConstant", DoNotGenerateAcw=true)]
	internal partial class IMagicConstantInvoker : global::Java.Lang.Object, IMagicConstant {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/intellij/lang/annotations/MagicConstant", typeof (IMagicConstantInvoker));

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

		public static IMagicConstant GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMagicConstant> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.stripe.intellij.lang.annotations.MagicConstant"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMagicConstantInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_flags;
#pragma warning disable 0169
		static Delegate GetFlagsHandler ()
		{
			if (cb_flags == null)
				cb_flags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Flags);
			return cb_flags;
		}

		static IntPtr n_Flags (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Stripe.Intellij.Lang.Annotations.IMagicConstant __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Intellij.Lang.Annotations.IMagicConstant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Flags ());
		}
#pragma warning restore 0169

		IntPtr id_flags;
		public unsafe long[] Flags ()
		{
			if (id_flags == IntPtr.Zero)
				id_flags = JNIEnv.GetMethodID (class_ref, "flags", "()[J");
			return (long[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flags), JniHandleOwnership.TransferLocalRef, typeof (long));
		}

		static Delegate cb_flagsFromClass;
#pragma warning disable 0169
		static Delegate GetFlagsFromClassHandler ()
		{
			if (cb_flagsFromClass == null)
				cb_flagsFromClass = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FlagsFromClass);
			return cb_flagsFromClass;
		}

		static IntPtr n_FlagsFromClass (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Stripe.Intellij.Lang.Annotations.IMagicConstant __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Intellij.Lang.Annotations.IMagicConstant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FlagsFromClass ());
		}
#pragma warning restore 0169

		IntPtr id_flagsFromClass;
		public unsafe global::Java.Lang.Class FlagsFromClass ()
		{
			if (id_flagsFromClass == IntPtr.Zero)
				id_flagsFromClass = JNIEnv.GetMethodID (class_ref, "flagsFromClass", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flagsFromClass), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_intValues;
#pragma warning disable 0169
		static Delegate GetIntValuesHandler ()
		{
			if (cb_intValues == null)
				cb_intValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IntValues);
			return cb_intValues;
		}

		static IntPtr n_IntValues (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Stripe.Intellij.Lang.Annotations.IMagicConstant __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Intellij.Lang.Annotations.IMagicConstant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.IntValues ());
		}
#pragma warning restore 0169

		IntPtr id_intValues;
		public unsafe long[] IntValues ()
		{
			if (id_intValues == IntPtr.Zero)
				id_intValues = JNIEnv.GetMethodID (class_ref, "intValues", "()[J");
			return (long[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_intValues), JniHandleOwnership.TransferLocalRef, typeof (long));
		}

		static Delegate cb_stringValues;
#pragma warning disable 0169
		static Delegate GetStringValuesHandler ()
		{
			if (cb_stringValues == null)
				cb_stringValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_StringValues);
			return cb_stringValues;
		}

		static IntPtr n_StringValues (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Stripe.Intellij.Lang.Annotations.IMagicConstant __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Intellij.Lang.Annotations.IMagicConstant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.StringValues ());
		}
#pragma warning restore 0169

		IntPtr id_stringValues;
		public unsafe string[] StringValues ()
		{
			if (id_stringValues == IntPtr.Zero)
				id_stringValues = JNIEnv.GetMethodID (class_ref, "stringValues", "()[Ljava/lang/String;");
			return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_stringValues), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static Delegate cb_valuesFromClass;
#pragma warning disable 0169
		static Delegate GetValuesFromClassHandler ()
		{
			if (cb_valuesFromClass == null)
				cb_valuesFromClass = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ValuesFromClass);
			return cb_valuesFromClass;
		}

		static IntPtr n_ValuesFromClass (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Stripe.Intellij.Lang.Annotations.IMagicConstant __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Intellij.Lang.Annotations.IMagicConstant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ValuesFromClass ());
		}
#pragma warning restore 0169

		IntPtr id_valuesFromClass;
		public unsafe global::Java.Lang.Class ValuesFromClass ()
		{
			if (id_valuesFromClass == IntPtr.Zero)
				id_valuesFromClass = JNIEnv.GetMethodID (class_ref, "valuesFromClass", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_valuesFromClass), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Stripe.Intellij.Lang.Annotations.IMagicConstant __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Intellij.Lang.Annotations.IMagicConstant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Stripe.Intellij.Lang.Annotations.IMagicConstant __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Intellij.Lang.Annotations.IMagicConstant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Stripe.Intellij.Lang.Annotations.IMagicConstant __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Intellij.Lang.Annotations.IMagicConstant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Stripe.Intellij.Lang.Annotations.IMagicConstant __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Intellij.Lang.Annotations.IMagicConstant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
