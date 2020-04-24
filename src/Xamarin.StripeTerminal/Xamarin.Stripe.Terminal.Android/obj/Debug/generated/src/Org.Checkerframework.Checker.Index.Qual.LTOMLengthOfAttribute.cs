using System;

namespace Org.Checkerframework.Checker.Index.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.checker.index.qual.LTOMLengthOf")]
	public partial class LTOMLengthOfAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string[] Value { get; set; }

	}
}
