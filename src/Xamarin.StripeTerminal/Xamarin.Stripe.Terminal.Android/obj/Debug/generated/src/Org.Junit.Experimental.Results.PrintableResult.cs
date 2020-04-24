using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Experimental.Results {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.experimental.results']/class[@name='PrintableResult']"
	[global::Android.Runtime.Register ("org/junit/experimental/results/PrintableResult", DoNotGenerateAcw=true)]
	public partial class PrintableResult : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/experimental/results/PrintableResult", typeof (PrintableResult));
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

		protected PrintableResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_failureCount;
#pragma warning disable 0169
		static Delegate GetFailureCountHandler ()
		{
			if (cb_failureCount == null)
				cb_failureCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_FailureCount);
			return cb_failureCount;
		}

		static int n_FailureCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Experimental.Results.PrintableResult __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Results.PrintableResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FailureCount ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.results']/class[@name='PrintableResult']/method[@name='failureCount' and count(parameter)=0]"
		[Register ("failureCount", "()I", "GetFailureCountHandler")]
		public virtual unsafe int FailureCount ()
		{
			const string __id = "failureCount.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.results']/class[@name='PrintableResult']/method[@name='testResult' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("testResult", "(Ljava/lang/Class;)Lorg/junit/experimental/results/PrintableResult;", "")]
		public static unsafe global::Org.Junit.Experimental.Results.PrintableResult TestResult (global::Java.Lang.Class type)
		{
			const string __id = "testResult.(Ljava/lang/Class;)Lorg/junit/experimental/results/PrintableResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Results.PrintableResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
