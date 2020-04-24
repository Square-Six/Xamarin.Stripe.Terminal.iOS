using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/stripe/stripeterminal/callable",
						"com/stripe/stripeterminal",
						"javax/annotation",
						"org/checkerframework/dataflow/qual",
						"org/junit",
					},
					new Converter<string, Type>[]{
						lookup_com_stripe_stripeterminal_callable_package,
						lookup_com_stripe_stripeterminal_package,
						lookup_javax_annotation_package,
						lookup_org_checkerframework_dataflow_qual_package,
						lookup_org_junit_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_stripe_stripeterminal_callable_mappings;
		static Type lookup_com_stripe_stripeterminal_callable_package (string klass)
		{
			if (package_com_stripe_stripeterminal_callable_mappings == null) {
				package_com_stripe_stripeterminal_callable_mappings = new string[]{
					"com/stripe/stripeterminal/callable/TerminalListener$DefaultImpls:Com.Stripe.Stripeterminal.Callable.TerminalListenerDefaultImpls",
				};
			}

			return Lookup (package_com_stripe_stripeterminal_callable_mappings, klass);
		}

		static string[] package_com_stripe_stripeterminal_mappings;
		static Type lookup_com_stripe_stripeterminal_package (string klass)
		{
			if (package_com_stripe_stripeterminal_mappings == null) {
				package_com_stripe_stripeterminal_mappings = new string[]{
					"com/stripe/stripeterminal/Terminal:Com.Stripe.Stripeterminal.StripeTerminal",
					"com/stripe/stripeterminal/Terminal$Companion:Com.Stripe.Stripeterminal.StripeTerminal/Companion",
				};
			}

			return Lookup (package_com_stripe_stripeterminal_mappings, klass);
		}

		static string[] package_javax_annotation_mappings;
		static Type lookup_javax_annotation_package (string klass)
		{
			if (package_javax_annotation_mappings == null) {
				package_javax_annotation_mappings = new string[]{
					"javax/annotation/MatchesPattern$Checker:Javax.Annotation.MatchesPatternChecker",
					"javax/annotation/Nonnegative$Checker:Javax.Annotation.NonnegativeChecker",
					"javax/annotation/Nonnull$Checker:Javax.Annotation.NonnullChecker",
					"javax/annotation/RegEx$Checker:Javax.Annotation.RegExChecker",
				};
			}

			return Lookup (package_javax_annotation_mappings, klass);
		}

		static string[] package_org_checkerframework_dataflow_qual_mappings;
		static Type lookup_org_checkerframework_dataflow_qual_package (string klass)
		{
			if (package_org_checkerframework_dataflow_qual_mappings == null) {
				package_org_checkerframework_dataflow_qual_mappings = new string[]{
					"org/checkerframework/dataflow/qual/Pure$Kind:Org.Checkerframework.Dataflow.Qual.PureKind",
				};
			}

			return Lookup (package_org_checkerframework_dataflow_qual_mappings, klass);
		}

		static string[] package_org_junit_mappings;
		static Type lookup_org_junit_package (string klass)
		{
			if (package_org_junit_mappings == null) {
				package_org_junit_mappings = new string[]{
					"org/junit/Test$None:Org.Junit.TestNone",
				};
			}

			return Lookup (package_org_junit_mappings, klass);
		}
	}
}
