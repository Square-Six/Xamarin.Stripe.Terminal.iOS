using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Validator {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.validator']/class[@name='PublicClassValidator']"
	[global::Android.Runtime.Register ("org/junit/validator/PublicClassValidator", DoNotGenerateAcw=true)]
	public partial class PublicClassValidator : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/validator/PublicClassValidator", typeof (PublicClassValidator));
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

		protected PublicClassValidator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.validator']/class[@name='PublicClassValidator']/constructor[@name='PublicClassValidator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PublicClassValidator ()
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
