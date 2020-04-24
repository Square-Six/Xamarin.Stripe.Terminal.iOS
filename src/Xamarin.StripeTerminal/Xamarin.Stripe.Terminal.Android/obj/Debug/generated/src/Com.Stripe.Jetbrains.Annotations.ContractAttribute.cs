using System;

namespace Com.Stripe.Jetbrains.Annotations {

	[global::Android.Runtime.Annotation ("com.stripe.jetbrains.annotations.Contract")]
	public partial class ContractAttribute : Attribute
	{
		[global::Android.Runtime.Register ("pure")]
		public bool Pure { get; set; }

		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
