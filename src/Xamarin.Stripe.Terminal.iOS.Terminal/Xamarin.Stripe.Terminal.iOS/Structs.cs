using System;
using ObjCRuntime;

namespace StripeTerminal
{ 
	public enum SCPCardBrand
	{
		Visa,
		Amex,
		MasterCard,
		Discover,
		Jcb,
		DinersClub,
		Unknown
	}

	public enum SCPCardFundingType
	{
		Debit,
		Credit,
		Prepaid,
		Other
	}

	public enum SCPChargeStatus
	{
		Succeeded,
		Pending,
		Failed
	}

	public enum SCPConnectionStatus
	{
		NotConnected,
		Connected,
		Connecting
	}

	public enum SCPDeviceType
	{
		SCPDeviceTypeChipper2X
	}

	public enum SCPDiscoveryMethod
	{
		Scan,
		Proximity
	}

	public enum SCPPaymentStatus
	{
		NotReady,
		Ready,
		WaitingForInput,
		Processing
	}

	public enum SCPReaderInputOptions 
	{
		None = 0,
		SwipeCard = 1 << 0,
		InsertCard = 1 << 1,
		TapCard = 1 << 2
	}

	public enum SCPReaderDisplayMessage
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

	public enum SCPReaderEvent
	{
		Inserted,
		Removed
	}

	public enum SCPLogLevel
	{
		None,
		Verbose
	}

	public enum SCPError
	{
		Busy = 1000,
		CancelFailedAlreadyCompleted = 1010,
		NotConnectedToReader = 1100,
		AlreadyConnectedToReader = 1110,
		ConnectionTokenProviderCompletedWithNothing = 1510,
		ProcessInvalidPaymentIntent = 1530,
		NilPaymentIntent = 1540,
		InvalidClientSecret = 1560,
		MustBeDiscoveringToConnect = 1570,
		CannotConnectToUndiscoveredReader = 1580,
		InvalidDiscoveryConfiguration = 1590,
		NilReaderDisplayDelegate = 1850,
		NilUpdate = 1860,
		UnsupportedSDK = 1870,
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
		UnexpectedSdkError = 5000,
		PaymentDeclinedByStripeAPI = 6000,
		PaymentDeclinedByReader = 6500,
		NotConnectedToInternet = 9000,
		RequestTimedOut = 9010,
		StripeAPIError = 9020,
		StripeAPIResponseDecodingError = 9030,
		InternalNetworkError = 9040,
		ConnectionTokenProviderCompletedWithError = 9050,
		SessionExpired = 9060
	}

	public enum SCPPaymentIntentStatus
	{
		RequiresPaymentMethod,
		RequiresConfirmation,
		RequiresCapture,
		Canceled,
		Succeeded
	}

	public enum SCPPaymentMethodType
	{
		Card,
		CardPresent,
		Unknown
	}

	public enum SCPUpdateTimeEstimate
	{
		LessThan1Minute,
		SCPUpdateTimeEstimate1To2Minutes,
		SCPUpdateTimeEstimate2To5Minutes,
		SCPUpdateTimeEstimate5To15Minutes
	}
}