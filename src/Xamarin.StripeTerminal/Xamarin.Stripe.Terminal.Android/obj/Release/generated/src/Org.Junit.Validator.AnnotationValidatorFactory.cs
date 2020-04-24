using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Validator {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.validator']/class[@name='AnnotationValidatorFactory']"
	[global::Android.Runtime.Register ("org/junit/validator/AnnotationValidatorFactory", DoNotGenerateAcw=true)]
	public partial class AnnotationValidatorFactory : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/validator/AnnotationValidatorFactory", typeof (AnnotationValidatorFactory));
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

		protected AnnotationValidatorFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.validator']/class[@name='AnnotationValidatorFactory']/constructor[@name='AnnotationValidatorFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AnnotationValidatorFactory ()
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

		static Delegate cb_createAnnotationValidator_Lorg_junit_validator_ValidateWith_;
#pragma warning disable 0169
		static Delegate GetCreateAnnotationValidator_Lorg_junit_validator_ValidateWith_Handler ()
		{
			if (cb_createAnnotationValidator_Lorg_junit_validator_ValidateWith_ == null)
				cb_createAnnotationValidator_Lorg_junit_validator_ValidateWith_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateAnnotationValidator_Lorg_junit_validator_ValidateWith_);
			return cb_createAnnotationValidator_Lorg_junit_validator_ValidateWith_;
		}

		static IntPtr n_CreateAnnotationValidator_Lorg_junit_validator_ValidateWith_ (IntPtr jnienv, IntPtr native__this, IntPtr native_validateWithAnnotation)
		{
			global::Org.Junit.Validator.AnnotationValidatorFactory __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Validator.AnnotationValidatorFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Junit.Validator.IValidateWith validateWithAnnotation = (global::Org.Junit.Validator.IValidateWith)global::Java.Lang.Object.GetObject<global::Org.Junit.Validator.IValidateWith> (native_validateWithAnnotation, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAnnotationValidator (validateWithAnnotation));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.validator']/class[@name='AnnotationValidatorFactory']/method[@name='createAnnotationValidator' and count(parameter)=1 and parameter[1][@type='org.junit.validator.ValidateWith']]"
		[Register ("createAnnotationValidator", "(Lorg/junit/validator/ValidateWith;)Lorg/junit/validator/AnnotationValidator;", "GetCreateAnnotationValidator_Lorg_junit_validator_ValidateWith_Handler")]
		public virtual unsafe global::Org.Junit.Validator.AnnotationValidator CreateAnnotationValidator (global::Org.Junit.Validator.IValidateWith validateWithAnnotation)
		{
			const string __id = "createAnnotationValidator.(Lorg/junit/validator/ValidateWith;)Lorg/junit/validator/AnnotationValidator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((validateWithAnnotation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) validateWithAnnotation).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Junit.Validator.AnnotationValidator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
