using System;

namespace Javax.Annotation.Concurrent {

	[global::Android.Runtime.Annotation ("javax.annotation.concurrent.GuardedBy")]
	public partial class GuardedByAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
