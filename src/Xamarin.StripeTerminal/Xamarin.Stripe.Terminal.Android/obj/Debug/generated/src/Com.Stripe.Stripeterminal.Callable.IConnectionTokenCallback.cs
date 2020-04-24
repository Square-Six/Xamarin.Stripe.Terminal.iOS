using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal.Callable {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/interface[@name='ConnectionTokenCallback']"
	[Register ("com/stripe/stripeterminal/callable/ConnectionTokenCallback", "", "Com.Stripe.Stripeterminal.Callable.IConnectionTokenCallbackInvoker")]
	public partial interface IConnectionTokenCallback : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/interface[@name='ConnectionTokenCallback']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='com.stripe.stripeterminal.model.external.ConnectionTokenException']]"
		[Register ("onFailure", "(Lcom/stripe/stripeterminal/model/external/ConnectionTokenException;)V", "GetOnFailure_Lcom_stripe_stripeterminal_model_external_ConnectionTokenException_Handler:Com.Stripe.Stripeterminal.Callable.IConnectionTokenCallbackInvoker, Xamarin.Stripe.Terminal.Android")]
		void OnFailure (global::Com.Stripe.Stripeterminal.Model.External.ConnectionTokenException e);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/interface[@name='ConnectionTokenCallback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onSuccess", "(Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Handler:Com.Stripe.Stripeterminal.Callable.IConnectionTokenCallbackInvoker, Xamarin.Stripe.Terminal.Android")]
		void OnSuccess (string token);

	}

	[global::Android.Runtime.Register ("com/stripe/stripeterminal/callable/ConnectionTokenCallback", DoNotGenerateAcw=true)]
	internal partial class IConnectionTokenCallbackInvoker : global::Java.Lang.Object, IConnectionTokenCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/callable/ConnectionTokenCallback", typeof (IConnectionTokenCallbackInvoker));

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

		public static IConnectionTokenCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnectionTokenCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.stripe.stripeterminal.callable.ConnectionTokenCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectionTokenCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFailure_Lcom_stripe_stripeterminal_model_external_ConnectionTokenException_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Lcom_stripe_stripeterminal_model_external_ConnectionTokenException_Handler ()
		{
			if (cb_onFailure_Lcom_stripe_stripeterminal_model_external_ConnectionTokenException_ == null)
				cb_onFailure_Lcom_stripe_stripeterminal_model_external_ConnectionTokenException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailure_Lcom_stripe_stripeterminal_model_external_ConnectionTokenException_);
			return cb_onFailure_Lcom_stripe_stripeterminal_model_external_ConnectionTokenException_;
		}

		static void n_OnFailure_Lcom_stripe_stripeterminal_model_external_ConnectionTokenException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Com.Stripe.Stripeterminal.Callable.IConnectionTokenCallback __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Callable.IConnectionTokenCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Stripe.Stripeterminal.Model.External.ConnectionTokenException e = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ConnectionTokenException> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (e);
		}
#pragma warning restore 0169

		IntPtr id_onFailure_Lcom_stripe_stripeterminal_model_external_ConnectionTokenException_;
		public unsafe void OnFailure (global::Com.Stripe.Stripeterminal.Model.External.ConnectionTokenException e)
		{
			if (id_onFailure_Lcom_stripe_stripeterminal_model_external_ConnectionTokenException_ == IntPtr.Zero)
				id_onFailure_Lcom_stripe_stripeterminal_model_external_ConnectionTokenException_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Lcom/stripe/stripeterminal/model/external/ConnectionTokenException;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Lcom_stripe_stripeterminal_model_external_ConnectionTokenException_, __args);
		}

		static Delegate cb_onSuccess_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_lang_String_Handler ()
		{
			if (cb_onSuccess_Ljava_lang_String_ == null)
				cb_onSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_lang_String_);
			return cb_onSuccess_Ljava_lang_String_;
		}

		static void n_OnSuccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_token)
		{
			global::Com.Stripe.Stripeterminal.Callable.IConnectionTokenCallback __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Callable.IConnectionTokenCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string token = JNIEnv.GetString (native_token, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (token);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_lang_String_;
		public unsafe void OnSuccess (string token)
		{
			if (id_onSuccess_Ljava_lang_String_ == IntPtr.Zero)
				id_onSuccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/String;)V");
			IntPtr native_token = JNIEnv.NewString (token);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_token);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_token);
		}

	}

}
