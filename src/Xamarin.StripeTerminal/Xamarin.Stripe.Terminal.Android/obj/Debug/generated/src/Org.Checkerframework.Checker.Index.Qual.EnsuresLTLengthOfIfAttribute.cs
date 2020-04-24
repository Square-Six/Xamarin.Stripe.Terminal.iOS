using System;

namespace Org.Checkerframework.Checker.Index.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.checker.index.qual.EnsuresLTLengthOfIf")]
	public partial class EnsuresLTLengthOfIfAttribute : Attribute
	{
		[global::Android.Runtime.Register ("expression")]
		public string[] Expression { get; set; }

		[global::Android.Runtime.Register ("offset")]
		public string[] Offset { get; set; }

		[global::Android.Runtime.Register ("result")]
		public bool Result { get; set; }

		[global::Android.Runtime.Register ("targetValue")]
		public string[] TargetValue { get; set; }

	}
}
