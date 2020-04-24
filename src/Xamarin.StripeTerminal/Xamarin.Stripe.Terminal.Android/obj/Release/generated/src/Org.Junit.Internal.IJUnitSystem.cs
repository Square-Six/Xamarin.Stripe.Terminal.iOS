using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.junit.internal']/interface[@name='JUnitSystem']"
	[Register ("org/junit/internal/JUnitSystem", "", "Org.Junit.Internal.IJUnitSystemInvoker")]
	public partial interface IJUnitSystem : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal']/interface[@name='JUnitSystem']/method[@name='exit' and count(parameter)=1 and parameter[1][@type='int']]"
[Obsolete (@"deprecated")]
		[Register ("exit", "(I)V", "GetExit_IHandler:Org.Junit.Internal.IJUnitSystemInvoker, Xamarin.Stripe.Terminal.Android")]
		void Exit (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal']/interface[@name='JUnitSystem']/method[@name='out' and count(parameter)=0]"
		[Register ("out", "()Ljava/io/PrintStream;", "GetOutHandler:Org.Junit.Internal.IJUnitSystemInvoker, Xamarin.Stripe.Terminal.Android")]
		global::Java.IO.PrintStream Out ();

	}

	[global::Android.Runtime.Register ("org/junit/internal/JUnitSystem", DoNotGenerateAcw=true)]
	internal partial class IJUnitSystemInvoker : global::Java.Lang.Object, IJUnitSystem {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/internal/JUnitSystem", typeof (IJUnitSystemInvoker));

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

		public static IJUnitSystem GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJUnitSystem> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.junit.internal.JUnitSystem"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJUnitSystemInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_exit_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetExit_IHandler ()
		{
			if (cb_exit_I == null)
				cb_exit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Exit_I);
			return cb_exit_I;
		}

		[Obsolete]
		static void n_Exit_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Junit.Internal.IJUnitSystem __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.IJUnitSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Exit (p0);
		}
#pragma warning restore 0169

		IntPtr id_exit_I;
		public unsafe void Exit (int p0)
		{
			if (id_exit_I == IntPtr.Zero)
				id_exit_I = JNIEnv.GetMethodID (class_ref, "exit", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_exit_I, __args);
		}

		static Delegate cb_out;
#pragma warning disable 0169
		static Delegate GetOutHandler ()
		{
			if (cb_out == null)
				cb_out = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Out);
			return cb_out;
		}

		static IntPtr n_Out (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.IJUnitSystem __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.IJUnitSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Out ());
		}
#pragma warning restore 0169

		IntPtr id_out;
		public unsafe global::Java.IO.PrintStream Out ()
		{
			if (id_out == IntPtr.Zero)
				id_out = JNIEnv.GetMethodID (class_ref, "out", "()Ljava/io/PrintStream;");
			return global::Java.Lang.Object.GetObject<global::Java.IO.PrintStream> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_out), JniHandleOwnership.TransferLocalRef);
		}

	}

}
