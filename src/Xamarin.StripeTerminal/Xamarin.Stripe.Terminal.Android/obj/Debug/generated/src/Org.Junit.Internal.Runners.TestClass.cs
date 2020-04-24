using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Internal.Runners {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='TestClass']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/junit/internal/runners/TestClass", DoNotGenerateAcw=true)]
	public partial class TestClass : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/internal/runners/TestClass", typeof (TestClass));
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

		protected TestClass (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='TestClass']/constructor[@name='TestClass' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register (".ctor", "(Ljava/lang/Class;)V", "")]
		public unsafe TestClass (global::Java.Lang.Class klass)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Class;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((klass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) klass).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getConstructor;
#pragma warning disable 0169
		static Delegate GetGetConstructorHandler ()
		{
			if (cb_getConstructor == null)
				cb_getConstructor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConstructor);
			return cb_getConstructor;
		}

		static IntPtr n_GetConstructor (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.Runners.TestClass __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.TestClass> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Constructor);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Reflect.Constructor Constructor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='TestClass']/method[@name='getConstructor' and count(parameter)=0]"
			[Register ("getConstructor", "()Ljava/lang/reflect/Constructor;", "GetGetConstructorHandler")]
			get {
				const string __id = "getConstructor.()Ljava/lang/reflect/Constructor;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Constructor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getJavaClass;
#pragma warning disable 0169
		static Delegate GetGetJavaClassHandler ()
		{
			if (cb_getJavaClass == null)
				cb_getJavaClass = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJavaClass);
			return cb_getJavaClass;
		}

		static IntPtr n_GetJavaClass (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.Runners.TestClass __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.TestClass> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JavaClass);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Class JavaClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='TestClass']/method[@name='getJavaClass' and count(parameter)=0]"
			[Register ("getJavaClass", "()Ljava/lang/Class;", "GetGetJavaClassHandler")]
			get {
				const string __id = "getJavaClass.()Ljava/lang/Class;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.Runners.TestClass __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.TestClass> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='TestClass']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTestMethods;
#pragma warning disable 0169
		static Delegate GetGetTestMethodsHandler ()
		{
			if (cb_getTestMethods == null)
				cb_getTestMethods = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTestMethods);
			return cb_getTestMethods;
		}

		static IntPtr n_GetTestMethods (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Internal.Runners.TestClass __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.TestClass> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.Reflect.Method>.ToLocalJniHandle (__this.TestMethods);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Lang.Reflect.Method> TestMethods {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='TestClass']/method[@name='getTestMethods' and count(parameter)=0]"
			[Register ("getTestMethods", "()Ljava/util/List;", "GetGetTestMethodsHandler")]
			get {
				const string __id = "getTestMethods.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Java.Lang.Reflect.Method>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAnnotatedMethods_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGetAnnotatedMethods_Ljava_lang_Class_Handler ()
		{
			if (cb_getAnnotatedMethods_Ljava_lang_Class_ == null)
				cb_getAnnotatedMethods_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAnnotatedMethods_Ljava_lang_Class_);
			return cb_getAnnotatedMethods_Ljava_lang_Class_;
		}

		static IntPtr n_GetAnnotatedMethods_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_annotationClass)
		{
			global::Org.Junit.Internal.Runners.TestClass __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Internal.Runners.TestClass> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class annotationClass = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_annotationClass, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Java.Lang.Reflect.Method>.ToLocalJniHandle (__this.GetAnnotatedMethods (annotationClass));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.internal.runners']/class[@name='TestClass']/method[@name='getAnnotatedMethods' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends java.lang.annotation.Annotation&gt;']]"
		[Register ("getAnnotatedMethods", "(Ljava/lang/Class;)Ljava/util/List;", "GetGetAnnotatedMethods_Ljava_lang_Class_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Lang.Reflect.Method> GetAnnotatedMethods (global::Java.Lang.Class annotationClass)
		{
			const string __id = "getAnnotatedMethods.(Ljava/lang/Class;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((annotationClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) annotationClass).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Java.Lang.Reflect.Method>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
