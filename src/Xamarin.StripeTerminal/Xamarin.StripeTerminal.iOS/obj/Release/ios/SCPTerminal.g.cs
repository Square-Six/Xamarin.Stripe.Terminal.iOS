//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;

namespace StripeTerminal {
	[Register("SCPTerminal", true)]
	public unsafe partial class SCPTerminal : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("SCPTerminal");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SCPTerminal (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCPTerminal (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("cancelPaymentIntent:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CancelPaymentIntent (SCPPaymentIntent paymentIntent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSCPPaymentIntentCompletionBlock))]SCPPaymentIntentCompletionBlock completion)
		{
			if (paymentIntent == null)
				throw new ArgumentNullException ("paymentIntent");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDSCPPaymentIntentCompletionBlock.Handler, completion);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("cancelPaymentIntent:completion:"), paymentIntent.Handle, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("cancelPaymentIntent:completion:"), paymentIntent.Handle, (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("checkForUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual SCPCancelable CheckForUpdate ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSCPReaderSoftwareUpdateCompletionBlock))]SCPReaderSoftwareUpdateCompletionBlock completion)
		{
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDSCPReaderSoftwareUpdateCompletionBlock.Handler, completion);
			
			SCPCancelable ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SCPCancelable> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("checkForUpdate:"), (IntPtr) block_ptr_completion));
			} else {
				ret =  Runtime.GetNSObject<SCPCancelable> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("checkForUpdate:"), (IntPtr) block_ptr_completion));
			}
			block_ptr_completion->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("clearCachedCredentials")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ClearCachedCredentials ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("clearCachedCredentials"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clearCachedCredentials"));
			}
		}
		
		[Export ("collectPaymentMethod:delegate:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual SCPCancelable CollectPaymentMethod (SCPPaymentIntent paymentIntent, SCPReaderDisplayDelegate @delegate, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSCPPaymentIntentCompletionBlock))]SCPPaymentIntentCompletionBlock completion)
		{
			if (paymentIntent == null)
				throw new ArgumentNullException ("paymentIntent");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDSCPPaymentIntentCompletionBlock.Handler, completion);
			
			SCPCancelable ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SCPCancelable> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("collectPaymentMethod:delegate:completion:"), paymentIntent.Handle, @delegate == null ? IntPtr.Zero : @delegate.Handle, (IntPtr) block_ptr_completion));
			} else {
				ret =  Runtime.GetNSObject<SCPCancelable> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("collectPaymentMethod:delegate:completion:"), paymentIntent.Handle, @delegate == null ? IntPtr.Zero : @delegate.Handle, (IntPtr) block_ptr_completion));
			}
			block_ptr_completion->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("connectReader:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ConnectReader (SCPReader reader, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSCPReaderCompletionBlock))]SCPReaderCompletionBlock completion)
		{
			if (reader == null)
				throw new ArgumentNullException ("reader");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDSCPReaderCompletionBlock.Handler, completion);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("connectReader:completion:"), reader.Handle, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("connectReader:completion:"), reader.Handle, (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("createPaymentIntent:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CreatePaymentIntent (SCPPaymentIntentParameters parameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSCPPaymentIntentCompletionBlock))]SCPPaymentIntentCompletionBlock completion)
		{
			if (parameters == null)
				throw new ArgumentNullException ("parameters");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDSCPPaymentIntentCompletionBlock.Handler, completion);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("createPaymentIntent:completion:"), parameters.Handle, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("createPaymentIntent:completion:"), parameters.Handle, (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("disconnectReader:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DisconnectReader ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSCPErrorCompletionBlock))]SCPErrorCompletionBlock completion)
		{
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDSCPErrorCompletionBlock.Handler, completion);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("disconnectReader:"), (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("disconnectReader:"), (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("discoverReaders:delegate:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual SCPCancelable DiscoverReaders (SCPDiscoveryConfiguration configuration, SCPDiscoveryDelegate @delegate, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSCPErrorCompletionBlock))]SCPErrorCompletionBlock completion)
		{
			if (configuration == null)
				throw new ArgumentNullException ("configuration");
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDSCPErrorCompletionBlock.Handler, completion);
			
			SCPCancelable ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SCPCancelable> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("discoverReaders:delegate:completion:"), configuration.Handle, @delegate.Handle, (IntPtr) block_ptr_completion));
			} else {
				ret =  Runtime.GetNSObject<SCPCancelable> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("discoverReaders:delegate:completion:"), configuration.Handle, @delegate.Handle, (IntPtr) block_ptr_completion));
			}
			block_ptr_completion->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("installUpdate:delegate:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual SCPCancelable InstallUpdate (SCPReaderSoftwareUpdate update, SCPReaderSoftwareUpdateDelegate @delegate, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSCPErrorCompletionBlock))]SCPErrorCompletionBlock completion)
		{
			if (update == null)
				throw new ArgumentNullException ("update");
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDSCPErrorCompletionBlock.Handler, completion);
			
			SCPCancelable ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SCPCancelable> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("installUpdate:delegate:completion:"), update.Handle, @delegate.Handle, (IntPtr) block_ptr_completion));
			} else {
				ret =  Runtime.GetNSObject<SCPCancelable> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("installUpdate:delegate:completion:"), update.Handle, @delegate.Handle, (IntPtr) block_ptr_completion));
			}
			block_ptr_completion->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("processPayment:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ProcessPayment (SCPPaymentIntent paymentIntent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSCPProcessPaymentCompletionBlock))]SCPProcessPaymentCompletionBlock completion)
		{
			if (paymentIntent == null)
				throw new ArgumentNullException ("paymentIntent");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDSCPProcessPaymentCompletionBlock.Handler, completion);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("processPayment:completion:"), paymentIntent.Handle, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("processPayment:completion:"), paymentIntent.Handle, (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("readReusableCard:delegate:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual SCPCancelable ReadReusableCard (SCPReadReusableCardParameters parameters, SCPReaderDisplayDelegate @delegate, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSCPPaymentMethodCompletionBlock))]SCPPaymentMethodCompletionBlock completion)
		{
			if (parameters == null)
				throw new ArgumentNullException ("parameters");
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDSCPPaymentMethodCompletionBlock.Handler, completion);
			
			SCPCancelable ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SCPCancelable> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("readReusableCard:delegate:completion:"), parameters.Handle, @delegate.Handle, (IntPtr) block_ptr_completion));
			} else {
				ret =  Runtime.GetNSObject<SCPCancelable> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("readReusableCard:delegate:completion:"), parameters.Handle, @delegate.Handle, (IntPtr) block_ptr_completion));
			}
			block_ptr_completion->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("retrievePaymentIntent:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RetrievePaymentIntent (string clientSecret, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSCPPaymentIntentCompletionBlock))]SCPPaymentIntentCompletionBlock completion)
		{
			if (clientSecret == null)
				throw new ArgumentNullException ("clientSecret");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			var nsclientSecret = NSString.CreateNative (clientSecret);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDSCPPaymentIntentCompletionBlock.Handler, completion);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("retrievePaymentIntent:completion:"), nsclientSecret, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("retrievePaymentIntent:completion:"), nsclientSecret, (IntPtr) block_ptr_completion);
			}
			NSString.ReleaseNative (nsclientSecret);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("setLogListener:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SetLogListener ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSCPLogListenerBlock))]SCPLogListenerBlock listener)
		{
			if (listener == null)
				throw new ArgumentNullException ("listener");
			BlockLiteral *block_ptr_listener;
			BlockLiteral block_listener;
			block_listener = new BlockLiteral ();
			block_ptr_listener = &block_listener;
			block_listener.SetupBlockUnsafe (Trampolines.SDSCPLogListenerBlock.Handler, listener);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setLogListener:"), (IntPtr) block_ptr_listener);
			block_ptr_listener->CleanupBlock ();
			
		}
		
		[Export ("setTokenProvider:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetTokenProvider (SCPConnectionTokenProvider tokenProvider)
		{
			if (tokenProvider == null)
				throw new ArgumentNullException ("tokenProvider");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setTokenProvider:"), tokenProvider.Handle);
		}
		
		[Export ("stringFromConnectionStatus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string StringFromConnectionStatus (SCPConnectionStatus status)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int (class_ptr, Selector.GetHandle ("stringFromConnectionStatus:"), (int)status));
		}
		
		[Export ("stringFromDeviceType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string StringFromDeviceType (SCPDeviceType deviceType)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int (class_ptr, Selector.GetHandle ("stringFromDeviceType:"), (int)deviceType));
		}
		
		[Export ("stringFromDiscoveryMethod:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string StringFromDiscoveryMethod (SCPDiscoveryMethod method)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int (class_ptr, Selector.GetHandle ("stringFromDiscoveryMethod:"), (int)method));
		}
		
		[Export ("stringFromPaymentStatus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string StringFromPaymentStatus (SCPPaymentStatus status)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int (class_ptr, Selector.GetHandle ("stringFromPaymentStatus:"), (int)status));
		}
		
		[Export ("stringFromReaderDisplayMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string StringFromReaderDisplayMessage (SCPReaderDisplayMessage message)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int (class_ptr, Selector.GetHandle ("stringFromReaderDisplayMessage:"), (int)message));
		}
		
		[Export ("stringFromReaderEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string StringFromReaderEvent (SCPReaderEvent @event)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int (class_ptr, Selector.GetHandle ("stringFromReaderEvent:"), (int)@event));
		}
		
		[Export ("stringFromReaderInputOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string StringFromReaderInputOptions (SCPReaderInputOptions options)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int (class_ptr, Selector.GetHandle ("stringFromReaderInputOptions:"), (int)options));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCPReader ConnectedReader {
			[Export ("connectedReader")]
			get {
				SCPReader ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCPReader> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("connectedReader")));
				} else {
					ret =  Runtime.GetNSObject<SCPReader> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("connectedReader")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCPConnectionStatus ConnectionStatus {
			[Export ("connectionStatus")]
			get {
				if (IsDirectBinding) {
					return (SCPConnectionStatus) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("connectionStatus"));
				} else {
					return (SCPConnectionStatus) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("connectionStatus"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SCPTerminalDelegate Delegate {
			get {
				return WeakDelegate as SCPTerminalDelegate;
			}
			set {
				var rvalue = value as NSObject;
				if (value != null && rvalue == null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HasTokenProvider {
			[Export ("hasTokenProvider")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("hasTokenProvider"));
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCPLogLevel LogLevel {
			[Export ("logLevel", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (SCPLogLevel) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("logLevel"));
				} else {
					return (SCPLogLevel) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("logLevel"));
				}
			}
			
			[Export ("setLogLevel:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setLogLevel:"), (int)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setLogLevel:"), (int)value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCPPaymentStatus PaymentStatus {
			[Export ("paymentStatus")]
			get {
				if (IsDirectBinding) {
					return (SCPPaymentStatus) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("paymentStatus"));
				} else {
					return (SCPPaymentStatus) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("paymentStatus"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCPTerminal Shared {
			[Export ("shared")]
			get {
				SCPTerminal ret;
				ret =  Runtime.GetNSObject<SCPTerminal> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("shared")));
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class SCPTerminal */
}
