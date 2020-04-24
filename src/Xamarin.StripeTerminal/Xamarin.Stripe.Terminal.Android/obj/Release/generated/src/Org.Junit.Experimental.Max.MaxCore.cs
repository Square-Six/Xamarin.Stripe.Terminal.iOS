using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Experimental.Max {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.experimental.max']/class[@name='MaxCore']"
	[global::Android.Runtime.Register ("org/junit/experimental/max/MaxCore", DoNotGenerateAcw=true)]
	public partial class MaxCore : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/experimental/max/MaxCore", typeof (MaxCore));
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

		protected MaxCore (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.max']/class[@name='MaxCore']/method[@name='forFolder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("forFolder", "(Ljava/lang/String;)Lorg/junit/experimental/max/MaxCore;", "")]
		public static unsafe global::Org.Junit.Experimental.Max.MaxCore ForFolder (string folderName)
		{
			const string __id = "forFolder.(Ljava/lang/String;)Lorg/junit/experimental/max/MaxCore;";
			IntPtr native_folderName = JNIEnv.NewString (folderName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_folderName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Max.MaxCore> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_folderName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.max']/class[@name='MaxCore']/method[@name='storedLocally' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("storedLocally", "(Ljava/io/File;)Lorg/junit/experimental/max/MaxCore;", "")]
		public static unsafe global::Org.Junit.Experimental.Max.MaxCore StoredLocally (global::Java.IO.File storedResults)
		{
			const string __id = "storedLocally.(Ljava/io/File;)Lorg/junit/experimental/max/MaxCore;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((storedResults == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storedResults).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Max.MaxCore> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
