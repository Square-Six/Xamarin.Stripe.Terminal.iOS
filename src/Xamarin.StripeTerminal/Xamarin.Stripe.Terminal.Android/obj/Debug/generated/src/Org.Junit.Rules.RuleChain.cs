using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Rules {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.rules']/class[@name='RuleChain']"
	[global::Android.Runtime.Register ("org/junit/rules/RuleChain", DoNotGenerateAcw=true)]
	public partial class RuleChain : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/rules/RuleChain", typeof (RuleChain));
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

		protected RuleChain (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='RuleChain']/method[@name='emptyRuleChain' and count(parameter)=0]"
		[Register ("emptyRuleChain", "()Lorg/junit/rules/RuleChain;", "")]
		public static unsafe global::Org.Junit.Rules.RuleChain EmptyRuleChain ()
		{
			const string __id = "emptyRuleChain.()Lorg/junit/rules/RuleChain;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.RuleChain> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
