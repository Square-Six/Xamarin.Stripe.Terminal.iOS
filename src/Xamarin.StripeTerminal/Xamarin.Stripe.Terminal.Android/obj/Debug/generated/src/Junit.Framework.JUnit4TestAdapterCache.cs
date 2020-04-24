using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Junit.Framework {

	// Metadata.xml XPath class reference: path="/api/package[@name='junit.framework']/class[@name='JUnit4TestAdapterCache']"
	[global::Android.Runtime.Register ("junit/framework/JUnit4TestAdapterCache", DoNotGenerateAcw=true)]
	public partial class JUnit4TestAdapterCache : global::Java.Util.HashMap {

		static readonly JniPeerMembers _members = new XAPeerMembers ("junit/framework/JUnit4TestAdapterCache", typeof (JUnit4TestAdapterCache));
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

		protected JUnit4TestAdapterCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.framework']/class[@name='JUnit4TestAdapterCache']/constructor[@name='JUnit4TestAdapterCache' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JUnit4TestAdapterCache ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public static unsafe global::Junit.Framework.JUnit4TestAdapterCache Default {
			// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/class[@name='JUnit4TestAdapterCache']/method[@name='getDefault' and count(parameter)=0]"
			[Register ("getDefault", "()Ljunit/framework/JUnit4TestAdapterCache;", "")]
			get {
				const string __id = "getDefault.()Ljunit/framework/JUnit4TestAdapterCache;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Junit.Framework.JUnit4TestAdapterCache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
