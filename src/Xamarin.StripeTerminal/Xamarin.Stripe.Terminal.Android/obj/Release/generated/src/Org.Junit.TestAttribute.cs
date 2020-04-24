using System;

namespace Org.Junit {

	[global::Android.Runtime.Annotation ("org.junit.Test")]
	public partial class TestAttribute : Attribute
	{
		[global::Android.Runtime.Register ("expected")]
		public global::Java.Lang.Class Expected { get; set; }

		[global::Android.Runtime.Register ("timeout")]
		public long Timeout { get; set; }

	}
}
