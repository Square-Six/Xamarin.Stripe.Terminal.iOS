using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='BuildConfig']"
	[global::Android.Runtime.Register ("com/stripe/stripeterminal/BuildConfig", DoNotGenerateAcw=true)]
	public sealed partial class BuildConfig : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='BuildConfig']/field[@name='BUILD_TYPE']"
		[Register ("BUILD_TYPE")]
		public const string BuildType = (string) "release";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='BuildConfig']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public const bool Debug = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='BuildConfig']/field[@name='LIBRARY_PACKAGE_NAME']"
		[Register ("LIBRARY_PACKAGE_NAME")]
		public const string LibraryPackageName = (string) "com.stripe.stripeterminal";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='BuildConfig']/field[@name='VERSION_CODE']"
		[Register ("VERSION_CODE")]
		public const int VersionCode = (int) 27;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='BuildConfig']/field[@name='VERSION_NAME']"
		[Register ("VERSION_NAME")]
		public const string VersionName = (string) "1.0.8";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/BuildConfig", typeof (BuildConfig));
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

		internal BuildConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='BuildConfig']/constructor[@name='BuildConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BuildConfig ()
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

	}
}
