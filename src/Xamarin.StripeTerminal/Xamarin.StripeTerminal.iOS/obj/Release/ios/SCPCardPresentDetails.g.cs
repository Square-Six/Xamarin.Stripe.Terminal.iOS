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
	[Register("SCPCardPresentDetails", true)]
	public unsafe partial class SCPCardPresentDetails : NSObject, ISCPJSONDecodable {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("SCPCardPresentDetails");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SCPCardPresentDetails (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCPCardPresentDetails (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("decodedObjectFromJSON:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCPJSONDecodable DecodedObjectFromJSON (NSDictionary json)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<SCPJSONDecodable> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("decodedObjectFromJSON:"), json == null ? IntPtr.Zero : json.Handle));
			} else {
				return  Runtime.GetNSObject<SCPJSONDecodable> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("decodedObjectFromJSON:"), json == null ? IntPtr.Zero : json.Handle));
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCPCardBrand Brand {
			[Export ("brand")]
			get {
				if (IsDirectBinding) {
					return (SCPCardBrand) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("brand"));
				} else {
					return (SCPCardBrand) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("brand"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string EmvAuthData {
			[Export ("emvAuthData")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("emvAuthData")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("emvAuthData")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ExpMonth {
			[Export ("expMonth")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("expMonth"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("expMonth"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ExpYear {
			[Export ("expYear")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("expYear"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("expYear"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Fingerprint {
			[Export ("fingerprint")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fingerprint")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fingerprint")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCPCardFundingType Funding {
			[Export ("funding")]
			get {
				if (IsDirectBinding) {
					return (SCPCardFundingType) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("funding"));
				} else {
					return (SCPCardFundingType) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("funding"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GeneratedCard {
			[Export ("generatedCard")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("generatedCard")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("generatedCard")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Last4 {
			[Export ("last4")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("last4")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("last4")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary OriginalJSON {
			[Export ("originalJSON")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("originalJSON")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("originalJSON")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCPReceiptDetails Receipt {
			[Export ("receipt")]
			get {
				SCPReceiptDetails ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCPReceiptDetails> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("receipt")));
				} else {
					ret =  Runtime.GetNSObject<SCPReceiptDetails> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("receipt")));
				}
				return ret;
			}
			
		}
		
	} /* class SCPCardPresentDetails */
}
