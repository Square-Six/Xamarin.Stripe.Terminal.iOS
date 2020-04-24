using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Checkerframework.Checker.Regex {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.checkerframework.checker.regex']/class[@name='RegexUtil']"
	[global::Android.Runtime.Register ("org/checkerframework/checker/regex/RegexUtil", DoNotGenerateAcw=true)]
	public sealed partial class RegexUtil : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.checkerframework.checker.regex']/class[@name='RegexUtil.CheckedPatternSyntaxException']"
		[global::Android.Runtime.Register ("org/checkerframework/checker/regex/RegexUtil$CheckedPatternSyntaxException", DoNotGenerateAcw=true)]
		public partial class CheckedPatternSyntaxException : global::Java.Lang.Exception {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/checkerframework/checker/regex/RegexUtil$CheckedPatternSyntaxException", typeof (CheckedPatternSyntaxException));
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

			protected CheckedPatternSyntaxException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.checkerframework.checker.regex']/class[@name='RegexUtil.CheckedPatternSyntaxException']/constructor[@name='RegexUtil.CheckedPatternSyntaxException' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;I)V", "")]
			public unsafe CheckedPatternSyntaxException (string desc, string regex, int index)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/String;I)V";

				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_desc = JNIEnv.NewString (desc);
				IntPtr native_regex = JNIEnv.NewString (regex);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_desc);
					__args [1] = new JniArgumentValue (native_regex);
					__args [2] = new JniArgumentValue (index);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_desc);
					JNIEnv.DeleteLocalRef (native_regex);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.checkerframework.checker.regex']/class[@name='RegexUtil.CheckedPatternSyntaxException']/constructor[@name='RegexUtil.CheckedPatternSyntaxException' and count(parameter)=1 and parameter[1][@type='java.util.regex.PatternSyntaxException']]"
			[Register (".ctor", "(Ljava/util/regex/PatternSyntaxException;)V", "")]
			public unsafe CheckedPatternSyntaxException (global::Java.Util.Regex.PatternSyntaxException pse)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/util/regex/PatternSyntaxException;)V";

				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((pse == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) pse).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_getDescription;
#pragma warning disable 0169
			static Delegate GetGetDescriptionHandler ()
			{
				if (cb_getDescription == null)
					cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
				return cb_getDescription;
			}

			static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Checkerframework.Checker.Regex.RegexUtil.CheckedPatternSyntaxException __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Checker.Regex.RegexUtil.CheckedPatternSyntaxException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Description);
			}
#pragma warning restore 0169

			public virtual unsafe string Description {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.regex']/class[@name='RegexUtil.CheckedPatternSyntaxException']/method[@name='getDescription' and count(parameter)=0]"
				[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
				get {
					const string __id = "getDescription.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getIndex;
#pragma warning disable 0169
			static Delegate GetGetIndexHandler ()
			{
				if (cb_getIndex == null)
					cb_getIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndex);
				return cb_getIndex;
			}

			static int n_GetIndex (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Checkerframework.Checker.Regex.RegexUtil.CheckedPatternSyntaxException __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Checker.Regex.RegexUtil.CheckedPatternSyntaxException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Index;
			}
#pragma warning restore 0169

			public virtual unsafe int Index {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.regex']/class[@name='RegexUtil.CheckedPatternSyntaxException']/method[@name='getIndex' and count(parameter)=0]"
				[Register ("getIndex", "()I", "GetGetIndexHandler")]
				get {
					const string __id = "getIndex.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getPattern;
#pragma warning disable 0169
			static Delegate GetGetPatternHandler ()
			{
				if (cb_getPattern == null)
					cb_getPattern = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPattern);
				return cb_getPattern;
			}

			static IntPtr n_GetPattern (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Checkerframework.Checker.Regex.RegexUtil.CheckedPatternSyntaxException __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Checker.Regex.RegexUtil.CheckedPatternSyntaxException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Pattern);
			}
#pragma warning restore 0169

			public virtual unsafe string Pattern {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.regex']/class[@name='RegexUtil.CheckedPatternSyntaxException']/method[@name='getPattern' and count(parameter)=0]"
				[Register ("getPattern", "()Ljava/lang/String;", "GetGetPatternHandler")]
				get {
					const string __id = "getPattern.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/checkerframework/checker/regex/RegexUtil", typeof (RegexUtil));
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

		internal RegexUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.regex']/class[@name='RegexUtil']/method[@name='asRegex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("asRegex", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string AsRegex (string s)
		{
			const string __id = "asRegex.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.regex']/class[@name='RegexUtil']/method[@name='asRegex' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("asRegex", "(Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string AsRegex (string s, int groups)
		{
			const string __id = "asRegex.(Ljava/lang/String;I)Ljava/lang/String;";
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_s);
				__args [1] = new JniArgumentValue (groups);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.regex']/class[@name='RegexUtil']/method[@name='isRegex' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("isRegex", "(C)Z", "")]
		public static unsafe bool IsRegex (char c)
		{
			const string __id = "isRegex.(C)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (c);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.regex']/class[@name='RegexUtil']/method[@name='isRegex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isRegex", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsRegex (string s)
		{
			const string __id = "isRegex.(Ljava/lang/String;)Z";
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.regex']/class[@name='RegexUtil']/method[@name='isRegex' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("isRegex", "(Ljava/lang/String;I)Z", "")]
		public static unsafe bool IsRegex (string s, int groups)
		{
			const string __id = "isRegex.(Ljava/lang/String;I)Z";
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_s);
				__args [1] = new JniArgumentValue (groups);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.regex']/class[@name='RegexUtil']/method[@name='regexError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("regexError", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string RegexError (string s)
		{
			const string __id = "regexError.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.regex']/class[@name='RegexUtil']/method[@name='regexError' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("regexError", "(Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string RegexError (string s, int groups)
		{
			const string __id = "regexError.(Ljava/lang/String;I)Ljava/lang/String;";
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_s);
				__args [1] = new JniArgumentValue (groups);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.regex']/class[@name='RegexUtil']/method[@name='regexException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("regexException", "(Ljava/lang/String;)Ljava/util/regex/PatternSyntaxException;", "")]
		public static unsafe global::Java.Util.Regex.PatternSyntaxException RegexException (string s)
		{
			const string __id = "regexException.(Ljava/lang/String;)Ljava/util/regex/PatternSyntaxException;";
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Regex.PatternSyntaxException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.regex']/class[@name='RegexUtil']/method[@name='regexException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("regexException", "(Ljava/lang/String;I)Ljava/util/regex/PatternSyntaxException;", "")]
		public static unsafe global::Java.Util.Regex.PatternSyntaxException RegexException (string s, int groups)
		{
			const string __id = "regexException.(Ljava/lang/String;I)Ljava/util/regex/PatternSyntaxException;";
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_s);
				__args [1] = new JniArgumentValue (groups);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Regex.PatternSyntaxException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

	}
}
