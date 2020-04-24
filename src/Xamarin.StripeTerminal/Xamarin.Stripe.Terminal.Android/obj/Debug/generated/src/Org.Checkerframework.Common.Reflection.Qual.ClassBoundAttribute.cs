using System;

namespace Org.Checkerframework.Common.Reflection.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.common.reflection.qual.ClassBound")]
	public partial class ClassBoundAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string[] Value { get; set; }

	}
}
