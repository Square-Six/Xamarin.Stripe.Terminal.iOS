using System;

namespace Org.Checkerframework.Common.Value.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.common.value.qual.EnsuresMinLenIf")]
	public partial class EnsuresMinLenIfAttribute : Attribute
	{
		[global::Android.Runtime.Register ("expression")]
		public string[] Expression { get; set; }

		[global::Android.Runtime.Register ("result")]
		public bool Result { get; set; }

		[global::Android.Runtime.Register ("targetValue")]
		public int TargetValue { get; set; }

	}
}
