using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal.Callable {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/interface[@name='ReaderDisplayListener']"
	[Register ("com/stripe/stripeterminal/callable/ReaderDisplayListener", "", "Com.Stripe.Stripeterminal.Callable.IReaderDisplayListenerInvoker")]
	public partial interface IReaderDisplayListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/interface[@name='ReaderDisplayListener']/method[@name='onRequestReaderDisplayMessage' and count(parameter)=1 and parameter[1][@type='com.stripe.stripeterminal.model.external.ReaderDisplayMessage']]"
		[Register ("onRequestReaderDisplayMessage", "(Lcom/stripe/stripeterminal/model/external/ReaderDisplayMessage;)V", "GetOnRequestReaderDisplayMessage_Lcom_stripe_stripeterminal_model_external_ReaderDisplayMessage_Handler:Com.Stripe.Stripeterminal.Callable.IReaderDisplayListenerInvoker, Xamarin.Stripe.Terminal.Android")]
		void OnRequestReaderDisplayMessage (global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage message);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/interface[@name='ReaderDisplayListener']/method[@name='onRequestReaderInput' and count(parameter)=1 and parameter[1][@type='com.stripe.stripeterminal.model.external.ReaderInputOptions']]"
		[Register ("onRequestReaderInput", "(Lcom/stripe/stripeterminal/model/external/ReaderInputOptions;)V", "GetOnRequestReaderInput_Lcom_stripe_stripeterminal_model_external_ReaderInputOptions_Handler:Com.Stripe.Stripeterminal.Callable.IReaderDisplayListenerInvoker, Xamarin.Stripe.Terminal.Android")]
		void OnRequestReaderInput (global::Com.Stripe.Stripeterminal.Model.External.ReaderInputOptions options);

	}

	[global::Android.Runtime.Register ("com/stripe/stripeterminal/callable/ReaderDisplayListener", DoNotGenerateAcw=true)]
	internal partial class IReaderDisplayListenerInvoker : global::Java.Lang.Object, IReaderDisplayListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/callable/ReaderDisplayListener", typeof (IReaderDisplayListenerInvoker));

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

		public static IReaderDisplayListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IReaderDisplayListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.stripe.stripeterminal.callable.ReaderDisplayListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IReaderDisplayListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRequestReaderDisplayMessage_Lcom_stripe_stripeterminal_model_external_ReaderDisplayMessage_;
#pragma warning disable 0169
		static Delegate GetOnRequestReaderDisplayMessage_Lcom_stripe_stripeterminal_model_external_ReaderDisplayMessage_Handler ()
		{
			if (cb_onRequestReaderDisplayMessage_Lcom_stripe_stripeterminal_model_external_ReaderDisplayMessage_ == null)
				cb_onRequestReaderDisplayMessage_Lcom_stripe_stripeterminal_model_external_ReaderDisplayMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRequestReaderDisplayMessage_Lcom_stripe_stripeterminal_model_external_ReaderDisplayMessage_);
			return cb_onRequestReaderDisplayMessage_Lcom_stripe_stripeterminal_model_external_ReaderDisplayMessage_;
		}

		static void n_OnRequestReaderDisplayMessage_Lcom_stripe_stripeterminal_model_external_ReaderDisplayMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			global::Com.Stripe.Stripeterminal.Callable.IReaderDisplayListener __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Callable.IReaderDisplayListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage message = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			__this.OnRequestReaderDisplayMessage (message);
		}
#pragma warning restore 0169

		IntPtr id_onRequestReaderDisplayMessage_Lcom_stripe_stripeterminal_model_external_ReaderDisplayMessage_;
		public unsafe void OnRequestReaderDisplayMessage (global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage message)
		{
			if (id_onRequestReaderDisplayMessage_Lcom_stripe_stripeterminal_model_external_ReaderDisplayMessage_ == IntPtr.Zero)
				id_onRequestReaderDisplayMessage_Lcom_stripe_stripeterminal_model_external_ReaderDisplayMessage_ = JNIEnv.GetMethodID (class_ref, "onRequestReaderDisplayMessage", "(Lcom/stripe/stripeterminal/model/external/ReaderDisplayMessage;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRequestReaderDisplayMessage_Lcom_stripe_stripeterminal_model_external_ReaderDisplayMessage_, __args);
		}

		static Delegate cb_onRequestReaderInput_Lcom_stripe_stripeterminal_model_external_ReaderInputOptions_;
#pragma warning disable 0169
		static Delegate GetOnRequestReaderInput_Lcom_stripe_stripeterminal_model_external_ReaderInputOptions_Handler ()
		{
			if (cb_onRequestReaderInput_Lcom_stripe_stripeterminal_model_external_ReaderInputOptions_ == null)
				cb_onRequestReaderInput_Lcom_stripe_stripeterminal_model_external_ReaderInputOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRequestReaderInput_Lcom_stripe_stripeterminal_model_external_ReaderInputOptions_);
			return cb_onRequestReaderInput_Lcom_stripe_stripeterminal_model_external_ReaderInputOptions_;
		}

		static void n_OnRequestReaderInput_Lcom_stripe_stripeterminal_model_external_ReaderInputOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Stripe.Stripeterminal.Callable.IReaderDisplayListener __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Callable.IReaderDisplayListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Stripe.Stripeterminal.Model.External.ReaderInputOptions options = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReaderInputOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.OnRequestReaderInput (options);
		}
#pragma warning restore 0169

		IntPtr id_onRequestReaderInput_Lcom_stripe_stripeterminal_model_external_ReaderInputOptions_;
		public unsafe void OnRequestReaderInput (global::Com.Stripe.Stripeterminal.Model.External.ReaderInputOptions options)
		{
			if (id_onRequestReaderInput_Lcom_stripe_stripeterminal_model_external_ReaderInputOptions_ == IntPtr.Zero)
				id_onRequestReaderInput_Lcom_stripe_stripeterminal_model_external_ReaderInputOptions_ = JNIEnv.GetMethodID (class_ref, "onRequestReaderInput", "(Lcom/stripe/stripeterminal/model/external/ReaderInputOptions;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRequestReaderInput_Lcom_stripe_stripeterminal_model_external_ReaderInputOptions_, __args);
		}

	}

	// event args for com.stripe.stripeterminal.callable.ReaderDisplayListener.onRequestReaderDisplayMessage
	public partial class RequestReaderDisplayMessageEventArgs : global::System.EventArgs {

		public RequestReaderDisplayMessageEventArgs (global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage message)
		{
			this.message = message;
		}

		global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage message;
		public global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage Message {
			get { return message; }
		}
	}

	// event args for com.stripe.stripeterminal.callable.ReaderDisplayListener.onRequestReaderInput
	public partial class RequestReaderInputEventArgs : global::System.EventArgs {

		public RequestReaderInputEventArgs (global::Com.Stripe.Stripeterminal.Model.External.ReaderInputOptions options)
		{
			this.options = options;
		}

		global::Com.Stripe.Stripeterminal.Model.External.ReaderInputOptions options;
		public global::Com.Stripe.Stripeterminal.Model.External.ReaderInputOptions Options {
			get { return options; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/stripe/stripeterminal/callable/ReaderDisplayListenerImplementor")]
	internal sealed partial class IReaderDisplayListenerImplementor : global::Java.Lang.Object, IReaderDisplayListener {

		object sender;

		public IReaderDisplayListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/stripe/stripeterminal/callable/ReaderDisplayListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<RequestReaderDisplayMessageEventArgs> OnRequestReaderDisplayMessageHandler;
#pragma warning restore 0649

		public void OnRequestReaderDisplayMessage (global::Com.Stripe.Stripeterminal.Model.External.ReaderDisplayMessage message)
		{
			var __h = OnRequestReaderDisplayMessageHandler;
			if (__h != null)
				__h (sender, new RequestReaderDisplayMessageEventArgs (message));
		}
#pragma warning disable 0649
		public EventHandler<RequestReaderInputEventArgs> OnRequestReaderInputHandler;
#pragma warning restore 0649

		public void OnRequestReaderInput (global::Com.Stripe.Stripeterminal.Model.External.ReaderInputOptions options)
		{
			var __h = OnRequestReaderInputHandler;
			if (__h != null)
				__h (sender, new RequestReaderInputEventArgs (options));
		}

		internal static bool __IsEmpty (IReaderDisplayListenerImplementor value)
		{
			return value.OnRequestReaderDisplayMessageHandler == null && value.OnRequestReaderInputHandler == null;
		}
	}

}
