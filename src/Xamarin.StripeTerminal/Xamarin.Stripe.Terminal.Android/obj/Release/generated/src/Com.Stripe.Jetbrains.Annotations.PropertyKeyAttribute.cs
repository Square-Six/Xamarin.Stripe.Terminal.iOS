using System;

namespace Com.Stripe.Jetbrains.Annotations {

	[global::Android.Runtime.Annotation ("com.stripe.jetbrains.annotations.PropertyKey")]
	public partial class PropertyKeyAttribute : Attribute
	{
		[global::Android.Runtime.Register ("resourceBundle")]
		public string ResourceBundle { get; set; }

	}
}
