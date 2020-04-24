using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal.Callable {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/interface[@name='ErrorCallback']"
	[Register ("com/stripe/stripeterminal/callable/ErrorCallback", "", "Com.Stripe.Stripeterminal.Callable.IErrorCallbackInvoker")]
	public partial interface IErrorCallback : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/interface[@name='ErrorCallback']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='com.stripe.stripeterminal.model.external.TerminalException']]"
		[Register ("onFailure", "(Lcom/stripe/stripeterminal/model/external/TerminalException;)V", "GetOnFailure_Lcom_stripe_stripeterminal_model_external_TerminalException_Handler:Com.Stripe.Stripeterminal.Callable.IErrorCallbackInvoker, Xamarin.Stripe.Terminal.Android")]
		void OnFailure (global::Com.Stripe.Stripeterminal.Model.External.TerminalException e);

	}

	[global::Android.Runtime.Register ("com/stripe/stripeterminal/callable/ErrorCallback", DoNotGenerateAcw=true)]
	internal partial class IErrorCallbackInvoker : global::Java.Lang.Object, IErrorCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/callable/ErrorCallback", typeof (IErrorCallbackInvoker));

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

		public static IErrorCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IErrorCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.stripe.stripeterminal.callable.ErrorCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IErrorCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Stripe.Stripeterminal.Callable.IErrorCallback __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Callable.IErrorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
