using System;

namespace Org.Checkerframework.Checker.Lock.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.checker.lock.qual.Holding")]
	public partial class HoldingAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string[] Value { get; set; }

	}
}
