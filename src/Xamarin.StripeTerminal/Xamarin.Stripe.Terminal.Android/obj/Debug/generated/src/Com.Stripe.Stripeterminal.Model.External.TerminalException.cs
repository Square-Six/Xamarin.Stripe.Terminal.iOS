using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal.Model.External {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException']"
	[global::Android.Runtime.Register ("com/stripe/stripeterminal/model/external/TerminalException", DoNotGenerateAcw=true)]
	public sealed partial class TerminalException : global::Java.Lang.Exception {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']"
		[global::Android.Runtime.Register ("com/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode", DoNotGenerateAcw=true)]
		public sealed partial class TerminalErrorCode : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='ALREADY_CONNECTED_TO_READER']"
			[Register ("ALREADY_CONNECTED_TO_READER")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode AlreadyConnectedToReader {
				get {
					const string __id = "ALREADY_CONNECTED_TO_READER.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='BLUETOOTH_DISCONNECTED']"
			[Register ("BLUETOOTH_DISCONNECTED")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode BluetoothDisconnected {
				get {
					const string __id = "BLUETOOTH_DISCONNECTED.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='BLUETOOTH_ERROR']"
			[Register ("BLUETOOTH_ERROR")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode BluetoothError {
				get {
					const string __id = "BLUETOOTH_ERROR.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='BLUETOOTH_LOW_ENERGY_UNSUPPORTED']"
			[Register ("BLUETOOTH_LOW_ENERGY_UNSUPPORTED")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode BluetoothLowEnergyUnsupported {
				get {
					const string __id = "BLUETOOTH_LOW_ENERGY_UNSUPPORTED.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='BLUETOOTH_PERMISSION_DENIED']"
			[Register ("BLUETOOTH_PERMISSION_DENIED")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode BluetoothPermissionDenied {
				get {
					const string __id = "BLUETOOTH_PERMISSION_DENIED.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='BLUETOOTH_SCAN_TIMED_OUT']"
			[Register ("BLUETOOTH_SCAN_TIMED_OUT")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode BluetoothScanTimedOut {
				get {
					const string __id = "BLUETOOTH_SCAN_TIMED_OUT.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='CANCELED']"
			[Register ("CANCELED")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode Canceled {
				get {
					const string __id = "CANCELED.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='CANCEL_FAILED']"
			[Register ("CANCEL_FAILED")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode CancelFailed {
				get {
					const string __id = "CANCEL_FAILED.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='CARD_INSERT_NOT_READ']"
			[Register ("CARD_INSERT_NOT_READ")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode CardInsertNotRead {
				get {
					const string __id = "CARD_INSERT_NOT_READ.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='CARD_READ_TIMED_OUT']"
			[Register ("CARD_READ_TIMED_OUT")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode CardReadTimedOut {
				get {
					const string __id = "CARD_READ_TIMED_OUT.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='CARD_REMOVED']"
			[Register ("CARD_REMOVED")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode CardRemoved {
				get {
					const string __id = "CARD_REMOVED.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='CARD_SWIPE_NOT_READ']"
			[Register ("CARD_SWIPE_NOT_READ")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode CardSwipeNotRead {
				get {
					const string __id = "CARD_SWIPE_NOT_READ.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='CONNECTION_TOKEN_PROVIDER_ERROR']"
			[Register ("CONNECTION_TOKEN_PROVIDER_ERROR")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode ConnectionTokenProviderError {
				get {
					const string __id = "CONNECTION_TOKEN_PROVIDER_ERROR.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='INVALID_CLIENT_SECRET']"
			[Register ("INVALID_CLIENT_SECRET")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode InvalidClientSecret {
				get {
					const string __id = "INVALID_CLIENT_SECRET.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='LOCATION_SERVICES_DISABLED']"
			[Register ("LOCATION_SERVICES_DISABLED")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode LocationServicesDisabled {
				get {
					const string __id = "LOCATION_SERVICES_DISABLED.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='MUST_BE_DISCOVERING_TO_CONNECT']"
			[Register ("MUST_BE_DISCOVERING_TO_CONNECT")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode MustBeDiscoveringToConnect {
				get {
					const string __id = "MUST_BE_DISCOVERING_TO_CONNECT.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='NOT_CONNECTED_TO_READER']"
			[Register ("NOT_CONNECTED_TO_READER")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode NotConnectedToReader {
				get {
					const string __id = "NOT_CONNECTED_TO_READER.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='PAYMENT_DECLINED_BY_READER']"
			[Register ("PAYMENT_DECLINED_BY_READER")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode PaymentDeclinedByReader {
				get {
					const string __id = "PAYMENT_DECLINED_BY_READER.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='PAYMENT_DECLINED_BY_STRIPE_API']"
			[Register ("PAYMENT_DECLINED_BY_STRIPE_API")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode PaymentDeclinedByStripeApi {
				get {
					const string __id = "PAYMENT_DECLINED_BY_STRIPE_API.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='PROCESS_INVALID_PAYMENT_INTENT']"
			[Register ("PROCESS_INVALID_PAYMENT_INTENT")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode ProcessInvalidPaymentIntent {
				get {
					const string __id = "PROCESS_INVALID_PAYMENT_INTENT.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='READER_BUSY']"
			[Register ("READER_BUSY")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode ReaderBusy {
				get {
					const string __id = "READER_BUSY.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='READER_COMMUNICATION_ERROR']"
			[Register ("READER_COMMUNICATION_ERROR")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode ReaderCommunicationError {
				get {
					const string __id = "READER_COMMUNICATION_ERROR.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='READER_SOFTWARE_UPDATE_FAILED']"
			[Register ("READER_SOFTWARE_UPDATE_FAILED")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode ReaderSoftwareUpdateFailed {
				get {
					const string __id = "READER_SOFTWARE_UPDATE_FAILED.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='READER_SOFTWARE_UPDATE_FAILED_BATTERY_LOW']"
			[Register ("READER_SOFTWARE_UPDATE_FAILED_BATTERY_LOW")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode ReaderSoftwareUpdateFailedBatteryLow {
				get {
					const string __id = "READER_SOFTWARE_UPDATE_FAILED_BATTERY_LOW.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='READER_SOFTWARE_UPDATE_FAILED_INTERRUPTED']"
			[Register ("READER_SOFTWARE_UPDATE_FAILED_INTERRUPTED")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode ReaderSoftwareUpdateFailedInterrupted {
				get {
					const string __id = "READER_SOFTWARE_UPDATE_FAILED_INTERRUPTED.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='READER_SOFTWARE_UPDATE_FAILED_READER_ERROR']"
			[Register ("READER_SOFTWARE_UPDATE_FAILED_READER_ERROR")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode ReaderSoftwareUpdateFailedReaderError {
				get {
					const string __id = "READER_SOFTWARE_UPDATE_FAILED_READER_ERROR.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='READER_SOFTWARE_UPDATE_FAILED_SERVER_ERROR']"
			[Register ("READER_SOFTWARE_UPDATE_FAILED_SERVER_ERROR")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode ReaderSoftwareUpdateFailedServerError {
				get {
					const string __id = "READER_SOFTWARE_UPDATE_FAILED_SERVER_ERROR.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='REQUEST_TIMED_OUT']"
			[Register ("REQUEST_TIMED_OUT")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode RequestTimedOut {
				get {
					const string __id = "REQUEST_TIMED_OUT.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='SESSION_EXPIRED']"
			[Register ("SESSION_EXPIRED")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode SessionExpired {
				get {
					const string __id = "SESSION_EXPIRED.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='STRIPE_API_ERROR']"
			[Register ("STRIPE_API_ERROR")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode StripeApiError {
				get {
					const string __id = "STRIPE_API_ERROR.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='STRIPE_API_RESPONSE_DECODING_ERROR']"
			[Register ("STRIPE_API_RESPONSE_DECODING_ERROR")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode StripeApiResponseDecodingError {
				get {
					const string __id = "STRIPE_API_RESPONSE_DECODING_ERROR.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='UNEXPECTED_SDK_ERROR']"
			[Register ("UNEXPECTED_SDK_ERROR")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode UnexpectedSdkError {
				get {
					const string __id = "UNEXPECTED_SDK_ERROR.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='UNSUPPORTED_READER_VERSION']"
			[Register ("UNSUPPORTED_READER_VERSION")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode UnsupportedReaderVersion {
				get {
					const string __id = "UNSUPPORTED_READER_VERSION.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/field[@name='UNSUPPORTED_SDK']"
			[Register ("UNSUPPORTED_SDK")]
			public static global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode UnsupportedSdk {
				get {
					const string __id = "UNSUPPORTED_SDK.Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode", typeof (TerminalErrorCode));
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

			internal TerminalErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;", "")]
			public static unsafe global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException.TerminalErrorCode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;", "")]
			public static unsafe global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode[] Values ()
			{
				const string __id = "values.()[Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/model/external/TerminalException", typeof (TerminalException));
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

		internal TerminalException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException']/constructor[@name='TerminalException' and count(parameter)=2 and parameter[1][@type='com.stripe.stripeterminal.model.external.TerminalException.TerminalErrorCode'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;Ljava/lang/String;)V", "")]
		public unsafe TerminalException (global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		public unsafe global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;", "")]
			get {
				const string __id = "getErrorCode.()Lcom/stripe/stripeterminal/model/external/TerminalException$TerminalErrorCode;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.TerminalException.TerminalErrorCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string ErrorMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException']/method[@name='getErrorMessage' and count(parameter)=0]"
			[Register ("getErrorMessage", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getErrorMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Stripe.Stripeterminal.Model.External.PaymentIntent PaymentIntent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='TerminalException']/method[@name='getPaymentIntent' and count(parameter)=0]"
			[Register ("getPaymentIntent", "()Lcom/stripe/stripeterminal/model/external/PaymentIntent;", "")]
			get {
				const string __id = "getPaymentIntent.()Lcom/stripe/stripeterminal/model/external/PaymentIntent;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentIntent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
