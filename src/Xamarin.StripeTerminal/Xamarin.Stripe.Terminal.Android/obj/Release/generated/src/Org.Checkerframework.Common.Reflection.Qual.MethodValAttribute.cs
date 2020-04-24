using System;

namespace Org.Checkerframework.Common.Reflection.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.common.reflection.qual.MethodVal")]
	public partial class MethodValAttribute : Attribute
	{
		[global::Android.Runtime.Register ("className")]
		public string[] ClassName { get; set; }

		[global::Android.Runtime.Register ("methodName")]
		public string[] MethodName { get; set; }

		[global::Android.Runtime.Register ("params")]
		public int[] Params { get; set; }

	}
}
