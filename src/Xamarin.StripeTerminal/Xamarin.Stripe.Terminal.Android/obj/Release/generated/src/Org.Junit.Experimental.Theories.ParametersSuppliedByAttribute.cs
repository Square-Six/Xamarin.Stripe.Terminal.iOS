using System;

namespace Org.Junit.Experimental.Theories {

	[global::Android.Runtime.Annotation ("org.junit.experimental.theories.ParametersSuppliedBy")]
	public partial class ParametersSuppliedByAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public global::Java.Lang.Class Value { get; set; }

	}
}
