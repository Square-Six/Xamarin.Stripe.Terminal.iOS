using System;

namespace Org.Checkerframework.Framework.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.framework.qual.ImplicitFor")]
	public partial class ImplicitForAttribute : Attribute
	{
		[global::Android.Runtime.Register ("stringPatterns")]
		public string[] StringPatterns { get; set; }

		[global::Android.Runtime.Register ("typeNames")]
		public global::Java.Lang.Class[] TypeNames { get; set; }

	}
}
