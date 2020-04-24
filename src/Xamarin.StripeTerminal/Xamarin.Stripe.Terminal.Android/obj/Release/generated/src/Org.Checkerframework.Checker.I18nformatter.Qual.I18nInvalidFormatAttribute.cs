using System;

namespace Org.Checkerframework.Checker.I18nformatter.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.checker.i18nformatter.qual.I18nInvalidFormat")]
	public partial class I18nInvalidFormatAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
