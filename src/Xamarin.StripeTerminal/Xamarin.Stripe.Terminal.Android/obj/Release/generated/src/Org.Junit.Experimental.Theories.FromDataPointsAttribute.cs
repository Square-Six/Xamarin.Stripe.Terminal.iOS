using System;

namespace Org.Junit.Experimental.Theories {

	[global::Android.Runtime.Annotation ("org.junit.experimental.theories.FromDataPoints")]
	public partial class FromDataPointsAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
