using System;

namespace Org.Checkerframework.Framework.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.framework.qual.PostconditionAnnotation")]
	public partial class PostconditionAnnotationAttribute : Attribute
	{
		[global::Android.Runtime.Register ("qualifier")]
		public global::Java.Lang.Class Qualifier { get; set; }

	}
}
