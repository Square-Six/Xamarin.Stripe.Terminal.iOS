using System;

namespace Javax.Annotation {

	[global::Android.Runtime.Annotation ("javax.annotation.MatchesPattern")]
	public partial class MatchesPatternAttribute : Attribute
	{
		[global::Android.Runtime.Register ("flags")]
		public int Flags { get; set; }

		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
