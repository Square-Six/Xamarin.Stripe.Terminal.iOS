using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.internal']/class[@name='Throwables']"
	[global::Android.Runtime.Register ("org/junit/internal/Throwables", DoNotGenerateAcw=true)]
	public sealed partial class Throwables : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/internal/Throwables", typeof (Throwables));
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

		internal Throwables (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal']/class[@name='Throwables']/method[@name='rethrowAsException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("rethrowAsException", "(Ljava/lang/Throwable;)Ljava/lang/Exception;", "")]
		public static unsafe global::Java.Lang.Exception RethrowAsException (global::Java.Lang.Throwable e)
		{
			const string __id = "rethrowAsException.(Ljava/lang/Throwable;)Ljava/lang/Exception;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
