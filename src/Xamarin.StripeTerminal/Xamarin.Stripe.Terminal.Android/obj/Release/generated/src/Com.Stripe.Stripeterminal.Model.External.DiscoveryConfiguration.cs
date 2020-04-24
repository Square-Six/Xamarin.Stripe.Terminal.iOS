using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal.Model.External {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='DiscoveryConfiguration']"
	[global::Android.Runtime.Register ("com/stripe/stripeterminal/model/external/DiscoveryConfiguration", DoNotGenerateAcw=true)]
	public sealed partial class DiscoveryConfiguration : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/model/external/DiscoveryConfiguration", typeof (DiscoveryConfiguration));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal DiscoveryConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='DiscoveryConfiguration']/constructor[@name='DiscoveryConfiguration' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DiscoveryConfiguration ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='DiscoveryConfiguration']/constructor[@name='DiscoveryConfiguration' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe DiscoveryConfiguration (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='DiscoveryConfiguration']/constructor[@name='DiscoveryConfiguration' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.stripe.stripeterminal.model.external.DeviceType']]"
		[Register (".ctor", "(ILcom/stripe/stripeterminal/model/external/DeviceType;)V", "")]
		public unsafe DiscoveryConfiguration (int p0, global::Com.Stripe.Stripeterminal.Model.External.DeviceType p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILcom/stripe/stripeterminal/model/external/DeviceType;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='DiscoveryConfiguration']/constructor[@name='DiscoveryConfiguration' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.stripe.stripeterminal.model.external.DeviceType'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(ILcom/stripe/stripeterminal/model/external/DeviceType;Z)V", "")]
		public unsafe DiscoveryConfiguration (int timeout, global::Com.Stripe.Stripeterminal.Model.External.DeviceType deviceType, bool isSimulated)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILcom/stripe/stripeterminal/model/external/DeviceType;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (timeout);
				__args [1] = new JniArgumentValue ((deviceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) deviceType).Handle);
				__args [2] = new JniArgumentValue (isSimulated);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe global::Com.Stripe.Stripeterminal.Model.External.DeviceType DeviceType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='DiscoveryConfiguration']/method[@name='getDeviceType' and count(parameter)=0]"
			[Register ("getDeviceType", "()Lcom/stripe/stripeterminal/model/external/DeviceType;", "")]
			get {
				const string __id = "getDeviceType.()Lcom/stripe/stripeterminal/model/external/DeviceType;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.DeviceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsSimulated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='DiscoveryConfiguration']/method[@name='isSimulated' and count(parameter)=0]"
			[Register ("isSimulated", "()Z", "")]
			get {
				const string __id = "isSimulated.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int Timeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='DiscoveryConfiguration']/method[@name='getTimeout' and count(parameter)=0]"
			[Register ("getTimeout", "()I", "")]
			get {
				const string __id = "getTimeout.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='DiscoveryConfiguration']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()I", "")]
		public unsafe int Component1 ()
		{
			const string __id = "component1.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='DiscoveryConfiguration']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()Lcom/stripe/stripeterminal/model/external/DeviceType;", "")]
		public unsafe global::Com.Stripe.Stripeterminal.Model.External.DeviceType Component2 ()
		{
			const string __id = "component2.()Lcom/stripe/stripeterminal/model/external/DeviceType;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.DeviceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='DiscoveryConfiguration']/method[@name='component3' and count(parameter)=0]"
		[Register ("component3", "()Z", "")]
		public unsafe bool Component3 ()
		{
			const string __id = "component3.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='DiscoveryConfiguration']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.stripe.stripeterminal.model.external.DeviceType'] and parameter[3][@type='boolean']]"
		[Register ("copy", "(ILcom/stripe/stripeterminal/model/external/DeviceType;Z)Lcom/stripe/stripeterminal/model/external/DiscoveryConfiguration;", "")]
		public unsafe global::Com.Stripe.Stripeterminal.Model.External.DiscoveryConfiguration Copy (int timeout, global::Com.Stripe.Stripeterminal.Model.External.DeviceType deviceType, bool isSimulated)
		{
			const string __id = "copy.(ILcom/stripe/stripeterminal/model/external/DeviceType;Z)Lcom/stripe/stripeterminal/model/external/DiscoveryConfiguration;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (timeout);
				__args [1] = new JniArgumentValue ((deviceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) deviceType).Handle);
				__args [2] = new JniArgumentValue (isSimulated);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.DiscoveryConfiguration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
