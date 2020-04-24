using System;

namespace Org.Checkerframework.Framework.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.framework.qual.PreconditionAnnotation")]
	public partial class PreconditionAnnotationAttribute : Attribute
	{
		[global::Android.Runtime.Register ("qualifier")]
		public global::Java.Lang.Class Qualifier { get; set; }

	}
}
