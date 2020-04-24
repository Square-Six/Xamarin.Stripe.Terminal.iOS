using System;

namespace Org.Checkerframework.Checker.Nullness.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.checker.nullness.qual.EnsuresKeyFor")]
	public partial class EnsuresKeyForAttribute : Attribute
	{
		[global::Android.Runtime.Register ("map")]
		public string[] Map { get; set; }

		[global::Android.Runtime.Register ("value")]
		public string[] Value { get; set; }

	}
}
