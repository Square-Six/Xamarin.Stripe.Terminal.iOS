using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal.Callable {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/interface[@name='ReaderSoftwareUpdateListener']"
	[Register ("com/stripe/stripeterminal/callable/ReaderSoftwareUpdateListener", "", "Com.Stripe.Stripeterminal.Callable.IReaderSoftwareUpdateListenerInvoker")]
	public partial interface IReaderSoftwareUpdateListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.callable']/interface[@name='ReaderSoftwareUpdateListener']/method[@name='onReportReaderSoftwareUpdateProgress' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("onReportReaderSoftwareUpdateProgress", "(F)V", "GetOnReportReaderSoftwareUpdateProgress_FHandler:Com.Stripe.Stripeterminal.Callable.IReaderSoftwareUpdateListenerInvoker, Xamarin.Stripe.Terminal.Android")]
		void OnReportReaderSoftwareUpdateProgress (float progress);

	}

	[global::Android.Runtime.Register ("com/stripe/stripeterminal/callable/ReaderSoftwareUpdateListener", DoNotGenerateAcw=true)]
	internal partial class IReaderSoftwareUpdateListenerInvoker : global::Java.Lang.Object, IReaderSoftwareUpdateListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/callable/ReaderSoftwareUpdateListener", typeof (IReaderSoftwareUpdateListenerInvoker));

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

		public static IReaderSoftwareUpdateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IReaderSoftwareUpdateListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.stripe.stripeterminal.callable.ReaderSoftwareUpdateListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IReaderSoftwareUpdateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onReportReaderSoftwareUpdateProgress_F;
#pragma warning disable 0169
		static Delegate GetOnReportReaderSoftwareUpdateProgress_FHandler ()
		{
			if (cb_onReportReaderSoftwareUpdateProgress_F == null)
				cb_onReportReaderSoftwareUpdateProgress_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_OnReportReaderSoftwareUpdateProgress_F);
			return cb_onReportReaderSoftwareUpdateProgress_F;
		}

		static void n_OnReportReaderSoftwareUpdateProgress_F (IntPtr jnienv, IntPtr native__this, float progress)
		{
			global::Com.Stripe.Stripeterminal.Callable.IReaderSoftwareUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Callable.IReaderSoftwareUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnReportReaderSoftwareUpdateProgress (progress);
		}
#pragma warning restore 0169

		IntPtr id_onReportReaderSoftwareUpdateProgress_F;
		public unsafe void OnReportReaderSoftwareUpdateProgress (float progress)
		{
			if (id_onReportReaderSoftwareUpdateProgress_F == IntPtr.Zero)
				id_onReportReaderSoftwareUpdateProgress_F = JNIEnv.GetMethodID (class_ref, "onReportReaderSoftwareUpdateProgress", "(F)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (progress);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReportReaderSoftwareUpdateProgress_F, __args);
		}

	}

	// event args for com.stripe.stripeterminal.callable.ReaderSoftwareUpdateListener.onReportReaderSoftwareUpdateProgress
	public partial class ReaderSoftwareUpdateEventArgs : global::System.EventArgs {

		public ReaderSoftwareUpdateEventArgs (float progress)
		{
			this.progress = progress;
		}

		float progress;
		public float Progress {
			get { return progress; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/stripe/stripeterminal/callable/ReaderSoftwareUpdateListenerImplementor")]
	internal sealed partial class IReaderSoftwareUpdateListenerImplementor : global::Java.Lang.Object, IReaderSoftwareUpdateListener {

		object sender;

		public IReaderSoftwareUpdateListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/stripe/stripeterminal/callable/ReaderSoftwareUpdateListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ReaderSoftwareUpdateEventArgs> Handler;
#pragma warning restore 0649

		public void OnReportReaderSoftwareUpdateProgress (float progress)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ReaderSoftwareUpdateEventArgs (progress));
		}

		internal static bool __IsEmpty (IReaderSoftwareUpdateListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
