using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Junit.Textui {

	// Metadata.xml XPath class reference: path="/api/package[@name='junit.textui']/class[@name='ResultPrinter']"
	[global::Android.Runtime.Register ("junit/textui/ResultPrinter", DoNotGenerateAcw=true)]
	public partial class ResultPrinter : global::Java.Lang.Object, global::Junit.Framework.ITestListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("junit/textui/ResultPrinter", typeof (ResultPrinter));
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

		protected ResultPrinter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='junit.textui']/class[@name='ResultPrinter']/constructor[@name='ResultPrinter' and count(parameter)=1 and parameter[1][@type='java.io.PrintStream']]"
		[Register (".ctor", "(Ljava/io/PrintStream;)V", "")]
		public unsafe ResultPrinter (global::Java.IO.PrintStream writer)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/PrintStream;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((writer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) writer).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getWriter;
#pragma warning disable 0169
		static Delegate GetGetWriterHandler ()
		{
			if (cb_getWriter == null)
				cb_getWriter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWriter);
			return cb_getWriter;
		}

		static IntPtr n_GetWriter (IntPtr jnienv, IntPtr native__this)
		{
			global::Junit.Textui.ResultPrinter __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.ResultPrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Writer);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.IO.PrintStream Writer {
			// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='ResultPrinter']/method[@name='getWriter' and count(parameter)=0]"
			[Register ("getWriter", "()Ljava/io/PrintStream;", "GetGetWriterHandler")]
			get {
				const string __id = "getWriter.()Ljava/io/PrintStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.PrintStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addError_Ljunit_framework_Test_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetAddError_Ljunit_framework_Test_Ljava_lang_Throwable_Handler ()
		{
			if (cb_addError_Ljunit_framework_Test_Ljava_lang_Throwable_ == null)
				cb_addError_Ljunit_framework_Test_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddError_Ljunit_framework_Test_Ljava_lang_Throwable_);
			return cb_addError_Ljunit_framework_Test_Ljava_lang_Throwable_;
		}

		static void n_AddError_Ljunit_framework_Test_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_test, IntPtr native_e)
		{
			global::Junit.Textui.ResultPrinter __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.ResultPrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITest test = (global::Junit.Framework.ITest)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (native_test, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable e = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.AddError (test, e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='ResultPrinter']/method[@name='addError' and count(parameter)=2 and parameter[1][@type='junit.framework.Test'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("addError", "(Ljunit/framework/Test;Ljava/lang/Throwable;)V", "GetAddError_Ljunit_framework_Test_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void AddError (global::Junit.Framework.ITest test, global::Java.Lang.Throwable e)
		{
			const string __id = "addError.(Ljunit/framework/Test;Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((test == null) ? IntPtr.Zero : ((global::Java.Lang.Object) test).Handle);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_;
#pragma warning disable 0169
		static Delegate GetAddFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_Handler ()
		{
			if (cb_addFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_ == null)
				cb_addFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_);
			return cb_addFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_;
		}

		static void n_AddFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_test, IntPtr native_t)
		{
			global::Junit.Textui.ResultPrinter __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.ResultPrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITest test = (global::Junit.Framework.ITest)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (native_test, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.AssertionFailedError t = global::Java.Lang.Object.GetObject<global::Junit.Framework.AssertionFailedError> (native_t, JniHandleOwnership.DoNotTransfer);
			__this.AddFailure (test, t);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='ResultPrinter']/method[@name='addFailure' and count(parameter)=2 and parameter[1][@type='junit.framework.Test'] and parameter[2][@type='junit.framework.AssertionFailedError']]"
		[Register ("addFailure", "(Ljunit/framework/Test;Ljunit/framework/AssertionFailedError;)V", "GetAddFailure_Ljunit_framework_Test_Ljunit_framework_AssertionFailedError_Handler")]
		public virtual unsafe void AddFailure (global::Junit.Framework.ITest test, global::Junit.Framework.AssertionFailedError t)
		{
			const string __id = "addFailure.(Ljunit/framework/Test;Ljunit/framework/AssertionFailedError;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((test == null) ? IntPtr.Zero : ((global::Java.Lang.Object) test).Handle);
				__args [1] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_elapsedTimeAsString_J;
#pragma warning disable 0169
		static Delegate GetElapsedTimeAsString_JHandler ()
		{
			if (cb_elapsedTimeAsString_J == null)
				cb_elapsedTimeAsString_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_ElapsedTimeAsString_J);
			return cb_elapsedTimeAsString_J;
		}

		static IntPtr n_ElapsedTimeAsString_J (IntPtr jnienv, IntPtr native__this, long runTime)
		{
			global::Junit.Textui.ResultPrinter __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.ResultPrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ElapsedTimeAsString (runTime));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='ResultPrinter']/method[@name='elapsedTimeAsString' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("elapsedTimeAsString", "(J)Ljava/lang/String;", "GetElapsedTimeAsString_JHandler")]
		protected virtual unsafe string ElapsedTimeAsString (long runTime)
		{
			const string __id = "elapsedTimeAsString.(J)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (runTime);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_endTest_Ljunit_framework_Test_;
#pragma warning disable 0169
		static Delegate GetEndTest_Ljunit_framework_Test_Handler ()
		{
			if (cb_endTest_Ljunit_framework_Test_ == null)
				cb_endTest_Ljunit_framework_Test_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EndTest_Ljunit_framework_Test_);
			return cb_endTest_Ljunit_framework_Test_;
		}

		static void n_EndTest_Ljunit_framework_Test_ (IntPtr jnienv, IntPtr native__this, IntPtr native_test)
		{
			global::Junit.Textui.ResultPrinter __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.ResultPrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITest test = (global::Junit.Framework.ITest)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (native_test, JniHandleOwnership.DoNotTransfer);
			__this.EndTest (test);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='ResultPrinter']/method[@name='endTest' and count(parameter)=1 and parameter[1][@type='junit.framework.Test']]"
		[Register ("endTest", "(Ljunit/framework/Test;)V", "GetEndTest_Ljunit_framework_Test_Handler")]
		public virtual unsafe void EndTest (global::Junit.Framework.ITest test)
		{
			const string __id = "endTest.(Ljunit/framework/Test;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((test == null) ? IntPtr.Zero : ((global::Java.Lang.Object) test).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_printDefect_Ljunit_framework_TestFailure_I;
#pragma warning disable 0169
		static Delegate GetPrintDefect_Ljunit_framework_TestFailure_IHandler ()
		{
			if (cb_printDefect_Ljunit_framework_TestFailure_I == null)
				cb_printDefect_Ljunit_framework_TestFailure_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_PrintDefect_Ljunit_framework_TestFailure_I);
			return cb_printDefect_Ljunit_framework_TestFailure_I;
		}

		static void n_PrintDefect_Ljunit_framework_TestFailure_I (IntPtr jnienv, IntPtr native__this, IntPtr native_booBoo, int count)
		{
			global::Junit.Textui.ResultPrinter __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.ResultPrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.TestFailure booBoo = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestFailure> (native_booBoo, JniHandleOwnership.DoNotTransfer);
			__this.PrintDefect (booBoo, count);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='ResultPrinter']/method[@name='printDefect' and count(parameter)=2 and parameter[1][@type='junit.framework.TestFailure'] and parameter[2][@type='int']]"
		[Register ("printDefect", "(Ljunit/framework/TestFailure;I)V", "GetPrintDefect_Ljunit_framework_TestFailure_IHandler")]
		public virtual unsafe void PrintDefect (global::Junit.Framework.TestFailure booBoo, int count)
		{
			const string __id = "printDefect.(Ljunit/framework/TestFailure;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((booBoo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) booBoo).Handle);
				__args [1] = new JniArgumentValue (count);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_printDefectHeader_Ljunit_framework_TestFailure_I;
#pragma warning disable 0169
		static Delegate GetPrintDefectHeader_Ljunit_framework_TestFailure_IHandler ()
		{
			if (cb_printDefectHeader_Ljunit_framework_TestFailure_I == null)
				cb_printDefectHeader_Ljunit_framework_TestFailure_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_PrintDefectHeader_Ljunit_framework_TestFailure_I);
			return cb_printDefectHeader_Ljunit_framework_TestFailure_I;
		}

		static void n_PrintDefectHeader_Ljunit_framework_TestFailure_I (IntPtr jnienv, IntPtr native__this, IntPtr native_booBoo, int count)
		{
			global::Junit.Textui.ResultPrinter __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.ResultPrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.TestFailure booBoo = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestFailure> (native_booBoo, JniHandleOwnership.DoNotTransfer);
			__this.PrintDefectHeader (booBoo, count);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='ResultPrinter']/method[@name='printDefectHeader' and count(parameter)=2 and parameter[1][@type='junit.framework.TestFailure'] and parameter[2][@type='int']]"
		[Register ("printDefectHeader", "(Ljunit/framework/TestFailure;I)V", "GetPrintDefectHeader_Ljunit_framework_TestFailure_IHandler")]
		protected virtual unsafe void PrintDefectHeader (global::Junit.Framework.TestFailure booBoo, int count)
		{
			const string __id = "printDefectHeader.(Ljunit/framework/TestFailure;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((booBoo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) booBoo).Handle);
				__args [1] = new JniArgumentValue (count);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_printDefectTrace_Ljunit_framework_TestFailure_;
#pragma warning disable 0169
		static Delegate GetPrintDefectTrace_Ljunit_framework_TestFailure_Handler ()
		{
			if (cb_printDefectTrace_Ljunit_framework_TestFailure_ == null)
				cb_printDefectTrace_Ljunit_framework_TestFailure_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PrintDefectTrace_Ljunit_framework_TestFailure_);
			return cb_printDefectTrace_Ljunit_framework_TestFailure_;
		}

		static void n_PrintDefectTrace_Ljunit_framework_TestFailure_ (IntPtr jnienv, IntPtr native__this, IntPtr native_booBoo)
		{
			global::Junit.Textui.ResultPrinter __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.ResultPrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.TestFailure booBoo = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestFailure> (native_booBoo, JniHandleOwnership.DoNotTransfer);
			__this.PrintDefectTrace (booBoo);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='ResultPrinter']/method[@name='printDefectTrace' and count(parameter)=1 and parameter[1][@type='junit.framework.TestFailure']]"
		[Register ("printDefectTrace", "(Ljunit/framework/TestFailure;)V", "GetPrintDefectTrace_Ljunit_framework_TestFailure_Handler")]
		protected virtual unsafe void PrintDefectTrace (global::Junit.Framework.TestFailure booBoo)
		{
			const string __id = "printDefectTrace.(Ljunit/framework/TestFailure;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((booBoo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) booBoo).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_printDefects_Ljava_util_Enumeration_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPrintDefects_Ljava_util_Enumeration_ILjava_lang_String_Handler ()
		{
			if (cb_printDefects_Ljava_util_Enumeration_ILjava_lang_String_ == null)
				cb_printDefects_Ljava_util_Enumeration_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_PrintDefects_Ljava_util_Enumeration_ILjava_lang_String_);
			return cb_printDefects_Ljava_util_Enumeration_ILjava_lang_String_;
		}

		static void n_PrintDefects_Ljava_util_Enumeration_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_booBoos, int count, IntPtr native_type)
		{
			global::Junit.Textui.ResultPrinter __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.ResultPrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.IEnumeration booBoos = (global::Java.Util.IEnumeration)global::Java.Lang.Object.GetObject<global::Java.Util.IEnumeration> (native_booBoos, JniHandleOwnership.DoNotTransfer);
			string type = JNIEnv.GetString (native_type, JniHandleOwnership.DoNotTransfer);
			__this.PrintDefects (booBoos, count, type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='ResultPrinter']/method[@name='printDefects' and count(parameter)=3 and parameter[1][@type='java.util.Enumeration&lt;junit.framework.TestFailure&gt;'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("printDefects", "(Ljava/util/Enumeration;ILjava/lang/String;)V", "GetPrintDefects_Ljava_util_Enumeration_ILjava_lang_String_Handler")]
		protected virtual unsafe void PrintDefects (global::Java.Util.IEnumeration booBoos, int count, string type)
		{
			const string __id = "printDefects.(Ljava/util/Enumeration;ILjava/lang/String;)V";
			IntPtr native_type = JNIEnv.NewString (type);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((booBoos == null) ? IntPtr.Zero : ((global::Java.Lang.Object) booBoos).Handle);
				__args [1] = new JniArgumentValue (count);
				__args [2] = new JniArgumentValue (native_type);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_type);
			}
		}

		static Delegate cb_printErrors_Ljunit_framework_TestResult_;
#pragma warning disable 0169
		static Delegate GetPrintErrors_Ljunit_framework_TestResult_Handler ()
		{
			if (cb_printErrors_Ljunit_framework_TestResult_ == null)
				cb_printErrors_Ljunit_framework_TestResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PrintErrors_Ljunit_framework_TestResult_);
			return cb_printErrors_Ljunit_framework_TestResult_;
		}

		static void n_PrintErrors_Ljunit_framework_TestResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			global::Junit.Textui.ResultPrinter __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.ResultPrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.TestResult result = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (native_result, JniHandleOwnership.DoNotTransfer);
			__this.PrintErrors (result);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='ResultPrinter']/method[@name='printErrors' and count(parameter)=1 and parameter[1][@type='junit.framework.TestResult']]"
		[Register ("printErrors", "(Ljunit/framework/TestResult;)V", "GetPrintErrors_Ljunit_framework_TestResult_Handler")]
		protected virtual unsafe void PrintErrors (global::Junit.Framework.TestResult result)
		{
			const string __id = "printErrors.(Ljunit/framework/TestResult;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_printFailures_Ljunit_framework_TestResult_;
#pragma warning disable 0169
		static Delegate GetPrintFailures_Ljunit_framework_TestResult_Handler ()
		{
			if (cb_printFailures_Ljunit_framework_TestResult_ == null)
				cb_printFailures_Ljunit_framework_TestResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PrintFailures_Ljunit_framework_TestResult_);
			return cb_printFailures_Ljunit_framework_TestResult_;
		}

		static void n_PrintFailures_Ljunit_framework_TestResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			global::Junit.Textui.ResultPrinter __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.ResultPrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.TestResult result = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (native_result, JniHandleOwnership.DoNotTransfer);
			__this.PrintFailures (result);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='ResultPrinter']/method[@name='printFailures' and count(parameter)=1 and parameter[1][@type='junit.framework.TestResult']]"
		[Register ("printFailures", "(Ljunit/framework/TestResult;)V", "GetPrintFailures_Ljunit_framework_TestResult_Handler")]
		protected virtual unsafe void PrintFailures (global::Junit.Framework.TestResult result)
		{
			const string __id = "printFailures.(Ljunit/framework/TestResult;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_printFooter_Ljunit_framework_TestResult_;
#pragma warning disable 0169
		static Delegate GetPrintFooter_Ljunit_framework_TestResult_Handler ()
		{
			if (cb_printFooter_Ljunit_framework_TestResult_ == null)
				cb_printFooter_Ljunit_framework_TestResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PrintFooter_Ljunit_framework_TestResult_);
			return cb_printFooter_Ljunit_framework_TestResult_;
		}

		static void n_PrintFooter_Ljunit_framework_TestResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			global::Junit.Textui.ResultPrinter __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.ResultPrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.TestResult result = global::Java.Lang.Object.GetObject<global::Junit.Framework.TestResult> (native_result, JniHandleOwnership.DoNotTransfer);
			__this.PrintFooter (result);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='ResultPrinter']/method[@name='printFooter' and count(parameter)=1 and parameter[1][@type='junit.framework.TestResult']]"
		[Register ("printFooter", "(Ljunit/framework/TestResult;)V", "GetPrintFooter_Ljunit_framework_TestResult_Handler")]
		protected virtual unsafe void PrintFooter (global::Junit.Framework.TestResult result)
		{
			const string __id = "printFooter.(Ljunit/framework/TestResult;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_printHeader_J;
#pragma warning disable 0169
		static Delegate GetPrintHeader_JHandler ()
		{
			if (cb_printHeader_J == null)
				cb_printHeader_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_PrintHeader_J);
			return cb_printHeader_J;
		}

		static void n_PrintHeader_J (IntPtr jnienv, IntPtr native__this, long runTime)
		{
			global::Junit.Textui.ResultPrinter __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.ResultPrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PrintHeader (runTime);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='ResultPrinter']/method[@name='printHeader' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("printHeader", "(J)V", "GetPrintHeader_JHandler")]
		protected virtual unsafe void PrintHeader (long runTime)
		{
			const string __id = "printHeader.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (runTime);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startTest_Ljunit_framework_Test_;
#pragma warning disable 0169
		static Delegate GetStartTest_Ljunit_framework_Test_Handler ()
		{
			if (cb_startTest_Ljunit_framework_Test_ == null)
				cb_startTest_Ljunit_framework_Test_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartTest_Ljunit_framework_Test_);
			return cb_startTest_Ljunit_framework_Test_;
		}

		static void n_StartTest_Ljunit_framework_Test_ (IntPtr jnienv, IntPtr native__this, IntPtr native_test)
		{
			global::Junit.Textui.ResultPrinter __this = global::Java.Lang.Object.GetObject<global::Junit.Textui.ResultPrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Junit.Framework.ITest test = (global::Junit.Framework.ITest)global::Java.Lang.Object.GetObject<global::Junit.Framework.ITest> (native_test, JniHandleOwnership.DoNotTransfer);
			__this.StartTest (test);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='junit.textui']/class[@name='ResultPrinter']/method[@name='startTest' and count(parameter)=1 and parameter[1][@type='junit.framework.Test']]"
		[Register ("startTest", "(Ljunit/framework/Test;)V", "GetStartTest_Ljunit_framework_Test_Handler")]
		public virtual unsafe void StartTest (global::Junit.Framework.ITest test)
		{
			const string __id = "startTest.(Ljunit/framework/Test;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((test == null) ? IntPtr.Zero : ((global::Java.Lang.Object) test).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
