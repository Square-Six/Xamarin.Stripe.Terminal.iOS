using System;

namespace Org.Checkerframework.Checker.Nullness.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.checker.nullness.qual.KeyFor")]
	public partial class KeyForAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string[] Value { get; set; }

	}
}
