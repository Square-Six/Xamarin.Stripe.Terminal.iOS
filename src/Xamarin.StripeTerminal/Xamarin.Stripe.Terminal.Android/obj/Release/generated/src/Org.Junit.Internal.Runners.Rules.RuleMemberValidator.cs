using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Internal.Runners.Rules {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.internal.runners.rules']/class[@name='RuleMemberValidator']"
	[global::Android.Runtime.Register ("org/junit/internal/runners/rules/RuleMemberValidator", DoNotGenerateAcw=true)]
	public partial class RuleMemberValidator : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.junit.internal.runners.rules']/class[@name='RuleMemberValidator']/field[@name='CLASS_RULE_METHOD_VALIDATOR']"
		[Register ("CLASS_RULE_METHOD_VALIDATOR")]
		public static global::Org.Junit.Internal.Runners.Rules.RuleMemberValidator ClassRuleMethodValidator {
			get {
				const string __id = "CLASS_RULE_METHOD_VALIDATOR.Lorg/junit/internal/runners/rules/RuleMemberValidator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.Rules.RuleMemberValidator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.junit.internal.runners.rules']/class[@name='RuleMemberValidator']/field[@name='CLASS_RULE_VALIDATOR']"
		[Register ("CLASS_RULE_VALIDATOR")]
		public static global::Org.Junit.Internal.Runners.Rules.RuleMemberValidator ClassRuleValidator {
			get {
				const string __id = "CLASS_RULE_VALIDATOR.Lorg/junit/internal/runners/rules/RuleMemberValidator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.Rules.RuleMemberValidator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.junit.internal.runners.rules']/class[@name='RuleMemberValidator']/field[@name='RULE_METHOD_VALIDATOR']"
		[Register ("RULE_METHOD_VALIDATOR")]
		public static global::Org.Junit.Internal.Runners.Rules.RuleMemberValidator RuleMethodValidator {
			get {
				const string __id = "RULE_METHOD_VALIDATOR.Lorg/junit/internal/runners/rules/RuleMemberValidator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.Rules.RuleMemberValidator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.junit.internal.runners.rules']/class[@name='RuleMemberValidator']/field[@name='RULE_VALIDATOR']"
		[Register ("RULE_VALIDATOR")]
		public static global::Org.Junit.Internal.Runners.Rules.RuleMemberValidator RuleValidator {
			get {
				const string __id = "RULE_VALIDATOR.Lorg/junit/internal/runners/rules/RuleMemberValidator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.Rules.RuleMemberValidator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/internal/runners/rules/RuleMemberValidator", typeof (RuleMemberValidator));
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

		protected RuleMemberValidator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
