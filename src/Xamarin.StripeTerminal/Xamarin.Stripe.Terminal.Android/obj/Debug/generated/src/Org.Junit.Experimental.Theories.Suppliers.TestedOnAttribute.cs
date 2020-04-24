using System;

namespace Org.Junit.Experimental.Theories.Suppliers {

	[global::Android.Runtime.Annotation ("org.junit.experimental.theories.suppliers.TestedOn")]
	public partial class TestedOnAttribute : Attribute
	{
		[global::Android.Runtime.Register ("ints")]
		public int[] Ints { get; set; }

	}
}
