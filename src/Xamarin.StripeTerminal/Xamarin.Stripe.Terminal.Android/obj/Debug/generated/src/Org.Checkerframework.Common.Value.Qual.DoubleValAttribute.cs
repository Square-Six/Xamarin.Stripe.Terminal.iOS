using System;

namespace Org.Checkerframework.Common.Value.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.common.value.qual.DoubleVal")]
	public partial class DoubleValAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public double[] Value { get; set; }

	}
}
