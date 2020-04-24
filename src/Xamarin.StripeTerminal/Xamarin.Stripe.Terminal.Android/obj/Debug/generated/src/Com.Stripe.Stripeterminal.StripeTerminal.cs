using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='Terminal']"
	[global::Android.Runtime.Register ("com/stripe/stripeterminal/Terminal", DoNotGenerateAcw=true)]
	public sealed partial class StripeTerminal : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='Terminal.Companion']"
		[global::Android.Runtime.Register ("com/stripe/stripeterminal/Terminal$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/Terminal$Companion", typeof (Companion));
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

			internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe bool IsInitialized {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='Terminal.Companion']/method[@name='isInitialized' and count(parameter)=0]"
				[Register ("isInitialized", "()Z", "")]
				get {
					const string __id = "isInitialized.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='Terminal.Companion']/method[@name='initTerminal' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.stripe.stripeterminal.callable.ConnectionTokenProvider'] and parameter[3][@type='com.stripe.stripeterminal.callable.TerminalListener']]"
			[Register ("initTerminal", "(Landroid/content/Context;Lcom/stripe/stripeterminal/callable/ConnectionTokenProvider;Lcom/stripe/stripeterminal/callable/TerminalListener;)V", "")]
			public unsafe void InitTerminal (global::Android.Content.Context context, global::Com.Stripe.Stripeterminal.Callable.IConnectionTokenProvider tokenProvider, global::Com.Stripe.Stripeterminal.Callable.ITerminalListener listener)
			{
				const string __id = "initTerminal.(Landroid/content/Context;Lcom/stripe/stripeterminal/callable/ConnectionTokenProvider;Lcom/stripe/stripeterminal/callable/TerminalListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					__args [1] = new JniArgumentValue ((tokenProvider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tokenProvider).Handle);
					__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/Terminal", typeof (StripeTerminal));
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

		internal StripeTerminal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe global::Com.Stripe.Stripeterminal.Model.External.Reader ConnectedReader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='Terminal']/method[@name='getConnectedReader' and count(parameter)=0]"
			[Register ("getConnectedReader", "()Lcom/stripe/stripeterminal/model/external/Reader;", "")]
			get {
				const string __id = "getConnectedReader.()Lcom/stripe/stripeterminal/model/external/Reader;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.Reader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Stripe.Stripeterminal.Model.External.ConnectionStatus ConnectionStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='Terminal']/method[@name='getConnectionStatus' and count(parameter)=0]"
			[Register ("getConnectionStatus", "()Lcom/stripe/stripeterminal/model/external/ConnectionStatus;", "")]
			get {
				const string __id = "getConnectionStatus.()Lcom/stripe/stripeterminal/model/external/ConnectionStatus;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ConnectionStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Stripe.Stripeterminal.StripeTerminal Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='Terminal']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/stripe/stripeterminal/Terminal;", "")]
			get {
				const string __id = "getInstance.()Lcom/stripe/stripeterminal/Terminal;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.StripeTerminal> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='Terminal']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "")]
			get {
				const string __id = "isInitialized.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Stripe.Stripeterminal.Model.External.PaymentStatus PaymentStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='Terminal']/method[@name='getPaymentStatus' and count(parameter)=0]"
			[Register ("getPaymentStatus", "()Lcom/stripe/stripeterminal/model/external/PaymentStatus;", "")]
			get {
				const string __id = "getPaymentStatus.()Lcom/stripe/stripeterminal/model/external/PaymentStatus;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='Terminal']/method[@name='cancelPaymentIntent' and count(parameter)=2 and parameter[1][@type='com.stripe.stripeterminal.model.external.PaymentIntent'] and parameter[2][@type='com.stripe.stripeterminal.callable.PaymentIntentCallback']]"
		[Register ("cancelPaymentIntent", "(Lcom/stripe/stripeterminal/model/external/PaymentIntent;Lcom/stripe/stripeterminal/callable/PaymentIntentCallback;)V", "")]
		public unsafe void CancelPaymentIntent (global::Com.Stripe.Stripeterminal.Model.External.PaymentIntent intent, global::Com.Stripe.Stripeterminal.Callable.IPaymentIntentCallback @callback)
		{
			const string __id = "cancelPaymentIntent.(Lcom/stripe/stripeterminal/model/external/PaymentIntent;Lcom/stripe/stripeterminal/callable/PaymentIntentCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='Terminal']/method[@name='checkForUpdate' and count(parameter)=1 and parameter[1][@type='com.stripe.stripeterminal.callable.ReaderSoftwareUpdateCallback']]"
		[Register ("checkForUpdate", "(Lcom/stripe/stripeterminal/callable/ReaderSoftwareUpdateCallback;)Lcom/stripe/stripeterminal/callable/Cancelable;", "")]
		public unsafe global::Com.Stripe.Stripeterminal.Callable.Cancelable CheckForUpdate (global::Com.Stripe.Stripeterminal.Callable.IReaderSoftwareUpdateCallback @callback)
		{
			const string __id = "checkForUpdate.(Lcom/stripe/stripeterminal/callable/ReaderSoftwareUpdateCallback;)Lcom/stripe/stripeterminal/callable/Cancelable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Callable.Cancelable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='Terminal']/method[@name='clearCachedCredentials' and count(parameter)=0]"
		[Register ("clearCachedCredentials", "()V", "")]
		public unsafe void ClearCachedCredentials ()
		{
			const string __id = "clearCachedCredentials.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='Terminal']/method[@name='collectPaymentMethod' and count(parameter)=3 and parameter[1][@type='com.stripe.stripeterminal.model.external.PaymentIntent'] and parameter[2][@type='com.stripe.stripeterminal.callable.ReaderDisplayListener'] and parameter[3][@type='com.stripe.stripeterminal.callable.PaymentIntentCallback']]"
		[Register ("collectPaymentMethod", "(Lcom/stripe/stripeterminal/model/external/PaymentIntent;Lcom/stripe/stripeterminal/callable/ReaderDisplayListener;Lcom/stripe/stripeterminal/callable/PaymentIntentCallback;)Lcom/stripe/stripeterminal/callable/Cancelable;", "")]
		public unsafe global::Com.Stripe.Stripeterminal.Callable.Cancelable CollectPaymentMethod (global::Com.Stripe.Stripeterminal.Model.External.PaymentIntent intent, global::Com.Stripe.Stripeterminal.Callable.IReaderDisplayListener listener, global::Com.Stripe.Stripeterminal.Callable.IPaymentIntentCallback @callback)
		{
			const string __id = "collectPaymentMethod.(Lcom/stripe/stripeterminal/model/external/PaymentIntent;Lcom/stripe/stripeterminal/callable/ReaderDisplayListener;Lcom/stripe/stripeterminal/callable/PaymentIntentCallback;)Lcom/stripe/stripeterminal/callable/Cancelable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Callable.Cancelable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='Terminal']/method[@name='connectReader' and count(parameter)=2 and parameter[1][@type='com.stripe.stripeterminal.model.external.Reader'] and parameter[2][@type='com.stripe.stripeterminal.callable.ReaderCallback']]"
		[Register ("connectReader", "(Lcom/stripe/stripeterminal/model/external/Reader;Lcom/stripe/stripeterminal/callable/ReaderCallback;)V", "")]
		public unsafe void ConnectReader (global::Com.Stripe.Stripeterminal.Model.External.Reader reader, global::Com.Stripe.Stripeterminal.Callable.IReaderCallback connectionCallback)
		{
			const string __id = "connectReader.(Lcom/stripe/stripeterminal/model/external/Reader;Lcom/stripe/stripeterminal/callable/ReaderCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [1] = new JniArgumentValue ((connectionCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connectionCallback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='Terminal']/method[@name='createPaymentIntent' and count(parameter)=2 and parameter[1][@type='com.stripe.stripeterminal.model.external.PaymentIntentParameters'] and parameter[2][@type='com.stripe.stripeterminal.callable.PaymentIntentCallback']]"
		[Register ("createPaymentIntent", "(Lcom/stripe/stripeterminal/model/external/PaymentIntentParameters;Lcom/stripe/stripeterminal/callable/PaymentIntentCallback;)V", "")]
		public unsafe void CreatePaymentIntent (global::Com.Stripe.Stripeterminal.Model.External.PaymentIntentParameters @params, global::Com.Stripe.Stripeterminal.Callable.IPaymentIntentCallback @callback)
		{
			const string __id = "createPaymentIntent.(Lcom/stripe/stripeterminal/model/external/PaymentIntentParameters;Lcom/stripe/stripeterminal/callable/PaymentIntentCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='Terminal']/method[@name='disconnectReader' and count(parameter)=1 and parameter[1][@type='com.stripe.stripeterminal.callable.Callback']]"
		[Register ("disconnectReader", "(Lcom/stripe/stripeterminal/callable/Callback;)V", "")]
		public unsafe void DisconnectReader (global::Com.Stripe.Stripeterminal.Callable.ICallback @callback)
		{
			const string __id = "disconnectReader.(Lcom/stripe/stripeterminal/callable/Callback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='Terminal']/method[@name='discoverReaders' and count(parameter)=3 and parameter[1][@type='com.stripe.stripeterminal.model.external.DiscoveryConfiguration'] and parameter[2][@type='com.stripe.stripeterminal.callable.DiscoveryListener'] and parameter[3][@type='com.stripe.stripeterminal.callable.Callback']]"
		[Register ("discoverReaders", "(Lcom/stripe/stripeterminal/model/external/DiscoveryConfiguration;Lcom/stripe/stripeterminal/callable/DiscoveryListener;Lcom/stripe/stripeterminal/callable/Callback;)Lcom/stripe/stripeterminal/callable/Cancelable;", "")]
		public unsafe global::Com.Stripe.Stripeterminal.Callable.Cancelable DiscoverReaders (global::Com.Stripe.Stripeterminal.Model.External.DiscoveryConfiguration config, global::Com.Stripe.Stripeterminal.Callable.IDiscoveryListener discoveryListener, global::Com.Stripe.Stripeterminal.Callable.ICallback @callback)
		{
			const string __id = "discoverReaders.(Lcom/stripe/stripeterminal/model/external/DiscoveryConfiguration;Lcom/stripe/stripeterminal/callable/DiscoveryListener;Lcom/stripe/stripeterminal/callable/Callback;)Lcom/stripe/stripeterminal/callable/Cancelable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				__args [1] = new JniArgumentValue ((discoveryListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) discoveryListener).Handle);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Callable.Cancelable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='Terminal']/method[@name='initTerminal' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.stripe.stripeterminal.callable.ConnectionTokenProvider'] and parameter[3][@type='com.stripe.stripeterminal.callable.TerminalListener']]"
		[Register ("initTerminal", "(Landroid/content/Context;Lcom/stripe/stripeterminal/callable/ConnectionTokenProvider;Lcom/stripe/stripeterminal/callable/TerminalListener;)V", "")]
		public static unsafe void InitTerminal (global::Android.Content.Context context, global::Com.Stripe.Stripeterminal.Callable.IConnectionTokenProvider tokenProvider, global::Com.Stripe.Stripeterminal.Callable.ITerminalListener listener)
		{
			const string __id = "initTerminal.(Landroid/content/Context;Lcom/stripe/stripeterminal/callable/ConnectionTokenProvider;Lcom/stripe/stripeterminal/callable/TerminalListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((tokenProvider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tokenProvider).Handle);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='Terminal']/method[@name='installUpdate' and count(parameter)=3 and parameter[1][@type='com.stripe.stripeterminal.model.external.ReaderSoftwareUpdate'] and parameter[2][@type='com.stripe.stripeterminal.callable.ReaderSoftwareUpdateListener'] and parameter[3][@type='com.stripe.stripeterminal.callable.Callback']]"
		[Register ("installUpdate", "(Lcom/stripe/stripeterminal/model/external/ReaderSoftwareUpdate;Lcom/stripe/stripeterminal/callable/ReaderSoftwareUpdateListener;Lcom/stripe/stripeterminal/callable/Callback;)Lcom/stripe/stripeterminal/callable/Cancelable;", "")]
		public unsafe global::Com.Stripe.Stripeterminal.Callable.Cancelable InstallUpdate (global::Com.Stripe.Stripeterminal.Model.External.ReaderSoftwareUpdate update, global::Com.Stripe.Stripeterminal.Callable.IReaderSoftwareUpdateListener listener, global::Com.Stripe.Stripeterminal.Callable.ICallback @callback)
		{
			const string __id = "installUpdate.(Lcom/stripe/stripeterminal/model/external/ReaderSoftwareUpdate;Lcom/stripe/stripeterminal/callable/ReaderSoftwareUpdateListener;Lcom/stripe/stripeterminal/callable/Callback;)Lcom/stripe/stripeterminal/callable/Cancelable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((update == null) ? IntPtr.Zero : ((global::Java.Lang.Object) update).Handle);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Callable.Cancelable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='Terminal']/method[@name='processPayment' and count(parameter)=2 and parameter[1][@type='com.stripe.stripeterminal.model.external.PaymentIntent'] and parameter[2][@type='com.stripe.stripeterminal.callable.PaymentIntentCallback']]"
		[Register ("processPayment", "(Lcom/stripe/stripeterminal/model/external/PaymentIntent;Lcom/stripe/stripeterminal/callable/PaymentIntentCallback;)V", "")]
		public unsafe void ProcessPayment (global::Com.Stripe.Stripeterminal.Model.External.PaymentIntent intent, global::Com.Stripe.Stripeterminal.Callable.IPaymentIntentCallback @callback)
		{
			const string __id = "processPayment.(Lcom/stripe/stripeterminal/model/external/PaymentIntent;Lcom/stripe/stripeterminal/callable/PaymentIntentCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='Terminal']/method[@name='readReusableCard' and count(parameter)=3 and parameter[1][@type='com.stripe.stripeterminal.model.external.ReadReusableCardParameters'] and parameter[2][@type='com.stripe.stripeterminal.callable.ReaderDisplayListener'] and parameter[3][@type='com.stripe.stripeterminal.callable.PaymentMethodCallback']]"
		[Register ("readReusableCard", "(Lcom/stripe/stripeterminal/model/external/ReadReusableCardParameters;Lcom/stripe/stripeterminal/callable/ReaderDisplayListener;Lcom/stripe/stripeterminal/callable/PaymentMethodCallback;)Lcom/stripe/stripeterminal/callable/Cancelable;", "")]
		public unsafe global::Com.Stripe.Stripeterminal.Callable.Cancelable ReadReusableCard (global::Com.Stripe.Stripeterminal.Model.External.ReadReusableCardParameters @params, global::Com.Stripe.Stripeterminal.Callable.IReaderDisplayListener listener, global::Com.Stripe.Stripeterminal.Callable.IPaymentMethodCallback @callback)
		{
			const string __id = "readReusableCard.(Lcom/stripe/stripeterminal/model/external/ReadReusableCardParameters;Lcom/stripe/stripeterminal/callable/ReaderDisplayListener;Lcom/stripe/stripeterminal/callable/PaymentMethodCallback;)Lcom/stripe/stripeterminal/callable/Cancelable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Callable.Cancelable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='Terminal']/method[@name='retrievePaymentIntent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.stripe.stripeterminal.callable.PaymentIntentCallback']]"
		[Register ("retrievePaymentIntent", "(Ljava/lang/String;Lcom/stripe/stripeterminal/callable/PaymentIntentCallback;)V", "")]
		public unsafe void RetrievePaymentIntent (string clientSecret, global::Com.Stripe.Stripeterminal.Callable.IPaymentIntentCallback @callback)
		{
			const string __id = "retrievePaymentIntent.(Ljava/lang/String;Lcom/stripe/stripeterminal/callable/PaymentIntentCallback;)V";
			IntPtr native_clientSecret = JNIEnv.NewString (clientSecret);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_clientSecret);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientSecret);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal']/class[@name='Terminal']/method[@name='setTerminalListener' and count(parameter)=1 and parameter[1][@type='com.stripe.stripeterminal.callable.TerminalListener']]"
		[Register ("setTerminalListener", "(Lcom/stripe/stripeterminal/callable/TerminalListener;)V", "")]
		public unsafe void SetTerminalListener (global::Com.Stripe.Stripeterminal.Callable.ITerminalListener listener)
		{
			const string __id = "setTerminalListener.(Lcom/stripe/stripeterminal/callable/TerminalListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Stripe.Stripeterminal.Callable.ITerminalListener"
		public event EventHandler<global::Com.Stripe.Stripeterminal.Callable.ConnectionStatusChangeEventArgs> ConnectionStatusChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Stripe.Stripeterminal.Callable.ITerminalListener, global::Com.Stripe.Stripeterminal.Callable.ITerminalListenerImplementor>(
						ref weak_implementor_SetTerminalListener,
						__CreateITerminalListenerImplementor,
						SetTerminalListener,
						__h => __h.OnConnectionStatusChangeHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Stripe.Stripeterminal.Callable.ITerminalListener, global::Com.Stripe.Stripeterminal.Callable.ITerminalListenerImplementor>(
						ref weak_implementor_SetTerminalListener,
						global::Com.Stripe.Stripeterminal.Callable.ITerminalListenerImplementor.__IsEmpty,
						__v => SetTerminalListener (null),
						__h => __h.OnConnectionStatusChangeHandler -= value);
			}
		}

		public event EventHandler<global::Com.Stripe.Stripeterminal.Callable.PaymentStatusChangeEventArgs> PaymentStatusChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Stripe.Stripeterminal.Callable.ITerminalListener, global::Com.Stripe.Stripeterminal.Callable.ITerminalListenerImplementor>(
						ref weak_implementor_SetTerminalListener,
						__CreateITerminalListenerImplementor,
						SetTerminalListener,
						__h => __h.OnPaymentStatusChangeHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Stripe.Stripeterminal.Callable.ITerminalListener, global::Com.Stripe.Stripeterminal.Callable.ITerminalListenerImplementor>(
						ref weak_implementor_SetTerminalListener,
						global::Com.Stripe.Stripeterminal.Callable.ITerminalListenerImplementor.__IsEmpty,
						__v => SetTerminalListener (null),
						__h => __h.OnPaymentStatusChangeHandler -= value);
			}
		}

		public event EventHandler ReportLowBatteryWarning {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Stripe.Stripeterminal.Callable.ITerminalListener, global::Com.Stripe.Stripeterminal.Callable.ITerminalListenerImplementor>(
						ref weak_implementor_SetTerminalListener,
						__CreateITerminalListenerImplementor,
						SetTerminalListener,
						__h => __h.OnReportLowBatteryWarningHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Stripe.Stripeterminal.Callable.ITerminalListener, global::Com.Stripe.Stripeterminal.Callable.ITerminalListenerImplementor>(
						ref weak_implementor_SetTerminalListener,
						global::Com.Stripe.Stripeterminal.Callable.ITerminalListenerImplementor.__IsEmpty,
						__v => SetTerminalListener (null),
						__h => __h.OnReportLowBatteryWarningHandler -= value);
			}
		}

		public event EventHandler<global::Com.Stripe.Stripeterminal.Callable.ReportReaderEventEventArgs> ReportReaderEvent {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Stripe.Stripeterminal.Callable.ITerminalListener, global::Com.Stripe.Stripeterminal.Callable.ITerminalListenerImplementor>(
						ref weak_implementor_SetTerminalListener,
						__CreateITerminalListenerImplementor,
						SetTerminalListener,
						__h => __h.OnReportReaderEventHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Stripe.Stripeterminal.Callable.ITerminalListener, global::Com.Stripe.Stripeterminal.Callable.ITerminalListenerImplementor>(
						ref weak_implementor_SetTerminalListener,
						global::Com.Stripe.Stripeterminal.Callable.ITerminalListenerImplementor.__IsEmpty,
						__v => SetTerminalListener (null),
						__h => __h.OnReportReaderEventHandler -= value);
			}
		}

		public event EventHandler<global::Com.Stripe.Stripeterminal.Callable.UnexpectedReaderDisconnectEventArgs> UnexpectedReaderDisconnect {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Stripe.Stripeterminal.Callable.ITerminalListener, global::Com.Stripe.Stripeterminal.Callable.ITerminalListenerImplementor>(
						ref weak_implementor_SetTerminalListener,
						__CreateITerminalListenerImplementor,
						SetTerminalListener,
						__h => __h.OnUnexpectedReaderDisconnectHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Stripe.Stripeterminal.Callable.ITerminalListener, global::Com.Stripe.Stripeterminal.Callable.ITerminalListenerImplementor>(
						ref weak_implementor_SetTerminalListener,
						global::Com.Stripe.Stripeterminal.Callable.ITerminalListenerImplementor.__IsEmpty,
						__v => SetTerminalListener (null),
						__h => __h.OnUnexpectedReaderDisconnectHandler -= value);
			}
		}

		WeakReference weak_implementor_SetTerminalListener;

		global::Com.Stripe.Stripeterminal.Callable.ITerminalListenerImplementor __CreateITerminalListenerImplementor ()
		{
			return new global::Com.Stripe.Stripeterminal.Callable.ITerminalListenerImplementor (this);
		}
#endregion
	}
}
