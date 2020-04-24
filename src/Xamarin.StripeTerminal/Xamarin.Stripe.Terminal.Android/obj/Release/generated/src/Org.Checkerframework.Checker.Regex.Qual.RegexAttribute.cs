using System;

namespace Org.Checkerframework.Checker.Regex.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.checker.regex.qual.Regex")]
	public partial class RegexAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public int Value { get; set; }

	}
}
