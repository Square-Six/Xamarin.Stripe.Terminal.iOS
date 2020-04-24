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
	[Protocol (Name = "SCPTerminalDelegate", WrapperType = typeof (SCPTerminalDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Terminal", Selector = "terminal:didReportUnexpectedReaderDisconnect:", ParameterType = new Type [] { typeof (StripeTerminal.SCPTerminal), typeof (StripeTerminal.SCPReader) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Terminal", Selector = "terminal:didReportReaderEvent:info:", ParameterType = new Type [] { typeof (StripeTerminal.SCPTerminal), typeof (StripeTerminal.SCPReaderEvent), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TerminalDidReportLowBatteryWarning", Selector = "terminalDidReportLowBatteryWarning:", ParameterType = new Type [] { typeof (StripeTerminal.SCPTerminal) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Terminal", Selector = "terminal:didChangeConnectionStatus:", ParameterType = new Type [] { typeof (StripeTerminal.SCPTerminal), typeof (StripeTerminal.SCPConnectionStatus) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Terminal", Selector = "terminal:didChangePaymentStatus:", ParameterType = new Type [] { typeof (StripeTerminal.SCPTerminal), typeof (StripeTerminal.SCPPaymentStatus) }, ParameterByRef = new bool [] { false, false })]
	public interface ISCPTerminalDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("terminal:didReportUnexpectedReaderDisconnect:")]
		[Preserve (Conditional = true)]
		void Terminal (SCPTerminal terminal, SCPReader reader);
		
	}
	
	public static partial class SCPTerminalDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Terminal (this ISCPTerminalDelegate This, SCPTerminal terminal, SCPReaderEvent @event, NSDictionary info)
		{
			if (terminal == null)
				throw new ArgumentNullException ("terminal");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int_IntPtr (This.Handle, Selector.GetHandle ("terminal:didReportReaderEvent:info:"), terminal.Handle, (int)@event, info == null ? IntPtr.Zero : info.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void TerminalDidReportLowBatteryWarning (this ISCPTerminalDelegate This, SCPTerminal terminal)
		{
			if (terminal == null)
				throw new ArgumentNullException ("terminal");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("terminalDidReportLowBatteryWarning:"), terminal.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Terminal (this ISCPTerminalDelegate This, SCPTerminal terminal, SCPConnectionStatus status)
		{
			if (terminal == null)
				throw new ArgumentNullException ("terminal");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int (This.Handle, Selector.GetHandle ("terminal:didChangeConnectionStatus:"), terminal.Handle, (int)status);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Terminal (this ISCPTerminalDelegate This, SCPTerminal terminal, SCPPaymentStatus status)
		{
			if (terminal == null)
				throw new ArgumentNullException ("terminal");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int (This.Handle, Selector.GetHandle ("terminal:didChangePaymentStatus:"), terminal.Handle, (int)status);
		}
		
	}
	
	internal sealed class SCPTerminalDelegateWrapper : BaseWrapper, ISCPTerminalDelegate {
		[Preserve (Conditional = true)]
		public SCPTerminalDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("terminal:didReportUnexpectedReaderDisconnect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Terminal (SCPTerminal terminal, SCPReader reader)
		{
			if (terminal == null)
				throw new ArgumentNullException ("terminal");
			if (reader == null)
				throw new ArgumentNullException ("reader");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("terminal:didReportUnexpectedReaderDisconnect:"), terminal.Handle, reader.Handle);
		}
		
	}
}
namespace StripeTerminal {
	[Protocol()]
	[Register("SCPTerminalDelegate", false)]
	[Model]
	public unsafe abstract partial class SCPTerminalDelegate : NSObject, ISCPTerminalDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected SCPTerminalDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SCPTerminalDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCPTerminalDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("terminal:didReportUnexpectedReaderDisconnect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void Terminal (SCPTerminal terminal, SCPReader reader);
		[Export ("terminal:didReportReaderEvent:info:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Terminal (SCPTerminal terminal, SCPReaderEvent @event, NSDictionary info)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("terminal:didChangeConnectionStatus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Terminal (SCPTerminal terminal, SCPConnectionStatus status)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("terminal:didChangePaymentStatus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Terminal (SCPTerminal terminal, SCPPaymentStatus status)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("terminalDidReportLowBatteryWarning:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TerminalDidReportLowBatteryWarning (SCPTerminal terminal)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class SCPTerminalDelegate */
}
