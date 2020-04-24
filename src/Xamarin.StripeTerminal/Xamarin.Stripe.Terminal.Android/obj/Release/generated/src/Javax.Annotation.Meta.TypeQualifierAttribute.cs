using System;

namespace Javax.Annotation.Meta {

	[global::Android.Runtime.Annotation ("javax.annotation.meta.TypeQualifier")]
	public partial class TypeQualifierAttribute : Attribute
	{
		[global::Android.Runtime.Register ("applicableTo")]
		public global::Java.Lang.Class ApplicableTo { get; set; }

	}
}
