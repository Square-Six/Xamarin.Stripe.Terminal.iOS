using System;

namespace Org.Checkerframework.Framework.Qual {

	[global::Android.Runtime.Annotation ("org.checkerframework.framework.qual.Covariant")]
	public partial class CovariantAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public int[] Value { get; set; }

	}
}
