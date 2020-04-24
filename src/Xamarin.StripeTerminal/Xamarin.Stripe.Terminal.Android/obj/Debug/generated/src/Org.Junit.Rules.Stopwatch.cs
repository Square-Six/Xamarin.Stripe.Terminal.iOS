using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Rules {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.rules']/class[@name='Stopwatch']"
	[global::Android.Runtime.Register ("org/junit/rules/Stopwatch", DoNotGenerateAcw=true)]
	public abstract partial class Stopwatch : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.rules']/class[@name='Stopwatch.Clock']"
		[global::Android.Runtime.Register ("org/junit/rules/Stopwatch$Clock", DoNotGenerateAcw=true)]
		public partial class Clock : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/rules/Stopwatch$Clock", typeof (Clock));
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

			protected Clock (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_nanoTime;
#pragma warning disable 0169
			static Delegate GetNanoTimeHandler ()
			{
				if (cb_nanoTime == null)
					cb_nanoTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_NanoTime);
				return cb_nanoTime;
			}

			static long n_NanoTime (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Junit.Rules.Stopwatch.Clock __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.Stopwatch.Clock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NanoTime ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='Stopwatch.Clock']/method[@name='nanoTime' and count(parameter)=0]"
			[Register ("nanoTime", "()J", "GetNanoTimeHandler")]
			public virtual unsafe long NanoTime ()
			{
				const string __id = "nanoTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/rules/Stopwatch", typeof (Stopwatch));
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

		protected Stopwatch (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.rules']/class[@name='Stopwatch']/constructor[@name='Stopwatch' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Stopwatch ()
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

		static Delegate cb_runtime_Ljava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetRuntime_Ljava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_runtime_Ljava_util_concurrent_TimeUnit_ == null)
				cb_runtime_Ljava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_Runtime_Ljava_util_concurrent_TimeUnit_);
			return cb_runtime_Ljava_util_concurrent_TimeUnit_;
		}

		static long n_Runtime_Ljava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_unit)
		{
			global::Org.Junit.Rules.Stopwatch __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.Stopwatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_unit, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Runtime (unit);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='Stopwatch']/method[@name='runtime' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.TimeUnit']]"
		[Register ("runtime", "(Ljava/util/concurrent/TimeUnit;)J", "GetRuntime_Ljava_util_concurrent_TimeUnit_Handler")]
		public virtual unsafe long Runtime (global::Java.Util.Concurrent.TimeUnit unit)
		{
			const string __id = "runtime.(Ljava/util/concurrent/TimeUnit;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unit).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/junit/rules/Stopwatch", DoNotGenerateAcw=true)]
	internal partial class StopwatchInvoker : Stopwatch {

		public StopwatchInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/rules/Stopwatch", typeof (StopwatchInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
