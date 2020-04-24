using System;

namespace Org.Checkerframework.Checker.Lock.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.checker.lock.qual.EnsuresLockHeldIf")]
	public partial class EnsuresLockHeldIfAttribute : Attribute
	{
		[global::Android.Runtime.Register ("expression")]
		public string[] Expression { get; set; }

		[global::Android.Runtime.Register ("result")]
		public bool Result { get; set; }

	}
}
