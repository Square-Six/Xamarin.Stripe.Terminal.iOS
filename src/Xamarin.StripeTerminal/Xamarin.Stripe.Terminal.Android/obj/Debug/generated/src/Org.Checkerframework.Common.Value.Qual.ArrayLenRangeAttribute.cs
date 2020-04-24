using System;

namespace Org.Checkerframework.Common.Value.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.common.value.qual.ArrayLenRange")]
	public partial class ArrayLenRangeAttribute : Attribute
	{
		[global::Android.Runtime.Register ("from")]
		public int From { get; set; }

		[global::Android.Runtime.Register ("to")]
		public int To { get; set; }

	}
}
