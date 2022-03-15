using System;
using ObjCRuntime;

namespace StripeTerminal
{
	[Native]
	public enum SCPBatteryStatus : ulong
	{
		Unknown,
		Critical,
		Low,
		Nominal
	}

	[Native]
	public enum SCPReaderDisplayMessage : ulong
	{
		RetryCard,
		InsertCard,
		InsertOrSwipeCard,
		SwipeCard,
		RemoveCard,
		MultipleContactlessCardsDetected,
		TryAnotherReadMethod,
		TryAnotherCard
	}

	[Native]
	public enum SCPReaderEvent : ulong
	{
		Inserted,
		Removed
	}

	[Flags]
	[Native]
	public enum SCPReaderInputOptions : ulong
	{
		None = 0x0,
		SwipeCard = 1uL << 0,
		InsertCard = 1uL << 1,
		TapCard = 1uL << 2
	}

	[Native]
	public enum SCPCardBrand : long
	{
		Visa,
		Amex,
		MasterCard,
		Discover,
		Jcb,
		DinersClub,
		Interac,
		Unknown
	}

	[Native]
	public enum SCPCardFundingType : long
	{
		Debit,
		Credit,
		Prepaid,
		Other
	}

	[Native]
	public enum SCPChargeStatus : ulong
	{
		Succeeded,
		Pending,
		Failed
	}

	[Native]
	public enum SCPError : long
	{
		Busy = 1000,
		CancelFailedAlreadyCompleted = 1010,
		NotConnectedToReader = 1100,
		AlreadyConnectedToReader = 1110,
		ConnectionTokenProviderCompletedWithNothing = 1510,
		ProcessInvalidPaymentIntent = 1530,
		NilPaymentIntent = 1540,
		NilSetupIntent = 1542,
		NilRefundPaymentMethod = 1550,
		InvalidRefundParameters = 1555,
		InvalidClientSecret = 1560,
		MustBeDiscoveringToConnect = 1570,
		CannotConnectToUndiscoveredReader = 1580,
		InvalidDiscoveryConfiguration = 1590,
		InvalidReaderForUpdate = 1861,
		UnsupportedSDK = 1870,
		FeatureNotAvailableWithConnectedReader = 1880,
		FeatureNotAvailable = 1890,
		InvalidListLocationsLimitParameter = 1900,
		BluetoothConnectionInvalidLocationIdParameter = 1910,
		Canceled = 2020,
		LocationServicesDisabled = 2200,
		BluetoothDisabled = 2320,
		BluetoothAccessDenied = 2321,
		BluetoothScanTimedOut = 2330,
		BluetoothLowEnergyUnsupported = 2340,
		ReaderSoftwareUpdateFailedBatteryLow = 2650,
		ReaderSoftwareUpdateFailedInterrupted = 2660,
		ReaderSoftwareUpdateFailedExpiredUpdate = 2670,
		BluetoothConnectionFailedBatteryCriticallyLow = 2680,
		CardInsertNotRead = 2810,
		CardSwipeNotRead = 2820,
		CardReadTimedOut = 2830,
		CardRemoved = 2840,
		CardLeftInReader = 2850,
		ReaderBusy = 3010,
		IncompatibleReader = 3030,
		ReaderCommunicationError = 3060,
		BluetoothError = 3200,
		BluetoothConnectTimedOut = 3210,
		BluetoothDisconnected = 3230,
		BluetoothPeerRemovedPairingInformation = 3240,
		BluetoothAlreadyPairedWithAnotherDevice = 3241,
		ReaderSoftwareUpdateFailed = 3800,
		ReaderSoftwareUpdateFailedReaderError = 3830,
		ReaderSoftwareUpdateFailedServerError = 3840,
		UnsupportedReaderVersion = 3850,
		UnknownReaderIpAddress = 3860,
		InternetConnectTimeOut = 3870,
		ConnectFailedReaderIsInUse = 3880,
		UnexpectedSdkError = 5000,
		UnexpectedReaderError = 5001,
		DeclinedByStripeAPI = 6000,
		DeclinedByReader = 6500,
		CommandRequiresCardholderConsent = 6700,
		RefundFailed = 6800,
		NotConnectedToInternet = 9000,
		RequestTimedOut = 9010,
		StripeAPIError = 9020,
		StripeAPIResponseDecodingError = 9030,
		InternalNetworkError = 9040,
		ConnectionTokenProviderCompletedWithError = 9050,
		SessionExpired = 9060
	}

	[Native]
	public enum SCPConnectionStatus : ulong
	{
		NotConnected,
		Connected,
		Connecting
	}

	[Native]
	public enum SCPDeviceType : ulong
	{
		Chipper2X,
		VerifoneP400,
		WisePad3,
		StripeM2,
		WisePosE,
		Chipper1X,
		WiseCube
	}

	[Native]
	public enum SCPDiscoveryMethod : ulong
	{
		BluetoothScan,
		BluetoothProximity,
		Internet
	}

	[Native]
	public enum SCPLogLevel : ulong
	{
		None,
		Verbose
	}

	[Native]
	public enum SCPPaymentStatus : ulong
	{
		NotReady,
		Ready,
		WaitingForInput,
		Processing
	}

	[Native]
	public enum SCPPaymentIntentStatus : ulong
	{
		RequiresPaymentMethod,
		RequiresConfirmation,
		RequiresCapture,
		Processing,
		Canceled,
		Succeeded
	}

	[Native]
	public enum SCPSimulateReaderUpdate : ulong
	{
		Available = 0,
		None,
		Required,
		LowBattery,
		Random
	}

	[Native]
	public enum SCPSimulatedCardType : ulong
	{
		Visa = 0,
		VisaDebit,
		Mastercard,
		MasterDebit,
		MastercardPrepaid,
		Amex,
		Amex2,
		Discover,
		Discover2,
		Diners,
		Diners14Digit,
		Jcb,
		UnionPay,
		Interac,
		ChargeDeclined,
		ChargeDeclinedInsufficientFunds,
		ChargeDeclinedLostCard,
		ChargeDeclinedStolenCard,
		ChargeDeclinedExpiredCard,
		ChargeDeclinedProcessingError,
		RefundFailed,
		OnlinePinCvm,
		OnlinePinScaRetry,
		OfflinePinCvm,
		OfflinePinScaRetry
	}

	[Native]
	public enum SCPLocationStatus : ulong
	{
		Unknown,
		Set,
		NotSet
	}

	[Native]
	public enum SCPPaymentMethodType : ulong
	{
		Card,
		CardPresent,
		InteracPresent,
		Unknown
	}

	[Native]
	public enum SCPReaderNetworkStatus : ulong
	{
		ffline,
		nline
	}

	[Native]
	public enum SCPUpdateTimeEstimate : ulong
	{
		LessThan1Minute,
		SCPUpdateTimeEstimate1To2Minutes,
		SCPUpdateTimeEstimate2To5Minutes,
		SCPUpdateTimeEstimate5To15Minutes
	}

	[Flags]
	[Native]
	public enum SCPUpdateComponent : ulong
	{
		Incremental = 1uL << 0,
		Firmware = 1uL << 1,
		Config = 1uL << 2,
		Keys = 1uL << 3
	}

	[Native]
	public enum SCPRefundStatus : ulong
	{
		Succeeded,
		Pending,
		Failed,
		Unknown
	}

	[Native]
	public enum SCPSetupIntentStatus : ulong
	{
		RequiresPaymentMethod,
		RequiresConfirmation,
		RequiresAction,
		Processing,
		Canceled,
		Succeeded
	}

	[Native]
	public enum SCPSetupIntentUsage : ulong
	{
		ffSession,
		nSession
	}
}