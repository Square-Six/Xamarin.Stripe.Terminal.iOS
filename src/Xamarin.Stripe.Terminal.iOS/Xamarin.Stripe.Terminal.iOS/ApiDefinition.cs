using System;
using System.Collections.Generic;
using Foundation;
using ObjCRuntime;
using StripeTerminal;


/*
 * How to Rename Methods and Parameters
 * 
 * [Export ("animation:valueForProgress:"), DelegateApiName ("ComputeAnimationCurve"), DelegateName ("Func<NSAnimation, float, float>")]
 *  float GetValueForProgress (NSAnimation animation, float progress);
 * 
 * Produces:
 * public Func<NSAnimation, float, float> ComputeAnimationCurve { get; set; }
 * 
 * This wraps the native method and produces a better result
 * 
 * 
 * Reference: https://docs.microsoft.com/en-us/xamarin/cross-platform/macios/binding/binding-types-reference
 * 
 * [BindAs (Type.GetType("IBluetoothReaderDelegate"))]
 * 
 */

namespace StripeTerminal
{
	[Protocol, Model]
	[BaseType(typeof(NSObject), Name = "SCPJSONDecodable")]
	interface JSONDecodable
	{
		// @required +(instancetype _Nullable)decodedObjectFromJSON:(NSDictionary * _Nullable)json;
		[Abstract]
		[Export("decodedObjectFromJSON:")]
		JSONDecodable DecodedObjectFromJSON([NullAllowed] NSDictionary json);

		// @required @property (readonly, nonatomic) NSDictionary * _Nonnull originalJSON;
		[Abstract]
		[Export("originalJSON")]
		NSDictionary OriginalJSON { get; }
	}

	// @interface SCPAddress : NSObject <SCPJSONDecodable>
	[Protocol]
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SCPAddress : JSONDecodable
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable city;
		[NullAllowed, Export("city")]
		string City { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable country;
		[NullAllowed, Export("country")]
		string Country { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable line1;
		[NullAllowed, Export("line1")]
		string Line1 { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable line2;
		[NullAllowed, Export("line2")]
		string Line2 { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable postalCode;
		[NullAllowed, Export("postalCode")]
		string PostalCode { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable state;
		[NullAllowed, Export("state")]
		string State { get; }
	}

	// typedef void (^SCPConnectionTokenCompletionBlock)(NSString * _Nullable, NSError * _Nullable);
	delegate void SCPConnectionTokenCompletionBlock([NullAllowed] string arg0, [NullAllowed] NSError arg1);

	// typedef void (^SCPLogListenerBlock)(NSString * _Nonnull);
	delegate void SCPLogListenerBlock(string arg0);

	// typedef void (^SCPPaymentMethodCompletionBlock)(SCPPaymentMethod * _Nullable, NSError * _Nullable);
	delegate void SCPPaymentMethodCompletionBlock([NullAllowed] PaymentMethod arg0, [NullAllowed] NSError arg1);

	// typedef void (^SCPErrorCompletionBlock)(NSError * _Nullable);
	delegate void SCPErrorCompletionBlock([NullAllowed] NSError arg0);

	// typedef void (^SCPProcessPaymentCompletionBlock)(SCPPaymentIntent * _Nullable, SCPProcessPaymentError * _Nullable);
	delegate void SCPProcessPaymentCompletionBlock([NullAllowed] PaymentIntent arg0, [NullAllowed] ProcessPaymentError arg1);

	// typedef void (^SCPProcessRefundCompletionBlock)(SCPRefund * _Nullable, SCPProcessRefundError * _Nullable);
	delegate void SCPProcessRefundCompletionBlock([NullAllowed] Refund arg0, [NullAllowed] ProcessRefundError arg1);

	// typedef void (^SCPRefundCompletionBlock)(SCPRefund * _Nullable, NSError * _Nullable);
	delegate void SCPRefundCompletionBlock([NullAllowed] Refund arg0, [NullAllowed] NSError arg1);

	// typedef void (^SCPPaymentIntentCompletionBlock)(SCPPaymentIntent * _Nullable, NSError * _Nullable);
	delegate void SCPPaymentIntentCompletionBlock([NullAllowed] PaymentIntent arg0, [NullAllowed] NSError arg1);

	// typedef void (^SCPSetupIntentCompletionBlock)(SCPSetupIntent * _Nullable, NSError * _Nullable);
	delegate void SCPSetupIntentCompletionBlock([NullAllowed] SetupIntent arg0, [NullAllowed] NSError arg1);

	// typedef void (^SCPConfirmSetupIntentCompletionBlock)(SCPSetupIntent * _Nullable, SCPConfirmSetupIntentError * _Nullable);
	delegate void SCPConfirmSetupIntentCompletionBlock([NullAllowed] SetupIntent arg0, [NullAllowed] ConfirmSetupIntentError arg1);

	// typedef void (^SCPLocationsCompletionBlock)(NSArray<SCPLocation *> * _Nullable, BOOL, NSError * _Nullable);
	delegate void SCPLocationsCompletionBlock([NullAllowed] Location[] arg0, bool arg1, [NullAllowed] NSError arg2);

	// typedef void (^SCPReaderCompletionBlock)(SCPReader * _Nullable, NSError * _Nullable);
	delegate void SCPReaderCompletionBlock([NullAllowed] Reader arg0, [NullAllowed] NSError arg1);

	// @interface SCPConnectionConfiguration : NSObject
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPConnectionConfiguration")]
	[DisableDefaultCtor]
	interface ConnectionConfiguration
	{
	}

	// @interface SCPBluetoothConnectionConfiguration : SCPConnectionConfiguration
	[Protocol]
	[BaseType(typeof(ConnectionConfiguration), Name = "SCPBluetoothConnectionConfiguration")]
	interface BluetoothConnectionConfiguration
	{
		// @property (readonly, nonatomic) NSString * _Nonnull locationId;
		[Export("locationId")]
		string LocationId { get; }

		// -(instancetype _Nonnull)initWithLocationId:(NSString * _Nonnull)locationId;
		[Export("initWithLocationId:")]
		IntPtr Constructor(string locationId);
	}

	// @protocol SCPBluetoothReaderDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject), Name = "SCPBluetoothReaderDelegate")]
	interface BluetoothReaderDelegate
	{
		// @required -(void)reader:(SCPReader * _Nonnull)reader didReportAvailableUpdate:(SCPReaderSoftwareUpdate * _Nonnull)update;
		[Abstract]
		[Export("reader:didReportAvailableUpdate:")]
		void OnReportAvailableUpdate(Reader reader, ReaderSoftwareUpdate update);

		// @required -(void)reader:(SCPReader * _Nonnull)reader didStartInstallingUpdate:(SCPReaderSoftwareUpdate * _Nonnull)update cancelable:(SCPCancelable * _Nullable)cancelable;
		[Abstract]
		[Export("reader:didStartInstallingUpdate:cancelable:")]
		void OnStartInstallingUpdate(Reader reader, ReaderSoftwareUpdate update, [NullAllowed] Cancelable cancelable);

		// @required -(void)reader:(SCPReader * _Nonnull)reader didReportReaderSoftwareUpdateProgress:(float)progress __attribute__((swift_name("reader(_:didReportReaderSoftwareUpdateProgress:)")));
		[Abstract]
		[Export("reader:didReportReaderSoftwareUpdateProgress:")]
		void OnReportReaderSoftwareUpdateProgress(Reader reader, float progress);

		// @required -(void)reader:(SCPReader * _Nonnull)reader didFinishInstallingUpdate:(SCPReaderSoftwareUpdate * _Nullable)update error:(NSError * _Nullable)error __attribute__((swift_name("reader(_:didFinishInstallingUpdate:error:)")));
		[Abstract]
		[Export("reader:didFinishInstallingUpdate:error:")]
		void OnFinishInstallingUpdate(Reader reader, [NullAllowed] ReaderSoftwareUpdate update, [NullAllowed] NSError error);

		// @required -(void)reader:(SCPReader * _Nonnull)reader didRequestReaderInput:(SCPReaderInputOptions)inputOptions __attribute__((swift_name("reader(_:didRequestReaderInput:)")));
		[Abstract]
		[Export("reader:didRequestReaderInput:")]
		void OnRequestReaderInput(Reader reader, SCPReaderInputOptions inputOptions);

		// @required -(void)reader:(SCPReader * _Nonnull)reader didRequestReaderDisplayMessage:(SCPReaderDisplayMessage)displayMessage __attribute__((swift_name("reader(_:didRequestReaderDisplayMessage:)")));
		[Abstract]
		[Export("reader:didRequestReaderDisplayMessage:")]
		void OnRequestReaderDisplayMessage(Reader reader, SCPReaderDisplayMessage displayMessage);

		// @optional -(void)reader:(SCPReader * _Nonnull)reader didReportReaderEvent:(SCPReaderEvent)event info:(NSDictionary * _Nullable)info __attribute__((swift_name("reader(_:didReportReaderEvent:info:)")));
		[Abstract]
		[Export("reader:didReportReaderEvent:info:")]
		void OnReportReaderEvent(Reader reader, SCPReaderEvent @event, [NullAllowed] NSDictionary info);

		// @optional -(void)reader:(SCPReader * _Nonnull)reader didReportBatteryLevel:(float)batteryLevel status:(SCPBatteryStatus)status isCharging:(BOOL)isCharging __attribute__((swift_name("reader(_:didReportBatteryLevel:status:isCharging:)")));
		[Abstract]
		[Export("reader:didReportBatteryLevel:status:isCharging:")]
		void OnReportBatteryLevel(Reader reader, float batteryLevel, SCPBatteryStatus status, bool isCharging);

		// @optional -(void)readerDidReportLowBatteryWarning:(SCPReader * _Nonnull)reader __attribute__((swift_name("readerDidReportLowBatteryWarning(_:)")));
		[Abstract]
		[Export("readerDidReportLowBatteryWarning:")]
		void OnReportLowBatteryWarning(Reader reader);
	}

	// @interface SCPCancelable : NSObject
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPCancelable")]
	interface Cancelable
	{
		// @property (readonly, nonatomic) BOOL completed;
		[Export("completed")]
		bool Completed { get; }

		// -(void)cancel:(SCPErrorCompletionBlock _Nonnull)completion;
		[Export("cancel:")]
		void Cancel(SCPErrorCompletionBlock completion);
	}

	// @interface SCPCardDetails : NSObject <SCPJSONDecodable>
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPCardDetails")]
	[DisableDefaultCtor]
	interface CardDetails : JSONDecodable
	{
		// @property (readonly, nonatomic) SCPCardBrand brand;
		[Export("brand")]
		SCPCardBrand Brand { get; }

		// @property (readonly, nonatomic) NSString * _Nullable country;
		[NullAllowed, Export("country")]
		string Country { get; }

		// @property (readonly, nonatomic) NSInteger expMonth;
		[Export("expMonth")]
		nint ExpMonth { get; }

		// @property (readonly, nonatomic) NSInteger expYear;
		[Export("expYear")]
		nint ExpYear { get; }

		// @property (readonly, nonatomic) SCPCardFundingType funding;
		[Export("funding")]
		SCPCardFundingType Funding { get; }

		// @property (readonly, nonatomic) NSString * _Nullable last4;
		[NullAllowed, Export("last4")]
		string Last4 { get; }

		// @property (readonly, nonatomic) NSString * _Nullable fingerprint;
		[NullAllowed, Export("fingerprint")]
		string Fingerprint { get; }
	}

	// @interface SCPCardPresentDetails : NSObject <SCPJSONDecodable>
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPCardPresentDetails")]
	[DisableDefaultCtor]
	interface CardPresentDetails : JSONDecodable
	{
		// @property (readonly, nonatomic) NSString * _Nonnull last4;
		[Export("last4")]
		string Last4 { get; }

		// @property (readonly, nonatomic) NSInteger expMonth;
		[Export("expMonth")]
		nint ExpMonth { get; }

		// @property (readonly, nonatomic) NSInteger expYear;
		[Export("expYear")]
		nint ExpYear { get; }

		// @property (readonly, nonatomic) NSString * _Nullable cardholderName;
		[NullAllowed, Export("cardholderName")]
		string CardholderName { get; }

		// @property (readonly, nonatomic) SCPCardFundingType funding;
		[Export("funding")]
		SCPCardFundingType Funding { get; }

		// @property (readonly, nonatomic) SCPCardBrand brand;
		[Export("brand")]
		SCPCardBrand Brand { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull fingerprint;
		[Export("fingerprint")]
		string Fingerprint { get; }

		// @property (readonly, nonatomic) NSString * _Nullable generatedCard;
		[NullAllowed, Export("generatedCard")]
		string GeneratedCard { get; }

		// @property (readonly, nonatomic) SCPReceiptDetails * _Nullable receipt;
		[NullAllowed, Export("receipt")]
		ReceiptDetails Receipt { get; }

		// @property (readonly, nonatomic) NSString * _Nullable emvAuthData;
		[NullAllowed, Export("emvAuthData")]
		string EmvAuthData { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable country;
		[NullAllowed, Export("country")]
		string Country { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable preferredLocales;
		[NullAllowed, Export("preferredLocales", ArgumentSemantic.Copy)]
		string[] PreferredLocales { get; }
	}

	// @interface SCPCartLineItem : NSObject
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPCartLineItem")]
	interface CartLineItem : INativeObject
	{
		// @property (assign, readwrite, nonatomic) NSInteger quantity;
		[Export("quantity")]
		nint Quantity { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull displayName;
		[Export("displayName")]
		string DisplayName { get; set; }

		// @property (assign, readwrite, nonatomic) NSInteger amount;
		[Export("amount")]
		nint Amount { get; set; }

		// -(instancetype _Nonnull)initWithDisplayName:(NSString * _Nonnull)displayName quantity:(NSInteger)quantity amount:(NSInteger)amount;
		[Export("initWithDisplayName:quantity:amount:")]
		IntPtr Constructor(string displayName, nint quantity, nint amount);
	}

	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPCart")]
	[DisableDefaultCtor]
	interface Cart
	{
		// @property (readwrite, nonatomic, strong) NSMutableArray<SCPCartLineItem *> * _Nonnull lineItems;
		[Export("lineItems", ArgumentSemantic.Strong)]
		NSMutableArray<CartLineItem> LineItems { get; set; }

		// @property (assign, readwrite, nonatomic) NSInteger tax;
		[Export("tax")]
		nint Tax { get; set; }

		// @property (assign, readwrite, nonatomic) NSInteger total;
		[Export("total")]
		nint Total { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull currency;
		[Export("currency")]
		string Currency { get; set; }

		// -(instancetype _Nonnull)initWithCurrency:(NSString * _Nonnull)currency tax:(NSInteger)tax total:(NSInteger)total;
		[Export("initWithCurrency:tax:total:")]
		IntPtr Constructor(string currency, nint tax, nint total);
	}



	// @interface SCPCharge : NSObject <SCPJSONDecodable>
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPCharge")]
	[DisableDefaultCtor]
	interface Charge : JSONDecodable
	{
		// @property (readonly, nonatomic) NSUInteger amount;
		[Export("amount")]
		nuint Amount { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull currency;
		[Export("currency")]
		string Currency { get; }

		// @property (readonly, nonatomic) SCPChargeStatus status;
		[Export("status")]
		SCPChargeStatus Status { get; }

		// @property (readonly, nonatomic) SCPPaymentMethodDetails * _Nullable paymentMethodDetails;
		[NullAllowed, Export("paymentMethodDetails")]
		PaymentMethodDetails PaymentMethodDetails { get; }

		// @property (readonly, nonatomic) NSString * _Nullable stripeDescription;
		[NullAllowed, Export("stripeDescription")]
		string StripeDescription { get; }

		// @property (readonly, nonatomic) NSDictionary * _Nonnull metadata;
		[Export("metadata")]
		NSDictionary Metadata { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull stripeId;
		[Export("stripeId")]
		string StripeId { get; }
	}

	// @interface SCPCollectConfiguration : NSObject
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPCollectConfiguration")]
	[DisableDefaultCtor]
	interface CollectConfiguration
	{
		// @property (assign, nonatomic) BOOL skipTipping;
		[Export("skipTipping")]
		bool SkipTipping { get; set; }

		// -(instancetype _Nonnull)initWithSkipTipping:(BOOL)skipTipping;
		[Export("initWithSkipTipping:")]
		IntPtr Constructor(bool skipTipping);
	}

	//[Static]
	//partial interface Constants
	//{
	//	// extern NSString *const _Nonnull SCPErrorDomain __attribute__((swift_name("ErrorDomain")));
	//	[Field("SCPErrorDomain", "__Internal")]
	//	NSString SCPErrorDomain { get; }

	//	// extern SCPErrorKey _Nonnull SCPErrorKeyMessage;
	//	[Field("SCPErrorKeyMessage", "__Internal")]
	//	NSString SCPErrorKeyMessage { get; }

	//	// extern SCPErrorKey _Nonnull SCPErrorKeyStripeAPIDeclineCode;
	//	[Field("SCPErrorKeyStripeAPIDeclineCode", "__Internal")]
	//	NSString SCPErrorKeyStripeAPIDeclineCode { get; }

	//	// extern SCPErrorKey _Nonnull SCPErrorKeyStripeAPIFailureReason;
	//	[Field("SCPErrorKeyStripeAPIFailureReason", "__Internal")]
	//	NSString SCPErrorKeyStripeAPIFailureReason { get; }

	//	// extern SCPErrorKey _Nonnull SCPErrorKeyStripeAPIRequestId;
	//	[Field("SCPErrorKeyStripeAPIRequestId", "__Internal")]
	//	NSString SCPErrorKeyStripeAPIRequestId { get; }

	//	// extern SCPErrorKey _Nonnull SCPErrorKeyStripeAPIErrorCode;
	//	[Field("SCPErrorKeyStripeAPIErrorCode", "__Internal")]
	//	NSString SCPErrorKeyStripeAPIErrorCode { get; }

	//	// extern SCPErrorKey _Nonnull SCPErrorKeyStripeAPIErrorType;
	//	[Field("SCPErrorKeyStripeAPIErrorType", "__Internal")]
	//	NSString SCPErrorKeyStripeAPIErrorType { get; }

	//	// extern SCPErrorKey _Nonnull SCPErrorKeyStripeAPIDocUrl;
	//	[Field("SCPErrorKeyStripeAPIDocUrl", "__Internal")]
	//	NSString SCPErrorKeyStripeAPIDocUrl { get; }

	//	// extern SCPErrorKey _Nonnull SCPErrorKeyStripeAPIErrorParameter;
	//	[Field("SCPErrorKeyStripeAPIErrorParameter", "__Internal")]
	//	NSString SCPErrorKeyStripeAPIErrorParameter { get; }

	//	// extern SCPErrorKey _Nonnull SCPErrorKeyHttpStatusCode;
	//	[Field("SCPErrorKeyHttpStatusCode", "__Internal")]
	//	NSString SCPErrorKeyHttpStatusCode { get; }

	//	// extern SCPErrorKey _Nonnull SCPErrorKeyStripeAPIPaymentIntent;
	//	[Field("SCPErrorKeyStripeAPIPaymentIntent", "__Internal")]
	//	NSString SCPErrorKeyStripeAPIPaymentIntent { get; }

	//	// extern SCPErrorKey _Nonnull SCPErrorKeyReaderMessage;
	//	[Field("SCPErrorKeyReaderMessage", "__Internal")]
	//	NSString SCPErrorKeyReaderMessage { get; }
	//}

	// @interface SCPConfirmSetupIntentError : NSError
	[Protocol]
	[BaseType(typeof(NSError), Name = "SCPConfirmSetupIntentError")]
	[DisableDefaultCtor]
	interface ConfirmSetupIntentError
	{
		// @property (readonly, nonatomic) SCPSetupIntent * _Nullable setupIntent;
		[NullAllowed, Export("setupIntent")]
		SetupIntent SetupIntent { get; }

		// @property (readonly, nonatomic) NSError * _Nullable requestError;
		[NullAllowed, Export("requestError")]
		NSError RequestError { get; }

		// @property (readonly, nonatomic) NSString * _Nullable declineCode;
		[NullAllowed, Export("declineCode")]
		string DeclineCode { get; }
	}

	// @protocol SCPConnectionTokenProvider
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	[Protocol, Model]
	[BaseType(typeof(NSObject), Name = "SCPConnectionTokenProvider")]
	interface ConnectionTokenProvider
	{
		// @required -(void)fetchConnectionToken:(SCPConnectionTokenCompletionBlock _Nonnull)completion __attribute__((swift_name("fetchConnectionToken(_:)")));
		[Abstract]
		[Export("fetchConnectionToken:")]
		void FetchConnectionToken(SCPConnectionTokenCompletionBlock completion);
	}

	// @interface SCPDiscoveryConfiguration : NSObject
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPDiscoveryConfiguration")]
	[DisableDefaultCtor]
	interface DiscoveryConfiguration
	{
		// -(instancetype _Nonnull)initWithDiscoveryMethod:(SCPDiscoveryMethod)discoveryMethod simulated:(BOOL)simulated;
		[Export("initWithDiscoveryMethod:simulated:")]
		IntPtr Constructor(SCPDiscoveryMethod discoveryMethod, bool simulated);

		// -(instancetype _Nonnull)initWithDiscoveryMethod:(SCPDiscoveryMethod)discoveryMethod locationId:(NSString * _Nullable)locationId simulated:(BOOL)simulated;
		[Export("initWithDiscoveryMethod:locationId:simulated:")]
		IntPtr Constructor(SCPDiscoveryMethod discoveryMethod, [NullAllowed] string locationId, bool simulated);

		// @property (assign, readwrite, nonatomic) NSUInteger timeout;
		[Export("timeout")]
		nuint Timeout { get; set; }

		// @property (readonly, nonatomic) SCPDiscoveryMethod discoveryMethod;
		[Export("discoveryMethod")]
		SCPDiscoveryMethod DiscoveryMethod { get; }

		// @property (readonly, nonatomic) BOOL simulated;
		[Export("simulated")]
		bool Simulated { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable locationId;
		[NullAllowed, Export("locationId")]
		string LocationId { get; }
	}

	// @interface SCPPaymentIntent : NSObject <SCPJSONDecodable, NSCopying>
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPPaymentIntent")]
	[DisableDefaultCtor]
	interface PaymentIntent : JSONDecodable, INSCopying
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull stripeId;
		[Export("stripeId")]
		string StripeId { get; }

		// @property (readonly, nonatomic) NSDate * _Nonnull created;
		[Export("created")]
		NSDate Created { get; }

		// @property (readonly, nonatomic) SCPPaymentIntentStatus status;
		[Export("status")]
		SCPPaymentIntentStatus Status { get; }

		// @property (readonly, nonatomic) NSUInteger amount;
		[Export("amount")]
		nuint Amount { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull currency;
		[Export("currency")]
		string Currency { get; }

		// @property (readonly, nonatomic) NSDictionary * _Nullable metadata;
		[NullAllowed, Export("metadata")]
		NSDictionary Metadata { get; }

		// @property (readonly, nonatomic) NSArray<SCPCharge *> * _Nonnull charges;
		[Export("charges")]
		Charge[] Charges { get; }
	}

	// @interface SCPRefundParameters : NSObject
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPRefundParameters")]
	[DisableDefaultCtor]
	interface RefundParameters
	{
		// @property (readonly, nonatomic) NSString * _Nullable chargeId;
		[NullAllowed, Export("chargeId")]
		string ChargeId { get; }

		// @property (readonly, nonatomic) NSUInteger amount;
		[Export("amount")]
		nuint Amount { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull currency;
		[Export("currency")]
		string Currency { get; }

		// @property (readwrite, copy, nonatomic) NSDictionary * _Nullable metadata;
		[NullAllowed, Export("metadata", ArgumentSemantic.Copy)]
		NSDictionary Metadata { get; set; }

		// @property (readwrite, nonatomic) NSNumber * _Nullable reverseTransfer;
		[NullAllowed, Export("reverseTransfer", ArgumentSemantic.Assign)]
		NSNumber ReverseTransfer { get; set; }

		// @property (readwrite, nonatomic) NSNumber * _Nullable refundApplicationFee;
		[NullAllowed, Export("refundApplicationFee", ArgumentSemantic.Assign)]
		NSNumber RefundApplicationFee { get; set; }

		// -(instancetype _Nonnull)initWithChargeId:(NSString * _Nonnull)chargeId amount:(NSUInteger)amount currency:(NSString * _Nonnull)currency;
		[Export("initWithChargeId:amount:currency:")]
		IntPtr Constructor(string chargeId, nuint amount, string currency);
	}

	// @interface SCPSimulatedCard : NSObject
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPSimulatedCard")]
	[DisableDefaultCtor]
	interface SimulatedCard
	{
		// -(instancetype _Nonnull)initWithType:(SCPSimulatedCardType)type;
		[Export("initWithType:")]
		IntPtr Constructor(SCPSimulatedCardType type);

		// -(instancetype _Nonnull)initWithTestCardNumber:(NSString * _Nonnull)testCardNumber;
		[Export("initWithTestCardNumber:")]
		IntPtr Constructor(string testCardNumber);

		// -(BOOL)isOnlinePin;
		[Export("isOnlinePin")]
		bool IsOnlinePin { get; }

		// -(BOOL)isOfflinePin;
		[Export("isOfflinePin")]
		bool IsOfflinePin { get; }
	}

	// @interface SCPSimulatorConfiguration : NSObject
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPSimulatorConfiguration")]
	[DisableDefaultCtor]
	interface SimulatorConfiguration
	{
		// @property (assign, nonatomic) SCPSimulateReaderUpdate availableReaderUpdate;
		[Export("availableReaderUpdate", ArgumentSemantic.Assign)]
		SCPSimulateReaderUpdate AvailableReaderUpdate { get; set; }

		// @property (readwrite, nonatomic) SCPSimulatedCard * _Nonnull simulatedCard;
		[Export("simulatedCard", ArgumentSemantic.Assign)]
		SimulatedCard SimulatedCard { get; set; }
	}

	// @interface SCPTerminal : NSObject
	[iOS(10, 0)]
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPTerminal")]
	[DisableDefaultCtor]
	interface Terminal
	{
		// +(void)setTokenProvider:(id<SCPConnectionTokenProvider> _Nonnull)tokenProvider __attribute__((swift_name("setTokenProvider(_:)")));
		[Static]
		[Export("setTokenProvider:")]
		void SetTokenProvider(ConnectionTokenProvider tokenProvider);

		// +(BOOL)hasTokenProvider;
		[Static]
		[Export("hasTokenProvider")]
		bool HasTokenProvider { get; }

		// +(void)setLogListener:(SCPLogListenerBlock _Nonnull)listener;
		[Static]
		[Export("setLogListener:")]
		void SetLogListener(SCPLogListenerBlock listener);

		// @property (readonly, nonatomic, class) SCPTerminal * _Nonnull shared;
		[Static]
		[Export("shared")]
		Terminal Shared { get; }

		[Wrap("WeakDelegate")]
		[NullAllowed]
		TerminalDelegate Delegate { get; set; }

		// @property (readwrite, nonatomic) id<SCPTerminalDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic) SCPReader * _Nullable connectedReader;
		[NullAllowed, Export("connectedReader")]
		Reader ConnectedReader { get; }

		// @property (readonly, nonatomic) SCPConnectionStatus connectionStatus;
		[Export("connectionStatus")]
		SCPConnectionStatus ConnectionStatus { get; }

		// @property (assign, readwrite, nonatomic) SCPLogLevel logLevel;
		[Export("logLevel", ArgumentSemantic.Assign)]
		SCPLogLevel LogLevel { get; set; }

		// @property (readonly, nonatomic) SCPSimulatorConfiguration * _Nonnull simulatorConfiguration;
		[Export("simulatorConfiguration")]
		SimulatorConfiguration SimulatorConfiguration { get; }

		// @property (readonly, nonatomic) SCPPaymentStatus paymentStatus;
		[Export("paymentStatus")]
		SCPPaymentStatus PaymentStatus { get; }

		// -(void)clearCachedCredentials __attribute__((swift_name("clearCachedCredentials()")));
		[Export("clearCachedCredentials")]
		void ClearCachedCredentials();

		// -(SCPCancelable * _Nullable)discoverReaders:(SCPDiscoveryConfiguration * _Nonnull)configuration delegate:(id<SCPDiscoveryDelegate> _Nonnull)delegate completion:(SCPErrorCompletionBlock _Nonnull)completion __attribute__((swift_name("discoverReaders(_:delegate:completion:)")));
		[Export("discoverReaders:delegate:completion:")]
		[return: NullAllowed]
		Cancelable DiscoverReaders(DiscoveryConfiguration configuration, DiscoveryDelegate @delegate, SCPErrorCompletionBlock completion);

		// -(void)connectBluetoothReader:(SCPReader * _Nonnull)reader delegate:(id<SCPBluetoothReaderDelegate> _Nonnull)delegate connectionConfig:(SCPBluetoothConnectionConfiguration * _Nonnull)connectionConfig completion:(SCPReaderCompletionBlock _Nonnull)completion __attribute__((swift_name("connectBluetoothReader(_:delegate:connectionConfig:completion:)")));
		[Export("connectBluetoothReader:delegate:connectionConfig:completion:")]
		void ConnectBluetoothReader(Reader reader, BluetoothReaderDelegate @delegate, BluetoothConnectionConfiguration connectionConfig, SCPReaderCompletionBlock completion);

		// -(void)connectInternetReader:(SCPReader * _Nonnull)reader connectionConfig:(SCPInternetConnectionConfiguration * _Nullable)connectionConfig completion:(SCPReaderCompletionBlock _Nonnull)completion __attribute__((swift_name("connectInternetReader(_:connectionConfig:completion:)")));
		[Export("connectInternetReader:connectionConfig:completion:")]
		void ConnectInternetReader(Reader reader, [NullAllowed] InternetConnectionConfiguration connectionConfig, SCPReaderCompletionBlock completion);

		// -(void)listLocations:(SCPListLocationsParameters * _Nullable)parameters completion:(SCPLocationsCompletionBlock _Nonnull)completion __attribute__((swift_name("listLocations(parameters:completion:)")));
		[Export("listLocations:completion:")]
		void ListLocations([NullAllowed] ListLocationsParameters parameters, SCPLocationsCompletionBlock completion);

		// -(void)installAvailableUpdate;
		[Export("installAvailableUpdate")]
		void InstallAvailableUpdate();

		// -(void)disconnectReader:(SCPErrorCompletionBlock _Nonnull)completion __attribute__((swift_name("disconnectReader(_:)")));
		[Export("disconnectReader:")]
		void DisconnectReader(SCPErrorCompletionBlock completion);

		// -(void)createPaymentIntent:(SCPPaymentIntentParameters * _Nonnull)parameters completion:(SCPPaymentIntentCompletionBlock _Nonnull)completion __attribute__((swift_name("createPaymentIntent(_:completion:)")));
		[Export("createPaymentIntent:completion:")]
		void CreatePaymentIntent(PaymentIntentParameters parameters, SCPPaymentIntentCompletionBlock completion);

		// -(void)retrievePaymentIntent:(NSString * _Nonnull)clientSecret completion:(SCPPaymentIntentCompletionBlock _Nonnull)completion __attribute__((swift_name("retrievePaymentIntent(clientSecret:completion:)")));
		[Export("retrievePaymentIntent:completion:")]
		void RetrievePaymentIntent(string clientSecret, SCPPaymentIntentCompletionBlock completion);

		// -(SCPCancelable * _Nullable)collectPaymentMethod:(SCPPaymentIntent * _Nonnull)paymentIntent completion:(SCPPaymentIntentCompletionBlock _Nonnull)completion __attribute__((swift_name("collectPaymentMethod(_:completion:)")));
		[Export("collectPaymentMethod:completion:")]
		[return: NullAllowed]
		Cancelable CollectPaymentMethod(PaymentIntent paymentIntent, SCPPaymentIntentCompletionBlock completion);

		// -(SCPCancelable * _Nullable)collectPaymentMethod:(SCPPaymentIntent * _Nonnull)paymentIntent collectConfig:(SCPCollectConfiguration * _Nullable)collectConfig completion:(SCPPaymentIntentCompletionBlock _Nonnull)completion;
		[Export("collectPaymentMethod:collectConfig:completion:")]
		[return: NullAllowed]
		Cancelable CollectPaymentMethod(PaymentIntent paymentIntent, [NullAllowed] CollectConfiguration collectConfig, SCPPaymentIntentCompletionBlock completion);

		// -(void)processPayment:(SCPPaymentIntent * _Nonnull)paymentIntent completion:(SCPProcessPaymentCompletionBlock _Nonnull)completion __attribute__((swift_name("processPayment(_:completion:)")));
		[Export("processPayment:completion:")]
		void ProcessPayment(PaymentIntent paymentIntent, SCPProcessPaymentCompletionBlock completion);

		// -(void)cancelPaymentIntent:(SCPPaymentIntent * _Nonnull)paymentIntent completion:(SCPPaymentIntentCompletionBlock _Nonnull)completion __attribute__((swift_name("cancelPaymentIntent(_:completion:)")));
		[Export("cancelPaymentIntent:completion:")]
		void CancelPaymentIntent(PaymentIntent paymentIntent, SCPPaymentIntentCompletionBlock completion);

		// -(SCPCancelable * _Nullable)readReusableCard:(SCPReadReusableCardParameters * _Nonnull)parameters completion:(SCPPaymentMethodCompletionBlock _Nonnull)completion __attribute__((swift_name("readReusableCard(_:completion:)")));
		[Export("readReusableCard:completion:")]
		[return: NullAllowed]
		Cancelable ReadReusableCard(ReadReusableCardParameters parameters, SCPPaymentMethodCompletionBlock completion);

		// -(void)createSetupIntent:(SCPSetupIntentParameters * _Nonnull)setupIntentParams completion:(SCPSetupIntentCompletionBlock _Nonnull)completion __attribute__((swift_name("createSetupIntent(_:completion:)")));
		[Export("createSetupIntent:completion:")]
		void CreateSetupIntent(SetupIntentParameters setupIntentParams, SCPSetupIntentCompletionBlock completion);

		// -(void)retrieveSetupIntent:(NSString * _Nonnull)clientSecret completion:(SCPSetupIntentCompletionBlock _Nonnull)completion __attribute__((swift_name("retrieveSetupIntent(clientSecret:completion:)")));
		[Export("retrieveSetupIntent:completion:")]
		void RetrieveSetupIntent(string clientSecret, SCPSetupIntentCompletionBlock completion);

		// -(void)cancelSetupIntent:(SCPSetupIntent * _Nonnull)intent completion:(SCPSetupIntentCompletionBlock _Nonnull)completion __attribute__((swift_name("cancelSetupIntent(_:completion:)")));
		[Export("cancelSetupIntent:completion:")]
		void CancelSetupIntent(SetupIntent intent, SCPSetupIntentCompletionBlock completion);

		// -(SCPCancelable * _Nullable)collectSetupIntentPaymentMethod:(SCPSetupIntent * _Nonnull)setupIntent customerConsentCollected:(BOOL)customerConsentCollected completion:(SCPSetupIntentCompletionBlock _Nonnull)completion __attribute__((swift_name("collectSetupIntentPaymentMethod(_:customerConsentCollected:completion:)")));
		[Export("collectSetupIntentPaymentMethod:customerConsentCollected:completion:")]
		[return: NullAllowed]
		Cancelable CollectSetupIntentPaymentMethod(SetupIntent setupIntent, bool customerConsentCollected, SCPSetupIntentCompletionBlock completion);

		// -(void)confirmSetupIntent:(SCPSetupIntent * _Nonnull)setupIntent completion:(SCPConfirmSetupIntentCompletionBlock _Nonnull)completion __attribute__((swift_name("confirmSetupIntent(_:completion:)")));
		[Export("confirmSetupIntent:completion:")]
		void ConfirmSetupIntent(SetupIntent setupIntent, SCPConfirmSetupIntentCompletionBlock completion);

		// -(SCPCancelable * _Nullable)collectRefundPaymentMethod:(SCPRefundParameters * _Nonnull)refundParams completion:(SCPErrorCompletionBlock _Nonnull)completion __attribute__((swift_name("collectRefundPaymentMethod(_:completion:)")));
		[Export("collectRefundPaymentMethod:completion:")]
		[return: NullAllowed]
		Cancelable CollectRefundPaymentMethod(RefundParameters refundParams, SCPErrorCompletionBlock completion);

		// -(void)processRefund:(SCPProcessRefundCompletionBlock _Nonnull)completion __attribute__((swift_name("processRefund(completion:)")));
		[Export("processRefund:")]
		void ProcessRefund(SCPProcessRefundCompletionBlock completion);

		// -(void)clearReaderDisplay:(SCPErrorCompletionBlock _Nonnull)completion __attribute__((swift_name("clearReaderDisplay(_:)")));
		[Export("clearReaderDisplay:")]
		void ClearReaderDisplay(SCPErrorCompletionBlock completion);

		// -(void)setReaderDisplay:(SCPCart * _Nonnull)cart completion:(SCPErrorCompletionBlock _Nonnull)completion __attribute__((swift_name("setReaderDisplay(_:completion:)")));
		[Export("setReaderDisplay:completion:")]
		void SetReaderDisplay(Cart cart, SCPErrorCompletionBlock completion);

		// +(NSString * _Nonnull)stringFromReaderInputOptions:(SCPReaderInputOptions)options __attribute__((swift_name("stringFromReaderInputOptions(_:)")));
		[Static]
		[Export("stringFromReaderInputOptions:")]
		string StringFromReaderInputOptions(SCPReaderInputOptions options);

		// +(NSString * _Nonnull)stringFromReaderDisplayMessage:(SCPReaderDisplayMessage)message __attribute__((swift_name("stringFromReaderDisplayMessage(_:)")));
		[Static]
		[Export("stringFromReaderDisplayMessage:")]
		string StringFromReaderDisplayMessage(SCPReaderDisplayMessage message);

		// +(NSString * _Nonnull)stringFromReaderEvent:(SCPReaderEvent)event __attribute__((swift_name("stringFromReaderEvent(_:)")));
		[Static]
		[Export("stringFromReaderEvent:")]
		string StringFromReaderEvent(SCPReaderEvent @event);

		// +(NSString * _Nonnull)stringFromConnectionStatus:(SCPConnectionStatus)status __attribute__((swift_name("stringFromConnectionStatus(_:)")));
		[Static]
		[Export("stringFromConnectionStatus:")]
		string StringFromConnectionStatus(SCPConnectionStatus status);

		// +(NSString * _Nonnull)stringFromPaymentStatus:(SCPPaymentStatus)status __attribute__((swift_name("stringFromPaymentStatus(_:)")));
		[Static]
		[Export("stringFromPaymentStatus:")]
		string StringFromPaymentStatus(SCPPaymentStatus status);

		// +(NSString * _Nonnull)stringFromDeviceType:(SCPDeviceType)deviceType __attribute__((swift_name("stringFromDeviceType(_:)")));
		[Static]
		[Export("stringFromDeviceType:")]
		string StringFromDeviceType(SCPDeviceType deviceType);

		// +(NSString * _Nonnull)stringFromDiscoveryMethod:(SCPDiscoveryMethod)method __attribute__((swift_name("stringFromDiscoveryMethod(_:)")));
		[Static]
		[Export("stringFromDiscoveryMethod:")]
		string StringFromDiscoveryMethod(SCPDiscoveryMethod method);

		// +(NSString * _Nonnull)stringFromCardBrand:(SCPCardBrand)cardBrand __attribute__((swift_name("stringFromCardBrand(_:)")));
		[Static]
		[Export("stringFromCardBrand:")]
		string StringFromCardBrand(SCPCardBrand cardBrand);

		// +(NSString * _Nonnull)stringFromPaymentIntentStatus:(SCPPaymentIntentStatus)paymentIntentStatus __attribute__((swift_name("stringFromPaymentIntentStatus(_:)")));
		[Static]
		[Export("stringFromPaymentIntentStatus:")]
		string StringFromPaymentIntentStatus(SCPPaymentIntentStatus paymentIntentStatus);
	}

	// @protocol SCPDiscoveryDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject), Name = "SCPDiscoveryDelegate")]
	interface DiscoveryDelegate
	{
		// @required -(void)terminal:(SCPTerminal * _Nonnull)terminal didUpdateDiscoveredReaders:(NSArray<SCPReader *> * _Nonnull)readers __attribute__((swift_name("terminal(_:didUpdateDiscoveredReaders:)")));
		[Abstract]
		[Export("terminal:didUpdateDiscoveredReaders:")]
		void OnUpdateDiscoveredReaders(Terminal terminal, Reader[] readers);
	}

	// @interface SCPInternetConnectionConfiguration : SCPConnectionConfiguration
	[Protocol]
	[BaseType(typeof(ConnectionConfiguration), Name = "SCPInternetConnectionConfiguration")]
	interface InternetConnectionConfiguration
	{
		// @property (readonly, nonatomic) BOOL failIfInUse;
		[Export("failIfInUse")]
		bool FailIfInUse { get; }

		// @property (readonly, nonatomic) BOOL allowCustomerCancel;
		[Export("allowCustomerCancel")]
		bool AllowCustomerCancel { get; }

		// -(instancetype _Nonnull)initWithFailIfInUse:(BOOL)failIfInUse allowCustomerCancel:(BOOL)allowCustomerCancel;
		[Export("initWithFailIfInUse:allowCustomerCancel:")]
		IntPtr Constructor(bool failIfInUse, bool allowCustomerCancel);

		// -(instancetype _Nonnull)initWithFailIfInUse:(BOOL)failIfInUse;
		[Export("initWithFailIfInUse:")]
		IntPtr Constructor(bool failIfInUse);

		// -(instancetype _Nonnull)initWithAllowCustomerCancel:(BOOL)allowCustomerCancel;
		[Export("initWithAllowCustomerCancel:")]
		IntPtr ConstructorWithCancel(bool allowCustomerCancel);
	}

	// @interface SCPListLocationsParameters : NSObject
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPListLocationsParameters")]
	interface ListLocationsParameters
	{
		// @property (readwrite, nonatomic) NSNumber * _Nullable limit;
		[NullAllowed, Export("limit", ArgumentSemantic.Assign)]
		NSNumber Limit { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * _Nullable endingBefore;
		[NullAllowed, Export("endingBefore")]
		string EndingBefore { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * _Nullable startingAfter;
		[NullAllowed, Export("startingAfter")]
		string StartingAfter { get; set; }

		// -(instancetype _Nonnull)initWithLimit:(NSNumber * _Nullable)limit endingBefore:(NSString * _Nullable)endingBefore startingAfter:(NSString * _Nullable)startingAfter;
		[Export("initWithLimit:endingBefore:startingAfter:")]
		IntPtr Constructor([NullAllowed] NSNumber limit, [NullAllowed] string endingBefore, [NullAllowed] string startingAfter);
	}

	// @interface SCPLocation : NSObject <SCPJSONDecodable>
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPLocation")]
	[DisableDefaultCtor]
	interface Location : JSONDecodable
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull stripeId;
		[Export("stripeId")]
		string StripeId { get; }

		// @property (readonly, nonatomic, strong) SCPAddress * _Nullable address;
		[NullAllowed, Export("address", ArgumentSemantic.Strong)]
		SCPAddress Address { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable displayName;
		[NullAllowed, Export("displayName")]
		string DisplayName { get; }

		// @property (readonly, assign, nonatomic) BOOL livemode;
		[Export("livemode")]
		bool Livemode { get; }

		// @property (readonly, nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable metadata;
		[NullAllowed, Export("metadata", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> Metadata { get; }
	}

	// @interface SCPPaymentIntentParameters : NSObject
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPPaymentIntentParameters")]
	[DisableDefaultCtor]
	interface PaymentIntentParameters
	{
		// @property (readonly, nonatomic) NSUInteger amount;
		[Export("amount")]
		nuint Amount { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull currency;
		[Export("currency")]
		string Currency { get; }

		// @property (readonly, nonatomic) NSArray<NSString *> * _Nonnull paymentMethodTypes;
		[Export("paymentMethodTypes")]
		string[] PaymentMethodTypes { get; }

		// @property (readwrite, copy, nonatomic) NSDictionary * _Nullable metadata;
		[NullAllowed, Export("metadata", ArgumentSemantic.Copy)]
		NSDictionary Metadata { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * _Nullable stripeDescription;
		[NullAllowed, Export("stripeDescription")]
		string StripeDescription { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * _Nullable statementDescriptor;
		[NullAllowed, Export("statementDescriptor")]
		string StatementDescriptor { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * _Nullable receiptEmail;
		[NullAllowed, Export("receiptEmail")]
		string ReceiptEmail { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * _Nullable customer;
		[NullAllowed, Export("customer")]
		string Customer { get; set; }

		// @property (readwrite, copy, nonatomic) NSNumber * _Nullable applicationFeeAmount;
		[NullAllowed, Export("applicationFeeAmount", ArgumentSemantic.Copy)]
		NSNumber ApplicationFeeAmount { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * _Nullable transferGroup;
		[NullAllowed, Export("transferGroup")]
		string TransferGroup { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * _Nullable transferDataDestination;
		[NullAllowed, Export("transferDataDestination")]
		string TransferDataDestination { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * _Nullable onBehalfOf;
		[NullAllowed, Export("onBehalfOf")]
		string OnBehalfOf { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * _Nullable setupFutureUsage;
		[NullAllowed, Export("setupFutureUsage")]
		string SetupFutureUsage { get; set; }

		// -(instancetype _Nonnull)initWithAmount:(NSUInteger)amount currency:(NSString * _Nonnull)currency;
		[Export("initWithAmount:currency:")]
		IntPtr Constructor(nuint amount, string currency);

		// -(instancetype _Nonnull)initWithAmount:(NSUInteger)amount currency:(NSString * _Nonnull)currency paymentMethodTypes:(NSArray<NSString *> * _Nonnull)paymentMethodTypes;
		[Export("initWithAmount:currency:paymentMethodTypes:")]
		IntPtr Constructor(nuint amount, string currency, string[] paymentMethodTypes);

		// @property (readonly, copy, nonatomic) DEPRECATED_MSG_ATTRIBUTE("Did you mean to use stripeDescription?") NSString * description __attribute__((deprecated("Did you mean to use stripeDescription?")));
		[Export("description")]
		string Description { get; }
	}

	// @interface SCPPaymentMethod : NSObject <SCPJSONDecodable>
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPPaymentMethod")]
	[DisableDefaultCtor]
	interface PaymentMethod : JSONDecodable
	{
		// @property (readonly, nonatomic) NSString * _Nonnull stripeId;
		[Export("stripeId")]
		string StripeId { get; }

		// @property (readonly, nonatomic) NSDate * _Nullable created;
		[NullAllowed, Export("created")]
		NSDate Created { get; }

		// @property (readonly, nonatomic) SCPPaymentMethodType type;
		[Export("type")]
		SCPPaymentMethodType Type { get; }

		// @property (readonly, nonatomic) SCPCardDetails * _Nullable card;
		[NullAllowed, Export("card")]
		CardDetails Card { get; }

		// @property (readonly, nonatomic) NSString * _Nullable customer;
		[NullAllowed, Export("customer")]
		string Customer { get; }

		// @property (readonly, nonatomic) NSDictionary<NSString *,NSString *> * _Nonnull metadata;
		[Export("metadata")]
		NSDictionary<NSString, NSString> Metadata { get; }
	}

	// @interface SCPPaymentMethodDetails : NSObject <SCPJSONDecodable>
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPPaymentMethodDetails")]
	[DisableDefaultCtor]
	interface PaymentMethodDetails : JSONDecodable
	{
		// @property (readonly, nonatomic) SCPPaymentMethodType type;
		[Export("type")]
		SCPPaymentMethodType Type { get; }

		// @property (readonly, nonatomic) SCPCardPresentDetails * _Nullable cardPresent;
		[NullAllowed, Export("cardPresent")]
		CardPresentDetails CardPresent { get; }

		// @property (readonly, nonatomic) SCPCardPresentDetails * _Nullable interacPresent;
		[NullAllowed, Export("interacPresent")]
		CardPresentDetails InteracPresent { get; }
	}

	// @interface SCPProcessPaymentError : NSError
	[Protocol]
	[BaseType(typeof(NSError), Name = "SCPProcessPaymentError")]
	[DisableDefaultCtor]
	interface ProcessPaymentError
	{
		// @property (readonly, nonatomic) SCPPaymentIntent * _Nullable paymentIntent;
		[NullAllowed, Export("paymentIntent")]
		PaymentIntent PaymentIntent { get; }

		// @property (readonly, nonatomic) NSError * _Nullable requestError;
		[NullAllowed, Export("requestError")]
		NSError RequestError { get; }

		// @property (readonly, nonatomic) NSString * _Nullable declineCode;
		[NullAllowed, Export("declineCode")]
		string DeclineCode { get; }
	}

	// @interface SCPProcessRefundError : NSError
	[Protocol]
	[BaseType(typeof(NSError), Name = "SCPProcessRefundError")]
	interface ProcessRefundError
	{
		// @property (readonly, nonatomic) SCPRefund * _Nullable refund;
		[NullAllowed, Export("refund")]
		Refund Refund { get; }

		// @property (readonly, nonatomic) NSError * _Nullable requestError;
		[NullAllowed, Export("requestError")]
		NSError RequestError { get; }
	}

	// @interface SCPReadReusableCardParameters : NSObject
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPReadReusableCardParameters")]
	interface ReadReusableCardParameters
	{
		// @property (readwrite, copy, nonatomic) NSString * _Nullable customer;
		[NullAllowed, Export("customer")]
		string Customer { get; set; }

		// @property (readwrite, copy, nonatomic) NSDictionary * _Nullable metadata;
		[NullAllowed, Export("metadata", ArgumentSemantic.Copy)]
		NSDictionary Metadata { get; set; }
	}

	// @interface SCPReader : NSObject <SCPJSONDecodable>
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPReader")]
	[DisableDefaultCtor]
	interface Reader : JSONDecodable
	{
		// @property (readonly, nonatomic) SCPDeviceType deviceType;
		[Export("deviceType")]
		SCPDeviceType DeviceType { get; }

		// @property (readonly, nonatomic) BOOL simulated;
		[Export("simulated")]
		bool IsSimulated { get; }

		// @property (readonly, nonatomic) NSString * _Nullable stripeId;
		[NullAllowed, Export("stripeId")]
		string StripeId { get; }

		// @property (readonly, atomic) NSString * _Nullable locationId;
		[NullAllowed, Export("locationId")]
		string LocationId { get; }

		// @property (readonly, atomic) SCPLocationStatus locationStatus;
		[Export("locationStatus")]
		SCPLocationStatus LocationStatus { get; }

		// @property (readonly, atomic) SCPLocation * _Nullable location;
		[NullAllowed, Export("location")]
		Location Location { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull serialNumber;
		[Export("serialNumber")]
		string SerialNumber { get; }

		// @property (readonly, atomic) NSString * _Nullable deviceSoftwareVersion;
		[NullAllowed, Export("deviceSoftwareVersion")]
		string DeviceSoftwareVersion { get; }

		// @property (readonly, atomic) SCPReaderSoftwareUpdate * _Nullable availableUpdate;
		[NullAllowed, Export("availableUpdate")]
		ReaderSoftwareUpdate AvailableUpdate { get; }

		// @property (readonly, atomic) NSNumber * _Nullable batteryLevel;
		[NullAllowed, Export("batteryLevel")]
		NSNumber BatteryLevel { get; }

		// @property (readonly, atomic) SCPBatteryStatus batteryStatus;
		[Export("batteryStatus")]
		SCPBatteryStatus BatteryStatus { get; }

		// @property (readonly, atomic) NSNumber * _Nullable isCharging;
		[NullAllowed, Export("isCharging")]
		NSNumber IsCharging { get; }

		// @property (readonly, nonatomic) NSString * _Nullable ipAddress;
		[NullAllowed, Export("ipAddress")]
		string IpAddress { get; }

		// @property (readonly, nonatomic) SCPReaderNetworkStatus status;
		[Export("status")]
		SCPReaderNetworkStatus Status { get; }

		// @property (readonly, nonatomic) NSString * _Nullable label;
		[NullAllowed, Export("label")]
		string Label { get; }
	}

	// @interface SCPReaderSoftwareUpdate : NSObject
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPReaderSoftwareUpdate")]
	[DisableDefaultCtor]
	interface ReaderSoftwareUpdate
	{
		// @property (readonly, nonatomic) SCPUpdateTimeEstimate estimatedUpdateTime;
		[Export("estimatedUpdateTime")]
		SCPUpdateTimeEstimate EstimatedUpdateTime { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull deviceSoftwareVersion;
		[Export("deviceSoftwareVersion")]
		string DeviceSoftwareVersion { get; }

		// @property (readonly, nonatomic) SCPUpdateComponent components;
		[Export("components")]
		SCPUpdateComponent Components { get; }

		// @property (readonly, nonatomic) NSDate * _Nonnull requiredAt;
		[Export("requiredAt")]
		NSDate RequiredAt { get; }

		// +(NSString * _Nonnull)stringFromUpdateTimeEstimate:(SCPUpdateTimeEstimate)estimate;
		[Static]
		[Export("stringFromUpdateTimeEstimate:")]
		string StringFromUpdateTimeEstimate(SCPUpdateTimeEstimate estimate);
	}

	// @interface SCPReceiptDetails : NSObject <SCPJSONDecodable>
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPReceiptDetails")]
	[DisableDefaultCtor]
	interface ReceiptDetails : JSONDecodable
	{
		// @property (readonly, nonatomic) NSString * _Nullable accountType;
		[NullAllowed, Export("accountType")]
		string AccountType { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull applicationPreferredName;
		[Export("applicationPreferredName")]
		string ApplicationPreferredName { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull dedicatedFileName;
		[Export("dedicatedFileName")]
		string DedicatedFileName { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull authorizationResponseCode;
		[Export("authorizationResponseCode")]
		string AuthorizationResponseCode { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull applicationCryptogram;
		[Export("applicationCryptogram")]
		string ApplicationCryptogram { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull terminalVerificationResults;
		[Export("terminalVerificationResults")]
		string TerminalVerificationResults { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull transactionStatusInformation;
		[Export("transactionStatusInformation")]
		string TransactionStatusInformation { get; }
	}

	// @interface SCPRefund : NSObject <SCPJSONDecodable>
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPRefund")]
	[DisableDefaultCtor]
	interface Refund : JSONDecodable
	{
		// @property (readonly, nonatomic) NSString * _Nonnull stripeId;
		[Export("stripeId")]
		string StripeId { get; }

		// @property (readonly, nonatomic) NSUInteger amount;
		[Export("amount")]
		nuint Amount { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull charge;
		[Export("charge")]
		string Charge { get; }

		// @property (readonly, nonatomic) NSDate * _Nonnull created;
		[Export("created")]
		NSDate Created { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull currency;
		[Export("currency")]
		string Currency { get; }

		// @property (readonly, nonatomic) NSDictionary * _Nonnull metadata;
		[Export("metadata")]
		NSDictionary Metadata { get; }

		// @property (readonly, nonatomic) NSString * _Nullable reason;
		[NullAllowed, Export("reason")]
		string Reason { get; }

		// @property (readonly, nonatomic) SCPRefundStatus status;
		[Export("status")]
		SCPRefundStatus Status { get; }

		// @property (readonly, nonatomic) SCPPaymentMethodDetails * _Nullable paymentMethodDetails;
		[NullAllowed, Export("paymentMethodDetails")]
		PaymentMethodDetails PaymentMethodDetails { get; }

		// @property (readonly, nonatomic) NSString * _Nullable failureReason;
		[NullAllowed, Export("failureReason")]
		string FailureReason { get; }
	}

	// @interface SCPSetupAttempt : NSObject <SCPJSONDecodable>
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPSetupAttempt")]
	interface SetupAttempt : JSONDecodable
	{
		// @property (readonly, nonatomic) NSString * _Nullable application;
		[NullAllowed, Export("application")]
		string Application { get; }

		// @property (readonly, nonatomic) NSDate * _Nonnull created;
		[Export("created")]
		NSDate Created { get; }

		// @property (readonly, nonatomic) NSString * _Nullable customer;
		[NullAllowed, Export("customer")]
		string Customer { get; }

		// @property (readonly, nonatomic) NSString * _Nullable onBehalfOf;
		[NullAllowed, Export("onBehalfOf")]
		string OnBehalfOf { get; }

		// @property (readonly, nonatomic) NSString * _Nullable paymentMethod;
		[NullAllowed, Export("paymentMethod")]
		string PaymentMethod { get; }

		// @property (readonly, nonatomic) SCPSetupAttemptPaymentMethodDetails * _Nullable paymentMethodDetails;
		[NullAllowed, Export("paymentMethodDetails")]
		SetupAttemptPaymentMethodDetails PaymentMethodDetails { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull setupIntent;
		[Export("setupIntent")]
		string SetupIntent { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull status;
		[Export("status")]
		string Status { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull stripeId;
		[Export("stripeId")]
		string StripeId { get; }
	}

	// @interface SCPSetupAttemptCardPresentDetails : NSObject <SCPJSONDecodable>
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPSetupAttemptCardPresentDetails")]
	[DisableDefaultCtor]
	interface SetupAttemptCardPresentDetails : JSONDecodable
	{
		// @property (readonly, nonatomic) NSString * _Nonnull generatedCard;
		[Export("generatedCard")]
		string GeneratedCard { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull emvAuthData;
		[Export("emvAuthData")]
		string EmvAuthData { get; }
	}

	// @interface SCPSetupAttemptPaymentMethodDetails : NSObject <SCPJSONDecodable>
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPSetupAttemptPaymentMethodDetails")]
	[DisableDefaultCtor]
	interface SetupAttemptPaymentMethodDetails : JSONDecodable
	{
		// @property (readonly, nonatomic) SCPPaymentMethodType type;
		[Export("type")]
		SCPPaymentMethodType Type { get; }

		// @property (readonly, nonatomic) SCPSetupAttemptCardPresentDetails * _Nullable cardPresent;
		[NullAllowed, Export("cardPresent")]
		SetupAttemptCardPresentDetails CardPresent { get; }

		// @property (readonly, nonatomic) SCPSetupAttemptCardPresentDetails * _Nullable interacPresent;
		[NullAllowed, Export("interacPresent")]
		SetupAttemptCardPresentDetails InteracPresent { get; }
	}

	// @interface SCPSetupIntent : NSObject <SCPJSONDecodable, NSCopying>
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPSetupIntent")]
	[DisableDefaultCtor]
	interface SetupIntent : JSONDecodable, INSCopying
	{
		// @property (readonly, nonatomic) NSString * _Nonnull stripeId;
		[Export("stripeId")]
		string StripeId { get; }

		// @property (readonly, nonatomic) NSDate * _Nonnull created;
		[Export("created")]
		NSDate Created { get; }

		// @property (readonly, nonatomic) NSString * _Nullable customer;
		[NullAllowed, Export("customer")]
		string Customer { get; }

		// @property (readonly, nonatomic) NSDictionary * _Nullable metadata;
		[NullAllowed, Export("metadata")]
		NSDictionary Metadata { get; }

		// @property (readonly, nonatomic) SCPSetupIntentUsage usage;
		[Export("usage")]
		SCPSetupIntentUsage Usage { get; }

		// @property (readonly, nonatomic) SCPSetupIntentStatus status;
		[Export("status")]
		SCPSetupIntentStatus Status { get; }

		// @property (readonly, nonatomic) SCPSetupAttempt * _Nullable latestAttempt;
		[NullAllowed, Export("latestAttempt")]
		SetupAttempt LatestAttempt { get; }
	}

	// @interface SCPSetupIntentParameters : NSObject
	[Protocol]
	[BaseType(typeof(NSObject), Name = "SCPSetupIntentParameters")]
	[DisableDefaultCtor]
	interface SetupIntentParameters
	{
		// @property (readwrite, copy, nonatomic) NSString * _Nullable customer;
		[NullAllowed, Export("customer")]
		string Customer { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * _Nullable stripeDescription;
		[NullAllowed, Export("stripeDescription")]
		string StripeDescription { get; set; }

		// @property (readwrite, copy, nonatomic) NSDictionary * _Nullable metadata;
		[NullAllowed, Export("metadata", ArgumentSemantic.Copy)]
		NSDictionary Metadata { get; set; }

		// @property (readwrite, nonatomic) SCPSetupIntentUsage usage;
		[Export("usage", ArgumentSemantic.Assign)]
		SCPSetupIntentUsage Usage { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * _Nullable onBehalfOf;
		[NullAllowed, Export("onBehalfOf")]
		string OnBehalfOf { get; set; }

		// -(instancetype _Nonnull)initWithCustomer:(NSString * _Nullable)customerId;
		[Export("initWithCustomer:")]
		IntPtr Constructor([NullAllowed] string customerId);

		// @property (readonly, copy, nonatomic) DEPRECATED_MSG_ATTRIBUTE("Did you mean to use stripeDescription?") NSString * description __attribute__((deprecated("Did you mean to use stripeDescription?")));
		[Export("description")]
		string Description { get; }
	}

	// @protocol SCPTerminalDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject), Name = "SCPTerminalDelegate")]
	interface TerminalDelegate
	{
		// @required -(void)terminal:(SCPTerminal * _Nonnull)terminal didReportUnexpectedReaderDisconnect:(SCPReader * _Nonnull)reader __attribute__((swift_name("terminal(_:didReportUnexpectedReaderDisconnect:)")));
		[Abstract]
		[Export("terminal:didReportUnexpectedReaderDisconnect:")]
		void OnUnexpectedReaderDisconnect(Terminal terminal, Reader reader);

		// @optional -(void)terminal:(SCPTerminal * _Nonnull)terminal didChangeConnectionStatus:(SCPConnectionStatus)status __attribute__((swift_name("terminal(_:didChangeConnectionStatus:)")));
		[Abstract]
		[Export("terminal:didChangeConnectionStatus:")]
		void OnConnectionStatusChange(Terminal terminal, SCPConnectionStatus status);

		// @optional -(void)terminal:(SCPTerminal * _Nonnull)terminal didChangePaymentStatus:(SCPPaymentStatus)status __attribute__((swift_name("terminal(_:didChangePaymentStatus:)")));
		[Abstract]
		[Export("terminal:didChangePaymentStatus:")]
		void OnPaymentStatusChange(Terminal terminal, SCPPaymentStatus status);
	}

}
