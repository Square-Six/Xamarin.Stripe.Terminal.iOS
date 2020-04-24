using System;

namespace Com.Stripe.Jetbrains.Annotations {

	[global::Android.Runtime.Annotation ("com.stripe.jetbrains.annotations.Nullable")]
	public partial class NullableAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
