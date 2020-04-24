using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit']/class[@name='Assert']"
	[global::Android.Runtime.Register ("org/junit/Assert", DoNotGenerateAcw=true)]
	public partial class Assert : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/Assert", typeof (Assert));
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit']/class[@name='Assert']/constructor[@name='Assert' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertArrayEquals' and count(parameter)=2 and parameter[1][@type='boolean[]'] and parameter[2][@type='boolean[]']]"
		[Register ("assertArrayEquals", "([Z[Z)V", "")]
		public static unsafe void AssertArrayEquals (bool[] expecteds, bool[] actuals)
		{
			const string __id = "assertArrayEquals.([Z[Z)V";
			IntPtr native_expecteds = JNIEnv.NewArray (expecteds);
			IntPtr native_actuals = JNIEnv.NewArray (actuals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_expecteds);
				__args [1] = new JniArgumentValue (native_actuals);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (expecteds != null) {
					JNIEnv.CopyArray (native_expecteds, expecteds);
					JNIEnv.DeleteLocalRef (native_expecteds);
				}
				if (actuals != null) {
					JNIEnv.CopyArray (native_actuals, actuals);
					JNIEnv.DeleteLocalRef (native_actuals);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertArrayEquals' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("assertArrayEquals", "([B[B)V", "")]
		public static unsafe void AssertArrayEquals (byte[] expecteds, byte[] actuals)
		{
			const string __id = "assertArrayEquals.([B[B)V";
			IntPtr native_expecteds = JNIEnv.NewArray (expecteds);
			IntPtr native_actuals = JNIEnv.NewArray (actuals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_expecteds);
				__args [1] = new JniArgumentValue (native_actuals);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (expecteds != null) {
					JNIEnv.CopyArray (native_expecteds, expecteds);
					JNIEnv.DeleteLocalRef (native_expecteds);
				}
				if (actuals != null) {
					JNIEnv.CopyArray (native_actuals, actuals);
					JNIEnv.DeleteLocalRef (native_actuals);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertArrayEquals' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='char[]']]"
		[Register ("assertArrayEquals", "([C[C)V", "")]
		public static unsafe void AssertArrayEquals (char[] expecteds, char[] actuals)
		{
			const string __id = "assertArrayEquals.([C[C)V";
			IntPtr native_expecteds = JNIEnv.NewArray (expecteds);
			IntPtr native_actuals = JNIEnv.NewArray (actuals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_expecteds);
				__args [1] = new JniArgumentValue (native_actuals);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (expecteds != null) {
					JNIEnv.CopyArray (native_expecteds, expecteds);
					JNIEnv.DeleteLocalRef (native_expecteds);
				}
				if (actuals != null) {
					JNIEnv.CopyArray (native_actuals, actuals);
					JNIEnv.DeleteLocalRef (native_actuals);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertArrayEquals' and count(parameter)=3 and parameter[1][@type='double[]'] and parameter[2][@type='double[]'] and parameter[3][@type='double']]"
		[Register ("assertArrayEquals", "([D[DD)V", "")]
		public static unsafe void AssertArrayEquals (double[] expecteds, double[] actuals, double delta)
		{
			const string __id = "assertArrayEquals.([D[DD)V";
			IntPtr native_expecteds = JNIEnv.NewArray (expecteds);
			IntPtr native_actuals = JNIEnv.NewArray (actuals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_expecteds);
				__args [1] = new JniArgumentValue (native_actuals);
				__args [2] = new JniArgumentValue (delta);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (expecteds != null) {
					JNIEnv.CopyArray (native_expecteds, expecteds);
					JNIEnv.DeleteLocalRef (native_expecteds);
				}
				if (actuals != null) {
					JNIEnv.CopyArray (native_actuals, actuals);
					JNIEnv.DeleteLocalRef (native_actuals);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertArrayEquals' and count(parameter)=3 and parameter[1][@type='float[]'] and parameter[2][@type='float[]'] and parameter[3][@type='float']]"
		[Register ("assertArrayEquals", "([F[FF)V", "")]
		public static unsafe void AssertArrayEquals (float[] expecteds, float[] actuals, float delta)
		{
			const string __id = "assertArrayEquals.([F[FF)V";
			IntPtr native_expecteds = JNIEnv.NewArray (expecteds);
			IntPtr native_actuals = JNIEnv.NewArray (actuals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_expecteds);
				__args [1] = new JniArgumentValue (native_actuals);
				__args [2] = new JniArgumentValue (delta);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (expecteds != null) {
					JNIEnv.CopyArray (native_expecteds, expecteds);
					JNIEnv.DeleteLocalRef (native_expecteds);
				}
				if (actuals != null) {
					JNIEnv.CopyArray (native_actuals, actuals);
					JNIEnv.DeleteLocalRef (native_actuals);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertArrayEquals' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("assertArrayEquals", "([I[I)V", "")]
		public static unsafe void AssertArrayEquals (int[] expecteds, int[] actuals)
		{
			const string __id = "assertArrayEquals.([I[I)V";
			IntPtr native_expecteds = JNIEnv.NewArray (expecteds);
			IntPtr native_actuals = JNIEnv.NewArray (actuals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_expecteds);
				__args [1] = new JniArgumentValue (native_actuals);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (expecteds != null) {
					JNIEnv.CopyArray (native_expecteds, expecteds);
					JNIEnv.DeleteLocalRef (native_expecteds);
				}
				if (actuals != null) {
					JNIEnv.CopyArray (native_actuals, actuals);
					JNIEnv.DeleteLocalRef (native_actuals);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertArrayEquals' and count(parameter)=2 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='java.lang.Object[]']]"
		[Register ("assertArrayEquals", "([Ljava/lang/Object;[Ljava/lang/Object;)V", "")]
		public static unsafe void AssertArrayEquals (global::Java.Lang.Object[] expecteds, global::Java.Lang.Object[] actuals)
		{
			const string __id = "assertArrayEquals.([Ljava/lang/Object;[Ljava/lang/Object;)V";
			IntPtr native_expecteds = JNIEnv.NewArray (expecteds);
			IntPtr native_actuals = JNIEnv.NewArray (actuals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_expecteds);
				__args [1] = new JniArgumentValue (native_actuals);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (expecteds != null) {
					JNIEnv.CopyArray (native_expecteds, expecteds);
					JNIEnv.DeleteLocalRef (native_expecteds);
				}
				if (actuals != null) {
					JNIEnv.CopyArray (native_actuals, actuals);
					JNIEnv.DeleteLocalRef (native_actuals);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertArrayEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean[]'] and parameter[3][@type='boolean[]']]"
		[Register ("assertArrayEquals", "(Ljava/lang/String;[Z[Z)V", "")]
		public static unsafe void AssertArrayEquals (string message, bool[] expecteds, bool[] actuals)
		{
			const string __id = "assertArrayEquals.(Ljava/lang/String;[Z[Z)V";
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_expecteds = JNIEnv.NewArray (expecteds);
			IntPtr native_actuals = JNIEnv.NewArray (actuals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (native_expecteds);
				__args [2] = new JniArgumentValue (native_actuals);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (expecteds != null) {
					JNIEnv.CopyArray (native_expecteds, expecteds);
					JNIEnv.DeleteLocalRef (native_expecteds);
				}
				if (actuals != null) {
					JNIEnv.CopyArray (native_actuals, actuals);
					JNIEnv.DeleteLocalRef (native_actuals);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertArrayEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("assertArrayEquals", "(Ljava/lang/String;[B[B)V", "")]
		public static unsafe void AssertArrayEquals (string message, byte[] expecteds, byte[] actuals)
		{
			const string __id = "assertArrayEquals.(Ljava/lang/String;[B[B)V";
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_expecteds = JNIEnv.NewArray (expecteds);
			IntPtr native_actuals = JNIEnv.NewArray (actuals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (native_expecteds);
				__args [2] = new JniArgumentValue (native_actuals);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (expecteds != null) {
					JNIEnv.CopyArray (native_expecteds, expecteds);
					JNIEnv.DeleteLocalRef (native_expecteds);
				}
				if (actuals != null) {
					JNIEnv.CopyArray (native_actuals, actuals);
					JNIEnv.DeleteLocalRef (native_actuals);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertArrayEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char[]'] and parameter[3][@type='char[]']]"
		[Register ("assertArrayEquals", "(Ljava/lang/String;[C[C)V", "")]
		public static unsafe void AssertArrayEquals (string message, char[] expecteds, char[] actuals)
		{
			const string __id = "assertArrayEquals.(Ljava/lang/String;[C[C)V";
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_expecteds = JNIEnv.NewArray (expecteds);
			IntPtr native_actuals = JNIEnv.NewArray (actuals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (native_expecteds);
				__args [2] = new JniArgumentValue (native_actuals);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (expecteds != null) {
					JNIEnv.CopyArray (native_expecteds, expecteds);
					JNIEnv.DeleteLocalRef (native_expecteds);
				}
				if (actuals != null) {
					JNIEnv.CopyArray (native_actuals, actuals);
					JNIEnv.DeleteLocalRef (native_actuals);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertArrayEquals' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double[]'] and parameter[3][@type='double[]'] and parameter[4][@type='double']]"
		[Register ("assertArrayEquals", "(Ljava/lang/String;[D[DD)V", "")]
		public static unsafe void AssertArrayEquals (string message, double[] expecteds, double[] actuals, double delta)
		{
			const string __id = "assertArrayEquals.(Ljava/lang/String;[D[DD)V";
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_expecteds = JNIEnv.NewArray (expecteds);
			IntPtr native_actuals = JNIEnv.NewArray (actuals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (native_expecteds);
				__args [2] = new JniArgumentValue (native_actuals);
				__args [3] = new JniArgumentValue (delta);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (expecteds != null) {
					JNIEnv.CopyArray (native_expecteds, expecteds);
					JNIEnv.DeleteLocalRef (native_expecteds);
				}
				if (actuals != null) {
					JNIEnv.CopyArray (native_actuals, actuals);
					JNIEnv.DeleteLocalRef (native_actuals);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertArrayEquals' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float[]'] and parameter[3][@type='float[]'] and parameter[4][@type='float']]"
		[Register ("assertArrayEquals", "(Ljava/lang/String;[F[FF)V", "")]
		public static unsafe void AssertArrayEquals (string message, float[] expecteds, float[] actuals, float delta)
		{
			const string __id = "assertArrayEquals.(Ljava/lang/String;[F[FF)V";
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_expecteds = JNIEnv.NewArray (expecteds);
			IntPtr native_actuals = JNIEnv.NewArray (actuals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (native_expecteds);
				__args [2] = new JniArgumentValue (native_actuals);
				__args [3] = new JniArgumentValue (delta);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (expecteds != null) {
					JNIEnv.CopyArray (native_expecteds, expecteds);
					JNIEnv.DeleteLocalRef (native_expecteds);
				}
				if (actuals != null) {
					JNIEnv.CopyArray (native_actuals, actuals);
					JNIEnv.DeleteLocalRef (native_actuals);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertArrayEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]']]"
		[Register ("assertArrayEquals", "(Ljava/lang/String;[I[I)V", "")]
		public static unsafe void AssertArrayEquals (string message, int[] expecteds, int[] actuals)
		{
			const string __id = "assertArrayEquals.(Ljava/lang/String;[I[I)V";
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_expecteds = JNIEnv.NewArray (expecteds);
			IntPtr native_actuals = JNIEnv.NewArray (actuals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (native_expecteds);
				__args [2] = new JniArgumentValue (native_actuals);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (expecteds != null) {
					JNIEnv.CopyArray (native_expecteds, expecteds);
					JNIEnv.DeleteLocalRef (native_expecteds);
				}
				if (actuals != null) {
					JNIEnv.CopyArray (native_actuals, actuals);
					JNIEnv.DeleteLocalRef (native_actuals);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertArrayEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object[]'] and parameter[3][@type='java.lang.Object[]']]"
		[Register ("assertArrayEquals", "(Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/Object;)V", "")]
		public static unsafe void AssertArrayEquals (string message, global::Java.Lang.Object[] expecteds, global::Java.Lang.Object[] actuals)
		{
			const string __id = "assertArrayEquals.(Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/Object;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_expecteds = JNIEnv.NewArray (expecteds);
			IntPtr native_actuals = JNIEnv.NewArray (actuals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (native_expecteds);
				__args [2] = new JniArgumentValue (native_actuals);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (expecteds != null) {
					JNIEnv.CopyArray (native_expecteds, expecteds);
					JNIEnv.DeleteLocalRef (native_expecteds);
				}
				if (actuals != null) {
					JNIEnv.CopyArray (native_actuals, actuals);
					JNIEnv.DeleteLocalRef (native_actuals);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertArrayEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long[]'] and parameter[3][@type='long[]']]"
		[Register ("assertArrayEquals", "(Ljava/lang/String;[J[J)V", "")]
		public static unsafe void AssertArrayEquals (string message, long[] expecteds, long[] actuals)
		{
			const string __id = "assertArrayEquals.(Ljava/lang/String;[J[J)V";
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_expecteds = JNIEnv.NewArray (expecteds);
			IntPtr native_actuals = JNIEnv.NewArray (actuals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (native_expecteds);
				__args [2] = new JniArgumentValue (native_actuals);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (expecteds != null) {
					JNIEnv.CopyArray (native_expecteds, expecteds);
					JNIEnv.DeleteLocalRef (native_expecteds);
				}
				if (actuals != null) {
					JNIEnv.CopyArray (native_actuals, actuals);
					JNIEnv.DeleteLocalRef (native_actuals);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertArrayEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='short[]'] and parameter[3][@type='short[]']]"
		[Register ("assertArrayEquals", "(Ljava/lang/String;[S[S)V", "")]
		public static unsafe void AssertArrayEquals (string message, short[] expecteds, short[] actuals)
		{
			const string __id = "assertArrayEquals.(Ljava/lang/String;[S[S)V";
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_expecteds = JNIEnv.NewArray (expecteds);
			IntPtr native_actuals = JNIEnv.NewArray (actuals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (native_expecteds);
				__args [2] = new JniArgumentValue (native_actuals);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (expecteds != null) {
					JNIEnv.CopyArray (native_expecteds, expecteds);
					JNIEnv.DeleteLocalRef (native_expecteds);
				}
				if (actuals != null) {
					JNIEnv.CopyArray (native_actuals, actuals);
					JNIEnv.DeleteLocalRef (native_actuals);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertArrayEquals' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='long[]']]"
		[Register ("assertArrayEquals", "([J[J)V", "")]
		public static unsafe void AssertArrayEquals (long[] expecteds, long[] actuals)
		{
			const string __id = "assertArrayEquals.([J[J)V";
			IntPtr native_expecteds = JNIEnv.NewArray (expecteds);
			IntPtr native_actuals = JNIEnv.NewArray (actuals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_expecteds);
				__args [1] = new JniArgumentValue (native_actuals);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (expecteds != null) {
					JNIEnv.CopyArray (native_expecteds, expecteds);
					JNIEnv.DeleteLocalRef (native_expecteds);
				}
				if (actuals != null) {
					JNIEnv.CopyArray (native_actuals, actuals);
					JNIEnv.DeleteLocalRef (native_actuals);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertArrayEquals' and count(parameter)=2 and parameter[1][@type='short[]'] and parameter[2][@type='short[]']]"
		[Register ("assertArrayEquals", "([S[S)V", "")]
		public static unsafe void AssertArrayEquals (short[] expecteds, short[] actuals)
		{
			const string __id = "assertArrayEquals.([S[S)V";
			IntPtr native_expecteds = JNIEnv.NewArray (expecteds);
			IntPtr native_actuals = JNIEnv.NewArray (actuals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_expecteds);
				__args [1] = new JniArgumentValue (native_actuals);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (expecteds != null) {
					JNIEnv.CopyArray (native_expecteds, expecteds);
					JNIEnv.DeleteLocalRef (native_expecteds);
				}
				if (actuals != null) {
					JNIEnv.CopyArray (native_actuals, actuals);
					JNIEnv.DeleteLocalRef (native_actuals);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Obsolete (@"deprecated")]
		[Register ("assertEquals", "(DD)V", "")]
		public static unsafe void AssertEquals (double expected, double actual)
		{
			const string __id = "assertEquals.(DD)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (expected);
				__args [1] = new JniArgumentValue (actual);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=2 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='java.lang.Object[]']]"
		[Obsolete (@"deprecated")]
		[Register ("assertEquals", "([Ljava/lang/Object;[Ljava/lang/Object;)V", "")]
		public static unsafe void AssertEquals (global::Java.Lang.Object[] expecteds, global::Java.Lang.Object[] actuals)
		{
			const string __id = "assertEquals.([Ljava/lang/Object;[Ljava/lang/Object;)V";
			IntPtr native_expecteds = JNIEnv.NewArray (expecteds);
			IntPtr native_actuals = JNIEnv.NewArray (actuals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_expecteds);
				__args [1] = new JniArgumentValue (native_actuals);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (expecteds != null) {
					JNIEnv.CopyArray (native_expecteds, expecteds);
					JNIEnv.DeleteLocalRef (native_expecteds);
				}
				if (actuals != null) {
					JNIEnv.CopyArray (native_actuals, actuals);
					JNIEnv.DeleteLocalRef (native_actuals);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Obsolete (@"deprecated")]
		[Register ("assertEquals", "(Ljava/lang/String;DD)V", "")]
		public static unsafe void AssertEquals (string message, double expected, double actual)
		{
			const string __id = "assertEquals.(Ljava/lang/String;DD)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object[]'] and parameter[3][@type='java.lang.Object[]']]"
		[Obsolete (@"deprecated")]
		[Register ("assertEquals", "(Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/Object;)V", "")]
		public static unsafe void AssertEquals (string message, global::Java.Lang.Object[] expecteds, global::Java.Lang.Object[] actuals)
		{
			const string __id = "assertEquals.(Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/Object;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_expecteds = JNIEnv.NewArray (expecteds);
			IntPtr native_actuals = JNIEnv.NewArray (actuals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (native_expecteds);
				__args [2] = new JniArgumentValue (native_actuals);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (expecteds != null) {
					JNIEnv.CopyArray (native_expecteds, expecteds);
					JNIEnv.DeleteLocalRef (native_expecteds);
				}
				if (actuals != null) {
					JNIEnv.CopyArray (native_actuals, actuals);
					JNIEnv.DeleteLocalRef (native_actuals);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertEquals' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertFalse' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertFalse' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertNotEquals' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("assertNotEquals", "(DDD)V", "")]
		public static unsafe void AssertNotEquals (double unexpected, double actual, double delta)
		{
			const string __id = "assertNotEquals.(DDD)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (unexpected);
				__args [1] = new JniArgumentValue (actual);
				__args [2] = new JniArgumentValue (delta);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertNotEquals' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("assertNotEquals", "(FFF)V", "")]
		public static unsafe void AssertNotEquals (float unexpected, float actual, float delta)
		{
			const string __id = "assertNotEquals.(FFF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (unexpected);
				__args [1] = new JniArgumentValue (actual);
				__args [2] = new JniArgumentValue (delta);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertNotEquals' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("assertNotEquals", "(Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public static unsafe void AssertNotEquals (global::Java.Lang.Object unexpected, global::Java.Lang.Object actual)
		{
			const string __id = "assertNotEquals.(Ljava/lang/Object;Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((unexpected == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unexpected).Handle);
				__args [1] = new JniArgumentValue ((actual == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actual).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertNotEquals' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
		[Register ("assertNotEquals", "(Ljava/lang/String;DDD)V", "")]
		public static unsafe void AssertNotEquals (string message, double unexpected, double actual, double delta)
		{
			const string __id = "assertNotEquals.(Ljava/lang/String;DDD)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (unexpected);
				__args [2] = new JniArgumentValue (actual);
				__args [3] = new JniArgumentValue (delta);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertNotEquals' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("assertNotEquals", "(Ljava/lang/String;FFF)V", "")]
		public static unsafe void AssertNotEquals (string message, float unexpected, float actual, float delta)
		{
			const string __id = "assertNotEquals.(Ljava/lang/String;FFF)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (unexpected);
				__args [2] = new JniArgumentValue (actual);
				__args [3] = new JniArgumentValue (delta);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertNotEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("assertNotEquals", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public static unsafe void AssertNotEquals (string message, global::Java.Lang.Object unexpected, global::Java.Lang.Object actual)
		{
			const string __id = "assertNotEquals.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((unexpected == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unexpected).Handle);
				__args [2] = new JniArgumentValue ((actual == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actual).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertNotEquals' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("assertNotEquals", "(Ljava/lang/String;JJ)V", "")]
		public static unsafe void AssertNotEquals (string message, long unexpected, long actual)
		{
			const string __id = "assertNotEquals.(Ljava/lang/String;JJ)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (unexpected);
				__args [2] = new JniArgumentValue (actual);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertNotEquals' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("assertNotEquals", "(JJ)V", "")]
		public static unsafe void AssertNotEquals (long unexpected, long actual)
		{
			const string __id = "assertNotEquals.(JJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (unexpected);
				__args [1] = new JniArgumentValue (actual);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertNotNull' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertNotNull' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertNotSame' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("assertNotSame", "(Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public static unsafe void AssertNotSame (global::Java.Lang.Object unexpected, global::Java.Lang.Object actual)
		{
			const string __id = "assertNotSame.(Ljava/lang/Object;Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((unexpected == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unexpected).Handle);
				__args [1] = new JniArgumentValue ((actual == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actual).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertNotSame' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("assertNotSame", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public static unsafe void AssertNotSame (string message, global::Java.Lang.Object unexpected, global::Java.Lang.Object actual)
		{
			const string __id = "assertNotSame.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((unexpected == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unexpected).Handle);
				__args [2] = new JniArgumentValue ((actual == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actual).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertNull' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertNull' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertSame' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertSame' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertTrue' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='assertTrue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='fail' and count(parameter)=0]"
		[Register ("fail", "()V", "")]
		public static unsafe void Fail ()
		{
			const string __id = "fail.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assert']/method[@name='fail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

	}
}
