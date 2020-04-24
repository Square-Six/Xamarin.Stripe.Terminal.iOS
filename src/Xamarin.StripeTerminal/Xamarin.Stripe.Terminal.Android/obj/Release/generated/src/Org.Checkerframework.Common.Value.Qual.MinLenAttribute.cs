using System;

namespace Org.Checkerframework.Common.Value.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.common.value.qual.MinLen")]
	public partial class MinLenAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public int Value { get; set; }

	}
}
