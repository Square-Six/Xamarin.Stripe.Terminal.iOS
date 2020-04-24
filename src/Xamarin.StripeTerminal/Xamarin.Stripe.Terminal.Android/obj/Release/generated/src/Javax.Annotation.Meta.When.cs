using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Javax.Annotation.Meta {

	// Metadata.xml XPath class reference: path="/api/package[@name='javax.annotation.meta']/class[@name='When']"
	[global::Android.Runtime.Register ("javax/annotation/meta/When", DoNotGenerateAcw=true)]
	public sealed partial class When : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='javax.annotation.meta']/class[@name='When']/field[@name='ALWAYS']"
		[Register ("ALWAYS")]
		public static global::Javax.Annotation.Meta.When Always {
			get {
				const string __id = "ALWAYS.Ljavax/annotation/meta/When;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Javax.Annotation.Meta.When> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='javax.annotation.meta']/class[@name='When']/field[@name='MAYBE']"
		[Register ("MAYBE")]
		public static global::Javax.Annotation.Meta.When Maybe {
			get {
				const string __id = "MAYBE.Ljavax/annotation/meta/When;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Javax.Annotation.Meta.When> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='javax.annotation.meta']/class[@name='When']/field[@name='NEVER']"
		[Register ("NEVER")]
		public static global::Javax.Annotation.Meta.When Never {
			get {
				const string __id = "NEVER.Ljavax/annotation/meta/When;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Javax.Annotation.Meta.When> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='javax.annotation.meta']/class[@name='When']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public static global::Javax.Annotation.Meta.When Unknown {
			get {
				const string __id = "UNKNOWN.Ljavax/annotation/meta/When;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Javax.Annotation.Meta.When> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("javax/annotation/meta/When", typeof (When));
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

		internal When (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='javax.annotation.meta']/class[@name='When']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Ljavax/annotation/meta/When;", "")]
		public static unsafe global::Javax.Annotation.Meta.When ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Ljavax/annotation/meta/When;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Javax.Annotation.Meta.When> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='javax.annotation.meta']/class[@name='When']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Ljavax/annotation/meta/When;", "")]
		public static unsafe global::Javax.Annotation.Meta.When[] Values ()
		{
			const string __id = "values.()[Ljavax/annotation/meta/When;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Javax.Annotation.Meta.When[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Javax.Annotation.Meta.When));
			} finally {
			}
		}

	}
}
