using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Checkerframework.Checker.Nullness {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.checkerframework.checker.nullness']/class[@name='Opt']"
	[global::Android.Runtime.Register ("org/checkerframework/checker/nullness/Opt", DoNotGenerateAcw=true)]
	public sealed partial class Opt : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/checkerframework/checker/nullness/Opt", typeof (Opt));
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

		internal Opt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.nullness']/class[@name='Opt']/method[@name='filter' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='java.util.function.Predicate&lt;? super T&gt;']]"
		[Register ("filter", "(Ljava/lang/Object;Ljava/util/function/Predicate;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object Filter (global::Java.Lang.Object primary, global::Java.Util.Functions.IPredicate predicate)
		{
			const string __id = "filter.(Ljava/lang/Object;Ljava/util/function/Predicate;)Ljava/lang/Object;";
			IntPtr native_primary = JNIEnv.ToLocalJniHandle (primary);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_primary);
				__args [1] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_primary);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.nullness']/class[@name='Opt']/method[@name='get' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("get", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object Get (global::Java.Lang.Object primary)
		{
			const string __id = "get.(Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_primary = JNIEnv.ToLocalJniHandle (primary);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_primary);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_primary);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.nullness']/class[@name='Opt']/method[@name='ifPresent' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='java.util.function.Consumer&lt;? super T&gt;']]"
		[Register ("ifPresent", "(Ljava/lang/Object;Ljava/util/function/Consumer;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe void IfPresent (global::Java.Lang.Object primary, global::Java.Util.Functions.IConsumer consumer)
		{
			const string __id = "ifPresent.(Ljava/lang/Object;Ljava/util/function/Consumer;)V";
			IntPtr native_primary = JNIEnv.ToLocalJniHandle (primary);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_primary);
				__args [1] = new JniArgumentValue ((consumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consumer).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_primary);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.nullness']/class[@name='Opt']/method[@name='isPresent' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("isPresent", "(Ljava/lang/Object;)Z", "")]
		public static unsafe bool IsPresent (global::Java.Lang.Object primary)
		{
			const string __id = "isPresent.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((primary == null) ? IntPtr.Zero : ((global::Java.Lang.Object) primary).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.nullness']/class[@name='Opt']/method[@name='map' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='java.util.function.Function&lt;? super T, ? extends U&gt;']]"
		[Register ("map", "(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U"})]
		public static unsafe global::Java.Lang.Object Map (global::Java.Lang.Object primary, global::Java.Util.Functions.IFunction mapper)
		{
			const string __id = "map.(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;";
			IntPtr native_primary = JNIEnv.ToLocalJniHandle (primary);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_primary);
				__args [1] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_primary);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.nullness']/class[@name='Opt']/method[@name='orElse' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='T']]"
		[Register ("orElse", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object OrElse (global::Java.Lang.Object primary, global::Java.Lang.Object other)
		{
			const string __id = "orElse.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_primary = JNIEnv.ToLocalJniHandle (primary);
			IntPtr native_other = JNIEnv.ToLocalJniHandle (other);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_primary);
				__args [1] = new JniArgumentValue (native_other);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_primary);
				JNIEnv.DeleteLocalRef (native_other);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.nullness']/class[@name='Opt']/method[@name='orElseGet' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='java.util.function.Supplier&lt;? extends T&gt;']]"
		[Register ("orElseGet", "(Ljava/lang/Object;Ljava/util/function/Supplier;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object OrElseGet (global::Java.Lang.Object primary, global::Java.Util.Functions.ISupplier other)
		{
			const string __id = "orElseGet.(Ljava/lang/Object;Ljava/util/function/Supplier;)Ljava/lang/Object;";
			IntPtr native_primary = JNIEnv.ToLocalJniHandle (primary);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_primary);
				__args [1] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_primary);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.nullness']/class[@name='Opt']/method[@name='orElseThrow' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='java.util.function.Supplier&lt;? extends X&gt;']]"
		[Register ("orElseThrow", "(Ljava/lang/Object;Ljava/util/function/Supplier;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "X extends java.lang.Throwable"})]
		public static unsafe global::Java.Lang.Object OrElseThrow (global::Java.Lang.Object primary, global::Java.Util.Functions.ISupplier exceptionSupplier)
		{
			const string __id = "orElseThrow.(Ljava/lang/Object;Ljava/util/function/Supplier;)Ljava/lang/Object;";
			IntPtr native_primary = JNIEnv.ToLocalJniHandle (primary);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_primary);
				__args [1] = new JniArgumentValue ((exceptionSupplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) exceptionSupplier).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_primary);
			}
		}

	}
}
