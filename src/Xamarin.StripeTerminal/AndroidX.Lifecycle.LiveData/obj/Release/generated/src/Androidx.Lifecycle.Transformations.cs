using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Androidx.Lifecycle {

	// Metadata.xml XPath class reference: path="/api/package[@name='androidx.lifecycle']/class[@name='Transformations']"
	[global::Android.Runtime.Register ("androidx/lifecycle/Transformations", DoNotGenerateAcw=true)]
	public partial class Transformations : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("androidx/lifecycle/Transformations", typeof (Transformations));
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

		protected Transformations (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
