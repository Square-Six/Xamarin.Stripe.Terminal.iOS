using System;

namespace Org.Checkerframework.Common.Value.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.common.value.qual.IntRange")]
	public partial class IntRangeAttribute : Attribute
	{
		[global::Android.Runtime.Register ("from")]
		public long From { get; set; }

		[global::Android.Runtime.Register ("to")]
		public long To { get; set; }

	}
}
