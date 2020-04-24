using System;

namespace Org.Intellij.Lang.Annotations {

	[global::Android.Runtime.Annotation ("org.intellij.lang.annotations.Subst")]
	public partial class SubstAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
