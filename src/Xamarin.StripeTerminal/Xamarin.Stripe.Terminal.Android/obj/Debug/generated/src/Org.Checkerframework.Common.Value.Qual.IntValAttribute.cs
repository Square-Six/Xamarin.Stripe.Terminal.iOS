using System;

namespace Org.Checkerframework.Common.Value.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.common.value.qual.IntVal")]
	public partial class IntValAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public long[] Value { get; set; }

	}
}
