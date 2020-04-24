using System;

namespace Com.Stripe.Jetbrains.Annotations {

	[global::Android.Runtime.Annotation ("com.stripe.jetbrains.annotations.NotNull")]
	public partial class NotNullAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
