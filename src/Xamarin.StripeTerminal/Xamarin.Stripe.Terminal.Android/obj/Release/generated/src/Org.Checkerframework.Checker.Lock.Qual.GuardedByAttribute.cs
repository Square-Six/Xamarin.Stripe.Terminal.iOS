using System;

namespace Org.Checkerframework.Checker.Lock.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.checker.lock.qual.GuardedBy")]
	public partial class GuardedByAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string[] Value { get; set; }

	}
}
