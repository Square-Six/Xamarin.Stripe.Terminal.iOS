using System;

namespace Org.Checkerframework.Checker.Nullness.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.checker.nullness.qual.EnsuresKeyForIf")]
	public partial class EnsuresKeyForIfAttribute : Attribute
	{
		[global::Android.Runtime.Register ("expression")]
		public string[] Expression { get; set; }

		[global::Android.Runtime.Register ("map")]
		public string[] Map { get; set; }

		[global::Android.Runtime.Register ("result")]
		public bool Result { get; set; }

	}
}
