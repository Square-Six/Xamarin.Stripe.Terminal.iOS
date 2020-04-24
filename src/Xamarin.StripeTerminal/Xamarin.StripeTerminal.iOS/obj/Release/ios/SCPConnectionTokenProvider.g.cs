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
	[Protocol (Name = "SCPConnectionTokenProvider", WrapperType = typeof (SCPConnectionTokenProviderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FetchConnectionToken", Selector = "fetchConnectionToken:", ParameterType = new Type [] { typeof (StripeTerminal.SCPConnectionTokenCompletionBlock) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type [] { typeof (ObjCRuntime.Trampolines.NIDSCPConnectionTokenCompletionBlock) })]
	public interface ISCPConnectionTokenProvider : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("fetchConnectionToken:")]
		[Preserve (Conditional = true)]
		unsafe void FetchConnectionToken ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSCPConnectionTokenCompletionBlock))]SCPConnectionTokenCompletionBlock completion);
		
	}
	
	internal sealed class SCPConnectionTokenProviderWrapper : BaseWrapper, ISCPConnectionTokenProvider {
		[Preserve (Conditional = true)]
		public SCPConnectionTokenProviderWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("fetchConnectionToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void FetchConnectionToken ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSCPConnectionTokenCompletionBlock))]SCPConnectionTokenCompletionBlock completion)
		{
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDSCPConnectionTokenCompletionBlock.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("fetchConnectionToken:"), (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
	}
}
namespace StripeTerminal {
	[Protocol()]
	[Register("SCPConnectionTokenProvider", false)]
	[Model]
	public unsafe abstract partial class SCPConnectionTokenProvider : NSObject, ISCPConnectionTokenProvider {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected SCPConnectionTokenProvider () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SCPConnectionTokenProvider (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCPConnectionTokenProvider (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("fetchConnectionToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe abstract void FetchConnectionToken ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSCPConnectionTokenCompletionBlock))]SCPConnectionTokenCompletionBlock completion);
	} /* class SCPConnectionTokenProvider */
}
