using System;

namespace Org.Junit.Experimental.Theories {

	[global::Android.Runtime.Annotation ("org.junit.experimental.theories.Theory")]
	public partial class TheoryAttribute : Attribute
	{
		[global::Android.Runtime.Register ("nullsAccepted")]
		public bool NullsAccepted { get; set; }

	}
}
