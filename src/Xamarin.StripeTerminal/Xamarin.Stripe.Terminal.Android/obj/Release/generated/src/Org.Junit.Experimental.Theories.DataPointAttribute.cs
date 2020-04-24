using System;

namespace Org.Junit.Experimental.Theories {

	[global::Android.Runtime.Annotation ("org.junit.experimental.theories.DataPoint")]
	public partial class DataPointAttribute : Attribute
	{
		[global::Android.Runtime.Register ("ignoredExceptions")]
		public global::Java.Lang.Class[] IgnoredExceptions { get; set; }

		[global::Android.Runtime.Register ("value")]
		public string[] Value { get; set; }

	}
}
