using System;

namespace Org.Junit.Validator {

	[global::Android.Runtime.Annotation ("org.junit.validator.ValidateWith")]
	public partial class ValidateWithAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public global::Java.Lang.Class Value { get; set; }

	}
}
