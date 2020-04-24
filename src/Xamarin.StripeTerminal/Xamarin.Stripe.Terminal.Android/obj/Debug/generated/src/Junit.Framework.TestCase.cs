using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Junit.Framework {

	// Metadata.xml XPath class reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']"
	[global::Android.Runtime.Register ("junit/framework/TestCase", DoNotGenerateAcw=true)]
	public abstract partial class TestCase : global::Junit.Framework.Assert, global::Junit.Framework.ITest {

		static readonly JniPeerMembers _members = new XAPeerMembers ("junit/framework/TestCase", typeof (TestCase));
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

		protected TestCase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/constructor[@name='TestCase' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TestCase ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/constructor[@name='TestCase' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe TestCase (string name)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestCase __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestCase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Junit.Framework.TestCase __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestCase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.Name = name;
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertEquals' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("assertEquals", "(ZZ)V", "")]
		public static unsafe void AssertEquals (bool expected, bool actual)
		{
			const string __id = "assertEquals.(ZZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (expected);
				__args [1] = new JniArgumentValue (actual);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertEquals' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
		[Register ("assertEquals", "(BB)V", "")]
		public static unsafe void AssertEquals (sbyte expected, sbyte actual)
		{
			const string __id = "assertEquals.(BB)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (expected);
				__args [1] = new JniArgumentValue (actual);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertEquals' and count(parameter)=2 and parameter[1][@type='char'] and parameter[2][@type='char']]"
		[Register ("assertEquals", "(CC)V", "")]
		public static unsafe void AssertEquals (char expected, char actual)
		{
			const string __id = "assertEquals.(CC)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (expected);
				__args [1] = new JniArgumentValue (actual);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("assertEquals", "(DDD)V", "")]
		public static unsafe void AssertEquals (double expected, double actual, double delta)
		{
			const string __id = "assertEquals.(DDD)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (expected);
				__args [1] = new JniArgumentValue (actual);
				__args [2] = new JniArgumentValue (delta);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("assertEquals", "(FFF)V", "")]
		public static unsafe void AssertEquals (float expected, float actual, float delta)
		{
			const string __id = "assertEquals.(FFF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (expected);
				__args [1] = new JniArgumentValue (actual);
				__args [2] = new JniArgumentValue (delta);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertEquals' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("assertEquals", "(II)V", "")]
		public static unsafe void AssertEquals (int expected, int actual)
		{
			const string __id = "assertEquals.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (expected);
				__args [1] = new JniArgumentValue (actual);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertEquals' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("assertEquals", "(Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public static unsafe void AssertEquals (global::Java.Lang.Object expected, global::Java.Lang.Object actual)
		{
			const string __id = "assertEquals.(Ljava/lang/Object;Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((expected == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expected).Handle);
				__args [1] = new JniArgumentValue ((actual == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actual).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("assertEquals", "(Ljava/lang/String;ZZ)V", "")]
		public static unsafe void AssertEquals (string message, bool expected, bool actual)
		{
			const string __id = "assertEquals.(Ljava/lang/String;ZZ)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (expected);
				__args [2] = new JniArgumentValue (actual);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte'] and parameter[3][@type='byte']]"
		[Register ("assertEquals", "(Ljava/lang/String;BB)V", "")]
		public static unsafe void AssertEquals (string message, sbyte expected, sbyte actual)
		{
			const string __id = "assertEquals.(Ljava/lang/String;BB)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (expected);
				__args [2] = new JniArgumentValue (actual);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char'] and parameter[3][@type='char']]"
		[Register ("assertEquals", "(Ljava/lang/String;CC)V", "")]
		public static unsafe void AssertEquals (string message, char expected, char actual)
		{
			const string __id = "assertEquals.(Ljava/lang/String;CC)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (expected);
				__args [2] = new JniArgumentValue (actual);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertEquals' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
		[Register ("assertEquals", "(Ljava/lang/String;DDD)V", "")]
		public static unsafe void AssertEquals (string message, double expected, double actual, double delta)
		{
			const string __id = "assertEquals.(Ljava/lang/String;DDD)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (expected);
				__args [2] = new JniArgumentValue (actual);
				__args [3] = new JniArgumentValue (delta);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertEquals' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("assertEquals", "(Ljava/lang/String;FFF)V", "")]
		public static unsafe void AssertEquals (string message, float expected, float actual, float delta)
		{
			const string __id = "assertEquals.(Ljava/lang/String;FFF)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (expected);
				__args [2] = new JniArgumentValue (actual);
				__args [3] = new JniArgumentValue (delta);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("assertEquals", "(Ljava/lang/String;II)V", "")]
		public static unsafe void AssertEquals (string message, int expected, int actual)
		{
			const string __id = "assertEquals.(Ljava/lang/String;II)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (expected);
				__args [2] = new JniArgumentValue (actual);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("assertEquals", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public static unsafe void AssertEquals (string message, global::Java.Lang.Object expected, global::Java.Lang.Object actual)
		{
			const string __id = "assertEquals.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((expected == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expected).Handle);
				__args [2] = new JniArgumentValue ((actual == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actual).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertEquals' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("assertEquals", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void AssertEquals (string expected, string actual)
		{
			const string __id = "assertEquals.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_expected = JNIEnv.NewString (expected);
			IntPtr native_actual = JNIEnv.NewString (actual);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_expected);
				__args [1] = new JniArgumentValue (native_actual);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_expected);
				JNIEnv.DeleteLocalRef (native_actual);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("assertEquals", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void AssertEquals (string message, string expected, string actual)
		{
			const string __id = "assertEquals.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_expected = JNIEnv.NewString (expected);
			IntPtr native_actual = JNIEnv.NewString (actual);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (native_expected);
				__args [2] = new JniArgumentValue (native_actual);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				JNIEnv.DeleteLocalRef (native_expected);
				JNIEnv.DeleteLocalRef (native_actual);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("assertEquals", "(Ljava/lang/String;JJ)V", "")]
		public static unsafe void AssertEquals (string message, long expected, long actual)
		{
			const string __id = "assertEquals.(Ljava/lang/String;JJ)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (expected);
				__args [2] = new JniArgumentValue (actual);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='short'] and parameter[3][@type='short']]"
		[Register ("assertEquals", "(Ljava/lang/String;SS)V", "")]
		public static unsafe void AssertEquals (string message, short expected, short actual)
		{
			const string __id = "assertEquals.(Ljava/lang/String;SS)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (expected);
				__args [2] = new JniArgumentValue (actual);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertEquals' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("assertEquals", "(JJ)V", "")]
		public static unsafe void AssertEquals (long expected, long actual)
		{
			const string __id = "assertEquals.(JJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (expected);
				__args [1] = new JniArgumentValue (actual);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertEquals' and count(parameter)=2 and parameter[1][@type='short'] and parameter[2][@type='short']]"
		[Register ("assertEquals", "(SS)V", "")]
		public static unsafe void AssertEquals (short expected, short actual)
		{
			const string __id = "assertEquals.(SS)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (expected);
				__args [1] = new JniArgumentValue (actual);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertFalse' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("assertFalse", "(Z)V", "")]
		public static unsafe void AssertFalse (bool condition)
		{
			const string __id = "assertFalse.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (condition);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertFalse' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("assertFalse", "(Ljava/lang/String;Z)V", "")]
		public static unsafe void AssertFalse (string message, bool condition)
		{
			const string __id = "assertFalse.(Ljava/lang/String;Z)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (condition);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertNotNull' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("assertNotNull", "(Ljava/lang/Object;)V", "")]
		public static unsafe void AssertNotNull (global::Java.Lang.Object @object)
		{
			const string __id = "assertNotNull.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertNotNull' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("assertNotNull", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public static unsafe void AssertNotNull (string message, global::Java.Lang.Object @object)
		{
			const string __id = "assertNotNull.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertNotSame' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("assertNotSame", "(Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public static unsafe void AssertNotSame (global::Java.Lang.Object expected, global::Java.Lang.Object actual)
		{
			const string __id = "assertNotSame.(Ljava/lang/Object;Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((expected == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expected).Handle);
				__args [1] = new JniArgumentValue ((actual == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actual).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertNotSame' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("assertNotSame", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public static unsafe void AssertNotSame (string message, global::Java.Lang.Object expected, global::Java.Lang.Object actual)
		{
			const string __id = "assertNotSame.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((expected == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expected).Handle);
				__args [2] = new JniArgumentValue ((actual == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actual).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertNull' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("assertNull", "(Ljava/lang/Object;)V", "")]
		public static unsafe void AssertNull (global::Java.Lang.Object @object)
		{
			const string __id = "assertNull.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertNull' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("assertNull", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public static unsafe void AssertNull (string message, global::Java.Lang.Object @object)
		{
			const string __id = "assertNull.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertSame' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("assertSame", "(Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public static unsafe void AssertSame (global::Java.Lang.Object expected, global::Java.Lang.Object actual)
		{
			const string __id = "assertSame.(Ljava/lang/Object;Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((expected == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expected).Handle);
				__args [1] = new JniArgumentValue ((actual == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actual).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertSame' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("assertSame", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public static unsafe void AssertSame (string message, global::Java.Lang.Object expected, global::Java.Lang.Object actual)
		{
			const string __id = "assertSame.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((expected == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expected).Handle);
				__args [2] = new JniArgumentValue ((actual == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actual).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertTrue' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("assertTrue", "(Z)V", "")]
		public static unsafe void AssertTrue (bool condition)
		{
			const string __id = "assertTrue.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (condition);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='assertTrue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("assertTrue", "(Ljava/lang/String;Z)V", "")]
		public static unsafe void AssertTrue (string message, bool condition)
		{
			const string __id = "assertTrue.(Ljava/lang/String;Z)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (condition);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_countTestCases;
#pragma warning disable 0169
		static Delegate GetCountTestCasesHandler ()
		{
			if (cb_countTestCases == null)
				cb_countTestCases = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_CountTestCases);
			return cb_countTestCases;
		}

		static int n_CountTestCases (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestCase __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestCase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CountTestCases ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='countTestCases' and count(parameter)=0]"
		[Register ("countTestCases", "()I", "GetCountTestCasesHandler")]
		public virtual unsafe int CountTestCases ()
		{
			const string __id = "countTestCases.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_createResult;
#pragma warning disable 0169
		static Delegate GetCreateResultHandler ()
		{
			if (cb_createResult == null)
				cb_createResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateResult);
			return cb_createResult;
		}

		static IntPtr n_CreateResult (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestCase __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestCase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateResult ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='createResult' and count(parameter)=0]"
		[Register ("createResult", "()Ljunit/framework/TestResult;", "GetCreateResultHandler")]
		protected virtual unsafe global::Junit.Framework.TestResult CreateResult ()
		{
			const string __id = "createResult.()Ljunit/framework/TestResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='fail' and count(parameter)=0]"
		[Register ("fail", "()V", "")]
		public static unsafe void Fail ()
		{
			const string __id = "fail.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='fail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fail", "(Ljava/lang/String;)V", "")]
		public static unsafe void Fail (string message)
		{
			const string __id = "fail.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='failNotEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("failNotEquals", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public static unsafe void FailNotEquals (string message, global::Java.Lang.Object expected, global::Java.Lang.Object actual)
		{
			const string __id = "failNotEquals.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((expected == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expected).Handle);
				__args [2] = new JniArgumentValue ((actual == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actual).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='failNotSame' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("failNotSame", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public static unsafe void FailNotSame (string message, global::Java.Lang.Object expected, global::Java.Lang.Object actual)
		{
			const string __id = "failNotSame.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((expected == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expected).Handle);
				__args [2] = new JniArgumentValue ((actual == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actual).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='failSame' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("failSame", "(Ljava/lang/String;)V", "")]
		public static unsafe void FailSame (string message)
		{
			const string __id = "failSame.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='format' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("format", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string Format (string message, global::Java.Lang.Object expected, global::Java.Lang.Object actual)
		{
			const string __id = "format.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String;";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((expected == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expected).Handle);
				__args [2] = new JniArgumentValue ((actual == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actual).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static IntPtr n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestCase __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestCase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Run ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()Ljunit/framework/TestResult;", "GetRunHandler")]
		public virtual unsafe global::Junit.Framework.TestResult Run ()
		{
			const string __id = "run.()Ljunit/framework/TestResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_run_Ljunit_framework_TestResult_;
#pragma warning disable 0169
		static Delegate GetRun_Ljunit_framework_TestResult_Handler ()
		{
			if (cb_run_Ljunit_framework_TestResult_ == null)
				cb_run_Ljunit_framework_TestResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Run_Ljunit_framework_TestResult_);
			return cb_run_Ljunit_framework_TestResult_;
		}

		static void n_Run_Ljunit_framework_TestResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			global::Junit.Framework.TestCase __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestCase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.TestResult result = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (native_result, JniHandleOwnership.DoNotTransfer);
			__this.Run (result);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='run' and count(parameter)=1 and parameter[1][@type='junit.framework.TestResult']]"
		[Register ("run", "(Ljunit/framework/TestResult;)V", "GetRun_Ljunit_framework_TestResult_Handler")]
		public virtual unsafe void Run (global::Junit.Framework.TestResult result)
		{
			const string __id = "run.(Ljunit/framework/TestResult;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_runBare;
#pragma warning disable 0169
		static Delegate GetRunBareHandler ()
		{
			if (cb_runBare == null)
				cb_runBare = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RunBare);
			return cb_runBare;
		}

		static void n_RunBare (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestCase __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestCase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RunBare ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='runBare' and count(parameter)=0]"
		[Register ("runBare", "()V", "GetRunBareHandler")]
		public virtual unsafe void RunBare ()
		{
			const string __id = "runBare.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_runTest;
#pragma warning disable 0169
		static Delegate GetRunTestHandler ()
		{
			if (cb_runTest == null)
				cb_runTest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RunTest);
			return cb_runTest;
		}

		static void n_RunTest (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestCase __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestCase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RunTest ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='runTest' and count(parameter)=0]"
		[Register ("runTest", "()V", "GetRunTestHandler")]
		protected virtual unsafe void RunTest ()
		{
			const string __id = "runTest.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setUp;
#pragma warning disable 0169
		static Delegate GetSetUpHandler ()
		{
			if (cb_setUp == null)
				cb_setUp = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetUp);
			return cb_setUp;
		}

		static void n_SetUp (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestCase __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestCase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUp ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='setUp' and count(parameter)=0]"
		[Register ("setUp", "()V", "GetSetUpHandler")]
		protected virtual unsafe void SetUp ()
		{
			const string __id = "setUp.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_tearDown;
#pragma warning disable 0169
		static Delegate GetTearDownHandler ()
		{
			if (cb_tearDown == null)
				cb_tearDown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TearDown);
			return cb_tearDown;
		}

		static void n_TearDown (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.TestCase __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestCase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TearDown ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='TestCase']/method[@name='tearDown' and count(parameter)=0]"
		[Register ("tearDown", "()V", "GetTearDownHandler")]
		protected virtual unsafe void TearDown ()
		{
			const string __id = "tearDown.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("junit/framework/TestCase", DoNotGenerateAcw=true)]
	internal partial class TestCaseInvoker : TestCase {

		public TestCaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("junit/framework/TestCase", typeof (TestCaseInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
