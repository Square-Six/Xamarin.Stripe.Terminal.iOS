using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Checkerframework.Checker.I18nformatter {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.checkerframework.checker.i18nformatter']/class[@name='I18nFormatUtil']"
	[global::Android.Runtime.Register ("org/checkerframework/checker/i18nformatter/I18nFormatUtil", DoNotGenerateAcw=true)]
	public partial class I18nFormatUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/checkerframework/checker/i18nformatter/I18nFormatUtil", typeof (I18nFormatUtil));
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

		protected I18nFormatUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.checkerframework.checker.i18nformatter']/class[@name='I18nFormatUtil']/constructor[@name='I18nFormatUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe I18nFormatUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.i18nformatter']/class[@name='I18nFormatUtil']/method[@name='formatParameterCategories' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("formatParameterCategories", "(Ljava/lang/String;)[Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;", "")]
		public static unsafe global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory[] FormatParameterCategories (string format)
		{
			const string __id = "formatParameterCategories.(Ljava/lang/String;)[Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_format);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory));
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.i18nformatter']/class[@name='I18nFormatUtil']/method[@name='hasFormat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.checkerframework.checker.i18nformatter.qual.I18nConversionCategory...']]"
		[Register ("hasFormat", "(Ljava/lang/String;[Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;)Z", "")]
		public static unsafe bool HasFormat (string format, params global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory[] cc)
		{
			const string __id = "hasFormat.(Ljava/lang/String;[Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;)Z";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_cc = JNIEnv.NewArray (cc);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_cc);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (cc != null) {
					JNIEnv.CopyArray (native_cc, cc);
					JNIEnv.DeleteLocalRef (native_cc);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.i18nformatter']/class[@name='I18nFormatUtil']/method[@name='isFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isFormat", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsFormat (string format)
		{
			const string __id = "isFormat.(Ljava/lang/String;)Z";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_format);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.i18nformatter']/class[@name='I18nFormatUtil']/method[@name='tryFormatSatisfiability' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("tryFormatSatisfiability", "(Ljava/lang/String;)V", "")]
		public static unsafe void TryFormatSatisfiability (string format)
		{
			const string __id = "tryFormatSatisfiability.(Ljava/lang/String;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_format);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
			}
		}

	}
}
