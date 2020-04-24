using System;

namespace Org.Checkerframework.Framework.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.framework.qual.PolymorphicQualifier")]
	public partial class PolymorphicQualifierAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public global::Java.Lang.Class Value { get; set; }

	}
}
