using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Checkerframework.Checker.Nullness {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.checkerframework.checker.nullness']/class[@name='NullnessUtil']"
	[global::Android.Runtime.Register ("org/checkerframework/checker/nullness/NullnessUtil", DoNotGenerateAcw=true)]
	public sealed partial class NullnessUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/checkerframework/checker/nullness/NullnessUtil", typeof (NullnessUtil));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal NullnessUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.nullness']/class[@name='NullnessUtil']/method[@name='castNonNull' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("castNonNull", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object CastNonNull (global::Java.Lang.Object @ref)
		{
			const string __id = "castNonNull.(Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native__ref = JNIEnv.ToLocalJniHandle (@ref);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__ref);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__ref);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.nullness']/class[@name='NullnessUtil']/method[@name='castNonNullDeep' and count(parameter)=1 and parameter[1][@type='T[]']]"
		[Register ("castNonNullDeep", "([Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] CastNonNullDeep (global::Java.Lang.Object[] arr)
		{
			const string __id = "castNonNullDeep.([Ljava/lang/Object;)[Ljava/lang/Object;";
			IntPtr native_arr = JNIEnv.NewArray (arr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_arr);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
				if (arr != null) {
					JNIEnv.CopyArray (native_arr, arr);
					JNIEnv.DeleteLocalRef (native_arr);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.nullness']/class[@name='NullnessUtil']/method[@name='castNonNullDeep' and count(parameter)=1 and parameter[1][@type='T[][]']]"
		[Register ("castNonNullDeep", "([[Ljava/lang/Object;)[[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[][] CastNonNullDeep (global::Java.Lang.Object[][] arr)
		{
			const string __id = "castNonNullDeep.([[Ljava/lang/Object;)[[Ljava/lang/Object;";
			IntPtr native_arr = JNIEnv.NewArray (arr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_arr);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object[][]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object[]));
			} finally {
				if (arr != null) {
					JNIEnv.CopyArray (native_arr, arr);
					JNIEnv.DeleteLocalRef (native_arr);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.nullness']/class[@name='NullnessUtil']/method[@name='castNonNullDeep' and count(parameter)=1 and parameter[1][@type='T[][][]']]"
		[Register ("castNonNullDeep", "([[[Ljava/lang/Object;)[[[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[][][] CastNonNullDeep (global::Java.Lang.Object[][][] arr)
		{
			const string __id = "castNonNullDeep.([[[Ljava/lang/Object;)[[[Ljava/lang/Object;";
			IntPtr native_arr = JNIEnv.NewArray (arr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_arr);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object[][][]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object[][]));
			} finally {
				if (arr != null) {
					JNIEnv.CopyArray (native_arr, arr);
					JNIEnv.DeleteLocalRef (native_arr);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.nullness']/class[@name='NullnessUtil']/method[@name='castNonNullDeep' and count(parameter)=1 and parameter[1][@type='T[][][][]']]"
		[Register ("castNonNullDeep", "([[[[Ljava/lang/Object;)[[[[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[][][][] CastNonNullDeep (global::Java.Lang.Object[][][][] arr)
		{
			const string __id = "castNonNullDeep.([[[[Ljava/lang/Object;)[[[[Ljava/lang/Object;";
			IntPtr native_arr = JNIEnv.NewArray (arr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_arr);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object[][][][]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object[][][]));
			} finally {
				if (arr != null) {
					JNIEnv.CopyArray (native_arr, arr);
					JNIEnv.DeleteLocalRef (native_arr);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.nullness']/class[@name='NullnessUtil']/method[@name='castNonNullDeep' and count(parameter)=1 and parameter[1][@type='T[][][][][]']]"
		[Register ("castNonNullDeep", "([[[[[Ljava/lang/Object;)[[[[[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[][][][][] CastNonNullDeep (global::Java.Lang.Object[][][][][] arr)
		{
			const string __id = "castNonNullDeep.([[[[[Ljava/lang/Object;)[[[[[Ljava/lang/Object;";
			IntPtr native_arr = JNIEnv.NewArray (arr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_arr);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object[][][][][]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object[][][][]));
			} finally {
				if (arr != null) {
					JNIEnv.CopyArray (native_arr, arr);
					JNIEnv.DeleteLocalRef (native_arr);
				}
			}
		}

	}
}
