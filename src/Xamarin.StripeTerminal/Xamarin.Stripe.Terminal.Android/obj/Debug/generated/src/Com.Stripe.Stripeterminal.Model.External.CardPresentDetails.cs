using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal.Model.External {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']"
	[global::Android.Runtime.Register ("com/stripe/stripeterminal/model/external/CardPresentDetails", DoNotGenerateAcw=true)]
	public sealed partial class CardPresentDetails : global::Java.Lang.Object, global::Android.OS.IParcelable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails.Creator']"
		[global::Android.Runtime.Register ("com/stripe/stripeterminal/model/external/CardPresentDetails$Creator", DoNotGenerateAcw=true)]
		public sealed partial class Creator : global::Java.Lang.Object, global::Android.OS.IParcelableCreator {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/model/external/CardPresentDetails$Creator", typeof (Creator));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails.Creator']/constructor[@name='CardPresentDetails.Creator' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails.Creator']/method[@name='createFromParcel' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails.Creator']/method[@name='newArray' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/model/external/CardPresentDetails", typeof (CardPresentDetails));
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

		internal CardPresentDetails (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/constructor[@name='CardPresentDetails' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CardPresentDetails ()
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

		public unsafe string Brand {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='getBrand' and count(parameter)=0]"
			[Register ("getBrand", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getBrand.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Country {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='getCountry' and count(parameter)=0]"
			[Register ("getCountry", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getCountry.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string EmvAuthData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='getEmvAuthData' and count(parameter)=0]"
			[Register ("getEmvAuthData", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getEmvAuthData.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int ExpMonth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='getExpMonth' and count(parameter)=0]"
			[Register ("getExpMonth", "()I", "")]
			get {
				const string __id = "getExpMonth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int ExpYear {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='getExpYear' and count(parameter)=0]"
			[Register ("getExpYear", "()I", "")]
			get {
				const string __id = "getExpYear.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string Fingerprint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='getFingerprint' and count(parameter)=0]"
			[Register ("getFingerprint", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getFingerprint.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Funding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='getFunding' and count(parameter)=0]"
			[Register ("getFunding", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getFunding.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string GeneratedCard {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='getGeneratedCard' and count(parameter)=0]"
			[Register ("getGeneratedCard", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getGeneratedCard.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Last4 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='getLast4' and count(parameter)=0]"
			[Register ("getLast4", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getLast4.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string ReadMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='getReadMethod' and count(parameter)=0]"
			[Register ("getReadMethod", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getReadMethod.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Stripe.Stripeterminal.Model.External.ReceiptDetails ReceiptDetails {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='getReceiptDetails' and count(parameter)=0]"
			[Register ("getReceiptDetails", "()Lcom/stripe/stripeterminal/model/external/ReceiptDetails;", "")]
			get {
				const string __id = "getReceiptDetails.()Lcom/stripe/stripeterminal/model/external/ReceiptDetails;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReceiptDetails> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='component1' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='component10' and count(parameter)=0]"
		[Register ("component10", "()Ljava/lang/String;", "")]
		public unsafe string Component10 ()
		{
			const string __id = "component10.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='component11' and count(parameter)=0]"
		[Register ("component11", "()Lcom/stripe/stripeterminal/model/external/ReceiptDetails;", "")]
		public unsafe global::Com.Stripe.Stripeterminal.Model.External.ReceiptDetails Component11 ()
		{
			const string __id = "component11.()Lcom/stripe/stripeterminal/model/external/ReceiptDetails;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.ReceiptDetails> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()Ljava/lang/String;", "")]
		public unsafe string Component2 ()
		{
			const string __id = "component2.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='component3' and count(parameter)=0]"
		[Register ("component3", "()Ljava/lang/String;", "")]
		public unsafe string Component3 ()
		{
			const string __id = "component3.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='component4' and count(parameter)=0]"
		[Register ("component4", "()I", "")]
		public unsafe int Component4 ()
		{
			const string __id = "component4.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='component5' and count(parameter)=0]"
		[Register ("component5", "()I", "")]
		public unsafe int Component5 ()
		{
			const string __id = "component5.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='component6' and count(parameter)=0]"
		[Register ("component6", "()Ljava/lang/String;", "")]
		public unsafe string Component6 ()
		{
			const string __id = "component6.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='component7' and count(parameter)=0]"
		[Register ("component7", "()Ljava/lang/String;", "")]
		public unsafe string Component7 ()
		{
			const string __id = "component7.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='component8' and count(parameter)=0]"
		[Register ("component8", "()Ljava/lang/String;", "")]
		public unsafe string Component8 ()
		{
			const string __id = "component8.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='component9' and count(parameter)=0]"
		[Register ("component9", "()Ljava/lang/String;", "")]
		public unsafe string Component9 ()
		{
			const string __id = "component9.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='copy' and count(parameter)=11 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='java.lang.String'] and parameter[11][@type='com.stripe.stripeterminal.model.external.ReceiptDetails']]"
		[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/stripe/stripeterminal/model/external/ReceiptDetails;)Lcom/stripe/stripeterminal/model/external/CardPresentDetails;", "")]
		public unsafe global::Com.Stripe.Stripeterminal.Model.External.CardPresentDetails Copy (string brand, string country, string emvAuthData, int expMonth, int expYear, string fingerprint, string funding, string generatedCard, string last4, string readMethod, global::Com.Stripe.Stripeterminal.Model.External.ReceiptDetails receiptDetails)
		{
			const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/stripe/stripeterminal/model/external/ReceiptDetails;)Lcom/stripe/stripeterminal/model/external/CardPresentDetails;";
			IntPtr native_brand = JNIEnv.NewString (brand);
			IntPtr native_country = JNIEnv.NewString (country);
			IntPtr native_emvAuthData = JNIEnv.NewString (emvAuthData);
			IntPtr native_fingerprint = JNIEnv.NewString (fingerprint);
			IntPtr native_funding = JNIEnv.NewString (funding);
			IntPtr native_generatedCard = JNIEnv.NewString (generatedCard);
			IntPtr native_last4 = JNIEnv.NewString (last4);
			IntPtr native_readMethod = JNIEnv.NewString (readMethod);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [11];
				__args [0] = new JniArgumentValue (native_brand);
				__args [1] = new JniArgumentValue (native_country);
				__args [2] = new JniArgumentValue (native_emvAuthData);
				__args [3] = new JniArgumentValue (expMonth);
				__args [4] = new JniArgumentValue (expYear);
				__args [5] = new JniArgumentValue (native_fingerprint);
				__args [6] = new JniArgumentValue (native_funding);
				__args [7] = new JniArgumentValue (native_generatedCard);
				__args [8] = new JniArgumentValue (native_last4);
				__args [9] = new JniArgumentValue (native_readMethod);
				__args [10] = new JniArgumentValue ((receiptDetails == null) ? IntPtr.Zero : ((global::Java.Lang.Object) receiptDetails).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.CardPresentDetails> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_brand);
				JNIEnv.DeleteLocalRef (native_country);
				JNIEnv.DeleteLocalRef (native_emvAuthData);
				JNIEnv.DeleteLocalRef (native_fingerprint);
				JNIEnv.DeleteLocalRef (native_funding);
				JNIEnv.DeleteLocalRef (native_generatedCard);
				JNIEnv.DeleteLocalRef (native_last4);
				JNIEnv.DeleteLocalRef (native_readMethod);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='describeContents' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='CardPresentDetails']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
