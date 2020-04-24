using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Junit.Framework {

	// Metadata.xml XPath interface reference: path="/api/package[@name='junit.framework']/interface[@name='Protectable']"
	[Register ("junit/framework/Protectable", "", "Junit.Framework.IProtectableInvoker")]
	public partial interface IProtectable : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.framework']/interface[@name='Protectable']/method[@name='protect' and count(parameter)=0]"
		[Register ("protect", "()V", "GetProtectHandler:Junit.Framework.IProtectableInvoker, Xamarin.Stripe.Terminal.Android")]
		void Protect ();

	}

	[global::Android.Runtime.Register ("junit/framework/Protectable", DoNotGenerateAcw=true)]
	internal partial class IProtectableInvoker : global::Java.Lang.Object, IProtectable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("junit/framework/Protectable", typeof (IProtectableInvoker));

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

		public static IProtectable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IProtectable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "junit.framework.Protectable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IProtectableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_protect;
#pragma warning disable 0169
		static Delegate GetProtectHandler ()
		{
			if (cb_protect == null)
				cb_protect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Protect);
			return cb_protect;
		}

		static void n_Protect (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Framework.IProtectable __this = global::Java.Lang.Object.GetObject<global::Junit.Framework.IProtectable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Protect ();
		}
#pragma warning restore 0169

		IntPtr id_protect;
		public unsafe void Protect ()
		{
			if (id_protect == IntPtr.Zero)
				id_protect = JNIEnv.GetMethodID (class_ref, "protect", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_protect);
		}

	}

}
