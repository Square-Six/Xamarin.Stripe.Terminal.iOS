using System;
using ObjCRuntime;

namespace StripeTerminal
{
	[Native]
	public enum SCPCardBrand : long
	{
		Visa,
		Amex,
		MasterCard,
		Discover,
		Jcb,
		DinersClub,
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
		WisePosE
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
	public enum SCPReaderEvent : ulong
	{
		Inserted,
		Removed
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
	public enum SCPError : long
	{
		Busy = 1000,
		CancelFailedAlreadyCompleted = 1010,
		NotConnectedToReader = 1100,
		AlreadyConnectedToReader = 1110,
		ConnectionTokenProviderCompletedWithNothing = 1510,
		ProcessInvalidPaymentIntent = 1530,
		NilPaymentIntent = 1540,
		NilRefundPaymentMethod = 1550,
		InvalidRefundParameters = 1555,
		InvalidClientSecret = 1560,
		MustBeDiscoveringToConnect = 1570,
		CannotConnectToUndiscoveredReader = 1580,
		InvalidDiscoveryConfiguration = 1590,
		InvalidCart = 1600,
		NilReaderDisplayDelegate = 1850,
		NilUpdate = 1860,
		UnsupportedSDK = 1870,
		FeatureNotAvailableWithConnectedReader = 1880,
		Canceled = 2020,
		LocationServicesDisabled = 2200,
		BluetoothDisabled = 2320,
		BluetoothScanTimedOut = 2330,
		BluetoothLowEnergyUnsupported = 2340,
		ReaderSoftwareUpdateFailedBatteryLow = 2650,
		ReaderSoftwareUpdateFailedInterrupted = 2660,
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
		ReaderSoftwareUpdateFailed = 3800,
		ReaderSoftwareUpdateFailedReaderError = 3830,
		ReaderSoftwareUpdateFailedServerError = 3840,
		UnsupportedReaderVersion = 3850,
		UnknownReaderIpAddress = 3860,
		InternetConnectTimeOut = 3870,
		ConnectFailedReaderIsInUse = 3880,
		UnexpectedSdkError = 5000,
		PaymentDeclinedByStripeAPI = 6000,
		PaymentDeclinedByReader = 6500,
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
	public enum SCPPaymentMethodType : ulong
	{
		Card,
		CardPresent,
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

	[Native]
	public enum SCPRefundStatus : ulong
	{
		Succeeded,
		Pending,
		Failed,
		Unknown
	}
}