using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.internal']/class[@name='RealSystem']"
	[global::Android.Runtime.Register ("org/junit/internal/RealSystem", DoNotGenerateAcw=true)]
	public partial class RealSystem : global::Java.Lang.Object, global::Org.Junit.Internal.IJUnitSystem {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/internal/RealSystem", typeof (RealSystem));
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

		protected RealSystem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.internal']/class[@name='RealSystem']/constructor[@name='RealSystem' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RealSystem ()
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
		static void n_Exit_I (IntPtr jnienv, IntPtr native__this, int code)
		{
			global::Org.Junit.Internal.RealSystem __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.RealSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Exit (code);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal']/class[@name='RealSystem']/method[@name='exit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("exit", "(I)V", "GetExit_IHandler")]
		public virtual unsafe void Exit (int code)
		{
			const string __id = "exit.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (code);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
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
			global::Org.Junit.Internal.RealSystem __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.RealSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Out ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal']/class[@name='RealSystem']/method[@name='out' and count(parameter)=0]"
		[Register ("out", "()Ljava/io/PrintStream;", "GetOutHandler")]
		public virtual unsafe global::Java.IO.PrintStream Out ()
		{
			const string __id = "out.()Ljava/io/PrintStream;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.IO.PrintStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
