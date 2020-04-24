using System;

namespace Org.Checkerframework.Framework.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.framework.qual.Unused")]
	public partial class UnusedAttribute : Attribute
	{
		[global::Android.Runtime.Register ("when")]
		public global::Java.Lang.Class When { get; set; }

	}
}
