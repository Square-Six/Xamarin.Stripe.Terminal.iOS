using System;

namespace Org.Checkerframework.Checker.Formatter.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.checker.formatter.qual.InvalidFormat")]
	public partial class InvalidFormatAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
