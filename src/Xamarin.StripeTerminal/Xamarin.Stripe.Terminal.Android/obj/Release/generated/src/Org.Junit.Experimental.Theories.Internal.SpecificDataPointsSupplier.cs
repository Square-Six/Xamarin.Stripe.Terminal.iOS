using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Experimental.Theories.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.experimental.theories.internal']/class[@name='SpecificDataPointsSupplier']"
	[global::Android.Runtime.Register ("org/junit/experimental/theories/internal/SpecificDataPointsSupplier", DoNotGenerateAcw=true)]
	public partial class SpecificDataPointsSupplier : global::Org.Junit.Experimental.Theories.Internal.AllMembersSupplier {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/experimental/theories/internal/SpecificDataPointsSupplier", typeof (SpecificDataPointsSupplier));
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

		protected SpecificDataPointsSupplier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
