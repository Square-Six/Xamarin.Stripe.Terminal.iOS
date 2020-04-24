using System;

namespace Org.Checkerframework.Framework.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.framework.qual.DefaultQualifier")]
	public partial class DefaultQualifierAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public global::Java.Lang.Class Value { get; set; }

	}
}
