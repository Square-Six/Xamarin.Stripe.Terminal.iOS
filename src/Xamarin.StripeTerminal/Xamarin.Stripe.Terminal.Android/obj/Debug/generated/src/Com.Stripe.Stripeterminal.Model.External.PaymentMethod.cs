using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal.Model.External {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentMethod']"
	[global::Android.Runtime.Register ("com/stripe/stripeterminal/model/external/PaymentMethod", DoNotGenerateAcw=true)]
	public sealed partial class PaymentMethod : global::Java.Lang.Object, global::Android.OS.IParcelable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentMethod.Creator']"
		[global::Android.Runtime.Register ("com/stripe/stripeterminal/model/external/PaymentMethod$Creator", DoNotGenerateAcw=true)]
		public sealed partial class Creator : global::Java.Lang.Object, global::Android.OS.IParcelableCreator {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/model/external/PaymentMethod$Creator", typeof (Creator));
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

			internal Creator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentMethod.Creator']/constructor[@name='PaymentMethod.Creator' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Creator ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentMethod.Creator']/method[@name='createFromParcel' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
			[Register ("createFromParcel", "(Landroid/os/Parcel;)Ljava/lang/Object;", "")]
			public unsafe global::Java.Lang.Object CreateFromParcel (global::Android.OS.Parcel @in)
			{
				const string __id = "createFromParcel.(Landroid/os/Parcel;)Ljava/lang/Object;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((@in == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @in).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentMethod.Creator']/method[@name='newArray' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("newArray", "(I)[Ljava/lang/Object;", "")]
			public unsafe global::Java.Lang.Object[] NewArray (int size)
			{
				const string __id = "newArray.(I)[Ljava/lang/Object;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (size);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/model/external/PaymentMethod", typeof (PaymentMethod));
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

		internal PaymentMethod (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe global::Com.Stripe.Stripeterminal.Model.External.CardDetails CardDetails {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentMethod']/method[@name='getCardDetails' and count(parameter)=0]"
			[Register ("getCardDetails", "()Lcom/stripe/stripeterminal/model/external/CardDetails;", "")]
			get {
				const string __id = "getCardDetails.()Lcom/stripe/stripeterminal/model/external/CardDetails;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.CardDetails> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Customer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentMethod']/method[@name='getCustomer' and count(parameter)=0]"
			[Register ("getCustomer", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getCustomer.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentMethod']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool Livemode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentMethod']/method[@name='getLivemode' and count(parameter)=0]"
			[Register ("getLivemode", "()Z", "")]
			get {
				const string __id = "getLivemode.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IDictionary<string, string> Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentMethod']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Ljava/util/Map;", "")]
			get {
				const string __id = "getMetadata.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentMethod']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()Ljava/lang/String;", "")]
		public unsafe string Component1 ()
		{
			const string __id = "component1.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentMethod']/method[@name='component3' and count(parameter)=0]"
		[Register ("component3", "()Lcom/stripe/stripeterminal/model/external/CardDetails;", "")]
		public unsafe global::Com.Stripe.Stripeterminal.Model.External.CardDetails Component3 ()
		{
			const string __id = "component3.()Lcom/stripe/stripeterminal/model/external/CardDetails;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.CardDetails> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentMethod']/method[@name='component5' and count(parameter)=0]"
		[Register ("component5", "()Ljava/lang/String;", "")]
		public unsafe string Component5 ()
		{
			const string __id = "component5.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentMethod']/method[@name='component6' and count(parameter)=0]"
		[Register ("component6", "()Z", "")]
		public unsafe bool Component6 ()
		{
			const string __id = "component6.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentMethod']/method[@name='component7' and count(parameter)=0]"
		[Register ("component7", "()Ljava/util/Map;", "")]
		public unsafe global::System.Collections.Generic.IDictionary<string, string> Component7 ()
		{
			const string __id = "component7.()Ljava/util/Map;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentMethod']/method[@name='copy' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.stripe.stripeterminal.model.external.CardDetails'] and parameter[4][@type='long'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='boolean'] and parameter[7][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[8][@type='java.lang.String']]"
		[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;Lcom/stripe/stripeterminal/model/external/CardDetails;JLjava/lang/String;ZLjava/util/Map;Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/PaymentMethod;", "")]
		public unsafe global::Com.Stripe.Stripeterminal.Model.External.PaymentMethod Copy (string id, string objectType, global::Com.Stripe.Stripeterminal.Model.External.CardDetails cardDetails, long created, string customer, bool livemode, global::System.Collections.Generic.IDictionary<string, string> metadata, string type)
		{
			const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;Lcom/stripe/stripeterminal/model/external/CardDetails;JLjava/lang/String;ZLjava/util/Map;Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/PaymentMethod;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_objectType = JNIEnv.NewString (objectType);
			IntPtr native_customer = JNIEnv.NewString (customer);
			IntPtr native_metadata = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (metadata);
			IntPtr native_type = JNIEnv.NewString (type);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_objectType);
				__args [2] = new JniArgumentValue ((cardDetails == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cardDetails).Handle);
				__args [3] = new JniArgumentValue (created);
				__args [4] = new JniArgumentValue (native_customer);
				__args [5] = new JniArgumentValue (livemode);
				__args [6] = new JniArgumentValue (native_metadata);
				__args [7] = new JniArgumentValue (native_type);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.PaymentMethod> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_objectType);
				JNIEnv.DeleteLocalRef (native_customer);
				JNIEnv.DeleteLocalRef (native_metadata);
				JNIEnv.DeleteLocalRef (native_type);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentMethod']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='PaymentMethod']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel parcel, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((parcel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parcel).Handle);
				__args [1] = new JniArgumentValue ((int) flags);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
