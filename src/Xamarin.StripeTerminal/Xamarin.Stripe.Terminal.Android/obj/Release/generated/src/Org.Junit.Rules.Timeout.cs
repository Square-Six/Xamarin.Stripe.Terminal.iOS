using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Rules {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.rules']/class[@name='Timeout']"
	[global::Android.Runtime.Register ("org/junit/rules/Timeout", DoNotGenerateAcw=true)]
	public partial class Timeout : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.rules']/class[@name='Timeout.Builder']"
		[global::Android.Runtime.Register ("org/junit/rules/Timeout$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/rules/Timeout$Builder", typeof (Builder));
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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.rules']/class[@name='Timeout.Builder']/constructor[@name='Timeout.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			protected unsafe Builder ()
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

			static Delegate cb_getLookingForStuckThread;
#pragma warning disable 0169
			static Delegate GetGetLookingForStuckThreadHandler ()
			{
				if (cb_getLookingForStuckThread == null)
					cb_getLookingForStuckThread = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetLookingForStuckThread);
				return cb_getLookingForStuckThread;
			}

			static bool n_GetLookingForStuckThread (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Junit.Rules.Timeout.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.Timeout.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.LookingForStuckThread;
			}
#pragma warning restore 0169

			protected virtual unsafe bool LookingForStuckThread {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='Timeout.Builder']/method[@name='getLookingForStuckThread' and count(parameter)=0]"
				[Register ("getLookingForStuckThread", "()Z", "GetGetLookingForStuckThreadHandler")]
				get {
					const string __id = "getLookingForStuckThread.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getTimeUnit;
#pragma warning disable 0169
			static Delegate GetGetTimeUnitHandler ()
			{
				if (cb_getTimeUnit == null)
					cb_getTimeUnit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimeUnit);
				return cb_getTimeUnit;
			}

			static IntPtr n_GetTimeUnit (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Junit.Rules.Timeout.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.Timeout.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.TimeUnit);
			}
#pragma warning restore 0169

			protected virtual unsafe global::Java.Util.Concurrent.TimeUnit TimeUnit {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='Timeout.Builder']/method[@name='getTimeUnit' and count(parameter)=0]"
				[Register ("getTimeUnit", "()Ljava/util/concurrent/TimeUnit;", "GetGetTimeUnitHandler")]
				get {
					const string __id = "getTimeUnit.()Ljava/util/concurrent/TimeUnit;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getTimeout;
#pragma warning disable 0169
			static Delegate GetGetTimeoutHandler ()
			{
				if (cb_getTimeout == null)
					cb_getTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimeout);
				return cb_getTimeout;
			}

			static long n_GetTimeout (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Junit.Rules.Timeout.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.Timeout.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Timeout;
			}
#pragma warning restore 0169

			protected virtual unsafe long Timeout {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='Timeout.Builder']/method[@name='getTimeout' and count(parameter)=0]"
				[Register ("getTimeout", "()J", "GetGetTimeoutHandler")]
				get {
					const string __id = "getTimeout.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Junit.Rules.Timeout.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.Timeout.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='Timeout.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lorg/junit/rules/Timeout;", "GetBuildHandler")]
			public virtual unsafe global::Org.Junit.Rules.Timeout Build ()
			{
				const string __id = "build.()Lorg/junit/rules/Timeout;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.Timeout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_withLookingForStuckThread_Z;
#pragma warning disable 0169
			static Delegate GetWithLookingForStuckThread_ZHandler ()
			{
				if (cb_withLookingForStuckThread_Z == null)
					cb_withLookingForStuckThread_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithLookingForStuckThread_Z);
				return cb_withLookingForStuckThread_Z;
			}

			static IntPtr n_WithLookingForStuckThread_Z (IntPtr jnienv, IntPtr native__this, bool enable)
			{
				global::Org.Junit.Rules.Timeout.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.Timeout.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.WithLookingForStuckThread (enable));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='Timeout.Builder']/method[@name='withLookingForStuckThread' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("withLookingForStuckThread", "(Z)Lorg/junit/rules/Timeout$Builder;", "GetWithLookingForStuckThread_ZHandler")]
			public virtual unsafe global::Org.Junit.Rules.Timeout.Builder WithLookingForStuckThread (bool enable)
			{
				const string __id = "withLookingForStuckThread.(Z)Lorg/junit/rules/Timeout$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (enable);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.Timeout.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_withTimeout_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
			static Delegate GetWithTimeout_JLjava_util_concurrent_TimeUnit_Handler ()
			{
				if (cb_withTimeout_JLjava_util_concurrent_TimeUnit_ == null)
					cb_withTimeout_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_WithTimeout_JLjava_util_concurrent_TimeUnit_);
				return cb_withTimeout_JLjava_util_concurrent_TimeUnit_;
			}

			static IntPtr n_WithTimeout_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long timeout, IntPtr native_unit)
			{
				global::Org.Junit.Rules.Timeout.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.Timeout.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Util.Concurrent.TimeUnit unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_unit, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithTimeout (timeout, unit));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='Timeout.Builder']/method[@name='withTimeout' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
			[Register ("withTimeout", "(JLjava/util/concurrent/TimeUnit;)Lorg/junit/rules/Timeout$Builder;", "GetWithTimeout_JLjava_util_concurrent_TimeUnit_Handler")]
			public virtual unsafe global::Org.Junit.Rules.Timeout.Builder WithTimeout (long timeout, global::Java.Util.Concurrent.TimeUnit unit)
			{
				const string __id = "withTimeout.(JLjava/util/concurrent/TimeUnit;)Lorg/junit/rules/Timeout$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (timeout);
					__args [1] = new JniArgumentValue ((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unit).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.Timeout.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/rules/Timeout", typeof (Timeout));
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

		protected Timeout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.rules']/class[@name='Timeout']/constructor[@name='Timeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe Timeout (int millis)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (millis);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.rules']/class[@name='Timeout']/constructor[@name='Timeout' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register (".ctor", "(JLjava/util/concurrent/TimeUnit;)V", "")]
		public unsafe Timeout (long timeout, global::Java.Util.Concurrent.TimeUnit timeUnit)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JLjava/util/concurrent/TimeUnit;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (timeout);
				__args [1] = new JniArgumentValue ((timeUnit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeUnit).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.rules']/class[@name='Timeout']/constructor[@name='Timeout' and count(parameter)=1 and parameter[1][@type='org.junit.rules.Timeout.Builder']]"
		[Register (".ctor", "(Lorg/junit/rules/Timeout$Builder;)V", "")]
		protected unsafe Timeout (global::Org.Junit.Rules.Timeout.Builder builder)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/junit/rules/Timeout$Builder;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		protected unsafe bool LookingForStuckThread {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='Timeout']/method[@name='getLookingForStuckThread' and count(parameter)=0]"
			[Register ("getLookingForStuckThread", "()Z", "")]
			get {
				const string __id = "getLookingForStuckThread.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='Timeout']/method[@name='builder' and count(parameter)=0]"
		[Register ("builder", "()Lorg/junit/rules/Timeout$Builder;", "")]
		public static unsafe global::Org.Junit.Rules.Timeout.Builder InvokeBuilder ()
		{
			const string __id = "builder.()Lorg/junit/rules/Timeout$Builder;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.Timeout.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='Timeout']/method[@name='getTimeout' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.TimeUnit']]"
		[Register ("getTimeout", "(Ljava/util/concurrent/TimeUnit;)J", "")]
		protected unsafe long GetTimeout (global::Java.Util.Concurrent.TimeUnit unit)
		{
			const string __id = "getTimeout.(Ljava/util/concurrent/TimeUnit;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unit).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='Timeout']/method[@name='millis' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("millis", "(J)Lorg/junit/rules/Timeout;", "")]
		public static unsafe global::Org.Junit.Rules.Timeout Millis (long millis)
		{
			const string __id = "millis.(J)Lorg/junit/rules/Timeout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (millis);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.Timeout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='Timeout']/method[@name='seconds' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("seconds", "(J)Lorg/junit/rules/Timeout;", "")]
		public static unsafe global::Org.Junit.Rules.Timeout Seconds (long seconds)
		{
			const string __id = "seconds.(J)Lorg/junit/rules/Timeout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (seconds);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.Timeout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
