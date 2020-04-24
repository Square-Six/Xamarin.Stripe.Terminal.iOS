using System;

namespace Org.Checkerframework.Checker.Regex.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.checker.regex.qual.PartialRegex")]
	public partial class PartialRegexAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
