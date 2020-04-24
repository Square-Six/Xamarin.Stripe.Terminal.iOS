using System;

namespace Org.Checkerframework.Common.Value.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.common.value.qual.ArrayLen")]
	public partial class ArrayLenAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public int[] Value { get; set; }

	}
}
