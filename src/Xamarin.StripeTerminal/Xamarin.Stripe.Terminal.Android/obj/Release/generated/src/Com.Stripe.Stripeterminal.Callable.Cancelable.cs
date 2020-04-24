using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal.Callable {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/class[@name='Cancelable']"
	[global::Android.Runtime.Register ("com/stripe/stripeterminal/callable/Cancelable", DoNotGenerateAcw=true)]
	public sealed partial class Cancelable : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/callable/Cancelable", typeof (Cancelable));
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

		internal Cancelable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe bool IsCompleted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/class[@name='Cancelable']/method[@name='isCompleted' and count(parameter)=0]"
			[Register ("isCompleted", "()Z", "")]
			get {
				const string __id = "isCompleted.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/class[@name='Cancelable']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='com.stripe.stripeterminal.callable.Callback']]"
		[Register ("cancel", "(Lcom/stripe/stripeterminal/callable/Callback;)V", "")]
		public unsafe void Cancel (global::Com.Stripe.Stripeterminal.Callable.ICallback @callback)
		{
			const string __id = "cancel.(Lcom/stripe/stripeterminal/callable/Callback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
