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

namespace ObjCRuntime {
	
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static partial class Trampolines {
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::StripeTerminal.SCPConnectionTokenCompletionBlock))]
		internal delegate void DSCPConnectionTokenCompletionBlock (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDSCPConnectionTokenCompletionBlock {
			static internal readonly DSCPConnectionTokenCompletionBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DSCPConnectionTokenCompletionBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::StripeTerminal.SCPConnectionTokenCompletionBlock) (descriptor->Target);
				if (del != null)
					del (NSString.FromHandle (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDSCPConnectionTokenCompletionBlock */
		
		internal sealed class NIDSCPConnectionTokenCompletionBlock : TrampolineBlockBase {
			DSCPConnectionTokenCompletionBlock invoker;
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDSCPConnectionTokenCompletionBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DSCPConnectionTokenCompletionBlock> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::StripeTerminal.SCPConnectionTokenCompletionBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::StripeTerminal.SCPConnectionTokenCompletionBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDSCPConnectionTokenCompletionBlock ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (string arg0, NSError arg1)
			{
				var nsarg0 = NSString.CreateNative (arg0);
				
				invoker (BlockPointer, nsarg0, arg1 == null ? IntPtr.Zero : arg1.Handle);
				NSString.ReleaseNative (nsarg0);
				
			}
		} /* class NIDSCPConnectionTokenCompletionBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::StripeTerminal.SCPErrorCompletionBlock))]
		internal delegate void DSCPErrorCompletionBlock (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDSCPErrorCompletionBlock {
			static internal readonly DSCPErrorCompletionBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DSCPErrorCompletionBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::StripeTerminal.SCPErrorCompletionBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSError> (arg0));
			}
		} /* class SDSCPErrorCompletionBlock */
		
		internal sealed class NIDSCPErrorCompletionBlock : TrampolineBlockBase {
			DSCPErrorCompletionBlock invoker;
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDSCPErrorCompletionBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DSCPErrorCompletionBlock> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::StripeTerminal.SCPErrorCompletionBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::StripeTerminal.SCPErrorCompletionBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDSCPErrorCompletionBlock ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSError arg0)
			{
				invoker (BlockPointer, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDSCPErrorCompletionBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::StripeTerminal.SCPLogListenerBlock))]
		internal delegate void DSCPLogListenerBlock (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDSCPLogListenerBlock {
			static internal readonly DSCPLogListenerBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DSCPLogListenerBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::StripeTerminal.SCPLogListenerBlock) (descriptor->Target);
				if (del != null)
					del (NSString.FromHandle (arg0));
			}
		} /* class SDSCPLogListenerBlock */
		
		internal sealed class NIDSCPLogListenerBlock : TrampolineBlockBase {
			DSCPLogListenerBlock invoker;
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDSCPLogListenerBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DSCPLogListenerBlock> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::StripeTerminal.SCPLogListenerBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::StripeTerminal.SCPLogListenerBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDSCPLogListenerBlock ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (string arg0)
			{
				var nsarg0 = NSString.CreateNative (arg0);
				
				invoker (BlockPointer, nsarg0);
				NSString.ReleaseNative (nsarg0);
				
			}
		} /* class NIDSCPLogListenerBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::StripeTerminal.SCPPaymentIntentCompletionBlock))]
		internal delegate void DSCPPaymentIntentCompletionBlock (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDSCPPaymentIntentCompletionBlock {
			static internal readonly DSCPPaymentIntentCompletionBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DSCPPaymentIntentCompletionBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::StripeTerminal.SCPPaymentIntentCompletionBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<StripeTerminal.SCPPaymentIntent> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDSCPPaymentIntentCompletionBlock */
		
		internal sealed class NIDSCPPaymentIntentCompletionBlock : TrampolineBlockBase {
			DSCPPaymentIntentCompletionBlock invoker;
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDSCPPaymentIntentCompletionBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DSCPPaymentIntentCompletionBlock> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::StripeTerminal.SCPPaymentIntentCompletionBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::StripeTerminal.SCPPaymentIntentCompletionBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDSCPPaymentIntentCompletionBlock ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::StripeTerminal.SCPPaymentIntent arg0, NSError arg1)
			{
				invoker (BlockPointer, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDSCPPaymentIntentCompletionBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::StripeTerminal.SCPPaymentMethodCompletionBlock))]
		internal delegate void DSCPPaymentMethodCompletionBlock (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDSCPPaymentMethodCompletionBlock {
			static internal readonly DSCPPaymentMethodCompletionBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DSCPPaymentMethodCompletionBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::StripeTerminal.SCPPaymentMethodCompletionBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<StripeTerminal.SCPPaymentMethod> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDSCPPaymentMethodCompletionBlock */
		
		internal sealed class NIDSCPPaymentMethodCompletionBlock : TrampolineBlockBase {
			DSCPPaymentMethodCompletionBlock invoker;
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDSCPPaymentMethodCompletionBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DSCPPaymentMethodCompletionBlock> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::StripeTerminal.SCPPaymentMethodCompletionBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::StripeTerminal.SCPPaymentMethodCompletionBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDSCPPaymentMethodCompletionBlock ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::StripeTerminal.SCPPaymentMethod arg0, NSError arg1)
			{
				invoker (BlockPointer, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDSCPPaymentMethodCompletionBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::StripeTerminal.SCPProcessPaymentCompletionBlock))]
		internal delegate void DSCPProcessPaymentCompletionBlock (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDSCPProcessPaymentCompletionBlock {
			static internal readonly DSCPProcessPaymentCompletionBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DSCPProcessPaymentCompletionBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::StripeTerminal.SCPProcessPaymentCompletionBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<StripeTerminal.SCPPaymentIntent> (arg0),  Runtime.GetNSObject<StripeTerminal.SCPProcessPaymentError> (arg1));
			}
		} /* class SDSCPProcessPaymentCompletionBlock */
		
		internal sealed class NIDSCPProcessPaymentCompletionBlock : TrampolineBlockBase {
			DSCPProcessPaymentCompletionBlock invoker;
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDSCPProcessPaymentCompletionBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DSCPProcessPaymentCompletionBlock> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::StripeTerminal.SCPProcessPaymentCompletionBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::StripeTerminal.SCPProcessPaymentCompletionBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDSCPProcessPaymentCompletionBlock ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::StripeTerminal.SCPPaymentIntent arg0, global::StripeTerminal.SCPProcessPaymentError arg1)
			{
				invoker (BlockPointer, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDSCPProcessPaymentCompletionBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::StripeTerminal.SCPReaderCompletionBlock))]
		internal delegate void DSCPReaderCompletionBlock (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDSCPReaderCompletionBlock {
			static internal readonly DSCPReaderCompletionBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DSCPReaderCompletionBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::StripeTerminal.SCPReaderCompletionBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<StripeTerminal.SCPReader> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDSCPReaderCompletionBlock */
		
		internal sealed class NIDSCPReaderCompletionBlock : TrampolineBlockBase {
			DSCPReaderCompletionBlock invoker;
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDSCPReaderCompletionBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DSCPReaderCompletionBlock> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::StripeTerminal.SCPReaderCompletionBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::StripeTerminal.SCPReaderCompletionBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDSCPReaderCompletionBlock ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::StripeTerminal.SCPReader arg0, NSError arg1)
			{
				invoker (BlockPointer, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDSCPReaderCompletionBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::StripeTerminal.SCPReaderSoftwareUpdateCompletionBlock))]
		internal delegate void DSCPReaderSoftwareUpdateCompletionBlock (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDSCPReaderSoftwareUpdateCompletionBlock {
			static internal readonly DSCPReaderSoftwareUpdateCompletionBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DSCPReaderSoftwareUpdateCompletionBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::StripeTerminal.SCPReaderSoftwareUpdateCompletionBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<StripeTerminal.SCPReaderSoftwareUpdate> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDSCPReaderSoftwareUpdateCompletionBlock */
		
		internal sealed class NIDSCPReaderSoftwareUpdateCompletionBlock : TrampolineBlockBase {
			DSCPReaderSoftwareUpdateCompletionBlock invoker;
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDSCPReaderSoftwareUpdateCompletionBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DSCPReaderSoftwareUpdateCompletionBlock> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::StripeTerminal.SCPReaderSoftwareUpdateCompletionBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::StripeTerminal.SCPReaderSoftwareUpdateCompletionBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDSCPReaderSoftwareUpdateCompletionBlock ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::StripeTerminal.SCPReaderSoftwareUpdate arg0, NSError arg1)
			{
				invoker (BlockPointer, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDSCPReaderSoftwareUpdateCompletionBlock */
	}
}
