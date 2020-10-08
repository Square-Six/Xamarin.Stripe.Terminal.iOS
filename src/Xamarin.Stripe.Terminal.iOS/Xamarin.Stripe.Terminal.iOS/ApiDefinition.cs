using System;
using Foundation;
using ObjCRuntime;

namespace StripeTerminal
{
	// typedef void (^SCPConnectionTokenCompletionBlock)(NSString * _Nullable, NSError * _Nullable);
	delegate void SCPConnectionTokenCompletionBlock([NullAllowed] string arg0, [NullAllowed] NSError arg1);

	// typedef void (^SCPLogListenerBlock)(NSString * _Nonnull);
	delegate void SCPLogListenerBlock(string arg0);

	// typedef void (^SCPPaymentMethodCompletionBlock)(SCPPaymentMethod * _Nullable, NSError * _Nullable);
	delegate void SCPPaymentMethodCompletionBlock([NullAllowed] SCPPaymentMethod arg0, [NullAllowed] NSError arg1);

	// typedef void (^SCPErrorCompletionBlock)(NSError * _Nullable);
	delegate void SCPErrorCompletionBlock([NullAllowed] NSError arg0);

	// typedef void (^SCPProcessPaymentCompletionBlock)(SCPPaymentIntent * _Nullable, SCPProcessPaymentError * _Nullable);
	delegate void SCPProcessPaymentCompletionBlock([NullAllowed] SCPPaymentIntent arg0, [NullAllowed] SCPProcessPaymentError arg1);

	// typedef void (^SCPProcessRefundCompletionBlock)(SCPRefund * _Nullable, SCPProcessRefundError * _Nullable);
	delegate void SCPProcessRefundCompletionBlock([NullAllowed] SCPRefund arg0, [NullAllowed] SCPProcessRefundError arg1);

	// typedef void (^SCPPaymentIntentCompletionBlock)(SCPPaymentIntent * _Nullable, NSError * _Nullable);
	delegate void SCPPaymentIntentCompletionBlock([NullAllowed] SCPPaymentIntent arg0, [NullAllowed] NSError arg1);

	// typedef void (^SCPReaderCompletionBlock)(SCPReader * _Nullable, NSError * _Nullable);
	delegate void SCPReaderCompletionBlock([NullAllowed] SCPReader arg0, [NullAllowed] NSError arg1);

	// typedef void (^SCPReaderSoftwareUpdateCompletionBlock)(SCPReaderSoftwareUpdate * _Nullable, NSError * _Nullable);
	delegate void SCPReaderSoftwareUpdateCompletionBlock([NullAllowed] SCPReaderSoftwareUpdate arg0, [NullAllowed] NSError arg1);

	// @interface SCPCancelable : NSObject
	[BaseType(typeof(NSObject))]
	interface SCPCancelable
	{
		// @property (readonly, nonatomic) BOOL completed;
		[Export("completed")]
		bool Completed { get; }

		// -(void)cancel:(SCPErrorCompletionBlock _Nonnull)completion;
		[Export("cancel:")]
		void Cancel(SCPErrorCompletionBlock completion);
	}


	// @protocol SCPJSONDecodable <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface SCPJSONDecodable
	{
		// @required +(instancetype _Nullable)decodedObjectFromJSON:(NSDictionary * _Nullable)json;
		[Abstract]
		[Export("decodedObjectFromJSON:")]
		SCPJSONDecodable DecodedObjectFromJSON([NullAllowed] NSDictionary json);

		// @required @property (readonly, nonatomic) NSDictionary * _Nonnull originalJSON;
		[Abstract]
		[Export("originalJSON")]
		NSDictionary OriginalJSON { get; }
	}

    // @interface SCPCardDetails : NSObject <SCPJSONDecodable>
    [BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SCPCardDetails : SCPJSONDecodable
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
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SCPCardPresentDetails : SCPJSONDecodable
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
		SCPReceiptDetails Receipt { get; }

		// @property (readonly, nonatomic) NSString * _Nullable emvAuthData;
		[NullAllowed, Export("emvAuthData")]
		string EmvAuthData { get; }
	}

	// @interface SCPCartLineItem : NSObject
	[BaseType(typeof(NSObject))]
	interface SCPCartLineItem : INativeObject
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

	// @interface SCPCart : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SCPCart
	{
        // @property (readwrite, nonatomic, strong) NSMutableArray<SCPCartLineItem *> * _Nonnull lineItems;
        [Export("lineItems", ArgumentSemantic.Strong)]
        NSMutableArray<SCPCartLineItem> LineItems { get; set; }

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
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SCPCharge : SCPJSONDecodable
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
		SCPPaymentMethodDetails PaymentMethodDetails { get; }

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

	// @interface SCPConnectionConfiguration : NSObject
	[BaseType(typeof(NSObject))]
	interface SCPConnectionConfiguration
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

		//// -(instancetype _Nonnull)initWithAllowCustomerCancel:(BOOL)allowCustomerCancel;
		//[Export("initWithAllowCustomerCancel:")]
		//IntPtr Constructor(bool allowCustomerCancel);
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
	[BaseType(typeof(NSObject))]
	interface SCPConnectionTokenProvider
	{
		// @required -(void)fetchConnectionToken:(SCPConnectionTokenCompletionBlock _Nonnull)completion __attribute__((swift_name("fetchConnectionToken(_:)")));
		[Abstract]
		[Export("fetchConnectionToken:")]
		void FetchConnectionToken(SCPConnectionTokenCompletionBlock completion);
	}

	// @interface SCPDiscoveryConfiguration : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SCPDiscoveryConfiguration
	{
		// -(instancetype _Nonnull)initWithDeviceType:(SCPDeviceType)deviceType simulated:(BOOL)simulated __attribute__((deprecated("All `initWithDeviceType` constructors of SCPDiscoveryConfiguration are deprecated; please use the corresponding `initWithDiscoveryMethod` constructor instead.")));
		[Export("initWithDeviceType:simulated:")]
		IntPtr Constructor(SCPDeviceType deviceType, bool simulated);

		// -(instancetype _Nonnull)initWithDeviceType:(SCPDeviceType)deviceType discoveryMethod:(SCPDiscoveryMethod)discoveryMethod simulated:(BOOL)simulated __attribute__((deprecated("All `initWithDeviceType` constructors of SCPDiscoveryConfiguration are deprecated; please use the corresponding `initWithDiscoveryMethod` constructor instead.")));
		[Export("initWithDeviceType:discoveryMethod:simulated:")]
		IntPtr Constructor(SCPDeviceType deviceType, SCPDiscoveryMethod discoveryMethod, bool simulated);

		// -(instancetype _Nonnull)initWithDiscoveryMethod:(SCPDiscoveryMethod)discoveryMethod simulated:(BOOL)simulated;
		[Export("initWithDiscoveryMethod:simulated:")]
		IntPtr Constructor(SCPDiscoveryMethod discoveryMethod, bool simulated);

		// -(instancetype _Nonnull)initWithDiscoveryMethod:(SCPDiscoveryMethod)discoveryMethod locationId:(NSString * _Nullable)locationId simulated:(BOOL)simulated;
		[Export("initWithDiscoveryMethod:locationId:simulated:")]
		IntPtr Constructor(SCPDiscoveryMethod discoveryMethod, [NullAllowed] string locationId, bool simulated);

		// -(instancetype _Nonnull)initWithDeviceType:(SCPDeviceType)deviceType discoveryMethod:(SCPDiscoveryMethod)discoveryMethod locationId:(NSString * _Nullable)locationId simulated:(BOOL)simulated __attribute__((deprecated("All `initWithDeviceType` constructors of SCPDiscoveryConfiguration are deprecated; please use the corresponding `initWithDiscoveryMethod` constructor instead.")));
		[Export("initWithDeviceType:discoveryMethod:locationId:simulated:")]
		IntPtr Constructor(SCPDeviceType deviceType, SCPDiscoveryMethod discoveryMethod, [NullAllowed] string locationId, bool simulated);

		// @property (assign, readwrite, nonatomic) NSUInteger timeout;
		[Export("timeout")]
		nuint Timeout { get; set; }

		// @property (readonly, nonatomic) SCPDeviceType deviceType __attribute__((deprecated("The `deviceType` property of SCPDiscoveryConfiguration is deprecated; please do not rely on the behavior of this property in your app.")));
		[Export("deviceType")]
		SCPDeviceType DeviceType { get; }

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

	// @protocol SCPReaderDisplayDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface SCPReaderDisplayDelegate
	{
		// @required -(void)terminal:(SCPTerminal * _Nonnull)terminal didRequestReaderInput:(SCPReaderInputOptions)inputOptions __attribute__((swift_name("terminal(_:didRequestReaderInput:)")));
		[Abstract]
		[Export("terminal:didRequestReaderInput:")]
		void DidRequestReaderInput(SCPTerminal terminal, SCPReaderInputOptions inputOptions);

		// @required -(void)terminal:(SCPTerminal * _Nonnull)terminal didRequestReaderDisplayMessage:(SCPReaderDisplayMessage)displayMessage __attribute__((swift_name("terminal(_:didRequestReaderDisplayMessage:)")));
		[Abstract]
		[Export("terminal:didRequestReaderDisplayMessage:")]
		void DidRequestReaderDisplayMessage(SCPTerminal terminal, SCPReaderDisplayMessage displayMessage);
	}

	// @interface SCPPaymentIntent : NSObject <SCPJSONDecodable, NSCopying>
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SCPPaymentIntent : SCPJSONDecodable, INSCopying
	{
		// @property (readonly, nonatomic) NSString * _Nonnull stripeId;
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
		SCPCharge[] Charges { get; }
	}

	// @interface SCPRefundParameters : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SCPRefundParameters
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

	// @interface SCPTerminal : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SCPTerminal
	{
		// +(void)setTokenProvider:(id<SCPConnectionTokenProvider> _Nonnull)tokenProvider __attribute__((swift_name("setTokenProvider(_:)")));
		[Static]
		[Export("setTokenProvider:")]
		void SetTokenProvider(SCPConnectionTokenProvider tokenProvider);

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
		SCPTerminal Shared { get; }

		[Wrap("WeakDelegate")]
		[NullAllowed]
		SCPTerminalDelegate Delegate { get; set; }

		// @property (readwrite, nonatomic) id<SCPTerminalDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic) SCPReader * _Nullable connectedReader;
		[NullAllowed, Export("connectedReader")]
		SCPReader ConnectedReader { get; }

		// @property (readonly, nonatomic) SCPConnectionStatus connectionStatus;
		[Export("connectionStatus")]
		SCPConnectionStatus ConnectionStatus { get; }

		// @property (assign, readwrite, nonatomic) SCPLogLevel logLevel;
		[Export("logLevel", ArgumentSemantic.Assign)]
		SCPLogLevel LogLevel { get; set; }

		// @property (readonly, nonatomic) SCPPaymentStatus paymentStatus;
		[Export("paymentStatus")]
		SCPPaymentStatus PaymentStatus { get; }

		// -(void)clearCachedCredentials __attribute__((swift_name("clearCachedCredentials()")));
		[Export("clearCachedCredentials")]
		void ClearCachedCredentials();

		// -(SCPCancelable * _Nullable)discoverReaders:(SCPDiscoveryConfiguration * _Nonnull)configuration delegate:(id<SCPDiscoveryDelegate> _Nonnull)delegate completion:(SCPErrorCompletionBlock _Nonnull)completion __attribute__((swift_name("discoverReaders(_:delegate:completion:)")));
		[Export("discoverReaders:delegate:completion:")]
		[return: NullAllowed]
		SCPCancelable DiscoverReaders(SCPDiscoveryConfiguration configuration, SCPDiscoveryDelegate @delegate, SCPErrorCompletionBlock completion);

		// -(void)connectReader:(SCPReader * _Nonnull)reader connectionConfig:(SCPConnectionConfiguration * _Nullable)connectionConfig completion:(SCPReaderCompletionBlock _Nonnull)completion __attribute__((swift_name("connectReader(_:connectionConfig:completion:)")));
		[Export("connectReader:connectionConfig:completion:")]
		void ConnectReader(SCPReader reader, [NullAllowed] SCPConnectionConfiguration connectionConfig, SCPReaderCompletionBlock completion);

		// -(void)connectReader:(SCPReader * _Nonnull)reader completion:(SCPReaderCompletionBlock _Nonnull)completion __attribute__((swift_name("connectReader(_:completion:)")));
		[Export("connectReader:completion:")]
		void ConnectReader(SCPReader reader, SCPReaderCompletionBlock completion);

		// -(void)disconnectReader:(SCPErrorCompletionBlock _Nonnull)completion __attribute__((swift_name("disconnectReader(_:)")));
		[Export("disconnectReader:")]
		void DisconnectReader(SCPErrorCompletionBlock completion);

		// -(void)createPaymentIntent:(SCPPaymentIntentParameters * _Nonnull)parameters completion:(SCPPaymentIntentCompletionBlock _Nonnull)completion __attribute__((swift_name("createPaymentIntent(_:completion:)")));
		[Export("createPaymentIntent:completion:")]
		void CreatePaymentIntent(SCPPaymentIntentParameters parameters, SCPPaymentIntentCompletionBlock completion);

		// -(void)retrievePaymentIntent:(NSString * _Nonnull)clientSecret completion:(SCPPaymentIntentCompletionBlock _Nonnull)completion __attribute__((swift_name("retrievePaymentIntent(clientSecret:completion:)")));
		[Export("retrievePaymentIntent:completion:")]
		void RetrievePaymentIntent(string clientSecret, SCPPaymentIntentCompletionBlock completion);

		// -(SCPCancelable * _Nullable)collectPaymentMethod:(SCPPaymentIntent * _Nonnull)paymentIntent delegate:(id<SCPReaderDisplayDelegate> _Nullable)delegate completion:(SCPPaymentIntentCompletionBlock _Nonnull)completion __attribute__((swift_name("collectPaymentMethod(_:delegate:completion:)")));
		[Export("collectPaymentMethod:delegate:completion:")]
		[return: NullAllowed]
		SCPCancelable CollectPaymentMethod(SCPPaymentIntent paymentIntent, [NullAllowed] SCPReaderDisplayDelegate @delegate, SCPPaymentIntentCompletionBlock completion);

		// -(void)processPayment:(SCPPaymentIntent * _Nonnull)paymentIntent completion:(SCPProcessPaymentCompletionBlock _Nonnull)completion __attribute__((swift_name("processPayment(_:completion:)")));
		[Export("processPayment:completion:")]
		void ProcessPayment(SCPPaymentIntent paymentIntent, SCPProcessPaymentCompletionBlock completion);

		// -(void)cancelPaymentIntent:(SCPPaymentIntent * _Nonnull)paymentIntent completion:(SCPPaymentIntentCompletionBlock _Nonnull)completion __attribute__((swift_name("cancelPaymentIntent(_:completion:)")));
		[Export("cancelPaymentIntent:completion:")]
		void CancelPaymentIntent(SCPPaymentIntent paymentIntent, SCPPaymentIntentCompletionBlock completion);

		// -(SCPCancelable * _Nullable)readReusableCard:(SCPReadReusableCardParameters * _Nonnull)parameters delegate:(id<SCPReaderDisplayDelegate> _Nonnull)delegate completion:(SCPPaymentMethodCompletionBlock _Nonnull)completion __attribute__((swift_name("readReusableCard(_:delegate:completion:)")));
		[Export("readReusableCard:delegate:completion:")]
		[return: NullAllowed]
		SCPCancelable ReadReusableCard(SCPReadReusableCardParameters parameters, SCPReaderDisplayDelegate @delegate, SCPPaymentMethodCompletionBlock completion);

		// -(SCPCancelable * _Nullable)collectRefundPaymentMethod:(SCPRefundParameters * _Nonnull)refundParams completion:(SCPErrorCompletionBlock _Nonnull)completion __attribute__((swift_name("collectRefundPaymentMethod(_:completion:)")));
		[Export("collectRefundPaymentMethod:completion:")]
		[return: NullAllowed]
		SCPCancelable CollectRefundPaymentMethod(SCPRefundParameters refundParams, SCPErrorCompletionBlock completion);

		// -(void)processRefund:(SCPProcessRefundCompletionBlock _Nonnull)completion __attribute__((swift_name("processRefund(completion:)")));
		[Export("processRefund:")]
		void ProcessRefund(SCPProcessRefundCompletionBlock completion);

		// -(SCPCancelable * _Nullable)checkForUpdate:(SCPReaderSoftwareUpdateCompletionBlock _Nonnull)completion __attribute__((swift_name("checkForUpdate(_:)")));
		[Export("checkForUpdate:")]
		[return: NullAllowed]
		SCPCancelable CheckForUpdate(SCPReaderSoftwareUpdateCompletionBlock completion);

		// -(void)clearReaderDisplay:(SCPErrorCompletionBlock _Nonnull)completion __attribute__((swift_name("clearReaderDisplay(_:)")));
		[Export("clearReaderDisplay:")]
		void ClearReaderDisplay(SCPErrorCompletionBlock completion);

		// -(void)setReaderDisplay:(SCPCart * _Nonnull)cart completion:(SCPErrorCompletionBlock _Nonnull)completion __attribute__((swift_name("setReaderDisplay(_:completion:)")));
		[Export("setReaderDisplay:completion:")]
		void SetReaderDisplay(SCPCart cart, SCPErrorCompletionBlock completion);

		// -(SCPCancelable * _Nullable)installUpdate:(SCPReaderSoftwareUpdate * _Nonnull)update delegate:(id<SCPReaderSoftwareUpdateDelegate> _Nonnull)delegate completion:(SCPErrorCompletionBlock _Nonnull)completion __attribute__((swift_name("installUpdate(_:delegate:completion:)")));
		[Export("installUpdate:delegate:completion:")]
		[return: NullAllowed]
		SCPCancelable InstallUpdate(SCPReaderSoftwareUpdate update, SCPReaderSoftwareUpdateDelegate @delegate, SCPErrorCompletionBlock completion);

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
	}

	// @protocol SCPDiscoveryDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface SCPDiscoveryDelegate
	{
		// @required -(void)terminal:(SCPTerminal * _Nonnull)terminal didUpdateDiscoveredReaders:(NSArray<SCPReader *> * _Nonnull)readers __attribute__((swift_name("terminal(_:didUpdateDiscoveredReaders:)")));
		[Abstract]
		[Export("terminal:didUpdateDiscoveredReaders:")]
		void DidUpdateDiscoveredReaders(SCPTerminal terminal, SCPReader[] readers);
	}

	[Static]
	partial interface Constants
	{
		// extern NSString *const _Nonnull SCPErrorDomain __attribute__((swift_name("ErrorDomain")));
		[Field("SCPErrorDomain", "__Internal")]
		NSString SCPErrorDomain { get; }

		// extern SCPErrorKey _Nonnull SCPErrorKeyMessage;
		[Field("SCPErrorKeyMessage", "__Internal")]
		NSString SCPErrorKeyMessage { get; }

		// extern SCPErrorKey _Nonnull SCPErrorKeyStripeAPIDeclineCode;
		[Field("SCPErrorKeyStripeAPIDeclineCode", "__Internal")]
		NSString SCPErrorKeyStripeAPIDeclineCode { get; }

		// extern SCPErrorKey _Nonnull SCPErrorKeyStripeAPIFailureReason;
		[Field("SCPErrorKeyStripeAPIFailureReason", "__Internal")]
		NSString SCPErrorKeyStripeAPIFailureReason { get; }

		// extern SCPErrorKey _Nonnull SCPErrorKeyStripeAPIRequestId;
		[Field("SCPErrorKeyStripeAPIRequestId", "__Internal")]
		NSString SCPErrorKeyStripeAPIRequestId { get; }

		// extern SCPErrorKey _Nonnull SCPErrorKeyStripeAPIErrorCode;
		[Field("SCPErrorKeyStripeAPIErrorCode", "__Internal")]
		NSString SCPErrorKeyStripeAPIErrorCode { get; }

		// extern SCPErrorKey _Nonnull SCPErrorKeyStripeAPIErrorType;
		[Field("SCPErrorKeyStripeAPIErrorType", "__Internal")]
		NSString SCPErrorKeyStripeAPIErrorType { get; }

		// extern SCPErrorKey _Nonnull SCPErrorKeyStripeAPIDocUrl;
		[Field("SCPErrorKeyStripeAPIDocUrl", "__Internal")]
		NSString SCPErrorKeyStripeAPIDocUrl { get; }

		// extern SCPErrorKey _Nonnull SCPErrorKeyStripeAPIErrorParameter;
		[Field("SCPErrorKeyStripeAPIErrorParameter", "__Internal")]
		NSString SCPErrorKeyStripeAPIErrorParameter { get; }

		// extern SCPErrorKey _Nonnull SCPErrorKeyHttpStatusCode;
		[Field("SCPErrorKeyHttpStatusCode", "__Internal")]
		NSString SCPErrorKeyHttpStatusCode { get; }

		// extern SCPErrorKey _Nonnull SCPErrorKeyStripeAPIPaymentIntent;
		[Field("SCPErrorKeyStripeAPIPaymentIntent", "__Internal")]
		NSString SCPErrorKeyStripeAPIPaymentIntent { get; }

		// extern SCPErrorKey _Nonnull SCPErrorKeyReaderMessage;
		[Field("SCPErrorKeyReaderMessage", "__Internal")]
		NSString SCPErrorKeyReaderMessage { get; }
	}

	// @interface SCPPaymentIntentParameters : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SCPPaymentIntentParameters
	{
		// @property (readonly, nonatomic) NSUInteger amount;
		[Export("amount")]
		nuint Amount { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull currency;
		[Export("currency")]
		string Currency { get; }

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

		// -(instancetype _Nonnull)initWithAmount:(NSUInteger)amount currency:(NSString * _Nonnull)currency;
		[Export("initWithAmount:currency:")]
		IntPtr Constructor(nuint amount, string currency);

		// @property (readonly, copy, nonatomic) DEPRECATED_MSG_ATTRIBUTE("Did you mean to use stripeDescription?") NSString * description __attribute__((deprecated("Did you mean to use stripeDescription?")));
		[Export("description")]
		string Description { get; }
	}

	// @interface SCPPaymentMethod : NSObject <SCPJSONDecodable>
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SCPPaymentMethod : SCPJSONDecodable
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
		SCPCardDetails Card { get; }

		// @property (readonly, nonatomic) NSString * _Nullable customer;
		[NullAllowed, Export("customer")]
		string Customer { get; }

		// @property (readonly, nonatomic) NSDictionary<NSString *,NSString *> * _Nonnull metadata;
		[Export("metadata")]
		NSDictionary<NSString, NSString> Metadata { get; }
	}

	// @interface SCPPaymentMethodDetails : NSObject <SCPJSONDecodable>
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SCPPaymentMethodDetails : SCPJSONDecodable
	{
		// @property (readonly, nonatomic) SCPPaymentMethodType type;
		[Export("type")]
		SCPPaymentMethodType Type { get; }

		// @property (readonly, nonatomic) SCPCardPresentDetails * _Nullable cardPresent;
		[NullAllowed, Export("cardPresent")]
		SCPCardPresentDetails CardPresent { get; }
	}

	// @interface SCPProcessPaymentError : NSError
	[BaseType(typeof(NSError))]
	[DisableDefaultCtor]
	interface SCPProcessPaymentError
	{
		// @property (readonly, nonatomic) SCPPaymentIntent * _Nullable paymentIntent;
		[NullAllowed, Export("paymentIntent")]
		SCPPaymentIntent PaymentIntent { get; }

		// @property (readonly, nonatomic) NSError * _Nullable requestError;
		[NullAllowed, Export("requestError")]
		NSError RequestError { get; }

		// @property (readonly, nonatomic) NSString * _Nullable declineCode;
		[NullAllowed, Export("declineCode")]
		string DeclineCode { get; }
	}

	// @interface SCPProcessRefundError : NSError
	[BaseType(typeof(NSError))]
	interface SCPProcessRefundError
	{
		// @property (readonly, nonatomic) SCPRefund * _Nullable refund;
		[NullAllowed, Export("refund")]
		SCPRefund Refund { get; }

		// @property (readonly, nonatomic) NSError * _Nullable requestError;
		[NullAllowed, Export("requestError")]
		NSError RequestError { get; }

		// @property (readonly, nonatomic) NSString * _Nullable failureReason;
		[NullAllowed, Export("failureReason")]
		string FailureReason { get; }
	}

	// @interface SCPReadReusableCardParameters : NSObject
	[BaseType(typeof(NSObject))]
	interface SCPReadReusableCardParameters
	{
		// @property (readwrite, copy, nonatomic) NSString * _Nullable customer;
		[NullAllowed, Export("customer")]
		string Customer { get; set; }

		// @property (readwrite, copy, nonatomic) NSDictionary * _Nullable metadata;
		[NullAllowed, Export("metadata", ArgumentSemantic.Copy)]
		NSDictionary Metadata { get; set; }
	}

	// @interface SCPReader : NSObject <SCPJSONDecodable>
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SCPReader : SCPJSONDecodable
	{
		// @property (readonly, nonatomic) NSString * _Nullable ipAddress;
		[NullAllowed, Export("ipAddress")]
		string IpAddress { get; }

		// @property (readonly, nonatomic) NSString * _Nullable locationId;
		[NullAllowed, Export("locationId")]
		string LocationId { get; }

		// @property (readonly, nonatomic) SCPReaderNetworkStatus status;
		[Export("status")]
		SCPReaderNetworkStatus Status { get; }

		// @property (readonly, nonatomic) NSString * _Nullable label;
		[NullAllowed, Export("label")]
		string Label { get; }

		// @property (readonly, nonatomic) NSNumber * _Nullable batteryLevel;
		[NullAllowed, Export("batteryLevel")]
		NSNumber BatteryLevel { get; }

		// @property (readonly, nonatomic) NSString * _Nullable stripeId;
		[NullAllowed, Export("stripeId")]
		string StripeId { get; }

		// @property (readonly, nonatomic) SCPDeviceType deviceType;
		[Export("deviceType")]
		SCPDeviceType DeviceType { get; }

		// @property (readonly, nonatomic) BOOL simulated;
		[Export("simulated")]
		bool Simulated { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull serialNumber;
		[Export("serialNumber")]
		string SerialNumber { get; }

		// @property (readonly, nonatomic) NSString * _Nullable deviceSoftwareVersion;
		[NullAllowed, Export("deviceSoftwareVersion")]
		string DeviceSoftwareVersion { get; }
	}

	// @interface SCPReaderSoftwareUpdate : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SCPReaderSoftwareUpdate
	{
		// @property (readonly, nonatomic) SCPUpdateTimeEstimate estimatedUpdateTime;
		[Export("estimatedUpdateTime")]
		SCPUpdateTimeEstimate EstimatedUpdateTime { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull deviceSoftwareVersion;
		[Export("deviceSoftwareVersion")]
		string DeviceSoftwareVersion { get; }

		// +(NSString * _Nonnull)stringFromUpdateTimeEstimate:(SCPUpdateTimeEstimate)estimate;
		[Static]
		[Export("stringFromUpdateTimeEstimate:")]
		string StringFromUpdateTimeEstimate(SCPUpdateTimeEstimate estimate);
	}

	// @protocol SCPReaderSoftwareUpdateDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface SCPReaderSoftwareUpdateDelegate
	{
		// @required -(void)terminal:(SCPTerminal * _Nonnull)terminal didReportReaderSoftwareUpdateProgress:(float)progress __attribute__((swift_name("terminal(_:didReportReaderSoftwareUpdateProgress:)")));
		[Abstract]
		[Export("terminal:didReportReaderSoftwareUpdateProgress:")]
		void DidReportReaderSoftwareUpdateProgress(SCPTerminal terminal, float progress);
	}

	// @interface SCPReceiptDetails : NSObject <SCPJSONDecodable>
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SCPReceiptDetails : SCPJSONDecodable
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
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SCPRefund : SCPJSONDecodable
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
		SCPPaymentMethodDetails PaymentMethodDetails { get; }

		// @property (readonly, nonatomic) NSString * _Nullable failureReason;
		[NullAllowed, Export("failureReason")]
		string FailureReason { get; }
	}

	// @protocol SCPTerminalDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface SCPTerminalDelegate
	{
		// @required -(void)terminal:(SCPTerminal * _Nonnull)terminal didReportUnexpectedReaderDisconnect:(SCPReader * _Nonnull)reader __attribute__((swift_name("terminal(_:didReportUnexpectedReaderDisconnect:)")));
		[Abstract]
		[Export("terminal:didReportUnexpectedReaderDisconnect:")]
		void Terminal(SCPTerminal terminal, SCPReader reader);

		// @optional -(void)terminal:(SCPTerminal * _Nonnull)terminal didReportReaderEvent:(SCPReaderEvent)event info:(NSDictionary * _Nullable)info __attribute__((swift_name("terminal(_:didReportReaderEvent:info:)")));
		[Export("terminal:didReportReaderEvent:info:")]
		void Terminal(SCPTerminal terminal, SCPReaderEvent @event, [NullAllowed] NSDictionary info);

		// @optional -(void)terminalDidReportLowBatteryWarning:(SCPTerminal * _Nonnull)terminal __attribute__((swift_name("terminalDidReportLowBatteryWarning(_:)")));
		[Export("terminalDidReportLowBatteryWarning:")]
		void TerminalDidReportLowBatteryWarning(SCPTerminal terminal);

		// @optional -(void)terminal:(SCPTerminal * _Nonnull)terminal didChangeConnectionStatus:(SCPConnectionStatus)status __attribute__((swift_name("terminal(_:didChangeConnectionStatus:)")));
		[Export("terminal:didChangeConnectionStatus:")]
		void Terminal(SCPTerminal terminal, SCPConnectionStatus status);

		// @optional -(void)terminal:(SCPTerminal * _Nonnull)terminal didChangePaymentStatus:(SCPPaymentStatus)status __attribute__((swift_name("terminal(_:didChangePaymentStatus:)")));
		[Export("terminal:didChangePaymentStatus:")]
		void Terminal(SCPTerminal terminal, SCPPaymentStatus status);
	}
}
