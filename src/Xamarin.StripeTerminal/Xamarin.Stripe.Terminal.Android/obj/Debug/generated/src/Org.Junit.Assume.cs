using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit']/class[@name='Assume']"
	[global::Android.Runtime.Register ("org/junit/Assume", DoNotGenerateAcw=true)]
	public partial class Assume : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/Assume", typeof (Assume));
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

		protected Assume (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit']/class[@name='Assume']/constructor[@name='Assume' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Assume ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assume']/method[@name='assumeFalse' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("assumeFalse", "(Z)V", "")]
		public static unsafe void AssumeFalse (bool b)
		{
			const string __id = "assumeFalse.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assume']/method[@name='assumeFalse' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("assumeFalse", "(Ljava/lang/String;Z)V", "")]
		public static unsafe void AssumeFalse (string message, bool b)
		{
			const string __id = "assumeFalse.(Ljava/lang/String;Z)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (b);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assume']/method[@name='assumeNoException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("assumeNoException", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void AssumeNoException (string message, global::Java.Lang.Throwable e)
		{
			const string __id = "assumeNoException.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assume']/method[@name='assumeNoException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("assumeNoException", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void AssumeNoException (global::Java.Lang.Throwable e)
		{
			const string __id = "assumeNoException.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assume']/method[@name='assumeNotNull' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("assumeNotNull", "([Ljava/lang/Object;)V", "")]
		public static unsafe void AssumeNotNull (params global::Java.Lang.Object[] objects)
		{
			const string __id = "assumeNotNull.([Ljava/lang/Object;)V";
			IntPtr native_objects = JNIEnv.NewArray (objects);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_objects);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (objects != null) {
					JNIEnv.CopyArray (native_objects, objects);
					JNIEnv.DeleteLocalRef (native_objects);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assume']/method[@name='assumeTrue' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("assumeTrue", "(Z)V", "")]
		public static unsafe void AssumeTrue (bool b)
		{
			const string __id = "assumeTrue.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit']/class[@name='Assume']/method[@name='assumeTrue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("assumeTrue", "(Ljava/lang/String;Z)V", "")]
		public static unsafe void AssumeTrue (string message, bool b)
		{
			const string __id = "assumeTrue.(Ljava/lang/String;Z)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (b);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

	}
}
