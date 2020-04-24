using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal.Callable {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/interface[@name='DiscoveryListener']"
	[Register ("com/stripe/stripeterminal/callable/DiscoveryListener", "", "Com.Stripe.Stripeterminal.Callable.IDiscoveryListenerInvoker")]
	public partial interface IDiscoveryListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/interface[@name='DiscoveryListener']/method[@name='onUpdateDiscoveredReaders' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;? extends com.stripe.stripeterminal.model.external.Reader&gt;']]"
		[Register ("onUpdateDiscoveredReaders", "(Ljava/util/List;)V", "GetOnUpdateDiscoveredReaders_Ljava_util_List_Handler:Com.Stripe.Stripeterminal.Callable.IDiscoveryListenerInvoker, Xamarin.Stripe.Terminal.Android")]
		void OnUpdateDiscoveredReaders (global::System.Collections.Generic.IList<global::Com.Stripe.Stripeterminal.Model.External.Reader> readers);

	}

	[global::Android.Runtime.Register ("com/stripe/stripeterminal/callable/DiscoveryListener", DoNotGenerateAcw=true)]
	internal partial class IDiscoveryListenerInvoker : global::Java.Lang.Object, IDiscoveryListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/callable/DiscoveryListener", typeof (IDiscoveryListenerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IDiscoveryListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDiscoveryListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.stripe.stripeterminal.callable.DiscoveryListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDiscoveryListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onUpdateDiscoveredReaders_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnUpdateDiscoveredReaders_Ljava_util_List_Handler ()
		{
			if (cb_onUpdateDiscoveredReaders_Ljava_util_List_ == null)
				cb_onUpdateDiscoveredReaders_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUpdateDiscoveredReaders_Ljava_util_List_);
			return cb_onUpdateDiscoveredReaders_Ljava_util_List_;
		}

		static void n_OnUpdateDiscoveredReaders_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_readers)
		{
			global::Com.Stripe.Stripeterminal.Callable.IDiscoveryListener __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Callable.IDiscoveryListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var readers = global::Android.Runtime.JavaList<global::Com.Stripe.Stripeterminal.Model.External.Reader>.FromJniHandle (native_readers, JniHandleOwnership.DoNotTransfer);
			__this.OnUpdateDiscoveredReaders (readers);
		}
#pragma warning restore 0169

		IntPtr id_onUpdateDiscoveredReaders_Ljava_util_List_;
		public unsafe void OnUpdateDiscoveredReaders (global::System.Collections.Generic.IList<global::Com.Stripe.Stripeterminal.Model.External.Reader> readers)
		{
			if (id_onUpdateDiscoveredReaders_Ljava_util_List_ == IntPtr.Zero)
				id_onUpdateDiscoveredReaders_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onUpdateDiscoveredReaders", "(Ljava/util/List;)V");
			IntPtr native_readers = global::Android.Runtime.JavaList<global::Com.Stripe.Stripeterminal.Model.External.Reader>.ToLocalJniHandle (readers);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_readers);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpdateDiscoveredReaders_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_readers);
		}

	}

	// event args for com.stripe.stripeterminal.callable.DiscoveryListener.onUpdateDiscoveredReaders
	public partial class DiscoveryEventArgs : global::System.EventArgs {

		public DiscoveryEventArgs (global::System.Collections.Generic.IList<global::Com.Stripe.Stripeterminal.Model.External.Reader> readers)
		{
			this.readers = readers;
		}

		global::System.Collections.Generic.IList<global::Com.Stripe.Stripeterminal.Model.External.Reader> readers;
		public global::System.Collections.Generic.IList<global::Com.Stripe.Stripeterminal.Model.External.Reader> Readers {
			get { return readers; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/stripe/stripeterminal/callable/DiscoveryListenerImplementor")]
	internal sealed partial class IDiscoveryListenerImplementor : global::Java.Lang.Object, IDiscoveryListener {

		object sender;

		public IDiscoveryListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/stripe/stripeterminal/callable/DiscoveryListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<DiscoveryEventArgs> Handler;
#pragma warning restore 0649

		public void OnUpdateDiscoveredReaders (global::System.Collections.Generic.IList<global::Com.Stripe.Stripeterminal.Model.External.Reader> readers)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new DiscoveryEventArgs (readers));
		}

		internal static bool __IsEmpty (IDiscoveryListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
