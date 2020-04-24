using System;

namespace Org.Checkerframework.Common.Value.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.common.value.qual.BoolVal")]
	public partial class BoolValAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public bool[] Value { get; set; }

	}
}
