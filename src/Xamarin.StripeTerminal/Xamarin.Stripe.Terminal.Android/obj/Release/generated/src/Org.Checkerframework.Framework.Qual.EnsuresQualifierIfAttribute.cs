using System;

namespace Org.Checkerframework.Framework.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.framework.qual.EnsuresQualifierIf")]
	public partial class EnsuresQualifierIfAttribute : Attribute
	{
		[global::Android.Runtime.Register ("expression")]
		public string[] Expression { get; set; }

		[global::Android.Runtime.Register ("qualifier")]
		public global::Java.Lang.Class Qualifier { get; set; }

		[global::Android.Runtime.Register ("result")]
		public bool Result { get; set; }

	}
}
