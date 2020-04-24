using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Junit.Rules {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.junit.rules']/class[@name='TemporaryFolder']"
	[global::Android.Runtime.Register ("org/junit/rules/TemporaryFolder", DoNotGenerateAcw=true)]
	public partial class TemporaryFolder : global::Org.Junit.Rules.ExternalResource {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/junit/rules/TemporaryFolder", typeof (TemporaryFolder));
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

		protected TemporaryFolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.rules']/class[@name='TemporaryFolder']/constructor[@name='TemporaryFolder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TemporaryFolder ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.junit.rules']/class[@name='TemporaryFolder']/constructor[@name='TemporaryFolder' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register (".ctor", "(Ljava/io/File;)V", "")]
		public unsafe TemporaryFolder (global::Java.IO.File parentFolder)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/File;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parentFolder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parentFolder).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getRoot;
#pragma warning disable 0169
		static Delegate GetGetRootHandler ()
		{
			if (cb_getRoot == null)
				cb_getRoot = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRoot);
			return cb_getRoot;
		}

		static IntPtr n_GetRoot (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Rules.TemporaryFolder __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.TemporaryFolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Root);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.IO.File Root {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='TemporaryFolder']/method[@name='getRoot' and count(parameter)=0]"
			[Register ("getRoot", "()Ljava/io/File;", "GetGetRootHandler")]
			get {
				const string __id = "getRoot.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_create;
#pragma warning disable 0169
		static Delegate GetCreateHandler ()
		{
			if (cb_create == null)
				cb_create = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Create);
			return cb_create;
		}

		static void n_Create (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Rules.TemporaryFolder __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.TemporaryFolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Create ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='TemporaryFolder']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()V", "GetCreateHandler")]
		public virtual unsafe void Create ()
		{
			const string __id = "create.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_delete;
#pragma warning disable 0169
		static Delegate GetDeleteHandler ()
		{
			if (cb_delete == null)
				cb_delete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Delete);
			return cb_delete;
		}

		static void n_Delete (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Rules.TemporaryFolder __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.TemporaryFolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='TemporaryFolder']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_newFile;
#pragma warning disable 0169
		static Delegate GetNewFileHandler ()
		{
			if (cb_newFile == null)
				cb_newFile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NewFile);
			return cb_newFile;
		}

		static IntPtr n_NewFile (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Rules.TemporaryFolder __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.TemporaryFolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewFile ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='TemporaryFolder']/method[@name='newFile' and count(parameter)=0]"
		[Register ("newFile", "()Ljava/io/File;", "GetNewFileHandler")]
		public virtual unsafe global::Java.IO.File NewFile ()
		{
			const string __id = "newFile.()Ljava/io/File;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_newFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNewFile_Ljava_lang_String_Handler ()
		{
			if (cb_newFile_Ljava_lang_String_ == null)
				cb_newFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewFile_Ljava_lang_String_);
			return cb_newFile_Ljava_lang_String_;
		}

		static IntPtr n_NewFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fileName)
		{
			global::Org.Junit.Rules.TemporaryFolder __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.TemporaryFolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string fileName = JNIEnv.GetString (native_fileName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewFile (fileName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='TemporaryFolder']/method[@name='newFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("newFile", "(Ljava/lang/String;)Ljava/io/File;", "GetNewFile_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.IO.File NewFile (string fileName)
		{
			const string __id = "newFile.(Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_fileName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
			}
		}

		static Delegate cb_newFolder;
#pragma warning disable 0169
		static Delegate GetNewFolderHandler ()
		{
			if (cb_newFolder == null)
				cb_newFolder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NewFolder);
			return cb_newFolder;
		}

		static IntPtr n_NewFolder (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Junit.Rules.TemporaryFolder __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.TemporaryFolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewFolder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='TemporaryFolder']/method[@name='newFolder' and count(parameter)=0]"
		[Register ("newFolder", "()Ljava/io/File;", "GetNewFolderHandler")]
		public virtual unsafe global::Java.IO.File NewFolder ()
		{
			const string __id = "newFolder.()Ljava/io/File;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_newFolder_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNewFolder_Ljava_lang_String_Handler ()
		{
			if (cb_newFolder_Ljava_lang_String_ == null)
				cb_newFolder_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewFolder_Ljava_lang_String_);
			return cb_newFolder_Ljava_lang_String_;
		}

		static IntPtr n_NewFolder_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_folder)
		{
			global::Org.Junit.Rules.TemporaryFolder __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.TemporaryFolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string folder = JNIEnv.GetString (native_folder, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewFolder (folder));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='TemporaryFolder']/method[@name='newFolder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("newFolder", "(Ljava/lang/String;)Ljava/io/File;", "GetNewFolder_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.IO.File NewFolder (string folder)
		{
			const string __id = "newFolder.(Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_folder = JNIEnv.NewString (folder);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_folder);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_folder);
			}
		}

		static Delegate cb_newFolder_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNewFolder_arrayLjava_lang_String_Handler ()
		{
			if (cb_newFolder_arrayLjava_lang_String_ == null)
				cb_newFolder_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewFolder_arrayLjava_lang_String_);
			return cb_newFolder_arrayLjava_lang_String_;
		}

		static IntPtr n_NewFolder_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_folderNames)
		{
			global::Org.Junit.Rules.TemporaryFolder __this = global::Java.Lang.Object.GetObject<global::Org.Junit.Rules.TemporaryFolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] folderNames = (string[]) JNIEnv.GetArray (native_folderNames, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewFolder (folderNames));
			if (folderNames != null)
				JNIEnv.CopyArray (folderNames, native_folderNames);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.junit.rules']/class[@name='TemporaryFolder']/method[@name='newFolder' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("newFolder", "([Ljava/lang/String;)Ljava/io/File;", "GetNewFolder_arrayLjava_lang_String_Handler")]
		public virtual unsafe global::Java.IO.File NewFolder (params string[] folderNames)
		{
			const string __id = "newFolder.([Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_folderNames = JNIEnv.NewArray (folderNames);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_folderNames);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (folderNames != null) {
					JNIEnv.CopyArray (native_folderNames, folderNames);
					JNIEnv.DeleteLocalRef (native_folderNames);
				}
			}
		}

	}
}
