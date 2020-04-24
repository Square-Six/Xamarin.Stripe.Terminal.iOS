using System;

namespace Org.Checkerframework.Checker.Nullness.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.checker.nullness.qual.AssertNonNullIfNonNull")]
	public partial class AssertNonNullIfNonNullAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string[] Value { get; set; }

	}
}
