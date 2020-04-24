using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Experimental.Categories {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.experimental.categories']/class[@name='CategoryValidator']"
	[global::Android.Runtime.Register ("org/junit/experimental/categories/CategoryValidator", DoNotGenerateAcw=true)]
	public sealed partial class CategoryValidator : global::Org.Junit.Validator.AnnotationValidator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/experimental/categories/CategoryValidator", typeof (CategoryValidator));
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

		internal CategoryValidator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.experimental.categories']/class[@name='CategoryValidator']/constructor[@name='CategoryValidator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CategoryValidator ()
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
