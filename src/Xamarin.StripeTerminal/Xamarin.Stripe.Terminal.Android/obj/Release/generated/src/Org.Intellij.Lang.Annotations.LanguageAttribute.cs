using System;

namespace Org.Intellij.Lang.Annotations {

	[global::Android.Runtime.Annotation ("org.intellij.lang.annotations.Language")]
	public partial class LanguageAttribute : Attribute
	{
		[global::Android.Runtime.Register ("prefix")]
		public string Prefix { get; set; }

		[global::Android.Runtime.Register ("suffix")]
		public string Suffix { get; set; }

		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
