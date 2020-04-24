using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Experimental.Results {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.experimental.results']/class[@name='ResultMatchers']"
	[global::Android.Runtime.Register ("org/junit/experimental/results/ResultMatchers", DoNotGenerateAcw=true)]
	public partial class ResultMatchers : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/experimental/results/ResultMatchers", typeof (ResultMatchers));
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

		protected ResultMatchers (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.experimental.results']/class[@name='ResultMatchers']/constructor[@name='ResultMatchers' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResultMatchers ()
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

	}
}
