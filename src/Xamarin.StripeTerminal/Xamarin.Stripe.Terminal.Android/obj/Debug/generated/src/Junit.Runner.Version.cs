using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Junit.Runner {

	// Metadata.xml XPath class reference: path="/api/package[@name='junit.runner']/class[@name='Version']"
	[global::Android.Runtime.Register ("junit/runner/Version", DoNotGenerateAcw=true)]
	public partial class Version : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("junit/runner/Version", typeof (Version));
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

		protected Version (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='Version']/method[@name='id' and count(parameter)=0]"
		[Register ("id", "()Ljava/lang/String;", "")]
		public static unsafe string Id ()
		{
			const string __id = "id.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.runner']/class[@name='Version']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] args)
		{
			const string __id = "main.([Ljava/lang/String;)V";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_args);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

	}
}
