using System;

namespace Org.Checkerframework.Checker.Initialization.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.checker.initialization.qual.UnknownInitialization")]
	public partial class UnknownInitializationAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public global::Java.Lang.Class Value { get; set; }

	}
}
