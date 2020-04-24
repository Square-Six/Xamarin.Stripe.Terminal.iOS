using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal.Callable {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/class[@name='TerminalListener.DefaultImpls']"
	[global::Android.Runtime.Register ("com/stripe/stripeterminal/callable/TerminalListener$DefaultImpls", DoNotGenerateAcw=true)]
	public sealed partial class TerminalListenerDefaultImpls : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/callable/TerminalListener$DefaultImpls", typeof (TerminalListenerDefaultImpls));
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

		internal TerminalListenerDefaultImpls (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/class[@name='TerminalListener.DefaultImpls']/method[@name='onConnectionStatusChange' and count(parameter)=2 and parameter[1][@type='com.stripe.stripeterminal.callable.TerminalListener'] and parameter[2][@type='com.stripe.stripeterminal.model.external.ConnectionStatus']]"
		[Register ("onConnectionStatusChange", "(Lcom/stripe/stripeterminal/callable/TerminalListener;Lcom/stripe/stripeterminal/model/external/ConnectionStatus;)V", "")]
		public static unsafe void OnConnectionStatusChange (global::Com.Stripe.Stripeterminal.Callable.ITerminalListener _this, global::Com.Stripe.Stripeterminal.Model.External.ConnectionStatus status)
		{
			const string __id = "onConnectionStatusChange.(Lcom/stripe/stripeterminal/callable/TerminalListener;Lcom/stripe/stripeterminal/model/external/ConnectionStatus;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((_this == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this).Handle);
				__args [1] = new JniArgumentValue ((status == null) ? IntPtr.Zero : ((global::Java.Lang.Object) status).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/class[@name='TerminalListener.DefaultImpls']/method[@name='onPaymentStatusChange' and count(parameter)=2 and parameter[1][@type='com.stripe.stripeterminal.callable.TerminalListener'] and parameter[2][@type='com.stripe.stripeterminal.model.external.PaymentStatus']]"
		[Register ("onPaymentStatusChange", "(Lcom/stripe/stripeterminal/callable/TerminalListener;Lcom/stripe/stripeterminal/model/external/PaymentStatus;)V", "")]
		public static unsafe void OnPaymentStatusChange (global::Com.Stripe.Stripeterminal.Callable.ITerminalListener _this, global::Com.Stripe.Stripeterminal.Model.External.PaymentStatus status)
		{
			const string __id = "onPaymentStatusChange.(Lcom/stripe/stripeterminal/callable/TerminalListener;Lcom/stripe/stripeterminal/model/external/PaymentStatus;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((_this == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this).Handle);
				__args [1] = new JniArgumentValue ((status == null) ? IntPtr.Zero : ((global::Java.Lang.Object) status).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/class[@name='TerminalListener.DefaultImpls']/method[@name='onReportLowBatteryWarning' and count(parameter)=1 and parameter[1][@type='com.stripe.stripeterminal.callable.TerminalListener']]"
		[Register ("onReportLowBatteryWarning", "(Lcom/stripe/stripeterminal/callable/TerminalListener;)V", "")]
		public static unsafe void OnReportLowBatteryWarning (global::Com.Stripe.Stripeterminal.Callable.ITerminalListener _this)
		{
			const string __id = "onReportLowBatteryWarning.(Lcom/stripe/stripeterminal/callable/TerminalListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_this == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/class[@name='TerminalListener.DefaultImpls']/method[@name='onReportReaderEvent' and count(parameter)=2 and parameter[1][@type='com.stripe.stripeterminal.callable.TerminalListener'] and parameter[2][@type='com.stripe.stripeterminal.model.external.ReaderEvent']]"
		[Register ("onReportReaderEvent", "(Lcom/stripe/stripeterminal/callable/TerminalListener;Lcom/stripe/stripeterminal/model/external/ReaderEvent;)V", "")]
		public static unsafe void OnReportReaderEvent (global::Com.Stripe.Stripeterminal.Callable.ITerminalListener _this, global::Com.Stripe.Stripeterminal.Model.External.ReaderEvent e)
		{
			const string __id = "onReportReaderEvent.(Lcom/stripe/stripeterminal/callable/TerminalListener;Lcom/stripe/stripeterminal/model/external/ReaderEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((_this == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this).Handle);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/interface[@name='TerminalListener']"
	[Register ("com/stripe/stripeterminal/callable/TerminalListener", "", "Com.Stripe.Stripeterminal.Callable.ITerminalListenerInvoker")]
	public partial interface ITerminalListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/interface[@name='TerminalListener']/method[@name='onConnectionStatusChange' and count(parameter)=1 and parameter[1][@type='com.stripe.stripeterminal.model.external.ConnectionStatus']]"
		[Register ("onConnectionStatusChange", "(Lcom/stripe/stripeterminal/model/external/ConnectionStatus;)V", "GetOnConnectionStatusChange_Lcom_stripe_stripeterminal_model_external_ConnectionStatus_Handler:Com.Stripe.Stripeterminal.Callable.ITerminalListenerInvoker, Xamarin.Stripe.Terminal.Android")]
		void OnConnectionStatusChange (global::Com.Stripe.Stripeterminal.Model.External.ConnectionStatus status);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/interface[@name='TerminalListener']/method[@name='onPaymentStatusChange' and count(parameter)=1 and parameter[1][@type='com.stripe.stripeterminal.model.external.PaymentStatus']]"
		[Register ("onPaymentStatusChange", "(Lcom/stripe/stripeterminal/model/external/PaymentStatus;)V", "GetOnPaymentStatusChange_Lcom_stripe_stripeterminal_model_external_PaymentStatus_Handler:Com.Stripe.Stripeterminal.Callable.ITerminalListenerInvoker, Xamarin.Stripe.Terminal.Android")]
		void OnPaymentStatusChange (global::Com.Stripe.Stripeterminal.Model.External.PaymentStatus status);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/interface[@name='TerminalListener']/method[@name='onReportLowBatteryWarning' and count(parameter)=0]"
		[Register ("onReportLowBatteryWarning", "()V", "GetOnReportLowBatteryWarningHandler:Com.Stripe.Stripeterminal.Callable.ITerminalListenerInvoker, Xamarin.Stripe.Terminal.Android")]
		void OnReportLowBatteryWarning ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/interface[@name='TerminalListener']/method[@name='onReportReaderEvent' and count(parameter)=1 and parameter[1][@type='com.stripe.stripeterminal.model.external.ReaderEvent']]"
		[Register ("onReportReaderEvent", "(Lcom/stripe/stripeterminal/model/external/ReaderEvent;)V", "GetOnReportReaderEvent_Lcom_stripe_stripeterminal_model_external_ReaderEvent_Handler:Com.Stripe.Stripeterminal.Callable.ITerminalListenerInvoker, Xamarin.Stripe.Terminal.Android")]
		void OnReportReaderEvent (global::Com.Stripe.Stripeterminal.Model.External.ReaderEvent e);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/interface[@name='TerminalListener']/method[@name='onUnexpectedReaderDisconnect' and count(parameter)=1 and parameter[1][@type='com.stripe.stripeterminal.model.external.Reader']]"
		[Register ("onUnexpectedReaderDisconnect", "(Lcom/stripe/stripeterminal/model/external/Reader;)V", "GetOnUnexpectedReaderDisconnect_Lcom_stripe_stripeterminal_model_external_Reader_Handler:Com.Stripe.Stripeterminal.Callable.ITerminalListenerInvoker, Xamarin.Stripe.Terminal.Android")]
		void OnUnexpectedReaderDisconnect (global::Com.Stripe.Stripeterminal.Model.External.Reader reader);

	}

	[global::Android.Runtime.Register ("com/stripe/stripeterminal/callable/TerminalListener", DoNotGenerateAcw=true)]
	internal partial class ITerminalListenerInvoker : global::Java.Lang.Object, ITerminalListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/callable/TerminalListener", typeof (ITerminalListenerInvoker));

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

		public static ITerminalListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITerminalListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.stripe.stripeterminal.callable.TerminalListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITerminalListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onConnectionStatusChange_Lcom_stripe_stripeterminal_model_external_ConnectionStatus_;
#pragma warning disable 0169
		static Delegate GetOnConnectionStatusChange_Lcom_stripe_stripeterminal_model_external_ConnectionStatus_Handler ()
		{
			if (cb_onConnectionStatusChange_Lcom_stripe_stripeterminal_model_external_ConnectionStatus_ == null)
				cb_onConnectionStatusChange_Lcom_stripe_stripeterminal_model_external_ConnectionStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnectionStatusChange_Lcom_stripe_stripeterminal_model_external_ConnectionStatus_);
			return cb_onConnectionStatusChange_Lcom_stripe_stripeterminal_model_external_ConnectionStatus_;
		}

		static void n_OnConnectionStatusChange_Lcom_stripe_stripeterminal_model_external_ConnectionStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_status)
		{
			global::Com.Stripe.Stripeterminal.Callable.ITerminalListener __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Callable.ITerminalListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Stripe.Stripeterminal.Model.External.ConnectionStatus status = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ConnectionStatus> (native_status, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionStatusChange (status);
		}
#pragma warning restore 0169

		IntPtr id_onConnectionStatusChange_Lcom_stripe_stripeterminal_model_external_ConnectionStatus_;
		public unsafe void OnConnectionStatusChange (global::Com.Stripe.Stripeterminal.Model.External.ConnectionStatus status)
		{
			if (id_onConnectionStatusChange_Lcom_stripe_stripeterminal_model_external_ConnectionStatus_ == IntPtr.Zero)
				id_onConnectionStatusChange_Lcom_stripe_stripeterminal_model_external_ConnectionStatus_ = JNIEnv.GetMethodID (class_ref, "onConnectionStatusChange", "(Lcom/stripe/stripeterminal/model/external/ConnectionStatus;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((status == null) ? IntPtr.Zero : ((global::Java.Lang.Object) status).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionStatusChange_Lcom_stripe_stripeterminal_model_external_ConnectionStatus_, __args);
		}

		static Delegate cb_onPaymentStatusChange_Lcom_stripe_stripeterminal_model_external_PaymentStatus_;
#pragma warning disable 0169
		static Delegate GetOnPaymentStatusChange_Lcom_stripe_stripeterminal_model_external_PaymentStatus_Handler ()
		{
			if (cb_onPaymentStatusChange_Lcom_stripe_stripeterminal_model_external_PaymentStatus_ == null)
				cb_onPaymentStatusChange_Lcom_stripe_stripeterminal_model_external_PaymentStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPaymentStatusChange_Lcom_stripe_stripeterminal_model_external_PaymentStatus_);
			return cb_onPaymentStatusChange_Lcom_stripe_stripeterminal_model_external_PaymentStatus_;
		}

		static void n_OnPaymentStatusChange_Lcom_stripe_stripeterminal_model_external_PaymentStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_status)
		{
			global::Com.Stripe.Stripeterminal.Callable.ITerminalListener __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Callable.ITerminalListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Stripe.Stripeterminal.Model.External.PaymentStatus status = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentStatus> (native_status, JniHandleOwnership.DoNotTransfer);
			__this.OnPaymentStatusChange (status);
		}
#pragma warning restore 0169

		IntPtr id_onPaymentStatusChange_Lcom_stripe_stripeterminal_model_external_PaymentStatus_;
		public unsafe void OnPaymentStatusChange (global::Com.Stripe.Stripeterminal.Model.External.PaymentStatus status)
		{
			if (id_onPaymentStatusChange_Lcom_stripe_stripeterminal_model_external_PaymentStatus_ == IntPtr.Zero)
				id_onPaymentStatusChange_Lcom_stripe_stripeterminal_model_external_PaymentStatus_ = JNIEnv.GetMethodID (class_ref, "onPaymentStatusChange", "(Lcom/stripe/stripeterminal/model/external/PaymentStatus;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((status == null) ? IntPtr.Zero : ((global::Java.Lang.Object) status).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPaymentStatusChange_Lcom_stripe_stripeterminal_model_external_PaymentStatus_, __args);
		}

		static Delegate cb_onReportLowBatteryWarning;
#pragma warning disable 0169
		static Delegate GetOnReportLowBatteryWarningHandler ()
		{
			if (cb_onReportLowBatteryWarning == null)
				cb_onReportLowBatteryWarning = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnReportLowBatteryWarning);
			return cb_onReportLowBatteryWarning;
		}

		static void n_OnReportLowBatteryWarning (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Stripe.Stripeterminal.Callable.ITerminalListener __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Callable.ITerminalListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnReportLowBatteryWarning ();
		}
#pragma warning restore 0169

		IntPtr id_onReportLowBatteryWarning;
		public unsafe void OnReportLowBatteryWarning ()
		{
			if (id_onReportLowBatteryWarning == IntPtr.Zero)
				id_onReportLowBatteryWarning = JNIEnv.GetMethodID (class_ref, "onReportLowBatteryWarning", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReportLowBatteryWarning);
		}

		static Delegate cb_onReportReaderEvent_Lcom_stripe_stripeterminal_model_external_ReaderEvent_;
#pragma warning disable 0169
		static Delegate GetOnReportReaderEvent_Lcom_stripe_stripeterminal_model_external_ReaderEvent_Handler ()
		{
			if (cb_onReportReaderEvent_Lcom_stripe_stripeterminal_model_external_ReaderEvent_ == null)
				cb_onReportReaderEvent_Lcom_stripe_stripeterminal_model_external_ReaderEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReportReaderEvent_Lcom_stripe_stripeterminal_model_external_ReaderEvent_);
			return cb_onReportReaderEvent_Lcom_stripe_stripeterminal_model_external_ReaderEvent_;
		}

		static void n_OnReportReaderEvent_Lcom_stripe_stripeterminal_model_external_ReaderEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Com.Stripe.Stripeterminal.Callable.ITerminalListener __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Callable.ITerminalListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Stripe.Stripeterminal.Model.External.ReaderEvent e = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReaderEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.OnReportReaderEvent (e);
		}
#pragma warning restore 0169

		IntPtr id_onReportReaderEvent_Lcom_stripe_stripeterminal_model_external_ReaderEvent_;
		public unsafe void OnReportReaderEvent (global::Com.Stripe.Stripeterminal.Model.External.ReaderEvent e)
		{
			if (id_onReportReaderEvent_Lcom_stripe_stripeterminal_model_external_ReaderEvent_ == IntPtr.Zero)
				id_onReportReaderEvent_Lcom_stripe_stripeterminal_model_external_ReaderEvent_ = JNIEnv.GetMethodID (class_ref, "onReportReaderEvent", "(Lcom/stripe/stripeterminal/model/external/ReaderEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReportReaderEvent_Lcom_stripe_stripeterminal_model_external_ReaderEvent_, __args);
		}

		static Delegate cb_onUnexpectedReaderDisconnect_Lcom_stripe_stripeterminal_model_external_Reader_;
#pragma warning disable 0169
		static Delegate GetOnUnexpectedReaderDisconnect_Lcom_stripe_stripeterminal_model_external_Reader_Handler ()
		{
			if (cb_onUnexpectedReaderDisconnect_Lcom_stripe_stripeterminal_model_external_Reader_ == null)
				cb_onUnexpectedReaderDisconnect_Lcom_stripe_stripeterminal_model_external_Reader_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUnexpectedReaderDisconnect_Lcom_stripe_stripeterminal_model_external_Reader_);
			return cb_onUnexpectedReaderDisconnect_Lcom_stripe_stripeterminal_model_external_Reader_;
		}

		static void n_OnUnexpectedReaderDisconnect_Lcom_stripe_stripeterminal_model_external_Reader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_reader)
		{
			global::Com.Stripe.Stripeterminal.Callable.ITerminalListener __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Callable.ITerminalListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Stripe.Stripeterminal.Model.External.Reader reader = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.Reader> (native_reader, JniHandleOwnership.DoNotTransfer);
			__this.OnUnexpectedReaderDisconnect (reader);
		}
#pragma warning restore 0169

		IntPtr id_onUnexpectedReaderDisconnect_Lcom_stripe_stripeterminal_model_external_Reader_;
		public unsafe void OnUnexpectedReaderDisconnect (global::Com.Stripe.Stripeterminal.Model.External.Reader reader)
		{
			if (id_onUnexpectedReaderDisconnect_Lcom_stripe_stripeterminal_model_external_Reader_ == IntPtr.Zero)
				id_onUnexpectedReaderDisconnect_Lcom_stripe_stripeterminal_model_external_Reader_ = JNIEnv.GetMethodID (class_ref, "onUnexpectedReaderDisconnect", "(Lcom/stripe/stripeterminal/model/external/Reader;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnexpectedReaderDisconnect_Lcom_stripe_stripeterminal_model_external_Reader_, __args);
		}

	}

	// event args for com.stripe.stripeterminal.callable.TerminalListener.onConnectionStatusChange
	public partial class ConnectionStatusChangeEventArgs : global::System.EventArgs {

		public ConnectionStatusChangeEventArgs (global::Com.Stripe.Stripeterminal.Model.External.ConnectionStatus status)
		{
			this.status = status;
		}

		global::Com.Stripe.Stripeterminal.Model.External.ConnectionStatus status;
		public global::Com.Stripe.Stripeterminal.Model.External.ConnectionStatus Status {
			get { return status; }
		}
	}

	// event args for com.stripe.stripeterminal.callable.TerminalListener.onPaymentStatusChange
	public partial class PaymentStatusChangeEventArgs : global::System.EventArgs {

		public PaymentStatusChangeEventArgs (global::Com.Stripe.Stripeterminal.Model.External.PaymentStatus status)
		{
			this.status = status;
		}

		global::Com.Stripe.Stripeterminal.Model.External.PaymentStatus status;
		public global::Com.Stripe.Stripeterminal.Model.External.PaymentStatus Status {
			get { return status; }
		}
	}

	// event args for com.stripe.stripeterminal.callable.TerminalListener.onReportReaderEvent
	public partial class ReportReaderEventEventArgs : global::System.EventArgs {

		public ReportReaderEventEventArgs (global::Com.Stripe.Stripeterminal.Model.External.ReaderEvent e)
		{
			this.e = e;
		}

		global::Com.Stripe.Stripeterminal.Model.External.ReaderEvent e;
		public global::Com.Stripe.Stripeterminal.Model.External.ReaderEvent Event {
			get { return e; }
		}
	}

	// event args for com.stripe.stripeterminal.callable.TerminalListener.onUnexpectedReaderDisconnect
	public partial class UnexpectedReaderDisconnectEventArgs : global::System.EventArgs {

		public UnexpectedReaderDisconnectEventArgs (global::Com.Stripe.Stripeterminal.Model.External.Reader reader)
		{
			this.reader = reader;
		}

		global::Com.Stripe.Stripeterminal.Model.External.Reader reader;
		public global::Com.Stripe.Stripeterminal.Model.External.Reader Reader {
			get { return reader; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/stripe/stripeterminal/callable/TerminalListenerImplementor")]
	internal sealed partial class ITerminalListenerImplementor : global::Java.Lang.Object, ITerminalListener {

		object sender;

		public ITerminalListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/stripe/stripeterminal/callable/TerminalListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ConnectionStatusChangeEventArgs> OnConnectionStatusChangeHandler;
#pragma warning restore 0649

		public void OnConnectionStatusChange (global::Com.Stripe.Stripeterminal.Model.External.ConnectionStatus status)
		{
			var __h = OnConnectionStatusChangeHandler;
			if (__h != null)
				__h (sender, new ConnectionStatusChangeEventArgs (status));
		}
#pragma warning disable 0649
		public EventHandler<PaymentStatusChangeEventArgs> OnPaymentStatusChangeHandler;
#pragma warning restore 0649

		public void OnPaymentStatusChange (global::Com.Stripe.Stripeterminal.Model.External.PaymentStatus status)
		{
			var __h = OnPaymentStatusChangeHandler;
			if (__h != null)
				__h (sender, new PaymentStatusChangeEventArgs (status));
		}
#pragma warning disable 0649
		public EventHandler OnReportLowBatteryWarningHandler;
#pragma warning restore 0649

		public void OnReportLowBatteryWarning ()
		{
			var __h = OnReportLowBatteryWarningHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<ReportReaderEventEventArgs> OnReportReaderEventHandler;
#pragma warning restore 0649

		public void OnReportReaderEvent (global::Com.Stripe.Stripeterminal.Model.External.ReaderEvent e)
		{
			var __h = OnReportReaderEventHandler;
			if (__h != null)
				__h (sender, new ReportReaderEventEventArgs (e));
		}
#pragma warning disable 0649
		public EventHandler<UnexpectedReaderDisconnectEventArgs> OnUnexpectedReaderDisconnectHandler;
#pragma warning restore 0649

		public void OnUnexpectedReaderDisconnect (global::Com.Stripe.Stripeterminal.Model.External.Reader reader)
		{
			var __h = OnUnexpectedReaderDisconnectHandler;
			if (__h != null)
				__h (sender, new UnexpectedReaderDisconnectEventArgs (reader));
		}

		internal static bool __IsEmpty (ITerminalListenerImplementor value)
		{
			return value.OnConnectionStatusChangeHandler == null && value.OnPaymentStatusChangeHandler == null && value.OnReportLowBatteryWarningHandler == null && value.OnReportReaderEventHandler == null && value.OnUnexpectedReaderDisconnectHandler == null;
		}
	}

}
