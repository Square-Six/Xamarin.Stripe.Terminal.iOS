using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal.Callable {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/interface[@name='ConnectionTokenProvider']"
	[Register ("com/stripe/stripeterminal/callable/ConnectionTokenProvider", "", "Com.Stripe.Stripeterminal.Callable.IConnectionTokenProviderInvoker")]
	public partial interface IConnectionTokenProvider : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/interface[@name='ConnectionTokenProvider']/method[@name='fetchConnectionToken' and count(parameter)=1 and parameter[1][@type='com.stripe.stripeterminal.callable.ConnectionTokenCallback']]"
		[Register ("fetchConnectionToken", "(Lcom/stripe/stripeterminal/callable/ConnectionTokenCallback;)V", "GetFetchConnectionToken_Lcom_stripe_stripeterminal_callable_ConnectionTokenCallback_Handler:Com.Stripe.Stripeterminal.Callable.IConnectionTokenProviderInvoker, Xamarin.Stripe.Terminal.Android")]
		void FetchConnectionToken (global::Com.Stripe.Stripeterminal.Callable.IConnectionTokenCallback @callback);

	}

	[global::Android.Runtime.Register ("com/stripe/stripeterminal/callable/ConnectionTokenProvider", DoNotGenerateAcw=true)]
	internal partial class IConnectionTokenProviderInvoker : global::Java.Lang.Object, IConnectionTokenProvider {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/callable/ConnectionTokenProvider", typeof (IConnectionTokenProviderInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IConnectionTokenProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnectionTokenProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.stripe.stripeterminal.callable.ConnectionTokenProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectionTokenProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_fetchConnectionToken_Lcom_stripe_stripeterminal_callable_ConnectionTokenCallback_;
#pragma warning disable 0169
		static Delegate GetFetchConnectionToken_Lcom_stripe_stripeterminal_callable_ConnectionTokenCallback_Handler ()
		{
			if (cb_fetchConnectionToken_Lcom_stripe_stripeterminal_callable_ConnectionTokenCallback_ == null)
				cb_fetchConnectionToken_Lcom_stripe_stripeterminal_callable_ConnectionTokenCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FetchConnectionToken_Lcom_stripe_stripeterminal_callable_ConnectionTokenCallback_);
			return cb_fetchConnectionToken_Lcom_stripe_stripeterminal_callable_ConnectionTokenCallback_;
		}

		static void n_FetchConnectionToken_Lcom_stripe_stripeterminal_callable_ConnectionTokenCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Stripe.Stripeterminal.Callable.IConnectionTokenProvider __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Callable.IConnectionTokenProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Stripe.Stripeterminal.Callable.IConnectionTokenCallback @callback = (global::Com.Stripe.Stripeterminal.Callable.IConnectionTokenCallback)global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Callable.IConnectionTokenCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.FetchConnectionToken (@callback);
		}
#pragma warning restore 0169

		IntPtr id_fetchConnectionToken_Lcom_stripe_stripeterminal_callable_ConnectionTokenCallback_;
		public unsafe void FetchConnectionToken (global::Com.Stripe.Stripeterminal.Callable.IConnectionTokenCallback @callback)
		{
			if (id_fetchConnectionToken_Lcom_stripe_stripeterminal_callable_ConnectionTokenCallback_ == IntPtr.Zero)
				id_fetchConnectionToken_Lcom_stripe_stripeterminal_callable_ConnectionTokenCallback_ = JNIEnv.GetMethodID (class_ref, "fetchConnectionToken", "(Lcom/stripe/stripeterminal/callable/ConnectionTokenCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fetchConnectionToken_Lcom_stripe_stripeterminal_callable_ConnectionTokenCallback_, __args);
		}

	}

}
