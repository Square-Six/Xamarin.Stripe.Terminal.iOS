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
	[Protocol (Name = "SCPJSONDecodable", WrapperType = typeof (SCPJSONDecodableWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DecodedObjectFromJSON", Selector = "decodedObjectFromJSON:", ReturnType = typeof (StripeTerminal.SCPJSONDecodable), ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "OriginalJSON", Selector = "originalJSON", PropertyType = typeof (NSDictionary), GetterSelector = "originalJSON", ArgumentSemantic = ArgumentSemantic.None)]
	public interface ISCPJSONDecodable : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("decodedObjectFromJSON:")]
		[Preserve (Conditional = true)]
		SCPJSONDecodable DecodedObjectFromJSON (NSDictionary json);
		
		[Preserve (Conditional = true)]
		NSDictionary OriginalJSON {
			[Export ("originalJSON")]
			get;
		}
		
	}
	
	internal sealed class SCPJSONDecodableWrapper : BaseWrapper, ISCPJSONDecodable {
		[Preserve (Conditional = true)]
		public SCPJSONDecodableWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("decodedObjectFromJSON:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SCPJSONDecodable DecodedObjectFromJSON (NSDictionary json)
		{
			return  Runtime.GetNSObject<SCPJSONDecodable> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("decodedObjectFromJSON:"), json == null ? IntPtr.Zero : json.Handle));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary OriginalJSON {
			[Export ("originalJSON")]
			get {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("originalJSON")));
			}
			
		}
		
	}
}
namespace StripeTerminal {
	[Protocol()]
	[Register("SCPJSONDecodable", false)]
	[Model]
	public unsafe abstract partial class SCPJSONDecodable : NSObject, ISCPJSONDecodable {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected SCPJSONDecodable () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SCPJSONDecodable (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCPJSONDecodable (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("decodedObjectFromJSON:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract SCPJSONDecodable DecodedObjectFromJSON (NSDictionary json);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract NSDictionary OriginalJSON {
			[Export ("originalJSON")]
			get; 
		}
		
	} /* class SCPJSONDecodable */
}
