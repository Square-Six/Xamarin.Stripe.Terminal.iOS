using System;

namespace Org.Checkerframework.Framework.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.framework.qual.AnnotatedFor")]
	public partial class AnnotatedForAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string[] Value { get; set; }

	}
}
