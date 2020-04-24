using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Junit.Framework {

	// Metadata.xml XPath class reference: path="/api/package[@name='junit.framework']/class[@name='Assert']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("junit/framework/Assert", DoNotGenerateAcw=true)]
	public partial class Assert : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("junit/framework/Assert", typeof (Assert));
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

		protected Assert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/constructor[@name='Assert' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe Assert ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=2 and parameter[1][@type='char'] and parameter[2][@type='char']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte'] and parameter[3][@type='byte']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char'] and parameter[3][@type='char']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='short'] and parameter[3][@type='short']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=2 and parameter[1][@type='short'] and parameter[2][@type='short']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertFalse' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertFalse' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertNotNull' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertNotNull' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertNotSame' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertNotSame' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertNull' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertNull' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertSame' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertSame' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertTrue' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='assertTrue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='fail' and count(parameter)=0]"
		[Register ("fail", "()V", "")]
		public static unsafe void Fail ()
		{
			const string __id = "fail.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='fail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='failNotEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='failNotSame' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='failSame' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='Assert']/method[@name='format' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
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

	}
}
