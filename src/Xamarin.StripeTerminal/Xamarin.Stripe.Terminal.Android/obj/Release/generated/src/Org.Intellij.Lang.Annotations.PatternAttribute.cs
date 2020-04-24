using System;

namespace Org.Intellij.Lang.Annotations {

	[global::Android.Runtime.Annotation ("org.intellij.lang.annotations.Pattern")]
	public partial class PatternAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
