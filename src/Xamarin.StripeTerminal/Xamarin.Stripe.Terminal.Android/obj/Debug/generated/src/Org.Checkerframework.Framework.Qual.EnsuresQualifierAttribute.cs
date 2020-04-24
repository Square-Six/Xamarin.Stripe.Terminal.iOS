using System;

namespace Org.Checkerframework.Framework.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.framework.qual.EnsuresQualifier")]
	public partial class EnsuresQualifierAttribute : Attribute
	{
		[global::Android.Runtime.Register ("expression")]
		public string[] Expression { get; set; }

		[global::Android.Runtime.Register ("qualifier")]
		public global::Java.Lang.Class Qualifier { get; set; }

	}
}
