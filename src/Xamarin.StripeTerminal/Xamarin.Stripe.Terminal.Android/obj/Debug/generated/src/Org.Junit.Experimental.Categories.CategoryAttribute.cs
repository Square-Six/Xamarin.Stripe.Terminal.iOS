using System;

namespace Org.Junit.Experimental.Categories {

	[global::Android.Runtime.Annotation ("org.junit.experimental.categories.Category")]
	public partial class CategoryAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public global::Java.Lang.Class[] Value { get; set; }

	}
}
