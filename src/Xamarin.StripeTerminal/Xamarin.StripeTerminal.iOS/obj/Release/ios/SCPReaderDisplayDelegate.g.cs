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
	[Protocol (Name = "SCPReaderDisplayDelegate", WrapperType = typeof (SCPReaderDisplayDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidRequestReaderInput", Selector = "terminal:didRequestReaderInput:", ParameterType = new Type [] { typeof (StripeTerminal.SCPTerminal), typeof (StripeTerminal.SCPReaderInputOptions) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidRequestReaderDisplayMessage", Selector = "terminal:didRequestReaderDisplayMessage:", ParameterType = new Type [] { typeof (StripeTerminal.SCPTerminal), typeof (StripeTerminal.SCPReaderDisplayMessage) }, ParameterByRef = new bool [] { false, false })]
	public interface ISCPReaderDisplayDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("terminal:didRequestReaderInput:")]
		[Preserve (Conditional = true)]
		void DidRequestReaderInput (SCPTerminal terminal, SCPReaderInputOptions inputOptions);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("terminal:didRequestReaderDisplayMessage:")]
		[Preserve (Conditional = true)]
		void DidRequestReaderDisplayMessage (SCPTerminal terminal, SCPReaderDisplayMessage displayMessage);
		
	}
	
	internal sealed class SCPReaderDisplayDelegateWrapper : BaseWrapper, ISCPReaderDisplayDelegate {
		[Preserve (Conditional = true)]
		public SCPReaderDisplayDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("terminal:didRequestReaderInput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidRequestReaderInput (SCPTerminal terminal, SCPReaderInputOptions inputOptions)
		{
			if (terminal == null)
				throw new ArgumentNullException ("terminal");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int (this.Handle, Selector.GetHandle ("terminal:didRequestReaderInput:"), terminal.Handle, (int)inputOptions);
		}
		
		[Export ("terminal:didRequestReaderDisplayMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidRequestReaderDisplayMessage (SCPTerminal terminal, SCPReaderDisplayMessage displayMessage)
		{
			if (terminal == null)
				throw new ArgumentNullException ("terminal");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int (this.Handle, Selector.GetHandle ("terminal:didRequestReaderDisplayMessage:"), terminal.Handle, (int)displayMessage);
		}
		
	}
}
namespace StripeTerminal {
	[Protocol()]
	[Register("SCPReaderDisplayDelegate", false)]
	[Model]
	public unsafe abstract partial class SCPReaderDisplayDelegate : NSObject, ISCPReaderDisplayDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected SCPReaderDisplayDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SCPReaderDisplayDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCPReaderDisplayDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("terminal:didRequestReaderDisplayMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DidRequestReaderDisplayMessage (SCPTerminal terminal, SCPReaderDisplayMessage displayMessage);
		[Export ("terminal:didRequestReaderInput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DidRequestReaderInput (SCPTerminal terminal, SCPReaderInputOptions inputOptions);
	} /* class SCPReaderDisplayDelegate */
}
