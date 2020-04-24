using System;

namespace Com.Stripe.Intellij.Lang.Annotations {

	[global::Android.Runtime.Annotation ("com.stripe.intellij.lang.annotations.Flow")]
	public partial class FlowAttribute : Attribute
	{
		[global::Android.Runtime.Register ("source")]
		public string Source { get; set; }

		[global::Android.Runtime.Register ("sourceIsContainer")]
		public bool SourceIsContainer { get; set; }

		[global::Android.Runtime.Register ("target")]
		public string Target { get; set; }

		[global::Android.Runtime.Register ("targetIsContainer")]
		public bool TargetIsContainer { get; set; }

	}
}
