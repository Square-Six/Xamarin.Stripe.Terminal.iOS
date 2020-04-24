using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Intellij.Lang.Annotations {

	[Register ("com/stripe/intellij/lang/annotations/Flow", DoNotGenerateAcw=true)]
	public abstract class Flow : Java.Lang.Object {

		internal Flow ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.intellij.lang.annotations']/interface[@name='Flow']/field[@name='DEFAULT_SOURCE']"
		[Register ("DEFAULT_SOURCE")]
		public const string DefaultSource = (string) "The method argument (if parameter was annotated) or this container (if instance method was annotated)";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.intellij.lang.annotations']/interface[@name='Flow']/field[@name='DEFAULT_TARGET']"
		[Register ("DEFAULT_TARGET")]
		public const string DefaultTarget = (string) "This container (if the parameter was annotated) or the return value (if instance method was annotated)";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.intellij.lang.annotations']/interface[@name='Flow']/field[@name='RETURN_METHOD_TARGET']"
		[Register ("RETURN_METHOD_TARGET")]
		public const string ReturnMethodTarget = (string) "The return value of this method";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.intellij.lang.annotations']/interface[@name='Flow']/field[@name='THIS_SOURCE']"
		[Register ("THIS_SOURCE")]
		public const string ThisSource = (string) "this";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.intellij.lang.annotations']/interface[@name='Flow']/field[@name='THIS_TARGET']"
		[Register ("THIS_TARGET")]
		public const string ThisTarget = (string) "this";

		// The following are fields from: java.lang.annotation.Annotation

		// The following are fields from: Android.Runtime.IJavaObject

		// The following are fields from: System.IDisposable

		// The following are fields from: Java.Interop.IJavaPeerable
	}

	[Register ("com/stripe/intellij/lang/annotations/Flow", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'Flow' type. This type will be removed in a future release.", error: true)]
	public abstract class FlowConsts : Flow {

		private FlowConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.stripe.intellij.lang.annotations']/interface[@name='Flow']"
	[Register ("com/stripe/intellij/lang/annotations/Flow", "", "Com.Stripe.Intellij.Lang.Annotations.IFlowInvoker")]
	public partial interface IFlow : global::Java.Lang.Annotation.IAnnotation {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.intellij.lang.annotations']/interface[@name='Flow']/method[@name='source' and count(parameter)=0]"
		[Register ("source", "()Ljava/lang/String;", "GetSourceHandler:Com.Stripe.Intellij.Lang.Annotations.IFlowInvoker, Xamarin.Stripe.Terminal.Android")]
		string Source ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.intellij.lang.annotations']/interface[@name='Flow']/method[@name='sourceIsContainer' and count(parameter)=0]"
		[Register ("sourceIsContainer", "()Z", "GetSourceIsContainerHandler:Com.Stripe.Intellij.Lang.Annotations.IFlowInvoker, Xamarin.Stripe.Terminal.Android")]
		bool SourceIsContainer ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.intellij.lang.annotations']/interface[@name='Flow']/method[@name='target' and count(parameter)=0]"
		[Register ("target", "()Ljava/lang/String;", "GetTargetHandler:Com.Stripe.Intellij.Lang.Annotations.IFlowInvoker, Xamarin.Stripe.Terminal.Android")]
		string Target ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.intellij.lang.annotations']/interface[@name='Flow']/method[@name='targetIsContainer' and count(parameter)=0]"
		[Register ("targetIsContainer", "()Z", "GetTargetIsContainerHandler:Com.Stripe.Intellij.Lang.Annotations.IFlowInvoker, Xamarin.Stripe.Terminal.Android")]
		bool TargetIsContainer ();

	}

	[global::Android.Runtime.Register ("com/stripe/intellij/lang/annotations/Flow", DoNotGenerateAcw=true)]
	internal partial class IFlowInvoker : global::Java.Lang.Object, IFlow {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/intellij/lang/annotations/Flow", typeof (IFlowInvoker));

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

		public static IFlow GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFlow> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.stripe.intellij.lang.annotations.Flow"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFlowInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_source;
#pragma warning disable 0169
		static Delegate GetSourceHandler ()
		{
			if (cb_source == null)
				cb_source = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Source);
			return cb_source;
		}

		static IntPtr n_Source (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Stripe.Intellij.Lang.Annotations.IFlow __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Intellij.Lang.Annotations.IFlow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Source ());
		}
#pragma warning restore 0169

		IntPtr id_source;
		public unsafe string Source ()
		{
			if (id_source == IntPtr.Zero)
				id_source = JNIEnv.GetMethodID (class_ref, "source", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_source), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_sourceIsContainer;
#pragma warning disable 0169
		static Delegate GetSourceIsContainerHandler ()
		{
			if (cb_sourceIsContainer == null)
				cb_sourceIsContainer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SourceIsContainer);
			return cb_sourceIsContainer;
		}

		static bool n_SourceIsContainer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Stripe.Intellij.Lang.Annotations.IFlow __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Intellij.Lang.Annotations.IFlow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SourceIsContainer ();
		}
#pragma warning restore 0169

		IntPtr id_sourceIsContainer;
		public unsafe bool SourceIsContainer ()
		{
			if (id_sourceIsContainer == IntPtr.Zero)
				id_sourceIsContainer = JNIEnv.GetMethodID (class_ref, "sourceIsContainer", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_sourceIsContainer);
		}

		static Delegate cb_target;
#pragma warning disable 0169
		static Delegate GetTargetHandler ()
		{
			if (cb_target == null)
				cb_target = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Target);
			return cb_target;
		}

		static IntPtr n_Target (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Stripe.Intellij.Lang.Annotations.IFlow __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Intellij.Lang.Annotations.IFlow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Target ());
		}
#pragma warning restore 0169

		IntPtr id_target;
		public unsafe string Target ()
		{
			if (id_target == IntPtr.Zero)
				id_target = JNIEnv.GetMethodID (class_ref, "target", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_target), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_targetIsContainer;
#pragma warning disable 0169
		static Delegate GetTargetIsContainerHandler ()
		{
			if (cb_targetIsContainer == null)
				cb_targetIsContainer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_TargetIsContainer);
			return cb_targetIsContainer;
		}

		static bool n_TargetIsContainer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Stripe.Intellij.Lang.Annotations.IFlow __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Intellij.Lang.Annotations.IFlow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TargetIsContainer ();
		}
#pragma warning restore 0169

		IntPtr id_targetIsContainer;
		public unsafe bool TargetIsContainer ()
		{
			if (id_targetIsContainer == IntPtr.Zero)
				id_targetIsContainer = JNIEnv.GetMethodID (class_ref, "targetIsContainer", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_targetIsContainer);
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
			global::Com.Stripe.Intellij.Lang.Annotations.IFlow __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Intellij.Lang.Annotations.IFlow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Stripe.Intellij.Lang.Annotations.IFlow __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Intellij.Lang.Annotations.IFlow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Stripe.Intellij.Lang.Annotations.IFlow __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Intellij.Lang.Annotations.IFlow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Stripe.Intellij.Lang.Annotations.IFlow __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Intellij.Lang.Annotations.IFlow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
