using System;

namespace Org.Checkerframework.Checker.Fenum.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.checker.fenum.qual.Fenum")]
	public partial class FenumAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
