using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Experimental.Theories {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='PotentialAssignment']"
	[global::Android.Runtime.Register ("org/junit/experimental/theories/PotentialAssignment", DoNotGenerateAcw=true)]
	public abstract partial class PotentialAssignment : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='PotentialAssignment.CouldNotGenerateValueException']"
		[global::Android.Runtime.Register ("org/junit/experimental/theories/PotentialAssignment$CouldNotGenerateValueException", DoNotGenerateAcw=true)]
		public partial class CouldNotGenerateValueException : global::Java.Lang.Exception {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/experimental/theories/PotentialAssignment$CouldNotGenerateValueException", typeof (CouldNotGenerateValueException));
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

			protected CouldNotGenerateValueException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='PotentialAssignment.CouldNotGenerateValueException']/constructor[@name='PotentialAssignment.CouldNotGenerateValueException' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe CouldNotGenerateValueException ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='PotentialAssignment.CouldNotGenerateValueException']/constructor[@name='PotentialAssignment.CouldNotGenerateValueException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register (".ctor", "(Ljava/lang/Throwable;)V", "")]
			public unsafe CouldNotGenerateValueException (global::Java.Lang.Throwable e)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/Throwable;)V";

				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/experimental/theories/PotentialAssignment", typeof (PotentialAssignment));
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

		protected PotentialAssignment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='PotentialAssignment']/constructor[@name='PotentialAssignment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PotentialAssignment ()
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

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Experimental.Theories.PotentialAssignment __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.PotentialAssignment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		public abstract string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='PotentialAssignment']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")] get;
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Experimental.Theories.PotentialAssignment __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.PotentialAssignment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Value);
		}
#pragma warning restore 0169

		public abstract global::Java.Lang.Object Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='PotentialAssignment']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/Object;", "GetGetValueHandler")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='PotentialAssignment']/method[@name='forValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("forValue", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/junit/experimental/theories/PotentialAssignment;", "")]
		public static unsafe global::Org.Junit.Experimental.Theories.PotentialAssignment ForValue (string name, global::Java.Lang.Object value)
		{
			const string __id = "forValue.(Ljava/lang/String;Ljava/lang/Object;)Lorg/junit/experimental/theories/PotentialAssignment;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Junit.Experimental.Theories.PotentialAssignment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

	}

	[global::Android.Runtime.Register ("org/junit/experimental/theories/PotentialAssignment", DoNotGenerateAcw=true)]
	internal partial class PotentialAssignmentInvoker : PotentialAssignment {

		public PotentialAssignmentInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/experimental/theories/PotentialAssignment", typeof (PotentialAssignmentInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='PotentialAssignment']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				const string __id = "getDescription.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Java.Lang.Object Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.experimental.theories']/class[@name='PotentialAssignment']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/Object;", "GetGetValueHandler")]
			get {
				const string __id = "getValue.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

}
