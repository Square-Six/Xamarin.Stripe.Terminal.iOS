using System;

namespace Org.Checkerframework.Common.Value.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.common.value.qual.MinLenFieldInvariant")]
	public partial class MinLenFieldInvariantAttribute : Attribute
	{
		[global::Android.Runtime.Register ("field")]
		public string[] Field { get; set; }

		[global::Android.Runtime.Register ("minLen")]
		public int[] MinLen { get; set; }

	}
}
