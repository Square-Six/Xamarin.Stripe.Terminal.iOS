using System;

namespace Org.Checkerframework.Checker.Index.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.checker.index.qual.EnsuresLTLengthOf")]
	public partial class EnsuresLTLengthOfAttribute : Attribute
	{
		[global::Android.Runtime.Register ("offset")]
		public string[] Offset { get; set; }

		[global::Android.Runtime.Register ("targetValue")]
		public string[] TargetValue { get; set; }

		[global::Android.Runtime.Register ("value")]
		public string[] Value { get; set; }

	}
}
