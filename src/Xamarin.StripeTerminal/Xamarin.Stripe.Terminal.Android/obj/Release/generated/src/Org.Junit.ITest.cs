using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit']/class[@name='Test.None']"
	[global::Android.Runtime.Register ("org/junit/Test$None", DoNotGenerateAcw=true)]
	public partial class TestNone : global::Java.Lang.Throwable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/Test$None", typeof (TestNone));
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

		protected TestNone (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.junit']/interface[@name='Test']"
	[Register ("org/junit/Test", "", "Org.Junit.ITestInvoker")]
	public partial interface ITest : global::Java.Lang.Annotation.IAnnotation {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/interface[@name='Test']/method[@name='expected' and count(parameter)=0]"
		[Register ("expected", "()Ljava/lang/Class;", "GetExpectedHandler:Org.Junit.ITestInvoker, Xamarin.Stripe.Terminal.Android")]
		global::Java.Lang.Class Expected ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/interface[@name='Test']/method[@name='timeout' and count(parameter)=0]"
		[Register ("timeout", "()J", "GetTimeoutHandler:Org.Junit.ITestInvoker, Xamarin.Stripe.Terminal.Android")]
		long Timeout ();

	}

	[global::Android.Runtime.Register ("org/junit/Test", DoNotGenerateAcw=true)]
	internal partial class ITestInvoker : global::Java.Lang.Object, ITest {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/Test", typeof (ITestInvoker));

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

		public static ITest GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITest> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.junit.Test"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_expected;
#pragma warning disable 0169
		static Delegate GetExpectedHandler ()
		{
			if (cb_expected == null)
				cb_expected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Expected);
			return cb_expected;
		}

		static IntPtr n_Expected (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.ITest __this = global::Java.Lang.Object.GetObject<global::Org.Junit.ITest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Expected ());
		}
#pragma warning restore 0169

		IntPtr id_expected;
		public unsafe global::Java.Lang.Class Expected ()
		{
			if (id_expected == IntPtr.Zero)
				id_expected = JNIEnv.GetMethodID (class_ref, "expected", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_expected), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_timeout;
#pragma warning disable 0169
		static Delegate GetTimeoutHandler ()
		{
			if (cb_timeout == null)
				cb_timeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Timeout);
			return cb_timeout;
		}

		static long n_Timeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.ITest __this = global::Java.Lang.Object.GetObject<global::Org.Junit.ITest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timeout ();
		}
#pragma warning restore 0169

		IntPtr id_timeout;
		public unsafe long Timeout ()
		{
			if (id_timeout == IntPtr.Zero)
				id_timeout = JNIEnv.GetMethodID (class_ref, "timeout", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_timeout);
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
			global::Org.Junit.ITest __this = global::Java.Lang.Object.GetObject<global::Org.Junit.ITest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Junit.ITest __this = global::Java.Lang.Object.GetObject<global::Org.Junit.ITest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Junit.ITest __this = global::Java.Lang.Object.GetObject<global::Org.Junit.ITest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Junit.ITest __this = global::Java.Lang.Object.GetObject<global::Org.Junit.ITest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
