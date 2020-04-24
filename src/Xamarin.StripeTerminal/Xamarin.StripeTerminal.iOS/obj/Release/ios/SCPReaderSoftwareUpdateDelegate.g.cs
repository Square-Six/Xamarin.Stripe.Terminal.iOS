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
	[Protocol (Name = "SCPReaderSoftwareUpdateDelegate", WrapperType = typeof (SCPReaderSoftwareUpdateDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReportReaderSoftwareUpdateProgress", Selector = "terminal:didReportReaderSoftwareUpdateProgress:", ParameterType = new Type [] { typeof (StripeTerminal.SCPTerminal), typeof (float) }, ParameterByRef = new bool [] { false, false })]
	public interface ISCPReaderSoftwareUpdateDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("terminal:didReportReaderSoftwareUpdateProgress:")]
		[Preserve (Conditional = true)]
		void DidReportReaderSoftwareUpdateProgress (SCPTerminal terminal, float progress);
		
	}
	
	internal sealed class SCPReaderSoftwareUpdateDelegateWrapper : BaseWrapper, ISCPReaderSoftwareUpdateDelegate {
		[Preserve (Conditional = true)]
		public SCPReaderSoftwareUpdateDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("terminal:didReportReaderSoftwareUpdateProgress:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidReportReaderSoftwareUpdateProgress (SCPTerminal terminal, float progress)
		{
			if (terminal == null)
				throw new ArgumentNullException ("terminal");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_float (this.Handle, Selector.GetHandle ("terminal:didReportReaderSoftwareUpdateProgress:"), terminal.Handle, progress);
		}
		
	}
}
namespace StripeTerminal {
	[Protocol()]
	[Register("SCPReaderSoftwareUpdateDelegate", false)]
	[Model]
	public unsafe abstract partial class SCPReaderSoftwareUpdateDelegate : NSObject, ISCPReaderSoftwareUpdateDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected SCPReaderSoftwareUpdateDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SCPReaderSoftwareUpdateDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCPReaderSoftwareUpdateDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("terminal:didReportReaderSoftwareUpdateProgress:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DidReportReaderSoftwareUpdateProgress (SCPTerminal terminal, float progress);
	} /* class SCPReaderSoftwareUpdateDelegate */
}
