using System;

namespace Org.Checkerframework.Checker.Index.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.checker.index.qual.LTEqLengthOf")]
	public partial class LTEqLengthOfAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string[] Value { get; set; }

	}
}
