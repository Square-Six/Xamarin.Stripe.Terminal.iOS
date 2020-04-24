using System;

namespace Org.Checkerframework.Checker.Lock.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.checker.lock.qual.EnsuresLockHeld")]
	public partial class EnsuresLockHeldAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string[] Value { get; set; }

	}
}
