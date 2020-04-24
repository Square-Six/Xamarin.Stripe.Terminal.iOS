using System;

namespace Com.Stripe.Intellij.Lang.Annotations {

	[global::Android.Runtime.Annotation ("com.stripe.intellij.lang.annotations.MagicConstant")]
	public partial class MagicConstantAttribute : Attribute
	{
		[global::Android.Runtime.Register ("flags")]
		public long[] Flags { get; set; }

		[global::Android.Runtime.Register ("flagsFromClass")]
		public global::Java.Lang.Class FlagsFromClass { get; set; }

		[global::Android.Runtime.Register ("intValues")]
		public long[] IntValues { get; set; }

		[global::Android.Runtime.Register ("stringValues")]
		public string[] StringValues { get; set; }

		[global::Android.Runtime.Register ("valuesFromClass")]
		public global::Java.Lang.Class ValuesFromClass { get; set; }

	}
}
