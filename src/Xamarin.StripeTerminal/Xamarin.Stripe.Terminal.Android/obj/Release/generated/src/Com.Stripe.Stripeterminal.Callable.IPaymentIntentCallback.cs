using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal.Callable {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/interface[@name='PaymentIntentCallback']"
	[Register ("com/stripe/stripeterminal/callable/PaymentIntentCallback", "", "Com.Stripe.Stripeterminal.Callable.IPaymentIntentCallbackInvoker")]
	public partial interface IPaymentIntentCallback : global::Com.Stripe.Stripeterminal.Callable.IErrorCallback {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/interface[@name='PaymentIntentCallback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='com.stripe.stripeterminal.model.external.PaymentIntent']]"
		[Register ("onSuccess", "(Lcom/stripe/stripeterminal/model/external/PaymentIntent;)V", "GetOnSuccess_Lcom_stripe_stripeterminal_model_external_PaymentIntent_Handler:Com.Stripe.Stripeterminal.Callable.IPaymentIntentCallbackInvoker, Xamarin.Stripe.Terminal.Android")]
		void OnSuccess (global::Com.Stripe.Stripeterminal.Model.External.PaymentIntent paymentIntent);

	}

	[global::Android.Runtime.Register ("com/stripe/stripeterminal/callable/PaymentIntentCallback", DoNotGenerateAcw=true)]
	internal partial class IPaymentIntentCallbackInvoker : global::Java.Lang.Object, IPaymentIntentCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/callable/PaymentIntentCallback", typeof (IPaymentIntentCallbackInvoker));

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

		public static IPaymentIntentCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPaymentIntentCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.stripe.stripeterminal.callable.PaymentIntentCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPaymentIntentCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSuccess_Lcom_stripe_stripeterminal_model_external_PaymentIntent_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Lcom_stripe_stripeterminal_model_external_PaymentIntent_Handler ()
		{
			if (cb_onSuccess_Lcom_stripe_stripeterminal_model_external_PaymentIntent_ == null)
				cb_onSuccess_Lcom_stripe_stripeterminal_model_external_PaymentIntent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Lcom_stripe_stripeterminal_model_external_PaymentIntent_);
			return cb_onSuccess_Lcom_stripe_stripeterminal_model_external_PaymentIntent_;
		}

		static void n_OnSuccess_Lcom_stripe_stripeterminal_model_external_PaymentIntent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paymentIntent)
		{
			global::Com.Stripe.Stripeterminal.Callable.IPaymentIntentCallback __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Callable.IPaymentIntentCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Stripe.Stripeterminal.Model.External.PaymentIntent paymentIntent = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentIntent> (native_paymentIntent, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (paymentIntent);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Lcom_stripe_stripeterminal_model_external_PaymentIntent_;
		public unsafe void OnSuccess (global::Com.Stripe.Stripeterminal.Model.External.PaymentIntent paymentIntent)
		{
			if (id_onSuccess_Lcom_stripe_stripeterminal_model_external_PaymentIntent_ == IntPtr.Zero)
				id_onSuccess_Lcom_stripe_stripeterminal_model_external_PaymentIntent_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lcom/stripe/stripeterminal/model/external/PaymentIntent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((paymentIntent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paymentIntent).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Lcom_stripe_stripeterminal_model_external_PaymentIntent_, __args);
		}

		static Delegate cb_onFailure_Lcom_stripe_stripeterminal_model_external_TerminalException_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Lcom_stripe_stripeterminal_model_external_TerminalException_Handler ()
		{
			if (cb_onFailure_Lcom_stripe_stripeterminal_model_external_TerminalException_ == null)
				cb_onFailure_Lcom_stripe_stripeterminal_model_external_TerminalException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailure_Lcom_stripe_stripeterminal_model_external_TerminalException_);
			return cb_onFailure_Lcom_stripe_stripeterminal_model_external_TerminalException_;
		}

		static void n_OnFailure_Lcom_stripe_stripeterminal_model_external_TerminalException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Com.Stripe.Stripeterminal.Callable.IPaymentIntentCallback __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Callable.IPaymentIntentCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Stripe.Stripeterminal.Model.External.TerminalException e = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (e);
		}
#pragma warning restore 0169

		IntPtr id_onFailure_Lcom_stripe_stripeterminal_model_external_TerminalException_;
		public unsafe void OnFailure (global::Com.Stripe.Stripeterminal.Model.External.TerminalException e)
		{
			if (id_onFailure_Lcom_stripe_stripeterminal_model_external_TerminalException_ == IntPtr.Zero)
				id_onFailure_Lcom_stripe_stripeterminal_model_external_TerminalException_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Lcom/stripe/stripeterminal/model/external/TerminalException;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Lcom_stripe_stripeterminal_model_external_TerminalException_, __args);
		}

	}

}
