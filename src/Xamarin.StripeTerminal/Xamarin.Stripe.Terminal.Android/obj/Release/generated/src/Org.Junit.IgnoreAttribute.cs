using System;

namespace Org.Junit {

	[global::Android.Runtime.Annotation ("org.junit.Ignore")]
	public partial class IgnoreAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
