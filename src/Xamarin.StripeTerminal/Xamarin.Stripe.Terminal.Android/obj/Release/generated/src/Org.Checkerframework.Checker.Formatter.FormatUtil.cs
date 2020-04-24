using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Checkerframework.Checker.Formatter {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.checkerframework.checker.formatter']/class[@name='FormatUtil']"
	[global::Android.Runtime.Register ("org/checkerframework/checker/formatter/FormatUtil", DoNotGenerateAcw=true)]
	public partial class FormatUtil : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.checkerframework.checker.formatter']/class[@name='FormatUtil.ExcessiveOrMissingFormatArgumentException']"
		[global::Android.Runtime.Register ("org/checkerframework/checker/formatter/FormatUtil$ExcessiveOrMissingFormatArgumentException", DoNotGenerateAcw=true)]
		public partial class ExcessiveOrMissingFormatArgumentException : global::Java.Util.MissingFormatArgumentException {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/checkerframework/checker/formatter/FormatUtil$ExcessiveOrMissingFormatArgumentException", typeof (ExcessiveOrMissingFormatArgumentException));
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

			protected ExcessiveOrMissingFormatArgumentException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.checkerframework.checker.formatter']/class[@name='FormatUtil.ExcessiveOrMissingFormatArgumentException']/constructor[@name='FormatUtil.ExcessiveOrMissingFormatArgumentException' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register (".ctor", "(II)V", "")]
			public unsafe ExcessiveOrMissingFormatArgumentException (int expected, int found)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(II)V";

				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (expected);
					__args [1] = new JniArgumentValue (found);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_getExpected;
#pragma warning disable 0169
			static Delegate GetGetExpectedHandler ()
			{
				if (cb_getExpected == null)
					cb_getExpected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetExpected);
				return cb_getExpected;
			}

			static int n_GetExpected (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Checkerframework.Checker.Formatter.FormatUtil.ExcessiveOrMissingFormatArgumentException __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Checker.Formatter.FormatUtil.ExcessiveOrMissingFormatArgumentException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Expected;
			}
#pragma warning restore 0169

			public virtual unsafe int Expected {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.formatter']/class[@name='FormatUtil.ExcessiveOrMissingFormatArgumentException']/method[@name='getExpected' and count(parameter)=0]"
				[Register ("getExpected", "()I", "GetGetExpectedHandler")]
				get {
					const string __id = "getExpected.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getFound;
#pragma warning disable 0169
			static Delegate GetGetFoundHandler ()
			{
				if (cb_getFound == null)
					cb_getFound = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFound);
				return cb_getFound;
			}

			static int n_GetFound (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Checkerframework.Checker.Formatter.FormatUtil.ExcessiveOrMissingFormatArgumentException __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Checker.Formatter.FormatUtil.ExcessiveOrMissingFormatArgumentException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Found;
			}
#pragma warning restore 0169

			public virtual unsafe int Found {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.formatter']/class[@name='FormatUtil.ExcessiveOrMissingFormatArgumentException']/method[@name='getFound' and count(parameter)=0]"
				[Register ("getFound", "()I", "GetGetFoundHandler")]
				get {
					const string __id = "getFound.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.checkerframework.checker.formatter']/class[@name='FormatUtil.IllegalFormatConversionCategoryException']"
		[global::Android.Runtime.Register ("org/checkerframework/checker/formatter/FormatUtil$IllegalFormatConversionCategoryException", DoNotGenerateAcw=true)]
		public partial class IllegalFormatConversionCategoryException : global::Java.Util.IllegalFormatConversionException {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/checkerframework/checker/formatter/FormatUtil$IllegalFormatConversionCategoryException", typeof (IllegalFormatConversionCategoryException));
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

			protected IllegalFormatConversionCategoryException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.checkerframework.checker.formatter']/class[@name='FormatUtil.IllegalFormatConversionCategoryException']/constructor[@name='FormatUtil.IllegalFormatConversionCategoryException' and count(parameter)=2 and parameter[1][@type='org.checkerframework.checker.formatter.qual.ConversionCategory'] and parameter[2][@type='org.checkerframework.checker.formatter.qual.ConversionCategory']]"
			[Register (".ctor", "(Lorg/checkerframework/checker/formatter/qual/ConversionCategory;Lorg/checkerframework/checker/formatter/qual/ConversionCategory;)V", "")]
			public unsafe IllegalFormatConversionCategoryException (global::Org.Checkerframework.Checker.Formatter.Qual.ConversionCategory expected, global::Org.Checkerframework.Checker.Formatter.Qual.ConversionCategory found)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lorg/checkerframework/checker/formatter/qual/ConversionCategory;Lorg/checkerframework/checker/formatter/qual/ConversionCategory;)V";

				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((expected == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expected).Handle);
					__args [1] = new JniArgumentValue ((found == null) ? IntPtr.Zero : ((global::Java.Lang.Object) found).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_getExpected;
#pragma warning disable 0169
			static Delegate GetGetExpectedHandler ()
			{
				if (cb_getExpected == null)
					cb_getExpected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExpected);
				return cb_getExpected;
			}

			static IntPtr n_GetExpected (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Checkerframework.Checker.Formatter.FormatUtil.IllegalFormatConversionCategoryException __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Checker.Formatter.FormatUtil.IllegalFormatConversionCategoryException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Expected);
			}
#pragma warning restore 0169

			public virtual unsafe global::Org.Checkerframework.Checker.Formatter.Qual.ConversionCategory Expected {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.formatter']/class[@name='FormatUtil.IllegalFormatConversionCategoryException']/method[@name='getExpected' and count(parameter)=0]"
				[Register ("getExpected", "()Lorg/checkerframework/checker/formatter/qual/ConversionCategory;", "GetGetExpectedHandler")]
				get {
					const string __id = "getExpected.()Lorg/checkerframework/checker/formatter/qual/ConversionCategory;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Checker.Formatter.Qual.ConversionCategory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getFound;
#pragma warning disable 0169
			static Delegate GetGetFoundHandler ()
			{
				if (cb_getFound == null)
					cb_getFound = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFound);
				return cb_getFound;
			}

			static IntPtr n_GetFound (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Checkerframework.Checker.Formatter.FormatUtil.IllegalFormatConversionCategoryException __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Checker.Formatter.FormatUtil.IllegalFormatConversionCategoryException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Found);
			}
#pragma warning restore 0169

			public virtual unsafe global::Org.Checkerframework.Checker.Formatter.Qual.ConversionCategory Found {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.formatter']/class[@name='FormatUtil.IllegalFormatConversionCategoryException']/method[@name='getFound' and count(parameter)=0]"
				[Register ("getFound", "()Lorg/checkerframework/checker/formatter/qual/ConversionCategory;", "GetGetFoundHandler")]
				get {
					const string __id = "getFound.()Lorg/checkerframework/checker/formatter/qual/ConversionCategory;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Checker.Formatter.Qual.ConversionCategory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/checkerframework/checker/formatter/FormatUtil", typeof (FormatUtil));
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

		protected FormatUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.checkerframework.checker.formatter']/class[@name='FormatUtil']/constructor[@name='FormatUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FormatUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.formatter']/class[@name='FormatUtil']/method[@name='asFormat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.checkerframework.checker.formatter.qual.ConversionCategory...']]"
		[Register ("asFormat", "(Ljava/lang/String;[Lorg/checkerframework/checker/formatter/qual/ConversionCategory;)Ljava/lang/String;", "")]
		public static unsafe string AsFormat (string format, params global::Org.Checkerframework.Checker.Formatter.Qual.ConversionCategory[] cc)
		{
			const string __id = "asFormat.(Ljava/lang/String;[Lorg/checkerframework/checker/formatter/qual/ConversionCategory;)Ljava/lang/String;";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_cc = JNIEnv.NewArray (cc);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_cc);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (cc != null) {
					JNIEnv.CopyArray (native_cc, cc);
					JNIEnv.DeleteLocalRef (native_cc);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.formatter']/class[@name='FormatUtil']/method[@name='formatParameterCategories' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("formatParameterCategories", "(Ljava/lang/String;)[Lorg/checkerframework/checker/formatter/qual/ConversionCategory;", "")]
		public static unsafe global::Org.Checkerframework.Checker.Formatter.Qual.ConversionCategory[] FormatParameterCategories (string format)
		{
			const string __id = "formatParameterCategories.(Ljava/lang/String;)[Lorg/checkerframework/checker/formatter/qual/ConversionCategory;";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_format);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Org.Checkerframework.Checker.Formatter.Qual.ConversionCategory[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Checkerframework.Checker.Formatter.Qual.ConversionCategory));
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.formatter']/class[@name='FormatUtil']/method[@name='tryFormatSatisfiability' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
