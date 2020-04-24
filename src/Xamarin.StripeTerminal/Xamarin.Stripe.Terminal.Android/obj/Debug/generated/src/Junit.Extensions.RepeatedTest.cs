using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Junit.Extensions {

	// Metadata.xml XPath class reference: path="/api/package[@name='junit.extensions']/class[@name='RepeatedTest']"
	[global::Android.Runtime.Register ("junit/extensions/RepeatedTest", DoNotGenerateAcw=true)]
	public partial class RepeatedTest : global::Junit.Extensions.TestDecorator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("junit/extensions/RepeatedTest", typeof (RepeatedTest));
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

		protected RepeatedTest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.extensions']/class[@name='RepeatedTest']/constructor[@name='RepeatedTest' and count(parameter)=2 and parameter[1][@type='junit.framework.Test'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljunit/framework/Test;I)V", "")]
		public unsafe RepeatedTest (global::Junit.Framework.ITest test, int repeat)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljunit/framework/Test;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((test == null) ? IntPtr.Zero : ((global::Java.Lang.Object) test).Handle);
				__args [1] = new JniArgumentValue (repeat);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
