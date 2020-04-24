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
	[Protocol (Name = "SCPDiscoveryDelegate", WrapperType = typeof (SCPDiscoveryDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidUpdateDiscoveredReaders", Selector = "terminal:didUpdateDiscoveredReaders:", ParameterType = new Type [] { typeof (StripeTerminal.SCPTerminal), typeof (StripeTerminal.SCPReader[]) }, ParameterByRef = new bool [] { false, false })]
	public interface ISCPDiscoveryDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("terminal:didUpdateDiscoveredReaders:")]
		[Preserve (Conditional = true)]
		void DidUpdateDiscoveredReaders (SCPTerminal terminal, SCPReader[] readers);
		
	}
	
	internal sealed class SCPDiscoveryDelegateWrapper : BaseWrapper, ISCPDiscoveryDelegate {
		[Preserve (Conditional = true)]
		public SCPDiscoveryDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("terminal:didUpdateDiscoveredReaders:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidUpdateDiscoveredReaders (SCPTerminal terminal, SCPReader[] readers)
		{
			if (terminal == null)
				throw new ArgumentNullException ("terminal");
			if (readers == null)
				throw new ArgumentNullException ("readers");
			var nsa_readers = NSArray.FromNSObjects (readers);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("terminal:didUpdateDiscoveredReaders:"), terminal.Handle, nsa_readers.Handle);
			nsa_readers.Dispose ();
			
		}
		
	}
}
namespace StripeTerminal {
	[Protocol()]
	[Register("SCPDiscoveryDelegate", false)]
	[Model]
	public unsafe abstract partial class SCPDiscoveryDelegate : NSObject, ISCPDiscoveryDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected SCPDiscoveryDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SCPDiscoveryDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCPDiscoveryDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("terminal:didUpdateDiscoveredReaders:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DidUpdateDiscoveredReaders (SCPTerminal terminal, SCPReader[] readers);
	} /* class SCPDiscoveryDelegate */
}
