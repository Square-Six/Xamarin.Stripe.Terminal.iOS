using System;

namespace Org.Checkerframework.Checker.Lock.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.checker.lock.qual.GuardSatisfied")]
	public partial class GuardSatisfiedAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public int Value { get; set; }

	}
}
