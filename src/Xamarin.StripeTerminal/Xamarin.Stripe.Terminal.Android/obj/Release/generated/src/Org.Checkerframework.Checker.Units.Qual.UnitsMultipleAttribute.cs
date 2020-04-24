using System;

namespace Org.Checkerframework.Checker.Units.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.checker.units.qual.UnitsMultiple")]
	public partial class UnitsMultipleAttribute : Attribute
	{
		[global::Android.Runtime.Register ("quantity")]
		public global::Java.Lang.Class Quantity { get; set; }

	}
}
