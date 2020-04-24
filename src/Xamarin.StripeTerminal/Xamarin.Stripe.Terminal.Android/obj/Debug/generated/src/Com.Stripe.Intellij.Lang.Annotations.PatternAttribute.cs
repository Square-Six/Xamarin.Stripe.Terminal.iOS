using System;

namespace Com.Stripe.Intellij.Lang.Annotations {

	[global::Android.Runtime.Annotation ("com.stripe.intellij.lang.annotations.Pattern")]
	public partial class PatternAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
