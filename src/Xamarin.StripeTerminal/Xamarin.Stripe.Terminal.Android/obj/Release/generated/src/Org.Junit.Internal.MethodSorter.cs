using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.internal']/class[@name='MethodSorter']"
	[global::Android.Runtime.Register ("org/junit/internal/MethodSorter", DoNotGenerateAcw=true)]
	public partial class MethodSorter : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.junit.internal']/class[@name='MethodSorter']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Java.Util.IComparator Default {
			get {
				const string __id = "DEFAULT.Ljava/util/Comparator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.junit.internal']/class[@name='MethodSorter']/field[@name='NAME_ASCENDING']"
		[Register ("NAME_ASCENDING")]
		public static global::Java.Util.IComparator NameAscending {
			get {
				const string __id = "NAME_ASCENDING.Ljava/util/Comparator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/internal/MethodSorter", typeof (MethodSorter));
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

		protected MethodSorter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal']/class[@name='MethodSorter']/method[@name='getDeclaredMethods' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getDeclaredMethods", "(Ljava/lang/Class;)[Ljava/lang/reflect/Method;", "")]
		public static unsafe global::Java.Lang.Reflect.Method[] GetDeclaredMethods (global::Java.Lang.Class clazz)
		{
			const string __id = "getDeclaredMethods.(Ljava/lang/Class;)[Ljava/lang/reflect/Method;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Reflect.Method[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.Method));
			} finally {
			}
		}

	}
}
