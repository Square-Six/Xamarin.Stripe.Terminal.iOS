using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Checkerframework.Checker.I18nformatter.Qual {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.checkerframework.checker.i18nformatter.qual']/class[@name='I18nConversionCategory']"
	[global::Android.Runtime.Register ("org/checkerframework/checker/i18nformatter/qual/I18nConversionCategory", DoNotGenerateAcw=true)]
	public sealed partial class I18nConversionCategory : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.i18nformatter.qual']/class[@name='I18nConversionCategory']/field[@name='DATE']"
		[Register ("DATE")]
		public static global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory Date {
			get {
				const string __id = "DATE.Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.i18nformatter.qual']/class[@name='I18nConversionCategory']/field[@name='GENERAL']"
		[Register ("GENERAL")]
		public static global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory General {
			get {
				const string __id = "GENERAL.Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.i18nformatter.qual']/class[@name='I18nConversionCategory']/field[@name='NUMBER']"
		[Register ("NUMBER")]
		public static global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory Number {
			get {
				const string __id = "NUMBER.Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.i18nformatter.qual']/class[@name='I18nConversionCategory']/field[@name='UNUSED']"
		[Register ("UNUSED")]
		public static global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory Unused {
			get {
				const string __id = "UNUSED.Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.i18nformatter.qual']/class[@name='I18nConversionCategory']/field[@name='strings']"
		[Register ("strings")]
		public IList<string> Strings {
			get {
				const string __id = "strings.[Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "strings.[Ljava/lang/String;";

				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.i18nformatter.qual']/class[@name='I18nConversionCategory']/field[@name='types']"
		[Register ("types")]
		public IList<Java.Lang.Class> Types {
			get {
				const string __id = "types.[Ljava/lang/Class;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<global::Java.Lang.Class>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "types.[Ljava/lang/Class;";

				IntPtr native_value = global::Android.Runtime.JavaArray<global::Java.Lang.Class>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/checkerframework/checker/i18nformatter/qual/I18nConversionCategory", typeof (I18nConversionCategory));
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

		internal I18nConversionCategory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.i18nformatter.qual']/class[@name='I18nConversionCategory']/method[@name='intersect' and count(parameter)=2 and parameter[1][@type='org.checkerframework.checker.i18nformatter.qual.I18nConversionCategory'] and parameter[2][@type='org.checkerframework.checker.i18nformatter.qual.I18nConversionCategory']]"
		[Register ("intersect", "(Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;)Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;", "")]
		public static unsafe global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory Intersect (global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory a, global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory b)
		{
			const string __id = "intersect.(Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;)Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [1] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.i18nformatter.qual']/class[@name='I18nConversionCategory']/method[@name='isSubsetOf' and count(parameter)=2 and parameter[1][@type='org.checkerframework.checker.i18nformatter.qual.I18nConversionCategory'] and parameter[2][@type='org.checkerframework.checker.i18nformatter.qual.I18nConversionCategory']]"
		[Register ("isSubsetOf", "(Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;)Z", "")]
		public static unsafe bool IsSubsetOf (global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory a, global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory b)
		{
			const string __id = "isSubsetOf.(Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [1] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.i18nformatter.qual']/class[@name='I18nConversionCategory']/method[@name='stringToI18nConversionCategory' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("stringToI18nConversionCategory", "(Ljava/lang/String;)Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;", "")]
		public static unsafe global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory StringToI18nConversionCategory (string @string)
		{
			const string __id = "stringToI18nConversionCategory.(Ljava/lang/String;)Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;";
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__string);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.i18nformatter.qual']/class[@name='I18nConversionCategory']/method[@name='union' and count(parameter)=2 and parameter[1][@type='org.checkerframework.checker.i18nformatter.qual.I18nConversionCategory'] and parameter[2][@type='org.checkerframework.checker.i18nformatter.qual.I18nConversionCategory']]"
		[Register ("union", "(Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;)Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;", "")]
		public static unsafe global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory Union (global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory a, global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory b)
		{
			const string __id = "union.(Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;)Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [1] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.i18nformatter.qual']/class[@name='I18nConversionCategory']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;", "")]
		public static unsafe global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.i18nformatter.qual']/class[@name='I18nConversionCategory']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;", "")]
		public static unsafe global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory[] Values ()
		{
			const string __id = "values.()[Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Checkerframework.Checker.I18nformatter.Qual.I18nConversionCategory));
			} finally {
			}
		}

	}
}
