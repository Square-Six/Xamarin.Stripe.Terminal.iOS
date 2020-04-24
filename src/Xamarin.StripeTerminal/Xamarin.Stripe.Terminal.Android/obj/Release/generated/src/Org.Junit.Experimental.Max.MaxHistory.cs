using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Experimental.Max {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.experimental.max']/class[@name='MaxHistory']"
	[global::Android.Runtime.Register ("org/junit/experimental/max/MaxHistory", DoNotGenerateAcw=true)]
	public partial class MaxHistory : global::Java.Lang.Object, global::Java.IO.ISerializable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/experimental/max/MaxHistory", typeof (MaxHistory));
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

		protected MaxHistory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.max']/class[@name='MaxHistory']/method[@name='forFolder' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("forFolder", "(Ljava/io/File;)Lorg/junit/experimental/max/MaxHistory;", "")]
		public static unsafe global::Org.Junit.Experimental.Max.MaxHistory ForFolder (global::Java.IO.File file)
		{
			const string __id = "forFolder.(Ljava/io/File;)Lorg/junit/experimental/max/MaxHistory;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Max.MaxHistory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_testComparator;
#pragma warning disable 0169
		static Delegate GetTestComparatorHandler ()
		{
			if (cb_testComparator == null)
				cb_testComparator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_TestComparator);
			return cb_testComparator;
		}

		static IntPtr n_TestComparator (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Experimental.Max.MaxHistory __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Max.MaxHistory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TestComparator ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.max']/class[@name='MaxHistory']/method[@name='testComparator' and count(parameter)=0]"
		[Register ("testComparator", "()Ljava/util/Comparator;", "GetTestComparatorHandler")]
		public virtual unsafe global::Java.Util.IComparator TestComparator ()
		{
			const string __id = "testComparator.()Ljava/util/Comparator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
