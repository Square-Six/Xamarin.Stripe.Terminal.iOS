using System;

namespace Org.Checkerframework.Common.Reflection.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.common.reflection.qual.ClassVal")]
	public partial class ClassValAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string[] Value { get; set; }

	}
}
