using System;

namespace Org.Checkerframework.Checker.Index.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.checker.index.qual.HasSubsequence")]
	public partial class HasSubsequenceAttribute : Attribute
	{
		[global::Android.Runtime.Register ("from")]
		public string From { get; set; }

		[global::Android.Runtime.Register ("subsequence")]
		public string Subsequence { get; set; }

		[global::Android.Runtime.Register ("to")]
		public string To { get; set; }

	}
}
