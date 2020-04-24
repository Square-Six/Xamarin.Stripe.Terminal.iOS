using System;

namespace Org.Checkerframework.Framework.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.framework.qual.FieldInvariant")]
	public partial class FieldInvariantAttribute : Attribute
	{
		[global::Android.Runtime.Register ("field")]
		public string[] Field { get; set; }

		[global::Android.Runtime.Register ("qualifier")]
		public global::Java.Lang.Class[] Qualifier { get; set; }

	}
}
